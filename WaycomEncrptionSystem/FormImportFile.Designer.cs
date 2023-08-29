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
            button_Cancel = new Button();
            pictureBox_Img = new PictureBox();
            textBox_fileType = new TextBox();
            label_File_Type = new Label();
            textBox_fileSize = new TextBox();
            label_fileSize = new Label();
            textBox_fileTitle = new TextBox();
            label_fileTitle = new Label();
            textBox_fileName = new TextBox();
            label_fileName = new Label();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            button_Clear = new Button();
            button_Encrypt = new Button();
            button_Decrypt = new Button();
            label_EnterSign = new Label();
            label_encryptionType = new Label();
            comboBox_encryptionMethods = new ComboBox();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Img).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(button_Import_File);
            panel.Controls.Add(button_Upload);
            panel.Controls.Add(button_Cancel);
            panel.Dock = DockStyle.Bottom;
            panel.Location = new Point(0, 650);
            panel.Name = "panel";
            panel.Size = new Size(982, 73);
            panel.TabIndex = 1;
            // 
            // button_Import_File
            // 
            button_Import_File.Anchor = AnchorStyles.None;
            button_Import_File.BackColor = Color.FromArgb(53, 169, 252);
            button_Import_File.FlatAppearance.BorderSize = 0;
            button_Import_File.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Import_File.ForeColor = Color.Transparent;
            button_Import_File.Location = new Point(37, 21);
            button_Import_File.Name = "button_Import_File";
            button_Import_File.Size = new Size(94, 37);
            button_Import_File.TabIndex = 56;
            button_Import_File.Text = "Import";
            button_Import_File.UseVisualStyleBackColor = false;
            button_Import_File.Click += button_Import_File_Click;
            // 
            // button_Upload
            // 
            button_Upload.Anchor = AnchorStyles.None;
            button_Upload.BackColor = Color.FromArgb(147, 212, 179);
            button_Upload.FlatAppearance.BorderSize = 0;
            button_Upload.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Upload.Location = new Point(732, 21);
            button_Upload.Name = "button_Upload";
            button_Upload.Size = new Size(94, 37);
            button_Upload.TabIndex = 54;
            button_Upload.Text = "Upload";
            button_Upload.UseVisualStyleBackColor = false;
            button_Upload.Click += button_Upload_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Anchor = AnchorStyles.None;
            button_Cancel.FlatAppearance.BorderSize = 0;
            button_Cancel.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancel.ForeColor = Color.Black;
            button_Cancel.Location = new Point(842, 21);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 37);
            button_Cancel.TabIndex = 55;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // pictureBox_Img
            // 
            pictureBox_Img.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Img.Location = new Point(444, 40);
            pictureBox_Img.Name = "pictureBox_Img";
            pictureBox_Img.Size = new Size(427, 245);
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
            textBox_fileType.Location = new Point(82, 338);
            textBox_fileType.Name = "textBox_fileType";
            textBox_fileType.ReadOnly = true;
            textBox_fileType.Size = new Size(176, 16);
            textBox_fileType.TabIndex = 52;
            // 
            // label_File_Type
            // 
            label_File_Type.Anchor = AnchorStyles.None;
            label_File_Type.AutoSize = true;
            label_File_Type.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_File_Type.Location = new Point(82, 314);
            label_File_Type.Name = "label_File_Type";
            label_File_Type.Size = new Size(75, 21);
            label_File_Type.TabIndex = 51;
            label_File_Type.Text = "File type";
            // 
            // textBox_fileSize
            // 
            textBox_fileSize.Anchor = AnchorStyles.None;
            textBox_fileSize.BorderStyle = BorderStyle.None;
            textBox_fileSize.Location = new Point(82, 255);
            textBox_fileSize.Name = "textBox_fileSize";
            textBox_fileSize.ReadOnly = true;
            textBox_fileSize.Size = new Size(176, 16);
            textBox_fileSize.TabIndex = 50;
            // 
            // label_fileSize
            // 
            label_fileSize.Anchor = AnchorStyles.None;
            label_fileSize.AutoSize = true;
            label_fileSize.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileSize.Location = new Point(82, 231);
            label_fileSize.Name = "label_fileSize";
            label_fileSize.Size = new Size(122, 21);
            label_fileSize.TabIndex = 49;
            label_fileSize.Text = "File Size (byte)";
            // 
            // textBox_fileTitle
            // 
            textBox_fileTitle.Anchor = AnchorStyles.None;
            textBox_fileTitle.BorderStyle = BorderStyle.None;
            textBox_fileTitle.Location = new Point(82, 100);
            textBox_fileTitle.Name = "textBox_fileTitle";
            textBox_fileTitle.Size = new Size(176, 16);
            textBox_fileTitle.TabIndex = 48;
            textBox_fileTitle.Text = "(enter a file name)";
            // 
            // label_fileTitle
            // 
            label_fileTitle.Anchor = AnchorStyles.None;
            label_fileTitle.AutoSize = true;
            label_fileTitle.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileTitle.Location = new Point(82, 76);
            label_fileTitle.Name = "label_fileTitle";
            label_fileTitle.Size = new Size(75, 21);
            label_fileTitle.TabIndex = 47;
            label_fileTitle.Text = "File Title";
            // 
            // textBox_fileName
            // 
            textBox_fileName.Anchor = AnchorStyles.None;
            textBox_fileName.BorderStyle = BorderStyle.None;
            textBox_fileName.Location = new Point(82, 171);
            textBox_fileName.Name = "textBox_fileName";
            textBox_fileName.ReadOnly = true;
            textBox_fileName.Size = new Size(176, 16);
            textBox_fileName.TabIndex = 46;
            // 
            // label_fileName
            // 
            label_fileName.Anchor = AnchorStyles.None;
            label_fileName.AutoSize = true;
            label_fileName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileName.Location = new Point(82, 147);
            label_fileName.Name = "label_fileName";
            label_fileName.Size = new Size(87, 21);
            label_fileName.TabIndex = 45;
            label_fileName.Text = "File Name";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 390);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 54;
            label1.Text = "File Source";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.DimGray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Passport", "Driver Liscence", "Certificate", "File Document", "Pictures", "Credit Card", "Others" });
            comboBox1.Location = new Point(83, 414);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 55;
            comboBox1.Text = "Please select a source";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(444, 314);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(427, 254);
            richTextBox1.TabIndex = 56;
            richTextBox1.Text = "";
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.None;
            button_Clear.FlatAppearance.BorderSize = 0;
            button_Clear.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Clear.ForeColor = Color.Black;
            button_Clear.Location = new Point(442, 584);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 37);
            button_Clear.TabIndex = 58;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Encrypt
            // 
            button_Encrypt.Anchor = AnchorStyles.None;
            button_Encrypt.BackColor = Color.FromArgb(53, 169, 252);
            button_Encrypt.FlatAppearance.BorderSize = 0;
            button_Encrypt.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Encrypt.ForeColor = Color.Transparent;
            button_Encrypt.Location = new Point(542, 584);
            button_Encrypt.Name = "button_Encrypt";
            button_Encrypt.Size = new Size(94, 37);
            button_Encrypt.TabIndex = 59;
            button_Encrypt.Text = "Encrypt";
            button_Encrypt.UseVisualStyleBackColor = false;
            button_Encrypt.Click += button_Encrypt_Click;
            // 
            // button_Decrypt
            // 
            button_Decrypt.Anchor = AnchorStyles.None;
            button_Decrypt.BackColor = Color.FromArgb(53, 169, 252);
            button_Decrypt.FlatAppearance.BorderSize = 0;
            button_Decrypt.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Decrypt.ForeColor = Color.Transparent;
            button_Decrypt.Location = new Point(642, 584);
            button_Decrypt.Name = "button_Decrypt";
            button_Decrypt.Size = new Size(94, 37);
            button_Decrypt.TabIndex = 63;
            button_Decrypt.Text = "Decrypt";
            button_Decrypt.UseVisualStyleBackColor = false;
            button_Decrypt.Click += button_Decrypt_Click;
            // 
            // label_EnterSign
            // 
            label_EnterSign.AutoSize = true;
            label_EnterSign.FlatStyle = FlatStyle.System;
            label_EnterSign.ForeColor = Color.Red;
            label_EnterSign.ImageAlign = ContentAlignment.MiddleRight;
            label_EnterSign.Location = new Point(157, 76);
            label_EnterSign.Name = "label_EnterSign";
            label_EnterSign.Size = new Size(12, 15);
            label_EnterSign.TabIndex = 64;
            label_EnterSign.Text = "*";
            // 
            // label_encryptionType
            // 
            label_encryptionType.Anchor = AnchorStyles.None;
            label_encryptionType.AutoSize = true;
            label_encryptionType.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_encryptionType.Location = new Point(83, 472);
            label_encryptionType.Name = "label_encryptionType";
            label_encryptionType.Size = new Size(134, 21);
            label_encryptionType.TabIndex = 65;
            label_encryptionType.Text = "Encryption Type";
            // 
            // comboBox_encryptionMethods
            // 
            comboBox_encryptionMethods.ForeColor = Color.DimGray;
            comboBox_encryptionMethods.FormattingEnabled = true;
            comboBox_encryptionMethods.Items.AddRange(new object[] { "AES", "RSA", "Blowfish", "Twofish", "Camellia", "Serpent" });
            comboBox_encryptionMethods.Location = new Point(83, 496);
            comboBox_encryptionMethods.Name = "comboBox_encryptionMethods";
            comboBox_encryptionMethods.Size = new Size(175, 23);
            comboBox_encryptionMethods.TabIndex = 66;
            comboBox_encryptionMethods.Text = "Please select a source";
            // 
            // FormImportFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(982, 723);
            Controls.Add(comboBox_encryptionMethods);
            Controls.Add(label_encryptionType);
            Controls.Add(label_EnterSign);
            Controls.Add(button_Decrypt);
            Controls.Add(button_Encrypt);
            Controls.Add(button_Clear);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox_Img);
            Controls.Add(textBox_fileType);
            Controls.Add(label_File_Type);
            Controls.Add(textBox_fileSize);
            Controls.Add(label_fileSize);
            Controls.Add(textBox_fileTitle);
            Controls.Add(label_fileTitle);
            Controls.Add(textBox_fileName);
            Controls.Add(label_fileName);
            Controls.Add(panel);
            Name = "FormImportFile";
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Img).EndInit();
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
        private TextBox textBox_fileTitle;
        private Label label_fileTitle;
        private TextBox textBox_fileName;
        private Label label_fileName;
        private Button button_Import_File;
        private Button button_Upload;
        private Button button_Cancel;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Button button_Clear;
        private Button button_Encrypt;
        private Button button_Decrypt;
        private Label label_EnterSign;
        private Label label_encryptionType;
        private ComboBox comboBox_encryptionMethods;
    }
}