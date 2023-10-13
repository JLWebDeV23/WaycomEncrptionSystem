namespace WaycomEncrptionSystem
{
    partial class FormImportFile
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
            panel = new Panel();
            button_Import_File = new Button();
            button_Upload = new Button();
            pictureBox_Img = new PictureBox();
            textBox_fileType = new TextBox();
            label_File_Type = new Label();
            textBox_fileSize = new TextBox();
            label_fileSize = new Label();
            textBox_fileName = new TextBox();
            label_fileName = new Label();
            openFileDialog1 = new OpenFileDialog();
            richTextBox1 = new RichTextBox();
            button_Clear = new Button();
            button_Encrypt = new Button();
            label_encryption_Type = new Label();
            comboBox_encryptionMethods = new ComboBox();
            panel2 = new Panel();
            button_nextPage = new Button();
            button_prevPage = new Button();
            button_Close_Window = new Button();
            panel1 = new Panel();
            textBox_PDF = new TextBox();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Img).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(button_Import_File);
            panel.Controls.Add(button_Upload);
            panel.Dock = DockStyle.Bottom;
            panel.Location = new Point(0, 637);
            panel.Name = "panel";
            panel.Size = new Size(973, 98);
            panel.TabIndex = 1;
            // 
            // button_Import_File
            // 
            button_Import_File.Anchor = AnchorStyles.None;
            button_Import_File.BackColor = Color.FromArgb(53, 169, 252);
            button_Import_File.FlatAppearance.BorderSize = 0;
            button_Import_File.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Import_File.ForeColor = Color.Transparent;
            button_Import_File.Location = new Point(32, 34);
            button_Import_File.Name = "button_Import_File";
            button_Import_File.Size = new Size(94, 37);
            button_Import_File.TabIndex = 56;
            button_Import_File.Text = "IMPORT";
            button_Import_File.UseVisualStyleBackColor = false;
            button_Import_File.Click += button_Import_File_Click;
            // 
            // button_Upload
            // 
            button_Upload.Anchor = AnchorStyles.None;
            button_Upload.BackColor = Color.FromArgb(147, 212, 179);
            button_Upload.FlatAppearance.BorderSize = 0;
            button_Upload.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Upload.Location = new Point(837, 34);
            button_Upload.Name = "button_Upload";
            button_Upload.Size = new Size(94, 37);
            button_Upload.TabIndex = 54;
            button_Upload.Text = "SAVE";
            button_Upload.UseVisualStyleBackColor = false;
            button_Upload.Visible = false;
            button_Upload.Click += button_Upload_Click;
            // 
            // pictureBox_Img
            // 
            pictureBox_Img.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Img.Location = new Point(319, 66);
            pictureBox_Img.Name = "pictureBox_Img";
            pictureBox_Img.Size = new Size(452, 249);
            pictureBox_Img.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Img.TabIndex = 53;
            pictureBox_Img.TabStop = false;
            pictureBox_Img.DragDrop += pictureBox_Img_DragDrop;
            pictureBox_Img.DragEnter += pictureBox_Img_DragEnter;
            // 
            // textBox_fileType
            // 
            textBox_fileType.Anchor = AnchorStyles.None;
            textBox_fileType.BorderStyle = BorderStyle.None;
            textBox_fileType.Enabled = false;
            textBox_fileType.Location = new Point(32, 265);
            textBox_fileType.Name = "textBox_fileType";
            textBox_fileType.ReadOnly = true;
            textBox_fileType.Size = new Size(174, 16);
            textBox_fileType.TabIndex = 52;
            // 
            // label_File_Type
            // 
            label_File_Type.Anchor = AnchorStyles.None;
            label_File_Type.AutoSize = true;
            label_File_Type.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_File_Type.ForeColor = Color.Snow;
            label_File_Type.Location = new Point(32, 241);
            label_File_Type.Name = "label_File_Type";
            label_File_Type.Size = new Size(75, 21);
            label_File_Type.TabIndex = 51;
            label_File_Type.Text = "File type";
            // 
            // textBox_fileSize
            // 
            textBox_fileSize.Anchor = AnchorStyles.None;
            textBox_fileSize.BorderStyle = BorderStyle.None;
            textBox_fileSize.Enabled = false;
            textBox_fileSize.Location = new Point(31, 165);
            textBox_fileSize.Name = "textBox_fileSize";
            textBox_fileSize.ReadOnly = true;
            textBox_fileSize.Size = new Size(175, 16);
            textBox_fileSize.TabIndex = 50;
            // 
            // label_fileSize
            // 
            label_fileSize.Anchor = AnchorStyles.None;
            label_fileSize.AutoSize = true;
            label_fileSize.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileSize.ForeColor = Color.Snow;
            label_fileSize.Location = new Point(30, 141);
            label_fileSize.Name = "label_fileSize";
            label_fileSize.Size = new Size(122, 21);
            label_fileSize.TabIndex = 49;
            label_fileSize.Text = "File Size (byte)";
            // 
            // textBox_fileName
            // 
            textBox_fileName.Anchor = AnchorStyles.None;
            textBox_fileName.BorderStyle = BorderStyle.None;
            textBox_fileName.Enabled = false;
            textBox_fileName.Location = new Point(32, 77);
            textBox_fileName.Name = "textBox_fileName";
            textBox_fileName.ReadOnly = true;
            textBox_fileName.Size = new Size(174, 16);
            textBox_fileName.TabIndex = 46;
            // 
            // label_fileName
            // 
            label_fileName.Anchor = AnchorStyles.None;
            label_fileName.AutoSize = true;
            label_fileName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileName.ForeColor = Color.Snow;
            label_fileName.Location = new Point(31, 53);
            label_fileName.Name = "label_fileName";
            label_fileName.Size = new Size(87, 21);
            label_fileName.TabIndex = 45;
            label_fileName.Text = "File Name";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(319, 343);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(452, 249);
            richTextBox1.TabIndex = 56;
            richTextBox1.Text = "";
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.None;
            button_Clear.FlatAppearance.BorderSize = 0;
            button_Clear.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Clear.ForeColor = Color.Black;
            button_Clear.Location = new Point(837, 457);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 37);
            button_Clear.TabIndex = 58;
            button_Clear.Text = "CLEAR";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Visible = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Encrypt
            // 
            button_Encrypt.Anchor = AnchorStyles.None;
            button_Encrypt.BackColor = Color.FromArgb(53, 169, 252);
            button_Encrypt.FlatAppearance.BorderSize = 0;
            button_Encrypt.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Encrypt.ForeColor = Color.Transparent;
            button_Encrypt.Location = new Point(837, 200);
            button_Encrypt.Name = "button_Encrypt";
            button_Encrypt.Size = new Size(94, 37);
            button_Encrypt.TabIndex = 59;
            button_Encrypt.Text = "ENCRYPT";
            button_Encrypt.UseVisualStyleBackColor = false;
            button_Encrypt.Visible = false;
            button_Encrypt.Click += button_Encrypt_Click;
            // 
            // label_encryption_Type
            // 
            label_encryption_Type.Anchor = AnchorStyles.None;
            label_encryption_Type.AutoSize = true;
            label_encryption_Type.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_encryption_Type.ForeColor = Color.Snow;
            label_encryption_Type.Location = new Point(32, 341);
            label_encryption_Type.Name = "label_encryption_Type";
            label_encryption_Type.Size = new Size(134, 21);
            label_encryption_Type.TabIndex = 65;
            label_encryption_Type.Text = "Encryption Type";
            // 
            // comboBox_encryptionMethods
            // 
            comboBox_encryptionMethods.ForeColor = Color.DimGray;
            comboBox_encryptionMethods.FormattingEnabled = true;
            comboBox_encryptionMethods.Items.AddRange(new object[] { "AES", "RSA", "Blowfish", "Twofish", "Camellia", "Serpent", "TripleDES" });
            comboBox_encryptionMethods.Location = new Point(31, 365);
            comboBox_encryptionMethods.Name = "comboBox_encryptionMethods";
            comboBox_encryptionMethods.Size = new Size(175, 23);
            comboBox_encryptionMethods.TabIndex = 66;
            comboBox_encryptionMethods.Text = "Please select a source";
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
            panel2.TabIndex = 68;
            // 
            // button_nextPage
            // 
            button_nextPage.FlatStyle = FlatStyle.Flat;
            button_nextPage.ForeColor = Color.FromArgb(32, 33, 36);
            button_nextPage.Image = Properties.Resources.icons8_forward_32;
            button_nextPage.Location = new Point(67, 0);
            button_nextPage.Name = "button_nextPage";
            button_nextPage.Size = new Size(67, 45);
            button_nextPage.TabIndex = 13;
            button_nextPage.UseVisualStyleBackColor = true;
            button_nextPage.Visible = false;
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
            button_prevPage.TabIndex = 12;
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
            // panel1
            // 
            panel1.Controls.Add(label_fileName);
            panel1.Controls.Add(textBox_fileType);
            panel1.Controls.Add(comboBox_encryptionMethods);
            panel1.Controls.Add(label_File_Type);
            panel1.Controls.Add(label_encryption_Type);
            panel1.Controls.Add(textBox_fileSize);
            panel1.Controls.Add(textBox_fileName);
            panel1.Controls.Add(label_fileSize);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 592);
            panel1.TabIndex = 69;
            // 
            // textBox_PDF
            // 
            textBox_PDF.BackColor = Color.FromArgb(32, 33, 36);
            textBox_PDF.BorderStyle = BorderStyle.None;
            textBox_PDF.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox_PDF.ForeColor = SystemColors.ScrollBar;
            textBox_PDF.Location = new Point(491, 179);
            textBox_PDF.Name = "textBox_PDF";
            textBox_PDF.Size = new Size(100, 28);
            textBox_PDF.TabIndex = 76;
            textBox_PDF.Text = "PDF FILE";
            textBox_PDF.Visible = false;
            // 
            // FormImportFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(973, 735);
            ControlBox = false;
            Controls.Add(textBox_PDF);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button_Encrypt);
            Controls.Add(button_Clear);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox_Img);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormImportFile";
            StartPosition = FormStartPosition.CenterScreen;
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Img).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private PictureBox pictureBox_Img;
        private TextBox textBox_fileType;
        private Label label_File_Type;
        private TextBox textBox_fileSize;
        private Label label_fileSize;
        private TextBox textBox_fileName;
        private Label label_fileName;
        private Button button_Import_File;
        private Button button_Upload;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
        private Button button_Clear;
        private Button button_Encrypt;
        private Label label_encryption_Type;
        private ComboBox comboBox_encryptionMethods;
        private Panel panel2;
        private Button button_Close_Window;
        private Panel panel1;
        private Button button_prevPage;
        private Button button_nextPage;
        private TextBox textBox_PDF;
    }
}