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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A0001_Login));
            this.btn_connections_manager = new MaterialSkin.Controls.MaterialButton();
            this.cbx_connection = new MaterialSkin.Controls.MaterialComboBox();
            this.lab_usuario = new MaterialSkin.Controls.MaterialLabel();
            this.txt_user = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.lab_conexao = new MaterialSkin.Controls.MaterialLabel();
            this.lab_password = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.btn_entrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btn_connections_manager
            // 
            this.btn_connections_manager.AutoSize = false;
            this.btn_connections_manager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_connections_manager.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btn_connections_manager.Depth = 0;
            this.btn_connections_manager.DrawShadows = false;
            this.btn_connections_manager.HighEmphasis = true;
            this.btn_connections_manager.Icon = ((System.Drawing.Image)(resources.GetObject("btn_connections_manager.Icon")));
            this.btn_connections_manager.Location = new System.Drawing.Point(363, 97);
            this.btn_connections_manager.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_connections_manager.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_connections_manager.Name = "btn_connections_manager";
            this.btn_connections_manager.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_connections_manager.Size = new System.Drawing.Size(38, 35);
            this.btn_connections_manager.TabIndex = 2;
            this.btn_connections_manager.TabStop = false;
            this.btn_connections_manager.Text = " ";
            this.btn_connections_manager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connections_manager.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btn_connections_manager.UseAccentColor = false;
            this.btn_connections_manager.UseVisualStyleBackColor = true;
            this.btn_connections_manager.Click += new System.EventHandler(this.Click_Connection_Manager);
            // 
            // cbx_connection
            // 
            this.cbx_connection.AutoResize = false;
            this.cbx_connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_connection.Depth = 0;
            this.cbx_connection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_connection.DropDownHeight = 118;
            this.cbx_connection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_connection.DropDownWidth = 121;
            this.cbx_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbx_connection.FormattingEnabled = true;
            this.cbx_connection.IntegralHeight = false;
            this.cbx_connection.ItemHeight = 29;
            this.cbx_connection.Location = new System.Drawing.Point(158, 97);
            this.cbx_connection.MaxDropDownItems = 4;
            this.cbx_connection.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_connection.Name = "cbx_connection";
            this.cbx_connection.Size = new System.Drawing.Size(199, 35);
            this.cbx_connection.StartIndex = 0;
            this.cbx_connection.TabIndex = 3;
            this.cbx_connection.TabStop = false;
            this.cbx_connection.UseTallSize = false;
            // 
            // lab_usuario
            // 
            this.lab_usuario.Depth = 0;
            this.lab_usuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_usuario.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_usuario.Location = new System.Drawing.Point(158, 135);
            this.lab_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_usuario.Name = "lab_usuario";
            this.lab_usuario.Size = new System.Drawing.Size(243, 19);
            this.lab_usuario.TabIndex = 5;
            this.lab_usuario.Text = "Usuário";
            this.lab_usuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_user
            // 
            this.txt_user.AnimateReadOnly = false;
            this.txt_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_user.Depth = 0;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_user.HideSelection = true;
            this.txt_user.LeadingIcon = null;
            this.txt_user.Location = new System.Drawing.Point(158, 157);
            this.txt_user.MaskCustom = "AA.11";
            this.txt_user.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.None;
            this.txt_user.MaxLength = 20;
            this.txt_user.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.PrefixSuffixText = null;
            this.txt_user.ReadOnly = false;
            this.txt_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_user.SelectedText = "";
            this.txt_user.SelectionLength = 0;
            this.txt_user.SelectionStart = 0;
            this.txt_user.ShortcutsEnabled = true;
            this.txt_user.Size = new System.Drawing.Size(243, 36);
            this.txt_user.TabIndex = 4;
            this.txt_user.TabStop = false;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user.TrailingIcon = null;
            this.txt_user.UseSystemPasswordChar = false;
            this.txt_user.UseTallSize = false;
            // 
            // lab_conexao
            // 
            this.lab_conexao.Depth = 0;
            this.lab_conexao.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_conexao.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_conexao.Location = new System.Drawing.Point(158, 75);
            this.lab_conexao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_conexao.Name = "lab_conexao";
            this.lab_conexao.Size = new System.Drawing.Size(243, 19);
            this.lab_conexao.TabIndex = 6;
            this.lab_conexao.Text = "Conexão";
            this.lab_conexao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_password
            // 
            this.lab_password.Depth = 0;
            this.lab_password.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_password.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_password.Location = new System.Drawing.Point(158, 196);
            this.lab_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(243, 19);
            this.lab_password.TabIndex = 8;
            this.lab_password.Text = "Senha";
            this.lab_password.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.HideSelection = true;
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(158, 218);
            this.txt_password.MaskCustom = "AA.11";
            this.txt_password.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.None;
            this.txt_password.MaxLength = 20;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.PrefixSuffixText = null;
            this.txt_password.ReadOnly = false;
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(243, 36);
            this.txt_password.TabIndex = 7;
            this.txt_password.TabStop = false;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TrailingIcon = null;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.UseTallSize = false;
            // 
            // btn_entrar
            // 
            this.btn_entrar.AutoSize = false;
            this.btn_entrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_entrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_entrar.Depth = 0;
            this.btn_entrar.HighEmphasis = true;
            this.btn_entrar.Icon = null;
            this.btn_entrar.Location = new System.Drawing.Point(158, 272);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_entrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_entrar.Size = new System.Drawing.Size(243, 36);
            this.btn_entrar.TabIndex = 9;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_entrar.UseAccentColor = false;
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.ClickConnect);
            // 
            // A0001_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 328);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lab_conexao);
            this.Controls.Add(this.lab_usuario);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.cbx_connection);
            this.Controls.Add(this.btn_connections_manager);
            this.MaximizeBox = false;
            this.Name = "A0001_Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LG4 - Login";
            this.Load += new System.EventHandler(this.Loading);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_connections_manager;
        private MaterialSkin.Controls.MaterialComboBox cbx_connection;
        private MaterialSkin.Controls.MaterialLabel lab_usuario;
        private Controls.LG4TextBox txt_user;
        private MaterialSkin.Controls.MaterialLabel lab_conexao;
        private MaterialSkin.Controls.MaterialLabel lab_password;
        private Controls.LG4TextBox txt_password;
        private MaterialSkin.Controls.MaterialButton btn_entrar;
    }
}