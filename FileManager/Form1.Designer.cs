﻿namespace FileManager
{
    partial class Form1
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
            this.lbxCheckins = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.bg_showHide = new System.ComponentModel.BackgroundWorker();
            this.pbFile = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbSaved = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSomeFile = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbSearchResult = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cheWhole = new System.Windows.Forms.CheckBox();
            this.cheAnd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCheckins
            // 
            this.lbxCheckins.FormattingEnabled = true;
            this.lbxCheckins.HorizontalScrollbar = true;
            this.lbxCheckins.ItemHeight = 20;
            this.lbxCheckins.Location = new System.Drawing.Point(293, 53);
            this.lbxCheckins.Name = "lbxCheckins";
            this.lbxCheckins.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxCheckins.Size = new System.Drawing.Size(327, 224);
            this.lbxCheckins.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Step 3: Type keywords seperated by \",\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Step 2: Check your files, remove if necessary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(643, 53);
            this.txtKeys.Multiline = true;
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(268, 103);
            this.txtKeys.TabIndex = 6;
            // 
            // bg_showHide
            // 
            this.bg_showHide.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_showHide_DoWork);
            this.bg_showHide.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_showHide_RunWorkerCompleted);
            // 
            // pbFile
            // 
            this.pbFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFile.Location = new System.Drawing.Point(3, 22);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(249, 335);
            this.pbFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFile.TabIndex = 7;
            this.pbFile.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 712);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbSaved);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnRemoveAll);
            this.tabPage1.Controls.Add(this.btnRemoveSelected);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbInfo);
            this.tabPage1.Controls.Add(this.txtKeys);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbxCheckins);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbSaved
            // 
            this.lbSaved.AutoSize = true;
            this.lbSaved.ForeColor = System.Drawing.Color.Blue;
            this.lbSaved.Location = new System.Drawing.Point(384, 394);
            this.lbSaved.Name = "lbSaved";
            this.lbSaved.Size = new System.Drawing.Size(147, 20);
            this.lbSaved.TabIndex = 18;
            this.lbSaved.Text = "Saved successfully!";
            this.lbSaved.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(293, 322);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(107, 33);
            this.btnRemoveAll.TabIndex = 16;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(293, 283);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(169, 33);
            this.btnRemoveSelected.TabIndex = 15;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbFile);
            this.groupBox1.Controls.Add(this.lbSomeFile);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 360);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1: Drag file here";
            // 
            // lbSomeFile
            // 
            this.lbSomeFile.AutoSize = true;
            this.lbSomeFile.Location = new System.Drawing.Point(6, 174);
            this.lbSomeFile.Name = "lbSomeFile";
            this.lbSomeFile.Size = new System.Drawing.Size(119, 20);
            this.lbSomeFile.TabIndex = 13;
            this.lbSomeFile.Text = "Some File Here";
            this.lbSomeFile.Visible = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(293, 427);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(129, 45);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open Folder";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(293, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(6, 479);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(41, 20);
            this.lbInfo.TabIndex = 9;
            this.lbInfo.Text = "Info:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cheAnd);
            this.tabPage2.Controls.Add(this.cheWhole);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.lbSearchResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View/Update/Delete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbSearchResult
            // 
            this.lbSearchResult.FormattingEnabled = true;
            this.lbSearchResult.ItemHeight = 20;
            this.lbSearchResult.Location = new System.Drawing.Point(12, 220);
            this.lbSearchResult.Name = "lbSearchResult";
            this.lbSearchResult.Size = new System.Drawing.Size(393, 224);
            this.lbSearchResult.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Keywords (seperate by \",\") :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(156, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 33);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cheExact
            // 
            this.cheWhole.AutoSize = true;
            this.cheWhole.Location = new System.Drawing.Point(335, 50);
            this.cheWhole.Name = "cheExact";
            this.cheWhole.Size = new System.Drawing.Size(186, 24);
            this.cheWhole.TabIndex = 7;
            this.cheWhole.Text = "Match whole keyword";
            this.cheWhole.UseVisualStyleBackColor = true;
            // 
            // cheAnd
            // 
            this.cheAnd.AutoSize = true;
            this.cheAnd.Location = new System.Drawing.Point(265, 50);
            this.cheAnd.Name = "cheAnd";
            this.cheAnd.Size = new System.Drawing.Size(64, 24);
            this.cheAnd.TabIndex = 8;
            this.cheAnd.Text = "And";
            this.cheAnd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileManager";
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCheckins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtKeys;
        private System.ComponentModel.BackgroundWorker bg_showHide;
        private System.Windows.Forms.PictureBox pbFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lbSomeFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbSaved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbSearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cheWhole;
        private System.Windows.Forms.CheckBox cheAnd;
    }
}

