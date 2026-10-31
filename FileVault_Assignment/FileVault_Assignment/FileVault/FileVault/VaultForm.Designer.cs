namespace FileVault
{
    partial class VaultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnMakeFile = new System.Windows.Forms.Button();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnWriteText = new System.Windows.Forms.Button();
            this.btnShowFile = new System.Windows.Forms.Button();
            this.btnByLine = new System.Windows.Forms.Button();
            this.btnWholeFile = new System.Windows.Forms.Button();
            this.btnCharByChar = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtViewerBox = new System.Windows.Forms.TextBox();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSideMenu.Controls.Add(this.btnMakeFile);
            this.pnlSideMenu.Controls.Add(this.btnPickFolder);
            this.pnlSideMenu.Controls.Add(this.btnSaveAs);
            this.pnlSideMenu.Controls.Add(this.btnWriteText);
            this.pnlSideMenu.Controls.Add(this.btnShowFile);
            this.pnlSideMenu.Controls.Add(this.btnByLine);
            this.pnlSideMenu.Controls.Add(this.btnWholeFile);
            this.pnlSideMenu.Controls.Add(this.btnCharByChar);
            this.pnlSideMenu.Controls.Add(this.btnAddText);
            this.pnlSideMenu.Controls.Add(this.btnRemoveFile);
            this.pnlSideMenu.Controls.Add(this.btnResetAll);
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(375, 1015);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnMakeFile
            // 
            this.btnMakeFile.Location = new System.Drawing.Point(22, 138);
            this.btnMakeFile.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnMakeFile.Name = "btnMakeFile";
            this.btnMakeFile.Size = new System.Drawing.Size(330, 62);
            this.btnMakeFile.TabIndex = 1;
            this.btnMakeFile.Text = "Create File";
            this.btnMakeFile.UseVisualStyleBackColor = true;
            this.btnMakeFile.Click += new System.EventHandler(this.btnMakeFile_Click);
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.Location = new System.Drawing.Point(22, 214);
            this.btnPickFolder.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.Size = new System.Drawing.Size(330, 62);
            this.btnPickFolder.TabIndex = 2;
            this.btnPickFolder.Text = "Create New File Path";
            this.btnPickFolder.UseVisualStyleBackColor = true;
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(22, 289);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(330, 62);
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.Text = "Create New File Name";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnWriteText
            // 
            this.btnWriteText.Location = new System.Drawing.Point(22, 365);
            this.btnWriteText.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(330, 62);
            this.btnWriteText.TabIndex = 4;
            this.btnWriteText.Text = "Write File";
            this.btnWriteText.UseVisualStyleBackColor = true;
            this.btnWriteText.Click += new System.EventHandler(this.btnWriteText_Click);
            // 
            // btnShowFile
            // 
            this.btnShowFile.Location = new System.Drawing.Point(22, 440);
            this.btnShowFile.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnShowFile.Name = "btnShowFile";
            this.btnShowFile.Size = new System.Drawing.Size(330, 62);
            this.btnShowFile.TabIndex = 5;
            this.btnShowFile.Text = "Read File";
            this.btnShowFile.UseVisualStyleBackColor = true;
            this.btnShowFile.Click += new System.EventHandler(this.btnShowFile_Click);
            // 
            // btnByLine
            // 
            this.btnByLine.Location = new System.Drawing.Point(22, 515);
            this.btnByLine.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnByLine.Name = "btnByLine";
            this.btnByLine.Size = new System.Drawing.Size(330, 62);
            this.btnByLine.TabIndex = 6;
            this.btnByLine.Text = "Read Using ReadLine()";
            this.btnByLine.UseVisualStyleBackColor = true;
            this.btnByLine.Click += new System.EventHandler(this.btnByLine_Click);
            // 
            // btnWholeFile
            // 
            this.btnWholeFile.Location = new System.Drawing.Point(22, 591);
            this.btnWholeFile.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnWholeFile.Name = "btnWholeFile";
            this.btnWholeFile.Size = new System.Drawing.Size(330, 62);
            this.btnWholeFile.TabIndex = 7;
            this.btnWholeFile.Text = "Read Using ReadAllText()";
            this.btnWholeFile.UseVisualStyleBackColor = true;
            this.btnWholeFile.Click += new System.EventHandler(this.btnWholeFile_Click);
            // 
            // btnCharByChar
            // 
            this.btnCharByChar.Location = new System.Drawing.Point(22, 666);
            this.btnCharByChar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnCharByChar.Name = "btnCharByChar";
            this.btnCharByChar.Size = new System.Drawing.Size(330, 62);
            this.btnCharByChar.TabIndex = 8;
            this.btnCharByChar.Text = "Read() Function";
            this.btnCharByChar.UseVisualStyleBackColor = true;
            this.btnCharByChar.Click += new System.EventHandler(this.btnCharByChar_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(22, 742);
            this.btnAddText.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(330, 62);
            this.btnAddText.TabIndex = 9;
            this.btnAddText.Text = "Append File";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(22, 817);
            this.btnRemoveFile.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(330, 62);
            this.btnRemoveFile.TabIndex = 10;
            this.btnRemoveFile.Text = "Delete File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(22, 892);
            this.btnResetAll.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(330, 62);
            this.btnResetAll.TabIndex = 11;
            this.btnResetAll.Text = "Clear";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(412, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1050, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "File Name";
            // 
            // txtPathBox
            // 
            this.txtPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathBox.Location = new System.Drawing.Point(412, 80);
            this.txtPathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPathBox.Name = "txtPathBox";
            this.txtPathBox.Size = new System.Drawing.Size(1048, 26);
            this.txtPathBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(412, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1050, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter Text";
            // 
            // txtNotesBox
            // 
            this.txtNotesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotesBox.Location = new System.Drawing.Point(412, 197);
            this.txtNotesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotesBox.Multiline = true;
            this.txtNotesBox.Name = "txtNotesBox";
            this.txtNotesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotesBox.Size = new System.Drawing.Size(1048, 259);
            this.txtNotesBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(412, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1050, 40);
            this.label4.TabIndex = 16;
            this.label4.Text = "File Content / Result";
            // 
            // txtViewerBox
            // 
            this.txtViewerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViewerBox.Location = new System.Drawing.Point(412, 535);
            this.txtViewerBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViewerBox.Multiline = true;
            this.txtViewerBox.Name = "txtViewerBox";
            this.txtViewerBox.ReadOnly = true;
            this.txtViewerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtViewerBox.Size = new System.Drawing.Size(1048, 447);
            this.txtViewerBox.TabIndex = 17;
            // 
            // VaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 1015);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotesBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtViewerBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1339, 893);
            this.Name = "VaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileVault - Text File Manager";
            this.pnlSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnMakeFile;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnWriteText;
        private System.Windows.Forms.Button btnShowFile;
        private System.Windows.Forms.Button btnByLine;
        private System.Windows.Forms.Button btnWholeFile;
        private System.Windows.Forms.Button btnCharByChar;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtViewerBox;
    }
}
