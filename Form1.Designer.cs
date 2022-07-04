namespace ClickToCopy
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
            this.button1 = new System.Windows.Forms.Button();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.MenuItemStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemStrip
            // 
            this.MenuItemStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.MenuItemStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuItemStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile});
            this.MenuItemStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuItemStrip.Name = "MenuItemStrip";
            this.MenuItemStrip.Padding = new System.Windows.Forms.Padding(0);
            this.MenuItemStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuItemStrip.Size = new System.Drawing.Size(120, 24);
            this.MenuItemStrip.TabIndex = 3;
            this.MenuItemStrip.Text = "menuStrip1";
            this.MenuItemStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCharacterFileToolStripMenuItem});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Padding = new System.Windows.Forms.Padding(0);
            this.MenuItemFile.Size = new System.Drawing.Size(29, 24);
            this.MenuItemFile.Text = "File";
            this.MenuItemFile.Click += new System.EventHandler(this.MenuItemFile_Click);
            // 
            // EditCharacterFileToolStripMenuItem
            // 
            this.EditCharacterFileToolStripMenuItem.Name = "EditCharacterFileToolStripMenuItem";
            this.EditCharacterFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.EditCharacterFileToolStripMenuItem.Text = "Edit Character File...";
            this.EditCharacterFileToolStripMenuItem.Click += new System.EventHandler(this.editCharacterFileToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reload App";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Panel PnlButtons;
    }
}