namespace LG4.ApplicationDesktop.UI.Forms.Infra {
    partial class A0001_Login {
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
            this.lG4TextBox1 = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lG4TextBox1
            // 
            this.lG4TextBox1.AnimateReadOnly = false;
            this.lG4TextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lG4TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lG4TextBox1.Depth = 0;
            this.lG4TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lG4TextBox1.HideSelection = true;
            this.lG4TextBox1.LeadingIcon = null;
            this.lG4TextBox1.Location = new System.Drawing.Point(226, 191);
            this.lG4TextBox1.MaskCustom = "111.111.111-11";
            this.lG4TextBox1.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.Integer;
            this.lG4TextBox1.MaxLength = 32767;
            this.lG4TextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.lG4TextBox1.Name = "lG4TextBox1";
            this.lG4TextBox1.PasswordChar = '\0';
            this.lG4TextBox1.PrefixSuffixText = null;
            this.lG4TextBox1.ReadOnly = false;
            this.lG4TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lG4TextBox1.SelectedText = "";
            this.lG4TextBox1.SelectionLength = 0;
            this.lG4TextBox1.SelectionStart = 0;
            this.lG4TextBox1.ShortcutsEnabled = true;
            this.lG4TextBox1.Size = new System.Drawing.Size(250, 36);
            this.lG4TextBox1.TabIndex = 0;
            this.lG4TextBox1.TabStop = false;
            this.lG4TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lG4TextBox1.TrailingIcon = null;
            this.lG4TextBox1.UseSystemPasswordChar = false;
            this.lG4TextBox1.UseTallSize = false;
            this.lG4TextBox1.TextChanged += new System.EventHandler(this.Teste);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // A0001_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lG4TextBox1);
            this.MaximizeBox = false;
            this.Name = "A0001_Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LG4 - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.LG4TextBox lG4TextBox1;
        private Label label1;
    }
}