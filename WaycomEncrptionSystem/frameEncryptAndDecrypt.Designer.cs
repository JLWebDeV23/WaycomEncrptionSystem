namespace WaycomEncrptionSystem
{
    partial class frameEncryptAndDecrypt
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
            panel1 = new Panel();
            button_Export = new Button();
            button_Import = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(32, 23, 31);
            panel1.Controls.Add(button_Export);
            panel1.Controls.Add(button_Import);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 663);
            panel1.TabIndex = 0;
            // 
            // button_Export
            // 
            button_Export.Anchor = AnchorStyles.None;
            button_Export.BackColor = Color.FromArgb(206, 210, 214);
            button_Export.FlatAppearance.BorderSize = 0;
            button_Export.FlatStyle = FlatStyle.Popup;
            button_Export.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Export.Image = Properties.Resources.export_32;
            button_Export.Location = new Point(417, 387);
            button_Export.Name = "button_Export";
            button_Export.Size = new Size(130, 40);
            button_Export.TabIndex = 5;
            button_Export.Text = "Export";
            button_Export.TextAlign = ContentAlignment.MiddleRight;
            button_Export.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Export.UseVisualStyleBackColor = false;
            button_Export.Click += button_Export_Click;
            // 
            // button_Import
            // 
            button_Import.Anchor = AnchorStyles.None;
            button_Import.BackColor = Color.FromArgb(206, 210, 214);
            button_Import.FlatAppearance.BorderSize = 0;
            button_Import.FlatStyle = FlatStyle.Popup;
            button_Import.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Import.Image = Properties.Resources.import_32;
            button_Import.Location = new Point(417, 268);
            button_Import.Name = "button_Import";
            button_Import.Size = new Size(130, 40);
            button_Import.TabIndex = 3;
            button_Import.Text = "Import";
            button_Import.TextAlign = ContentAlignment.MiddleRight;
            button_Import.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Import.UseVisualStyleBackColor = false;
            button_Import.Click += button_Import_Click;
            // 
            // frameEncryptAndDecrypt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(panel1);
            Name = "frameEncryptAndDecrypt";
            Size = new Size(964, 663);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button_Export;
        private Button button_Import;
    }
}
