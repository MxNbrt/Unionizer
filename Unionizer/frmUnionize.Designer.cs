namespace Unionizer
{
    partial class frmUnionize
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDirectory = new System.Windows.Forms.Button();
            this.chkSubdirectories = new System.Windows.Forms.CheckBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.btnUnionize = new System.Windows.Forms.Button();
            this.lstAffectedFiles = new System.Windows.Forms.ListBox();
            this.btnShowFiles = new System.Windows.Forms.Button();
            this.chkUnionizePropAndAttr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDirectory
            // 
            this.btnDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectory.Location = new System.Drawing.Point(570, 12);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(24, 20);
            this.btnDirectory.TabIndex = 0;
            this.btnDirectory.Text = "...";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // chkSubdirectories
            // 
            this.chkSubdirectories.AutoSize = true;
            this.chkSubdirectories.Checked = true;
            this.chkSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubdirectories.Location = new System.Drawing.Point(12, 43);
            this.chkSubdirectories.Name = "chkSubdirectories";
            this.chkSubdirectories.Size = new System.Drawing.Size(166, 17);
            this.chkSubdirectories.TabIndex = 1;
            this.chkSubdirectories.Text = "process files in subdirectories:";
            this.chkSubdirectories.UseVisualStyleBackColor = true;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(83, 12);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(481, 20);
            this.txtDirectory.TabIndex = 2;
            this.txtDirectory.Text = "D:\\DevelopXE\\Ba";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(13, 15);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(50, 13);
            this.lblDirectory.TabIndex = 4;
            this.lblDirectory.Text = "directory:";
            // 
            // btnUnionize
            // 
            this.btnUnionize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnionize.Enabled = false;
            this.btnUnionize.Location = new System.Drawing.Point(12, 462);
            this.btnUnionize.Name = "btnUnionize";
            this.btnUnionize.Size = new System.Drawing.Size(580, 23);
            this.btnUnionize.TabIndex = 6;
            this.btnUnionize.Text = "unionize";
            this.btnUnionize.UseVisualStyleBackColor = true;
            this.btnUnionize.Click += new System.EventHandler(this.btnUnionize_Click);
            // 
            // lstAffectedFiles
            // 
            this.lstAffectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAffectedFiles.FormattingEnabled = true;
            this.lstAffectedFiles.Location = new System.Drawing.Point(12, 141);
            this.lstAffectedFiles.Name = "lstAffectedFiles";
            this.lstAffectedFiles.Size = new System.Drawing.Size(580, 303);
            this.lstAffectedFiles.TabIndex = 8;
            this.lstAffectedFiles.DoubleClick += new System.EventHandler(this.lstAffectedFiles_DoubleClick);
            // 
            // btnShowFiles
            // 
            this.btnShowFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowFiles.Location = new System.Drawing.Point(12, 102);
            this.btnShowFiles.Name = "btnShowFiles";
            this.btnShowFiles.Size = new System.Drawing.Size(580, 23);
            this.btnShowFiles.TabIndex = 9;
            this.btnShowFiles.Text = "show files";
            this.btnShowFiles.UseVisualStyleBackColor = true;
            this.btnShowFiles.Click += new System.EventHandler(this.btnShowFiles_Click);
            // 
            // chkUnionizePropAndAttr
            // 
            this.chkUnionizePropAndAttr.AutoSize = true;
            this.chkUnionizePropAndAttr.Location = new System.Drawing.Point(12, 66);
            this.chkUnionizePropAndAttr.Name = "chkUnionizePropAndAttr";
            this.chkUnionizePropAndAttr.Size = new System.Drawing.Size(158, 17);
            this.chkUnionizePropAndAttr.TabIndex = 10;
            this.chkUnionizePropAndAttr.Text = "unionize .prop and .attr files:";
            this.chkUnionizePropAndAttr.UseVisualStyleBackColor = true;
            // 
            // frmUnionize
            // 
            this.AcceptButton = this.btnShowFiles;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 497);
            this.Controls.Add(this.chkUnionizePropAndAttr);
            this.Controls.Add(this.btnShowFiles);
            this.Controls.Add(this.lstAffectedFiles);
            this.Controls.Add(this.btnUnionize);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.chkSubdirectories);
            this.Controls.Add(this.btnDirectory);
            this.MinimumSize = new System.Drawing.Size(439, 322);
            this.Name = "frmUnionize";
            this.ShowIcon = false;
            this.Text = "Delphi Unionizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.CheckBox chkSubdirectories;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Button btnUnionize;
        private System.Windows.Forms.ListBox lstAffectedFiles;
        private System.Windows.Forms.Button btnShowFiles;
        private System.Windows.Forms.CheckBox chkUnionizePropAndAttr;

    }
}

