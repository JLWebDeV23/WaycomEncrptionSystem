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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Export = new System.Windows.Forms.Button();
            this.button_View_Search = new System.Windows.Forms.Button();
            this.button_Import = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_Export);
            this.panel1.Controls.Add(this.button_View_Search);
            this.panel1.Controls.Add(this.button_Import);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 663);
            this.panel1.TabIndex = 0;
            // 
            // button_Export
            // 
            this.button_Export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Export.FlatAppearance.BorderSize = 0;
            this.button_Export.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Export.Image = global::WaycomEncrptionSystem.Properties.Resources.export_32;
            this.button_Export.Location = new System.Drawing.Point(417, 406);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(130, 40);
            this.button_Export.TabIndex = 5;
            this.button_Export.Text = "Export";
            this.button_Export.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Export.UseVisualStyleBackColor = true;
            // 
            // button_View_Search
            // 
            this.button_View_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_View_Search.FlatAppearance.BorderSize = 0;
            this.button_View_Search.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_View_Search.Image = global::WaycomEncrptionSystem.Properties.Resources.view_32;
            this.button_View_Search.Location = new System.Drawing.Point(417, 217);
            this.button_View_Search.Name = "button_View_Search";
            this.button_View_Search.Size = new System.Drawing.Size(130, 40);
            this.button_View_Search.TabIndex = 4;
            this.button_View_Search.Text = "View";
            this.button_View_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_View_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_View_Search.UseVisualStyleBackColor = true;
            // 
            // button_Import
            // 
            this.button_Import.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Import.FlatAppearance.BorderSize = 0;
            this.button_Import.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Import.Image = global::WaycomEncrptionSystem.Properties.Resources.import_32;
            this.button_Import.Location = new System.Drawing.Point(417, 312);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(130, 40);
            this.button_Import.TabIndex = 3;
            this.button_Import.Text = "Import";
            this.button_Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // frameEncryptAndDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.panel1);
            this.Name = "frameEncryptAndDecrypt";
            this.Size = new System.Drawing.Size(964, 663);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button button_Export;
        private Button button_View_Search;
        private Button button_Import;
    }
}
