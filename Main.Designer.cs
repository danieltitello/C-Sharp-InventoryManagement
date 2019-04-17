namespace Lockers
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBoxAssets = new System.Windows.Forms.PictureBox();
            this.pictureBoxUSB = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_usb = new System.Windows.Forms.Button();
            this.btn_assets = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOutputUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.labelOutputLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAssets
            // 
            this.pictureBoxAssets.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAssets.Image")));
            this.pictureBoxAssets.Location = new System.Drawing.Point(40, 46);
            this.pictureBoxAssets.Name = "pictureBoxAssets";
            this.pictureBoxAssets.Size = new System.Drawing.Size(106, 78);
            this.pictureBoxAssets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAssets.TabIndex = 3;
            this.pictureBoxAssets.TabStop = false;
            // 
            // pictureBoxUSB
            // 
            this.pictureBoxUSB.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUSB.Image")));
            this.pictureBoxUSB.Location = new System.Drawing.Point(40, 170);
            this.pictureBoxUSB.Name = "pictureBoxUSB";
            this.pictureBoxUSB.Size = new System.Drawing.Size(106, 89);
            this.pictureBoxUSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUSB.TabIndex = 4;
            this.pictureBoxUSB.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(178, 317);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(126, 34);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_usb
            // 
            this.btn_usb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usb.Location = new System.Drawing.Point(168, 187);
            this.btn_usb.Name = "btn_usb";
            this.btn_usb.Size = new System.Drawing.Size(147, 63);
            this.btn_usb.TabIndex = 8;
            this.btn_usb.Text = "Returning USB Sticks";
            this.btn_usb.UseVisualStyleBackColor = true;
            this.btn_usb.Click += new System.EventHandler(this.btn_usb_Click);
            // 
            // btn_assets
            // 
            this.btn_assets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assets.Location = new System.Drawing.Point(168, 67);
            this.btn_assets.Name = "btn_assets";
            this.btn_assets.Size = new System.Drawing.Size(147, 40);
            this.btn_assets.TabIndex = 9;
            this.btn_assets.Text = "Assets";
            this.btn_assets.UseVisualStyleBackColor = true;
            this.btn_assets.Click += new System.EventHandler(this.btn_assets_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelOutputUser
            // 
            this.labelOutputUser.AutoSize = true;
            this.labelOutputUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutputUser.Location = new System.Drawing.Point(536, 405);
            this.labelOutputUser.Name = "labelOutputUser";
            this.labelOutputUser.Size = new System.Drawing.Size(2, 19);
            this.labelOutputUser.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "LOGIN";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(559, 127);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(137, 22);
            this.TBUsername.TabIndex = 15;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(559, 189);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(137, 22);
            this.TBPassword.TabIndex = 16;
            this.TBPassword.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(506, 259);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 34);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // labelOutputLogin
            // 
            this.labelOutputLogin.AutoSize = true;
            this.labelOutputLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputLogin.Location = new System.Drawing.Point(444, 333);
            this.labelOutputLogin.Name = "labelOutputLogin";
            this.labelOutputLogin.Size = new System.Drawing.Size(2, 19);
            this.labelOutputLogin.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.labelOutputLogin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutputUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_assets);
            this.Controls.Add(this.btn_usb);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBoxUSB);
            this.Controls.Add(this.pictureBoxAssets);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxAssets;
        private System.Windows.Forms.PictureBox pictureBoxUSB;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_usb;
        private System.Windows.Forms.Button btn_assets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelOutputUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label labelOutputLogin;
    }
}