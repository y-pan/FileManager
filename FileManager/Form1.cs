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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            lbInfo.Text ="drag: "+ e.ToString();
            
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop,false);
            //foreach (string file in files) Console.WriteLine(file);
            lbInfo.Text = Lib.GetName(files[0]);
            label4.Text = files[0];
            
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
                lbSomeFile.Text = files[0];
                lbSomeFile.Visible = true;
            }
            lbxCheckins.Items.Add(files[0]);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.Copy(pbFile.ImageLocation, lbInfo.Text, true);
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
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lbxCheckins.Items.Count > 0)
            {
                lbxCheckins.Items.Clear();
                if (pbFile.Visible) { pbFile.ImageLocation = ""; pbFile.Visible = false; }
                lbSomeFile.Text = "N/A"; lbSomeFile.Visible = true;
            }
        }


    }
}
