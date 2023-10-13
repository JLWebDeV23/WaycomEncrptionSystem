namespace WaycomEncrptionSystem
{
    partial class FormDecryptFiles
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
            panel2 = new Panel();
            button_nextPage = new Button();
            button_prevPage = new Button();
            button_Close_Window = new Button();
            userBindingSource = new BindingSource(components);
            panel1 = new Panel();
            textBox_Encryption_Method = new TextBox();
            label_fileName = new Label();
            textBox_fileType = new TextBox();
            label_File_Type = new Label();
            label_encryption_Type = new Label();
            textBox_fileSize = new TextBox();
            textBox_fileName = new TextBox();
            label_fileSize = new Label();
            panel3 = new Panel();
            button_Decrypt = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox_Img = new PictureBox();
            button_Clear = new Button();
            textBox_PDF = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Img).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button_nextPage);
            panel2.Controls.Add(button_prevPage);
            panel2.Controls.Add(button_Close_Window);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 45);
            panel2.TabIndex = 69;
            // 
            // button_nextPage
            // 
            button_nextPage.FlatStyle = FlatStyle.Flat;
            button_nextPage.ForeColor = Color.FromArgb(32, 33, 36);
            button_nextPage.Image = Properties.Resources.icons8_forward_32;
            button_nextPage.Location = new Point(67, 0);
            button_nextPage.Name = "button_nextPage";
            button_nextPage.Size = new Size(67, 45);
            button_nextPage.TabIndex = 15;
            button_nextPage.UseVisualStyleBackColor = true;
            button_nextPage.Click += button_nextPage_Click;
            // 
            // button_prevPage
            // 
            button_prevPage.FlatStyle = FlatStyle.Flat;
            button_prevPage.ForeColor = Color.FromArgb(32, 33, 36);
            button_prevPage.Image = Properties.Resources.icons8_previous_32;
            button_prevPage.Location = new Point(0, 0);
            button_prevPage.Name = "button_prevPage";
            button_prevPage.Size = new Size(67, 45);
            button_prevPage.TabIndex = 14;
            button_prevPage.UseVisualStyleBackColor = true;
            button_prevPage.Visible = false;
            button_prevPage.Click += button_prevPage_Click;
            // 
            // button_Close_Window
            // 
            button_Close_Window.Dock = DockStyle.Right;
            button_Close_Window.FlatAppearance.BorderSize = 0;
            button_Close_Window.FlatAppearance.MouseOverBackColor = Color.Red;
            button_Close_Window.FlatStyle = FlatStyle.Flat;
            button_Close_Window.Image = Properties.Resources.icons8_close_16;
            button_Close_Window.Location = new Point(915, 0);
            button_Close_Window.Name = "button_Close_Window";
            button_Close_Window.Size = new Size(58, 45);
            button_Close_Window.TabIndex = 11;
            button_Close_Window.UseVisualStyleBackColor = true;
            button_Close_Window.Click += button_Close_Window_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_Encryption_Method);
            panel1.Controls.Add(label_fileName);
            panel1.Controls.Add(textBox_fileType);
            panel1.Controls.Add(label_File_Type);
            panel1.Controls.Add(label_encryption_Type);
            panel1.Controls.Add(textBox_fileSize);
            panel1.Controls.Add(textBox_fileName);
            panel1.Controls.Add(label_fileSize);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 690);
            panel1.TabIndex = 70;
            // 
            // textBox_Encryption_Method
            // 
            textBox_Encryption_Method.Anchor = AnchorStyles.None;
            textBox_Encryption_Method.BorderStyle = BorderStyle.None;
            textBox_Encryption_Method.Enabled = false;
            textBox_Encryption_Method.Location = new Point(48, 375);
            textBox_Encryption_Method.Name = "textBox_Encryption_Method";
            textBox_Encryption_Method.ReadOnly = true;
            textBox_Encryption_Method.Size = new Size(174, 16);
            textBox_Encryption_Method.TabIndex = 74;
            // 
            // label_fileName
            // 
            label_fileName.Anchor = AnchorStyles.None;
            label_fileName.AutoSize = true;
            label_fileName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileName.ForeColor = Color.Snow;
            label_fileName.Location = new Point(47, 63);
            label_fileName.Name = "label_fileName";
            label_fileName.Size = new Size(87, 21);
            label_fileName.TabIndex = 67;
            label_fileName.Text = "File Name";
            // 
            // textBox_fileType
            // 
            textBox_fileType.Anchor = AnchorStyles.None;
            textBox_fileType.BorderStyle = BorderStyle.None;
            textBox_fileType.Enabled = false;
            textBox_fileType.Location = new Point(48, 275);
            textBox_fileType.Name = "textBox_fileType";
            textBox_fileType.ReadOnly = true;
            textBox_fileType.Size = new Size(174, 16);
            textBox_fileType.TabIndex = 72;
            // 
            // label_File_Type
            // 
            label_File_Type.Anchor = AnchorStyles.None;
            label_File_Type.AutoSize = true;
            label_File_Type.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_File_Type.ForeColor = Color.Snow;
            label_File_Type.Location = new Point(48, 251);
            label_File_Type.Name = "label_File_Type";
            label_File_Type.Size = new Size(75, 21);
            label_File_Type.TabIndex = 71;
            label_File_Type.Text = "File type";
            // 
            // label_encryption_Type
            // 
            label_encryption_Type.Anchor = AnchorStyles.None;
            label_encryption_Type.AutoSize = true;
            label_encryption_Type.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_encryption_Type.ForeColor = Color.Snow;
            label_encryption_Type.Location = new Point(48, 351);
            label_encryption_Type.Name = "label_encryption_Type";
            label_encryption_Type.Size = new Size(134, 21);
            label_encryption_Type.TabIndex = 73;
            label_encryption_Type.Text = "Encryption Type";
            // 
            // textBox_fileSize
            // 
            textBox_fileSize.Anchor = AnchorStyles.None;
            textBox_fileSize.BorderStyle = BorderStyle.None;
            textBox_fileSize.Enabled = false;
            textBox_fileSize.Location = new Point(47, 175);
            textBox_fileSize.Name = "textBox_fileSize";
            textBox_fileSize.ReadOnly = true;
            textBox_fileSize.Size = new Size(175, 16);
            textBox_fileSize.TabIndex = 70;
            // 
            // textBox_fileName
            // 
            textBox_fileName.Anchor = AnchorStyles.None;
            textBox_fileName.BorderStyle = BorderStyle.None;
            textBox_fileName.Enabled = false;
            textBox_fileName.Location = new Point(48, 87);
            textBox_fileName.Name = "textBox_fileName";
            textBox_fileName.ReadOnly = true;
            textBox_fileName.Size = new Size(174, 16);
            textBox_fileName.TabIndex = 68;
            // 
            // label_fileSize
            // 
            label_fileSize.Anchor = AnchorStyles.None;
            label_fileSize.AutoSize = true;
            label_fileSize.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileSize.ForeColor = Color.Snow;
            label_fileSize.Location = new Point(46, 151);
            label_fileSize.Name = "label_fileSize";
            label_fileSize.Size = new Size(122, 21);
            label_fileSize.TabIndex = 69;
            label_fileSize.Text = "File Size (byte)";
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Decrypt);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(289, 637);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 98);
            panel3.TabIndex = 71;
            // 
            // button_Decrypt
            // 
            button_Decrypt.Anchor = AnchorStyles.None;
            button_Decrypt.BackColor = Color.FromArgb(53, 169, 252);
            button_Decrypt.FlatAppearance.BorderSize = 0;
            button_Decrypt.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Decrypt.ForeColor = Color.Transparent;
            button_Decrypt.Location = new Point(561, 35);
            button_Decrypt.Name = "button_Decrypt";
            button_Decrypt.Size = new Size(94, 37);
            button_Decrypt.TabIndex = 64;
            button_Decrypt.Text = "DECRYPT";
            button_Decrypt.UseVisualStyleBackColor = false;
            button_Decrypt.Click += button_Decrypt_Click_1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(319, 343);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(452, 249);
            richTextBox1.TabIndex = 73;
            richTextBox1.Text = "";
            // 
            // pictureBox_Img
            // 
            pictureBox_Img.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Img.Location = new Point(319, 66);
            pictureBox_Img.Name = "pictureBox_Img";
            pictureBox_Img.Size = new Size(452, 249);
            pictureBox_Img.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Img.TabIndex = 72;
            pictureBox_Img.TabStop = false;
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.None;
            button_Clear.FlatAppearance.BorderSize = 0;
            button_Clear.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Clear.ForeColor = Color.Black;
            button_Clear.Location = new Point(850, 269);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 37);
            button_Clear.TabIndex = 74;
            button_Clear.Text = "DELETE";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Visible = false;
            // 
            // textBox_PDF
            // 
            textBox_PDF.BackColor = Color.FromArgb(32, 33, 36);
            textBox_PDF.BorderStyle = BorderStyle.None;
            textBox_PDF.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox_PDF.ForeColor = SystemColors.ScrollBar;
            textBox_PDF.Location = new Point(498, 177);
            textBox_PDF.Name = "textBox_PDF";
            textBox_PDF.Size = new Size(100, 28);
            textBox_PDF.TabIndex = 75;
            textBox_PDF.Text = "PDF FILE";
            textBox_PDF.Visible = false;
            // 
            // FormDecryptFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(973, 735);
            Controls.Add(textBox_PDF);
            Controls.Add(button_Clear);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox_Img);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDecryptFiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDecryptFiles";
            Load += FormDecryptFiles_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button_Close_Window;
        private BindingSource userBindingSource;
        private Button button_nextPage;
        private Button button_prevPage;
        private Panel panel1;
        private Panel panel3;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox_Img;
        private Button button_Decrypt;
        private Button button_Clear;
        private Label label_fileName;
        private TextBox textBox_fileType;
        private Label label_File_Type;
        private Label label_encryption_Type;
        private TextBox textBox_fileSize;
        private TextBox textBox_fileName;
        private Label label_fileSize;
        private TextBox textBox_Encryption_Method;
        private TextBox textBox_PDF;
    }
}