using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unionizer
{
    public partial class frmUnionize : Form
    {
        public frmUnionize()
        {
            InitializeComponent();
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (Directory.Exists(txtDirectory.Text))
                dialog.SelectedPath = txtDirectory.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
                txtDirectory.Text = dialog.SelectedPath;
        }

        private void btnShowFiles_Click(object sender, EventArgs e)
        {
            btnUnionize.Enabled = false;
            if (!Directory.Exists(txtDirectory.Text))
            {
                MessageBox.Show("Given directory does not exist.");
                return;
            }

            loadUnionizableFiles();
            if ((lstAffectedFiles.DataSource as List<string>).Count() == 0)
                MessageBox.Show("No splitted files found.");
        }

        private void loadUnionizableFiles()
        {
            List<string> files = Directory.GetFiles(txtDirectory.Text, "*.pas", (chkSubdirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)).ToList();
            files = files.Where(filename => isFileUnionizable(filename)).ToList();
            lstAffectedFiles.DataSource = files;
            if (files.Count == 0)
            {
                AcceptButton = btnShowFiles;
                btnShowFiles.Focus();
            }
            else
            {
                AcceptButton = btnUnionize;
                btnUnionize.Focus();
                btnUnionize.Enabled = true;
            }
        }

        public List<int> getOccurrences(string source, string searchString)
        {
            List<int> ret = new List<int>();
            int len = searchString.Length;
            int start = -len;
            while (true)
            {
                start = source.IndexOf(searchString, start + len);
                if (start == -1)
                {
                    break;
                }
                else
                {
                    ret.Add(start);
                }
            }
            return ret;
        }

        private bool isFileUnionizable(string filename)
        {
            string fileContent = File.ReadAllText(filename);
            List<int> occurrences = getOccurrences(fileContent, "{$I ");

            foreach (int start in occurrences)
            {
                string substr = fileContent.Substring(start, fileContent.IndexOf("}", start + 1) - start + 1).ToUpper();
                // ignore inc include files
                if (substr.Contains(".INC"))
                    continue;

                // others are .pas files or without file ending (means also .pas)
                if (!substr.Contains(".ATTR") && !substr.Contains(".PROP"))
                    return true;

                // rest are prop and attr files, just accept them if user wants to
                if (chkUnionizePropAndAttr.Checked)
                    return true;
            }

            return false;
        }

        private void lstAffectedFiles_DoubleClick(object sender, EventArgs e)
        {
            // open selected file in notepad++
            string filename = (sender as ListBox).Text;
            Process.Start("notepad++.exe", filename);
        }

        private void btnUnionize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("begin unionize?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            List<string> errors = new List<string>();
            foreach (string filename in lstAffectedFiles.DataSource as List<string>)
            {
                try
                {
                    unionizeFile(filename);
                }
                catch (Exception ex)
                {
                    string error = "file: " + filename + " exception: " + ex.Message;
                    if (ex.InnerException != null)
                        error += " (inner exception: " + ex.InnerException.Message + ")";
                    errors.Add(error);
                }
            }
            if (errors.Count > 0)
                MessageBox.Show("There were errors processing the following files: " + Environment.NewLine + errors);

            loadUnionizableFiles();
        }

        private void unionizeFile(string filename)
        {
            List<string> lines = File.ReadAllLines(filename, Encoding.Default).ToList();
            for (int i = lines.Count - 1; i > 0; i--)
            {
                string line = lines[i];
                int start = line.IndexOf("{$I ") + 4;
                if (start < 4)
                    continue;

                string incFilename = line.Substring(start, line.IndexOf("}", start + 1) - start).ToUpper();
                // ignore inc include files
                if (incFilename.EndsWith(".INC"))
                    continue;

                // just unionize attr and prop if user wants to
                if ((incFilename.EndsWith(".ATTR") || incFilename.EndsWith(".PROP")) && !chkUnionizePropAndAttr.Checked)
                    continue;

                // files without file ending are also .pas
                if (!incFilename.Contains("."))
                    incFilename += ".pas";

                incFilename = Path.GetDirectoryName(filename) + "\\" + incFilename;
                lines[i] = File.ReadAllText(incFilename, Encoding.Default);
                File.Delete(incFilename);
            }
            File.WriteAllLines(filename, lines, Encoding.Default);
        }
    }
}
