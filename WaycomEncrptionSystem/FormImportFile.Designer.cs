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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Import_File = new System.Windows.Forms.Button();
            this.button_Upload = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.pictureBox_Img = new System.Windows.Forms.PictureBox();
            this.textBox_fileType = new System.Windows.Forms.TextBox();
            this.label_File_Type = new System.Windows.Forms.Label();
            this.textBox_fileSize = new System.Windows.Forms.TextBox();
            this.label_fileSize = new System.Windows.Forms.Label();
            this.textBox_fileTitle = new System.Windows.Forms.TextBox();
            this.label_fileTitle = new System.Windows.Forms.Label();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.label_fileName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Import_File);
            this.panel1.Controls.Add(this.button_Upload);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 73);
            this.panel1.TabIndex = 1;
            // 
            // button_Import_File
            // 
            this.button_Import_File.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Import_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(169)))), ((int)(((byte)(252)))));
            this.button_Import_File.FlatAppearance.BorderSize = 0;
            this.button_Import_File.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Import_File.ForeColor = System.Drawing.Color.Transparent;
            this.button_Import_File.Location = new System.Drawing.Point(37, 21);
            this.button_Import_File.Name = "button_Import_File";
            this.button_Import_File.Size = new System.Drawing.Size(94, 37);
            this.button_Import_File.TabIndex = 56;
            this.button_Import_File.Text = "Import";
            this.button_Import_File.UseVisualStyleBackColor = false;
            this.button_Import_File.Click += new System.EventHandler(this.button_Import_File_Click);
            // 
            // button_Upload
            // 
            this.button_Upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(212)))), ((int)(((byte)(179)))));
            this.button_Upload.FlatAppearance.BorderSize = 0;
            this.button_Upload.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Upload.Location = new System.Drawing.Point(732, 21);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(94, 37);
            this.button_Upload.TabIndex = 54;
            this.button_Upload.Text = "Upload";
            this.button_Upload.UseVisualStyleBackColor = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Location = new System.Drawing.Point(842, 21);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 37);
            this.button_Cancel.TabIndex = 55;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // pictureBox_Img
            // 
            this.pictureBox_Img.Location = new System.Drawing.Point(442, 40);
            this.pictureBox_Img.Name = "pictureBox_Img";
            this.pictureBox_Img.Size = new System.Drawing.Size(429, 560);
            this.pictureBox_Img.TabIndex = 53;
            this.pictureBox_Img.TabStop = false;
            // 
            // textBox_fileType
            // 
            this.textBox_fileType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_fileType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fileType.Location = new System.Drawing.Point(82, 338);
            this.textBox_fileType.Name = "textBox_fileType";
            this.textBox_fileType.ReadOnly = true;
            this.textBox_fileType.Size = new System.Drawing.Size(176, 16);
            this.textBox_fileType.TabIndex = 52;
            // 
            // label_File_Type
            // 
            this.label_File_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_File_Type.AutoSize = true;
            this.label_File_Type.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_File_Type.Location = new System.Drawing.Point(82, 314);
            this.label_File_Type.Name = "label_File_Type";
            this.label_File_Type.Size = new System.Drawing.Size(75, 21);
            this.label_File_Type.TabIndex = 51;
            this.label_File_Type.Text = "File type";
            // 
            // textBox_fileSize
            // 
            this.textBox_fileSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_fileSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fileSize.Location = new System.Drawing.Point(82, 255);
            this.textBox_fileSize.Name = "textBox_fileSize";
            this.textBox_fileSize.ReadOnly = true;
            this.textBox_fileSize.Size = new System.Drawing.Size(176, 16);
            this.textBox_fileSize.TabIndex = 50;
            // 
            // label_fileSize
            // 
            this.label_fileSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_fileSize.AutoSize = true;
            this.label_fileSize.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_fileSize.Location = new System.Drawing.Point(82, 231);
            this.label_fileSize.Name = "label_fileSize";
            this.label_fileSize.Size = new System.Drawing.Size(122, 21);
            this.label_fileSize.TabIndex = 49;
            this.label_fileSize.Text = "File Size (byte)";
            // 
            // textBox_fileTitle
            // 
            this.textBox_fileTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_fileTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fileTitle.Location = new System.Drawing.Point(82, 100);
            this.textBox_fileTitle.Name = "textBox_fileTitle";
            this.textBox_fileTitle.Size = new System.Drawing.Size(176, 16);
            this.textBox_fileTitle.TabIndex = 48;
            // 
            // label_fileTitle
            // 
            this.label_fileTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_fileTitle.AutoSize = true;
            this.label_fileTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_fileTitle.Location = new System.Drawing.Point(82, 76);
            this.label_fileTitle.Name = "label_fileTitle";
            this.label_fileTitle.Size = new System.Drawing.Size(75, 21);
            this.label_fileTitle.TabIndex = 47;
            this.label_fileTitle.Text = "File Title";
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_fileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fileName.Location = new System.Drawing.Point(82, 171);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.ReadOnly = true;
            this.textBox_fileName.Size = new System.Drawing.Size(176, 16);
            this.textBox_fileName.TabIndex = 46;
            // 
            // label_fileName
            // 
            this.label_fileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_fileName.AutoSize = true;
            this.label_fileName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_fileName.Location = new System.Drawing.Point(82, 147);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(87, 21);
            this.label_fileName.TabIndex = 45;
            this.label_fileName.Text = "File Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "File Source";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Passport",
            "Driver Liscence",
            "Certificate",
            "File Document",
            "Pictures",
            "Credit Card",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(83, 414);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 23);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.Text = "Please select a source";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormImportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(982, 723);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Img);
            this.Controls.Add(this.textBox_fileType);
            this.Controls.Add(this.label_File_Type);
            this.Controls.Add(this.textBox_fileSize);
            this.Controls.Add(this.label_fileSize);
            this.Controls.Add(this.textBox_fileTitle);
            this.Controls.Add(this.label_fileTitle);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.label_fileName);
            this.Controls.Add(this.panel1);
            this.Name = "FormImportFile";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
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
    }
}