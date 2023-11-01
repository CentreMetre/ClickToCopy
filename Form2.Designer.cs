namespace ClickToCopy
{
    partial class FormAbout
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
            LblVersion = new Label();
            BtnQuit = new Button();
            LblLicense = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LblVersion
            // 
            LblVersion.AutoSize = true;
            LblVersion.Location = new Point(12, 9);
            LblVersion.Name = "LblVersion";
            LblVersion.Size = new Size(122, 15);
            LblVersion.TabIndex = 0;
            LblVersion.Text = "Version: 1.2.1 (Build 4)";
            LblVersion.Click += LblVersion_Click;
            // 
            // BtnQuit
            // 
            BtnQuit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnQuit.Location = new Point(341, 120);
            BtnQuit.Name = "BtnQuit";
            BtnQuit.Size = new Size(75, 23);
            BtnQuit.TabIndex = 1;
            BtnQuit.Text = "OK";
            BtnQuit.UseVisualStyleBackColor = true;
            BtnQuit.Click += BtnQuit_Click;
            // 
            // LblLicense
            // 
            LblLicense.AutoSize = true;
            LblLicense.Location = new Point(12, 46);
            LblLicense.Name = "LblLicense";
            LblLicense.Size = new Size(403, 15);
            LblLicense.TabIndex = 5;
            LblLicense.Text = "ClickToCopy © 2022 by Martin McLaren is licensed under CC BY-NC-SA 4.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 6;
            label1.Text = "github.com/CentreMetre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 7;
            label2.Text = "github.com/CentreMetre/ClickToCopy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(246, 15);
            label3.TabIndex = 8;
            label3.Text = "creativecommons.org/licenses/by-nc-sa/4.0/";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 155);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblLicense);
            Controls.Add(BtnQuit);
            Controls.Add(LblVersion);
            Name = "FormAbout";
            ShowIcon = false;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblVersion;
        private Button BtnQuit;
        private Label LblLicense;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}