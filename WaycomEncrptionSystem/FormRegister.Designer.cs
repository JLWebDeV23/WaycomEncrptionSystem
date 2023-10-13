namespace WaycomEncrptionSystem
{
    partial class FormRegister
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
            panel3 = new Panel();
            button_Close_Window = new Button();
            label8 = new Label();
            panel2 = new Panel();
            textBox_Address_Country = new TextBox();
            label6 = new Label();
            textBox_Address_State = new TextBox();
            label7 = new Label();
            textBox_Address_Postcode = new TextBox();
            label5 = new Label();
            textBox_Address_City = new TextBox();
            label4 = new Label();
            textBox_Address_2 = new TextBox();
            label3 = new Label();
            textBox_Address_1 = new TextBox();
            label2 = new Label();
            textBox_Email_Confirmation = new TextBox();
            label1 = new Label();
            label_organisation = new Label();
            textBox_Email = new TextBox();
            label_email = new Label();
            textBox_Password_Confirmation = new TextBox();
            label_password_confirmation = new Label();
            textBox_Password = new TextBox();
            label_password = new Label();
            textBox_Username = new TextBox();
            label_username = new Label();
            textBox_Organisation = new TextBox();
            textBox_FirstName = new TextBox();
            label_name = new Label();
            button_Submit = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 33, 36);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 136);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Close_Window);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(978, 36);
            panel3.TabIndex = 87;
            // 
            // button_Close_Window
            // 
            button_Close_Window.Dock = DockStyle.Right;
            button_Close_Window.FlatAppearance.BorderSize = 0;
            button_Close_Window.FlatAppearance.MouseOverBackColor = Color.Red;
            button_Close_Window.FlatStyle = FlatStyle.Flat;
            button_Close_Window.Image = Properties.Resources.icons8_close_16;
            button_Close_Window.Location = new Point(938, 0);
            button_Close_Window.Margin = new Padding(1);
            button_Close_Window.Name = "button_Close_Window";
            button_Close_Window.Size = new Size(40, 36);
            button_Close_Window.TabIndex = 11;
            button_Close_Window.UseVisualStyleBackColor = true;
            button_Close_Window.Click += button_Close_Window_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(269, 42);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(391, 63);
            label8.TabIndex = 86;
            label8.Text = "Register Form";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_Address_Country);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox_Address_State);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox_Address_Postcode);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox_Address_City);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox_Address_2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_Address_1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_Email_Confirmation);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label_organisation);
            panel2.Controls.Add(textBox_Email);
            panel2.Controls.Add(label_email);
            panel2.Controls.Add(textBox_Password_Confirmation);
            panel2.Controls.Add(label_password_confirmation);
            panel2.Controls.Add(textBox_Password);
            panel2.Controls.Add(label_password);
            panel2.Controls.Add(textBox_Username);
            panel2.Controls.Add(label_username);
            panel2.Controls.Add(textBox_Organisation);
            panel2.Controls.Add(textBox_FirstName);
            panel2.Controls.Add(label_name);
            panel2.Controls.Add(button_Submit);
            panel2.Controls.Add(button1);
            panel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(40, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 539);
            panel2.TabIndex = 1;
            // 
            // textBox_Address_Country
            // 
            textBox_Address_Country.Anchor = AnchorStyles.None;
            textBox_Address_Country.Location = new Point(647, 225);
            textBox_Address_Country.Multiline = true;
            textBox_Address_Country.Name = "textBox_Address_Country";
            textBox_Address_Country.Size = new Size(176, 37);
            textBox_Address_Country.TabIndex = 132;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(647, 201);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 131;
            label6.Text = "Country";
            // 
            // textBox_Address_State
            // 
            textBox_Address_State.Anchor = AnchorStyles.None;
            textBox_Address_State.Location = new Point(441, 225);
            textBox_Address_State.Multiline = true;
            textBox_Address_State.Name = "textBox_Address_State";
            textBox_Address_State.Size = new Size(176, 37);
            textBox_Address_State.TabIndex = 130;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(441, 201);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 129;
            label7.Text = "State";
            // 
            // textBox_Address_Postcode
            // 
            textBox_Address_Postcode.Anchor = AnchorStyles.None;
            textBox_Address_Postcode.Location = new Point(647, 144);
            textBox_Address_Postcode.Multiline = true;
            textBox_Address_Postcode.Name = "textBox_Address_Postcode";
            textBox_Address_Postcode.Size = new Size(176, 37);
            textBox_Address_Postcode.TabIndex = 128;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(647, 120);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 127;
            label5.Text = "Postcode";
            // 
            // textBox_Address_City
            // 
            textBox_Address_City.Anchor = AnchorStyles.None;
            textBox_Address_City.Location = new Point(441, 144);
            textBox_Address_City.Multiline = true;
            textBox_Address_City.Name = "textBox_Address_City";
            textBox_Address_City.Size = new Size(176, 37);
            textBox_Address_City.TabIndex = 126;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(441, 120);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 125;
            label4.Text = "City";
            // 
            // textBox_Address_2
            // 
            textBox_Address_2.Anchor = AnchorStyles.None;
            textBox_Address_2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Address_2.Location = new Point(647, 61);
            textBox_Address_2.Multiline = true;
            textBox_Address_2.Name = "textBox_Address_2";
            textBox_Address_2.Size = new Size(176, 37);
            textBox_Address_2.TabIndex = 124;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(647, 37);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 123;
            label3.Text = "Address 2";
            // 
            // textBox_Address_1
            // 
            textBox_Address_1.Anchor = AnchorStyles.None;
            textBox_Address_1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Address_1.Location = new Point(441, 61);
            textBox_Address_1.Multiline = true;
            textBox_Address_1.Name = "textBox_Address_1";
            textBox_Address_1.Size = new Size(176, 37);
            textBox_Address_1.TabIndex = 122;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(441, 37);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 121;
            label2.Text = "Address 1*";
            // 
            // textBox_Email_Confirmation
            // 
            textBox_Email_Confirmation.Anchor = AnchorStyles.None;
            textBox_Email_Confirmation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email_Confirmation.Location = new Point(20, 476);
            textBox_Email_Confirmation.Multiline = true;
            textBox_Email_Confirmation.Name = "textBox_Email_Confirmation";
            textBox_Email_Confirmation.Size = new Size(376, 37);
            textBox_Email_Confirmation.TabIndex = 120;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(20, 452);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 119;
            label1.Text = "Confirm Email*";
            // 
            // label_organisation
            // 
            label_organisation.Anchor = AnchorStyles.None;
            label_organisation.AutoSize = true;
            label_organisation.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_organisation.ForeColor = Color.Snow;
            label_organisation.Location = new Point(220, 16);
            label_organisation.Name = "label_organisation";
            label_organisation.Size = new Size(127, 42);
            label_organisation.TabIndex = 118;
            label_organisation.Text = "Organisation/\r\nOccupation";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.None;
            textBox_Email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(20, 398);
            textBox_Email.Multiline = true;
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(376, 37);
            textBox_Email.TabIndex = 117;
            // 
            // label_email
            // 
            label_email.Anchor = AnchorStyles.None;
            label_email.AutoSize = true;
            label_email.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_email.ForeColor = Color.Snow;
            label_email.Location = new Point(20, 374);
            label_email.Name = "label_email";
            label_email.Size = new Size(64, 21);
            label_email.TabIndex = 116;
            label_email.Text = "Email*";
            // 
            // textBox_Password_Confirmation
            // 
            textBox_Password_Confirmation.Anchor = AnchorStyles.None;
            textBox_Password_Confirmation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Password_Confirmation.Location = new Point(20, 313);
            textBox_Password_Confirmation.Multiline = true;
            textBox_Password_Confirmation.Name = "textBox_Password_Confirmation";
            textBox_Password_Confirmation.Size = new Size(376, 37);
            textBox_Password_Confirmation.TabIndex = 115;
            // 
            // label_password_confirmation
            // 
            label_password_confirmation.Anchor = AnchorStyles.None;
            label_password_confirmation.AutoSize = true;
            label_password_confirmation.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_password_confirmation.ForeColor = Color.Snow;
            label_password_confirmation.Location = new Point(20, 289);
            label_password_confirmation.Name = "label_password_confirmation";
            label_password_confirmation.Size = new Size(172, 21);
            label_password_confirmation.TabIndex = 114;
            label_password_confirmation.Text = "Re-enter Password*";
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.None;
            textBox_Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Password.Location = new Point(20, 225);
            textBox_Password.Multiline = true;
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(376, 37);
            textBox_Password.TabIndex = 113;
            // 
            // label_password
            // 
            label_password.Anchor = AnchorStyles.None;
            label_password.AutoSize = true;
            label_password.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_password.ForeColor = Color.Snow;
            label_password.Location = new Point(20, 201);
            label_password.Name = "label_password";
            label_password.Size = new Size(91, 21);
            label_password.TabIndex = 112;
            label_password.Text = "Password*";
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.None;
            textBox_Username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Username.Location = new Point(20, 144);
            textBox_Username.Multiline = true;
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(376, 37);
            textBox_Username.TabIndex = 111;
            // 
            // label_username
            // 
            label_username.Anchor = AnchorStyles.None;
            label_username.AutoSize = true;
            label_username.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_username.ForeColor = Color.Snow;
            label_username.Location = new Point(20, 120);
            label_username.Name = "label_username";
            label_username.Size = new Size(91, 21);
            label_username.TabIndex = 110;
            label_username.Text = "Username*";
            // 
            // textBox_Organisation
            // 
            textBox_Organisation.Anchor = AnchorStyles.None;
            textBox_Organisation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Organisation.Location = new Point(220, 61);
            textBox_Organisation.Multiline = true;
            textBox_Organisation.Name = "textBox_Organisation";
            textBox_Organisation.Size = new Size(176, 37);
            textBox_Organisation.TabIndex = 109;
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Anchor = AnchorStyles.None;
            textBox_FirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_FirstName.Location = new Point(20, 61);
            textBox_FirstName.Multiline = true;
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(176, 37);
            textBox_FirstName.TabIndex = 108;
            // 
            // label_name
            // 
            label_name.Anchor = AnchorStyles.None;
            label_name.AutoSize = true;
            label_name.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.ForeColor = Color.Snow;
            label_name.Location = new Point(20, 37);
            label_name.Name = "label_name";
            label_name.Size = new Size(55, 21);
            label_name.TabIndex = 107;
            label_name.Text = "Name*";
            // 
            // button_Submit
            // 
            button_Submit.Anchor = AnchorStyles.None;
            button_Submit.FlatStyle = FlatStyle.Flat;
            button_Submit.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Submit.ForeColor = Color.Snow;
            button_Submit.Location = new Point(768, 471);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(94, 37);
            button_Submit.TabIndex = 106;
            button_Submit.Text = "Submit";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.White;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(775, 476);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 133;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 59, 57);
            ClientSize = new Size(980, 705);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private TextBox textBox_Address_Country;
        private Label label6;
        private TextBox textBox_Address_State;
        private Label label7;
        private TextBox textBox_Address_Postcode;
        private Label label5;
        private TextBox textBox_Address_City;
        private Label label4;
        private TextBox textBox_Address_2;
        private Label label3;
        private TextBox textBox_Address_1;
        private Label label2;
        private TextBox textBox_Email_Confirmation;
        private Label label1;
        private Label label_organisation;
        private TextBox textBox_Email;
        private Label label_email;
        private TextBox textBox_Password_Confirmation;
        private Label label_password_confirmation;
        private TextBox textBox_Password;
        private Label label_password;
        private TextBox textBox_Username;
        private Label label_username;
        private TextBox textBox_Organisation;
        private TextBox textBox_FirstName;
        private Label label_name;
        private Button button_Submit;
        private Button button1;
        private Panel panel3;
        private Button button_Close_Window;
    }
}