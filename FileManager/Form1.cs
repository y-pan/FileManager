﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    enum SIGNALS { SAVE,UPDATE,DELETE }
    
    public partial class Form1 : Form
    {
        SIGNALS signal;
        private ItemManager IM;
        public Form1()
        {
            InitializeComponent();
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

            init();
        }
        
        public void init()
        {
            IM = new ItemManager();

        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            lbInfo.Text ="drag: "+ e.ToString();
            
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                IM.add(files[0]); // will throw duplicates exception

                if (Lib.getFormat(files[0]) == "img")
                {
                    lbSomeFile.Visible = false;

                    pbFile.ImageLocation = files[0];
                    pbFile.Refresh();
                    pbFile.Visible = true;
                }
                else
                {
                    pbFile.Visible = false;
                    lbSomeFile.Text = Lib.GetName(files[0]);
                    lbSomeFile.Visible = true;
                }
                lbxCheckins.Items.Add(files[0]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (lbxCheckins.Items.Count <= 0) return;

            try{
                if (txtKeys.Text.Length <= 0) throw new Exception("Keywords should not be empty");
                string keywords = Lib.trim(txtKeys.Text);
                //while (keywords.Contains("  ")) { keywords.Replace("  ", " "); }
                if (keywords.Length <= 0) throw new Exception("Invalid keywords");
                IM.Save(keywords);
                lbxCheckins.Items.Clear();
                txtKeys.Text = "";

                pbFile.ImageLocation = ""; pbFile.Visible = false;
                lbSomeFile.Visible = false;

                signal = SIGNALS.SAVE;
                lbSaved.Visible = true;
                bg_showHide.RunWorkerAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start(".");
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lbxCheckins.SelectedIndex >= 0)
            {
                lbxCheckins.Items.RemoveAt(lbxCheckins.SelectedIndex);
                IM.remove(lbxCheckins.SelectedItem.ToString());
                if (lbxCheckins.Items.Count <= 0)
                {
                    pbFile.ImageLocation = ""; pbFile.Visible = false;
                    lbSomeFile.Visible = false;
                }
            }

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lbxCheckins.Items.Count > 0)
            {
                lbxCheckins.Items.Clear();
                IM.ClearTemp();
                if (pbFile.Visible) { pbFile.ImageLocation = ""; pbFile.Visible = false; }
                lbSomeFile.Visible = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IM.data[0].ToString());

        }

        private void bg_showHide_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(800);
        }

        private void bg_showHide_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (signal)
            {
                case SIGNALS.SAVE: lbSaved.Visible = false; break;
                default: break;
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            bool isWhole = cheWhole.Checked;
            bool isOr = !cheAnd.Checked;
            string keys = Lib.trim(txtSearch.Text);
            
            if (keys.Length <= 0) return;
            IM.Search(keys,isOr,isWhole);
            MessageBox.Show("find: " + IM.matches.Count);
            

        }



    }
}
