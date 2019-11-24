namespace SWSM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcomeTitle = new System.Windows.Forms.Label();
            this.welcomeUndertitle = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.warningNotice = new System.Windows.Forms.Label();
            this.pathNotice = new System.Windows.Forms.Label();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeTitle
            // 
            this.welcomeTitle.BackColor = System.Drawing.Color.Transparent;
            this.welcomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(91)))), ((int)(((byte)(143)))));
            this.welcomeTitle.Location = new System.Drawing.Point(0, 42);
            this.welcomeTitle.Name = "welcomeTitle";
            this.welcomeTitle.Size = new System.Drawing.Size(998, 77);
            this.welcomeTitle.TabIndex = 0;
            this.welcomeTitle.Text = "SWSM";
            this.welcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeUndertitle
            // 
            this.welcomeUndertitle.BackColor = System.Drawing.Color.Transparent;
            this.welcomeUndertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUndertitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(91)))), ((int)(((byte)(143)))));
            this.welcomeUndertitle.Location = new System.Drawing.Point(0, 119);
            this.welcomeUndertitle.Name = "welcomeUndertitle";
            this.welcomeUndertitle.Size = new System.Drawing.Size(998, 60);
            this.welcomeUndertitle.TabIndex = 1;
            this.welcomeUndertitle.Text = "Star Wars Save Manager";
            this.welcomeUndertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(969, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(29, 25);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.warningNotice);
            this.panel1.Controls.Add(this.pathNotice);
            this.panel1.Controls.Add(this.fileSelectButton);
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 348);
            this.panel1.TabIndex = 4;
            // 
            // warningNotice
            // 
            this.warningNotice.AutoSize = true;
            this.warningNotice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningNotice.ForeColor = System.Drawing.Color.Red;
            this.warningNotice.Location = new System.Drawing.Point(300, 247);
            this.warningNotice.Name = "warningNotice";
            this.warningNotice.Size = new System.Drawing.Size(399, 18);
            this.warningNotice.TabIndex = 2;
            this.warningNotice.Text = "MAKE BACKUP OF SAVE FILES BEFORE USING SWSM";
            // 
            // pathNotice
            // 
            this.pathNotice.AutoSize = true;
            this.pathNotice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(91)))), ((int)(((byte)(143)))));
            this.pathNotice.Location = new System.Drawing.Point(237, 219);
            this.pathNotice.Name = "pathNotice";
            this.pathNotice.Size = new System.Drawing.Size(525, 17);
            this.pathNotice.TabIndex = 1;
            this.pathNotice.Text = "Save files is located in C:/User/[name]/Saved Games/Respawn/JediFallenOrder";
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.fileSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileSelectButton.FlatAppearance.BorderSize = 0;
            this.fileSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileSelectButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(91)))), ((int)(((byte)(143)))));
            this.fileSelectButton.Location = new System.Drawing.Point(399, 83);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(200, 102);
            this.fileSelectButton.TabIndex = 0;
            this.fileSelectButton.Text = "Select Saves Path";
            this.fileSelectButton.UseVisualStyleBackColor = false;
            this.fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(998, 536);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.welcomeUndertitle);
            this.Controls.Add(this.welcomeTitle);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Star Wars Save Manager";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeTitle;
        private System.Windows.Forms.Label welcomeUndertitle;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.Label pathNotice;
        private System.Windows.Forms.Label warningNotice;
    }
}

