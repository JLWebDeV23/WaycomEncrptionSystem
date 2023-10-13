namespace WaycomEncrptionSystem
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox_Password = new TextBox();
            textBox_Username = new TextBox();
            linkLabel_Register_Account = new LinkLabel();
            button_Login = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button_Exit = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox_Password);
            panel1.Controls.Add(textBox_Username);
            panel1.Controls.Add(linkLabel_Register_Account);
            panel1.Location = new Point(172, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 348);
            panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_32__1_;
            pictureBox3.Location = new Point(44, 78);
            pictureBox3.Margin = new Padding(1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 153);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Password.Location = new Point(85, 153);
            textBox_Password.Multiline = true;
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(333, 32);
            textBox_Password.TabIndex = 0;
            // 
            // textBox_Username
            // 
            textBox_Username.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Username.Location = new Point(85, 78);
            textBox_Username.Multiline = true;
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(333, 32);
            textBox_Username.TabIndex = 5;
            // 
            // linkLabel_Register_Account
            // 
            linkLabel_Register_Account.ActiveLinkColor = Color.Gainsboro;
            linkLabel_Register_Account.AutoSize = true;
            linkLabel_Register_Account.ForeColor = Color.WhiteSmoke;
            linkLabel_Register_Account.LinkColor = Color.Silver;
            linkLabel_Register_Account.Location = new Point(329, 305);
            linkLabel_Register_Account.Name = "linkLabel_Register_Account";
            linkLabel_Register_Account.Size = new Size(115, 15);
            linkLabel_Register_Account.TabIndex = 6;
            linkLabel_Register_Account.TabStop = true;
            linkLabel_Register_Account.Text = "REGISTER ACCOUNT";
            linkLabel_Register_Account.LinkClicked += linkLabel_Register_Account_LinkClicked;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.FromArgb(130, 133, 140);
            button_Login.Font = new Font("HoloLens MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Login.ForeColor = Color.White;
            button_Login.Location = new Point(312, 442);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(178, 44);
            button_Login.TabIndex = 4;
            button_Login.Text = "LOGIN";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(36, 36);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.FromArgb(130, 133, 140);
            button_Exit.Font = new Font("HoloLens MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Exit.ForeColor = Color.White;
            button_Exit.Location = new Point(720, 501);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(77, 31);
            button_Exit.TabIndex = 6;
            button_Exit.Text = "EXIT";
            button_Exit.TextAlign = ContentAlignment.TopCenter;
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 22);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(832, 551);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button_Exit);
            Controls.Add(button_Login);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Padding = new Padding(20, 0, 20, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_Login;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox_Password;
        private TextBox textBox_Username;
        private LinkLabel linkLabel_Register_Account;
        private Panel panel1;
        private Button button_Exit;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}