﻿namespace ClickToCopy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuItemStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCharacterFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.MenuItemStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemStrip
            // 
            this.MenuItemStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.MenuItemStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemAbout});
            this.MenuItemStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuItemStrip.Name = "MenuItemStrip";
            this.MenuItemStrip.Padding = new System.Windows.Forms.Padding(0);
            this.MenuItemStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuItemStrip.Size = new System.Drawing.Size(120, 24);
            this.MenuItemStrip.TabIndex = 3;
            this.MenuItemStrip.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCharacterFileToolStripMenuItem});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Padding = new System.Windows.Forms.Padding(0);
            this.MenuItemFile.Size = new System.Drawing.Size(29, 24);
            this.MenuItemFile.Text = "File";
            // 
            // EditCharacterFileToolStripMenuItem
            // 
            this.EditCharacterFileToolStripMenuItem.Name = "EditCharacterFileToolStripMenuItem";
            this.EditCharacterFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditCharacterFileToolStripMenuItem.Text = "Edit Character File...";
            this.EditCharacterFileToolStripMenuItem.Click += new System.EventHandler(this.editCharacterFileToolStripMenuItem_Click);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(52, 24);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.Location = new System.Drawing.Point(0, 27);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(120, 23);
            this.BtnRestart.TabIndex = 4;
            this.BtnRestart.Text = "Reload Buttons";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlButtons
            // 
            this.PnlButtons.AutoScroll = true;
            this.PnlButtons.Location = new System.Drawing.Point(0, 50);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(120, 339);
            this.PnlButtons.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 389);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.MenuItemStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.MenuItemStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ClickToCopy";
            this.MenuItemStrip.ResumeLayout(false);
            this.MenuItemStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip MenuItemStrip;
        private ToolStripMenuItem MenuItemFile;
        private ToolStripMenuItem EditCharacterFileToolStripMenuItem;
        private Button BtnRestart;
        private Panel PnlButtons;
        private ToolStripMenuItem MenuItemAbout;
    }
}