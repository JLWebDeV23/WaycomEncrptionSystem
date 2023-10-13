namespace WaycomEncrptionSystem
{
    partial class FormCompareDoc
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
            pictureBox_Original = new PictureBox();
            richTextBox_Original = new RichTextBox();
            panel2 = new Panel();
            button_Close_Window = new Button();
            groupBox_Decrypted = new GroupBox();
            pictureBox_Decrypted = new PictureBox();
            richTextBox_Decrypted = new RichTextBox();
            groupBox_Original = new GroupBox();
            textBox_PDF1 = new TextBox();
            textBox_PDF2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Original).BeginInit();
            panel2.SuspendLayout();
            groupBox_Decrypted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Decrypted).BeginInit();
            groupBox_Original.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_Original
            // 
            pictureBox_Original.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Original.Location = new Point(23, 59);
            pictureBox_Original.Name = "pictureBox_Original";
            pictureBox_Original.Size = new Size(452, 249);
            pictureBox_Original.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Original.TabIndex = 74;
            pictureBox_Original.TabStop = false;
            // 
            // richTextBox_Original
            // 
            richTextBox_Original.Location = new Point(23, 336);
            richTextBox_Original.Name = "richTextBox_Original";
            richTextBox_Original.Size = new Size(452, 249);
            richTextBox_Original.TabIndex = 75;
            richTextBox_Original.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_Close_Window);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1092, 45);
            panel2.TabIndex = 79;
            // 
            // button_Close_Window
            // 
            button_Close_Window.Dock = DockStyle.Right;
            button_Close_Window.FlatAppearance.BorderSize = 0;
            button_Close_Window.FlatAppearance.MouseOverBackColor = Color.Red;
            button_Close_Window.FlatStyle = FlatStyle.Flat;
            button_Close_Window.Image = Properties.Resources.icons8_close_16;
            button_Close_Window.Location = new Point(1034, 0);
            button_Close_Window.Name = "button_Close_Window";
            button_Close_Window.Size = new Size(58, 45);
            button_Close_Window.TabIndex = 11;
            button_Close_Window.UseVisualStyleBackColor = true;
            button_Close_Window.Click += button_Close_Window_Click;
            // 
            // groupBox_Decrypted
            // 
            groupBox_Decrypted.BackColor = Color.FromArgb(32, 33, 36);
            groupBox_Decrypted.BackgroundImageLayout = ImageLayout.None;
            groupBox_Decrypted.Controls.Add(textBox_PDF2);
            groupBox_Decrypted.Controls.Add(pictureBox_Decrypted);
            groupBox_Decrypted.Controls.Add(richTextBox_Decrypted);
            groupBox_Decrypted.FlatStyle = FlatStyle.Flat;
            groupBox_Decrypted.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Decrypted.ForeColor = Color.White;
            groupBox_Decrypted.Location = new Point(569, 78);
            groupBox_Decrypted.Name = "groupBox_Decrypted";
            groupBox_Decrypted.Size = new Size(497, 617);
            groupBox_Decrypted.TabIndex = 81;
            groupBox_Decrypted.TabStop = false;
            groupBox_Decrypted.Text = "Decrypted File";
            // 
            // pictureBox_Decrypted
            // 
            pictureBox_Decrypted.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Decrypted.Location = new Point(23, 59);
            pictureBox_Decrypted.Name = "pictureBox_Decrypted";
            pictureBox_Decrypted.Size = new Size(452, 249);
            pictureBox_Decrypted.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Decrypted.TabIndex = 74;
            pictureBox_Decrypted.TabStop = false;
            // 
            // richTextBox_Decrypted
            // 
            richTextBox_Decrypted.Location = new Point(23, 336);
            richTextBox_Decrypted.Name = "richTextBox_Decrypted";
            richTextBox_Decrypted.Size = new Size(452, 249);
            richTextBox_Decrypted.TabIndex = 75;
            richTextBox_Decrypted.Text = "";
            // 
            // groupBox_Original
            // 
            groupBox_Original.Controls.Add(textBox_PDF1);
            groupBox_Original.Controls.Add(pictureBox_Original);
            groupBox_Original.Controls.Add(richTextBox_Original);
            groupBox_Original.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Original.ForeColor = Color.White;
            groupBox_Original.Location = new Point(12, 78);
            groupBox_Original.Name = "groupBox_Original";
            groupBox_Original.Size = new Size(497, 617);
            groupBox_Original.TabIndex = 80;
            groupBox_Original.TabStop = false;
            groupBox_Original.Text = "Original File";
            // 
            // textBox_PDF1
            // 
            textBox_PDF1.BackColor = Color.FromArgb(32, 33, 36);
            textBox_PDF1.BorderStyle = BorderStyle.None;
            textBox_PDF1.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox_PDF1.ForeColor = SystemColors.ScrollBar;
            textBox_PDF1.Location = new Point(184, 175);
            textBox_PDF1.Name = "textBox_PDF1";
            textBox_PDF1.Size = new Size(100, 28);
            textBox_PDF1.TabIndex = 76;
            textBox_PDF1.Text = "PDF FILE";
            textBox_PDF1.Visible = false;
            // 
            // textBox_PDF2
            // 
            textBox_PDF2.BackColor = Color.FromArgb(32, 33, 36);
            textBox_PDF2.BorderStyle = BorderStyle.None;
            textBox_PDF2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox_PDF2.ForeColor = SystemColors.ScrollBar;
            textBox_PDF2.Location = new Point(202, 175);
            textBox_PDF2.Name = "textBox_PDF2";
            textBox_PDF2.Size = new Size(100, 28);
            textBox_PDF2.TabIndex = 76;
            textBox_PDF2.Text = "PDF FILE";
            textBox_PDF2.Visible = false;
            // 
            // FormCompareDoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1092, 735);
            Controls.Add(panel2);
            Controls.Add(groupBox_Decrypted);
            Controls.Add(groupBox_Original);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCompareDoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCompareDoc";
            Load += FormCompareDoc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Original).EndInit();
            panel2.ResumeLayout(false);
            groupBox_Decrypted.ResumeLayout(false);
            groupBox_Decrypted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Decrypted).EndInit();
            groupBox_Original.ResumeLayout(false);
            groupBox_Original.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_Original;
        private RichTextBox richTextBox_Original;
        private Panel panel2;
        private Button button_Close_Window;
        private GroupBox groupBox_Decrypted;
        private PictureBox pictureBox_Decrypted;
        private RichTextBox richTextBox_Decrypted;
        private GroupBox groupBox_Original;
        private TextBox textBox_PDF2;
        private TextBox textBox_PDF1;
    }
}