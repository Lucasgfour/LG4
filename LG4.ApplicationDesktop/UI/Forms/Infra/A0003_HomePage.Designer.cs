namespace LG4.ApplicationDesktop.UI.Forms.Infra {
    partial class A0003_HomePage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lab_top_userName = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lab_top_userName
            // 
            this.lab_top_userName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab_top_userName.Depth = 0;
            this.lab_top_userName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lab_top_userName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lab_top_userName.Location = new System.Drawing.Point(0, 25);
            this.lab_top_userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_top_userName.Name = "lab_top_userName";
            this.lab_top_userName.Padding = new System.Windows.Forms.Padding(3);
            this.lab_top_userName.Size = new System.Drawing.Size(315, 39);
            this.lab_top_userName.TabIndex = 0;
            this.lab_top_userName.Text = "materialLabel1";
            this.lab_top_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A0003_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 552);
            this.Controls.Add(this.lab_top_userName);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "A0003_HomePage";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LG4";
            this.Load += new System.EventHandler(this.Loading);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lab_top_userName;
    }
}