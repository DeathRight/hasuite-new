﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaCreator.MapEditor;

namespace HaCreator.GUI
{
    public partial class Save : DevComponents.DotNetBar.Office2007Form
    {
        private MultiBoard multiBoard;

        public Save(MultiBoard multiBoard)
        {
            InitializeComponent();
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            this.multiBoard = multiBoard;
        }

        private void Save_Load(object sender, EventArgs e)
        {
            //textDir.Text = ApplicationSettings.MapleFolder + "\\EdittedWZ";
        }

        /*private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldrBrowse = new FolderBrowserDialog();
            fldrBrowse.Description = "Browse to your MapleStory folder";
            if (fldrBrowse.ShowDialog() != DialogResult.OK) return;
            textDir.Text = fldrBrowse.SelectedPath + "\\EdittedWZ";
        }*/

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Program.WzManager.getWzPath() != "ERROR")
            {
                Form msgbx = new GUI.YesNoBox("Save confirmation", "Are you sure you want to save Map.wz?", "Yes", "No");
                //DialogResult msgbx = MessageBox.Show("Are you sure you want to save Map.wz?", "Save confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (msgbx == DialogResult.Yes)
                if (msgbx.DialogResult == DialogResult.Yes)
                {
                    progressBar1.Enabled = true;
                    progressBar1.PerformStep(); //10%
                    progressBar1.Refresh();
                    Program.WzManager.SaveMap(Program.WzManager.getWzPath() + "\\EdittedWZ", multiBoard.SelectedBoard.MapInfo.mapImage, progressBar1);
                    //MessageBox.Show("Save completed!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new GUI.InfoMsgBox("Completed", "Save completed!");
                }
            
            } /*else {
                MessageBox.Show("Some shiz went down!" ,"FFFFFFFFFFFUUUUUUUUUUUUUU-", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}