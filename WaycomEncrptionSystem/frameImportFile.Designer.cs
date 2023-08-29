namespace WaycomEncrptionSystem
{
    partial class frameImportFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_frameView = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label_encryptionType = new Label();
            comboBox_encryptionSelect = new ComboBox();
            panel1 = new Panel();
            button_Import_File = new Button();
            button_Cancel = new Button();
            button_Upload = new Button();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            label_fileType = new Label();
            textBox_fileSize = new TextBox();
            label_fileSize = new Label();
            textBox_fileTitle = new TextBox();
            label_fileTitle = new Label();
            textBox_fileName = new TextBox();
            label_fileName = new Label();
            panel_frameView.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_frameView
            // 
            panel_frameView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_frameView.Controls.Add(comboBox1);
            panel_frameView.Controls.Add(label1);
            panel_frameView.Controls.Add(label_encryptionType);
            panel_frameView.Controls.Add(comboBox_encryptionSelect);
            panel_frameView.Controls.Add(panel1);
            panel_frameView.Controls.Add(pictureBox1);
            panel_frameView.Controls.Add(textBox3);
            panel_frameView.Controls.Add(label_fileType);
            panel_frameView.Controls.Add(textBox_fileSize);
            panel_frameView.Controls.Add(label_fileSize);
            panel_frameView.Controls.Add(textBox_fileTitle);
            panel_frameView.Controls.Add(label_fileTitle);
            panel_frameView.Controls.Add(textBox_fileName);
            panel_frameView.Controls.Add(label_fileName);
            panel_frameView.Location = new Point(0, 0);
            panel_frameView.Name = "panel_frameView";
            panel_frameView.Size = new Size(968, 729);
            panel_frameView.TabIndex = 1;
            panel_frameView.Paint += panel_frameView_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AES (default)", "RSA", "Blowfish", "Twofish" });
            comboBox1.Location = new Point(75, 475);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 49;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 451);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 48;
            label1.Text = "File type";
            // 
            // label_encryptionType
            // 
            label_encryptionType.Anchor = AnchorStyles.None;
            label_encryptionType.AutoSize = true;
            label_encryptionType.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_encryptionType.Location = new Point(72, 372);
            label_encryptionType.Name = "label_encryptionType";
            label_encryptionType.Size = new Size(75, 21);
            label_encryptionType.TabIndex = 47;
            label_encryptionType.Text = "File type";
            // 
            // comboBox_encryptionSelect
            // 
            comboBox_encryptionSelect.FormattingEnabled = true;
            comboBox_encryptionSelect.Items.AddRange(new object[] { "AES (default)", "RSA", "Blowfish", "Twofish" });
            comboBox_encryptionSelect.Location = new Point(75, 396);
            comboBox_encryptionSelect.Name = "comboBox_encryptionSelect";
            comboBox_encryptionSelect.Size = new Size(121, 23);
            comboBox_encryptionSelect.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(button_Import_File);
            panel1.Controls.Add(button_Cancel);
            panel1.Controls.Add(button_Upload);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 665);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 64);
            panel1.TabIndex = 45;
            // 
            // button_Import_File
            // 
            button_Import_File.Anchor = AnchorStyles.None;
            button_Import_File.BackColor = Color.FromArgb(53, 169, 252);
            button_Import_File.FlatAppearance.BorderSize = 0;
            button_Import_File.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Import_File.ForeColor = Color.Transparent;
            button_Import_File.Location = new Point(38, 14);
            button_Import_File.Name = "button_Import_File";
            button_Import_File.Size = new Size(94, 37);
            button_Import_File.TabIndex = 52;
            button_Import_File.Text = "Import";
            button_Import_File.UseVisualStyleBackColor = false;
            button_Import_File.Click += button_Import_File_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Anchor = AnchorStyles.None;
            button_Cancel.FlatAppearance.BorderSize = 0;
            button_Cancel.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancel.ForeColor = Color.Black;
            button_Cancel.Location = new Point(841, 14);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 37);
            button_Cancel.TabIndex = 51;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Upload
            // 
            button_Upload.Anchor = AnchorStyles.None;
            button_Upload.BackColor = Color.FromArgb(147, 212, 179);
            button_Upload.FlatAppearance.BorderSize = 0;
            button_Upload.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Upload.Location = new Point(733, 14);
            button_Upload.Name = "button_Upload";
            button_Upload.Size = new Size(94, 37);
            button_Upload.TabIndex = 50;
            button_Upload.Text = "Upload";
            button_Upload.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(407, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 292);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(75, 321);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(176, 16);
            textBox3.TabIndex = 43;
            // 
            // label_fileType
            // 
            label_fileType.Anchor = AnchorStyles.None;
            label_fileType.AutoSize = true;
            label_fileType.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileType.Location = new Point(75, 298);
            label_fileType.Name = "label_fileType";
            label_fileType.Size = new Size(75, 21);
            label_fileType.TabIndex = 42;
            label_fileType.Text = "File type";
            // 
            // textBox_fileSize
            // 
            textBox_fileSize.Anchor = AnchorStyles.None;
            textBox_fileSize.BorderStyle = BorderStyle.None;
            textBox_fileSize.Location = new Point(75, 239);
            textBox_fileSize.Name = "textBox_fileSize";
            textBox_fileSize.ReadOnly = true;
            textBox_fileSize.Size = new Size(176, 16);
            textBox_fileSize.TabIndex = 41;
            // 
            // label_fileSize
            // 
            label_fileSize.Anchor = AnchorStyles.None;
            label_fileSize.AutoSize = true;
            label_fileSize.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileSize.Location = new Point(75, 215);
            label_fileSize.Name = "label_fileSize";
            label_fileSize.Size = new Size(72, 21);
            label_fileSize.TabIndex = 40;
            label_fileSize.Text = "File Size";
            // 
            // textBox_fileTitle
            // 
            textBox_fileTitle.Anchor = AnchorStyles.None;
            textBox_fileTitle.BorderStyle = BorderStyle.None;
            textBox_fileTitle.Location = new Point(75, 84);
            textBox_fileTitle.Name = "textBox_fileTitle";
            textBox_fileTitle.Size = new Size(176, 16);
            textBox_fileTitle.TabIndex = 39;
            // 
            // label_fileTitle
            // 
            label_fileTitle.Anchor = AnchorStyles.None;
            label_fileTitle.AutoSize = true;
            label_fileTitle.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileTitle.Location = new Point(75, 60);
            label_fileTitle.Name = "label_fileTitle";
            label_fileTitle.Size = new Size(75, 21);
            label_fileTitle.TabIndex = 38;
            label_fileTitle.Text = "File Title";
            // 
            // textBox_fileName
            // 
            textBox_fileName.Anchor = AnchorStyles.None;
            textBox_fileName.BorderStyle = BorderStyle.None;
            textBox_fileName.Location = new Point(75, 155);
            textBox_fileName.Name = "textBox_fileName";
            textBox_fileName.ReadOnly = true;
            textBox_fileName.Size = new Size(176, 16);
            textBox_fileName.TabIndex = 37;
            // 
            // label_fileName
            // 
            label_fileName.Anchor = AnchorStyles.None;
            label_fileName.AutoSize = true;
            label_fileName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_fileName.Location = new Point(75, 131);
            label_fileName.Name = "label_fileName";
            label_fileName.Size = new Size(87, 21);
            label_fileName.TabIndex = 36;
            label_fileName.Text = "File Name";
            // 
            // frameImportFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(panel_frameView);
            Name = "frameImportFile";
            Size = new Size(968, 729);
            panel_frameView.ResumeLayout(false);
            panel_frameView.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_frameView;
        private TextBox textBox_fileName;
        private Label label_fileName;
        private TextBox textBox3;
        private Label label_fileType;
        private TextBox textBox_fileSize;
        private Label label_fileSize;
        private TextBox textBox_fileTitle;
        private Label label_fileTitle;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button_Cancel;
        private Button button_Upload;
        private Button button_Import_File;
        private ComboBox comboBox_encryptionSelect;
        private Label label_encryptionType;
        private ComboBox comboBox1;
        private Label label1;
    }
}
