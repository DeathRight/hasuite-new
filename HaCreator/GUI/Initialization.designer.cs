﻿/*  HaCreator - MapleStory Map Editor
 * Copyright (C) 2009, 2010  haha01haha01
   
 * This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

namespace HaCreator.GUI
{
    partial class Initialization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initialization));
            this.button1 = new DevComponents.DotNetBar.ButtonX();
            this.versionBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pathBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.button2 = new DevComponents.DotNetBar.ButtonX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Initialize";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // versionBox
            // 
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Items.AddRange(new object[] {
            "GMS",
            "EMS , MSEA , KMS",
            "BMS , JMS",
            "Auto-Detect"});
            this.versionBox.Location = new System.Drawing.Point(79, 38);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(201, 21);
            this.versionBox.TabIndex = 3;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MS Path";
            // 
            // textBox2
            // 
            // 
            // 
            // 
            this.textBox2.Border.Class = "";
            this.textBox2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox2.Location = new System.Drawing.Point(12, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(268, 20);
            this.textBox2.TabIndex = 2;
            // 
            // pathBox
            // 
            this.pathBox.FormattingEnabled = true;
            this.pathBox.Location = new System.Drawing.Point(79, 12);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(159, 21);
            this.pathBox.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button2.Location = new System.Drawing.Point(244, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // styleManager
            // 
            this.styleManager.ManagerColorTint = System.Drawing.SystemColors.HotTrack;
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // Initialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 131);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Initialization";
            this.Text = "HaCreator";
            this.Load += new System.EventHandler(this.Initialization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX button1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx versionBox;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx pathBox;
        private DevComponents.DotNetBar.ButtonX button2;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}

