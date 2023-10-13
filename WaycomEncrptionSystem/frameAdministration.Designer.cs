namespace WaycomEncrptionSystem
{
    partial class frameAdministration
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
            panel1 = new Panel();
            button_About = new Button();
            button_Data_Encrypt_Decrypt = new Button();
            button_Profile = new Button();
            button_Home = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button_Close_Window = new Button();
            label_Client_Login = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            frameEncryptAndDecrypt1 = new frameEncryptAndDecrypt();
            panel_home = new Panel();
            frameUserProfile1 = new FrameUserProfile();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel_home.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(button_About);
            panel1.Controls.Add(button_Data_Encrypt_Decrypt);
            panel1.Controls.Add(button_Profile);
            panel1.Controls.Add(button_Home);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 735);
            panel1.TabIndex = 0;
            // 
            // button_About
            // 
            button_About.Dock = DockStyle.Top;
            button_About.FlatAppearance.BorderSize = 0;
            button_About.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button_About.FlatStyle = FlatStyle.Flat;
            button_About.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_About.ForeColor = Color.White;
            button_About.Image = Properties.Resources.info_5_24;
            button_About.ImageAlign = ContentAlignment.MiddleLeft;
            button_About.Location = new Point(0, 280);
            button_About.Name = "button_About";
            button_About.Size = new Size(207, 47);
            button_About.TabIndex = 8;
            button_About.Text = "About";
            button_About.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_About.UseVisualStyleBackColor = true;
            // 
            // button_Data_Encrypt_Decrypt
            // 
            button_Data_Encrypt_Decrypt.Dock = DockStyle.Top;
            button_Data_Encrypt_Decrypt.FlatAppearance.BorderSize = 0;
            button_Data_Encrypt_Decrypt.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button_Data_Encrypt_Decrypt.FlatStyle = FlatStyle.Flat;
            button_Data_Encrypt_Decrypt.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_Data_Encrypt_Decrypt.ForeColor = Color.White;
            button_Data_Encrypt_Decrypt.Image = Properties.Resources.data_encryption_24;
            button_Data_Encrypt_Decrypt.ImageAlign = ContentAlignment.MiddleLeft;
            button_Data_Encrypt_Decrypt.Location = new Point(0, 233);
            button_Data_Encrypt_Decrypt.Name = "button_Data_Encrypt_Decrypt";
            button_Data_Encrypt_Decrypt.Size = new Size(207, 47);
            button_Data_Encrypt_Decrypt.TabIndex = 6;
            button_Data_Encrypt_Decrypt.Text = "Data Encrypt / Decrypt";
            button_Data_Encrypt_Decrypt.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Data_Encrypt_Decrypt.UseVisualStyleBackColor = true;
            button_Data_Encrypt_Decrypt.Click += button_Data_Encrypt_Decrypt_Click;
            // 
            // button_Profile
            // 
            button_Profile.Dock = DockStyle.Top;
            button_Profile.FlatAppearance.BorderSize = 0;
            button_Profile.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button_Profile.FlatStyle = FlatStyle.Flat;
            button_Profile.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_Profile.ForeColor = Color.White;
            button_Profile.Image = Properties.Resources.edit_user_24;
            button_Profile.ImageAlign = ContentAlignment.MiddleLeft;
            button_Profile.Location = new Point(0, 186);
            button_Profile.Name = "button_Profile";
            button_Profile.Size = new Size(207, 47);
            button_Profile.TabIndex = 5;
            button_Profile.Text = "Profile";
            button_Profile.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Profile.UseVisualStyleBackColor = true;
            button_Profile.Click += button_Profile_Click;
            // 
            // button_Home
            // 
            button_Home.Dock = DockStyle.Top;
            button_Home.FlatAppearance.BorderSize = 0;
            button_Home.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button_Home.FlatStyle = FlatStyle.Flat;
            button_Home.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_Home.ForeColor = Color.White;
            button_Home.Image = Properties.Resources.house_24;
            button_Home.ImageAlign = ContentAlignment.MiddleLeft;
            button_Home.Location = new Point(0, 139);
            button_Home.Name = "button_Home";
            button_Home.Size = new Size(207, 47);
            button_Home.TabIndex = 3;
            button_Home.Text = "Home";
            button_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Home.UseVisualStyleBackColor = true;
            button_Home.Click += button_Home_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 139);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_Close_Window);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(207, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(935, 50);
            panel2.TabIndex = 1;
            // 
            // button_Close_Window
            // 
            button_Close_Window.Dock = DockStyle.Right;
            button_Close_Window.FlatAppearance.BorderSize = 0;
            button_Close_Window.FlatAppearance.MouseOverBackColor = Color.Red;
            button_Close_Window.FlatStyle = FlatStyle.Flat;
            button_Close_Window.Image = Properties.Resources.icons8_close_16;
            button_Close_Window.Location = new Point(881, 0);
            button_Close_Window.Name = "button_Close_Window";
            button_Close_Window.Size = new Size(54, 50);
            button_Close_Window.TabIndex = 10;
            button_Close_Window.UseVisualStyleBackColor = true;
            button_Close_Window.Click += button_Close_Window_Click;
            // 
            // label_Client_Login
            // 
            label_Client_Login.AutoSize = true;
            label_Client_Login.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Italic, GraphicsUnit.Point);
            label_Client_Login.ForeColor = Color.White;
            label_Client_Login.Location = new Point(44, 319);
            label_Client_Login.Name = "label_Client_Login";
            label_Client_Login.Size = new Size(421, 50);
            label_Client_Login.TabIndex = 1;
            label_Client_Login.Text = "Waycom Encryption";
            label_Client_Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.Home;
            pictureBox2.Location = new Point(120, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(287, 232);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(frameUserProfile1);
            panel4.Controls.Add(frameEncryptAndDecrypt1);
            panel4.Controls.Add(panel_home);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(207, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(935, 685);
            panel4.TabIndex = 31;
            // 
            // frameEncryptAndDecrypt1
            // 
            frameEncryptAndDecrypt1.BackColor = Color.SeaShell;
            frameEncryptAndDecrypt1.Dock = DockStyle.Fill;
            frameEncryptAndDecrypt1.Location = new Point(0, 0);
            frameEncryptAndDecrypt1.Margin = new Padding(6, 7, 6, 7);
            frameEncryptAndDecrypt1.Name = "frameEncryptAndDecrypt1";
            frameEncryptAndDecrypt1.Size = new Size(935, 685);
            frameEncryptAndDecrypt1.TabIndex = 30;
            frameEncryptAndDecrypt1.Visible = false;
            // 
            // panel_home
            // 
            panel_home.Controls.Add(label_Client_Login);
            panel_home.Controls.Add(pictureBox2);
            panel_home.Location = new Point(222, 136);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(501, 407);
            panel_home.TabIndex = 36;
            // 
            // frameUserProfile1
            // 
            frameUserProfile1.BackColor = Color.FromArgb(40, 68, 69);
            frameUserProfile1.Dock = DockStyle.Fill;
            frameUserProfile1.Location = new Point(0, 0);
            frameUserProfile1.Margin = new Padding(1);
            frameUserProfile1.Name = "frameUserProfile1";
            frameUserProfile1.Size = new Size(935, 685);
            frameUserProfile1.TabIndex = 37;
            // 
            // frameAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 23, 31);
            ClientSize = new Size(1142, 735);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frameAdministration";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frameAdmission_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_Home;
        private Panel panel3;
        private Panel panel2;
        private Button button_Data_Encrypt_Decrypt;
        private Button button_Profile;
        private Button button_About;
        private PictureBox pictureBox1;
        private Button button_Close_Window;
        private Label label_Client_Login;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel_home;
        private frameEncryptAndDecrypt frameEncryptAndDecrypt1;
        private FrameUserProfile frameUserProfile1;
    }
}