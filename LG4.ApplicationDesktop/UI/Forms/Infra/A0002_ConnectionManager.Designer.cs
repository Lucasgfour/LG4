namespace LG4.ApplicationDesktop.UI.Forms.Infra {
    partial class A0002_ConnectionManager {
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
            this.list_conexoes = new System.Windows.Forms.ListView();
            this.colNome = new System.Windows.Forms.ColumnHeader();
            this.colHost = new System.Windows.Forms.ColumnHeader();
            this.pn_fields = new System.Windows.Forms.Panel();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.lab_senha = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.lab_banco = new MaterialSkin.Controls.MaterialLabel();
            this.txt_database = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.lab_usuario = new MaterialSkin.Controls.MaterialLabel();
            this.txt_user = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.lab_porta = new MaterialSkin.Controls.MaterialLabel();
            this.txt_port = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.lab_host = new MaterialSkin.Controls.MaterialLabel();
            this.txt_host = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.lab_nome = new MaterialSkin.Controls.MaterialLabel();
            this.txt_name = new LG4.ApplicationDesktop.UI.Controls.LG4TextBox();
            this.pn_top_buttons = new System.Windows.Forms.Panel();
            this.btn_remover = new MaterialSkin.Controls.MaterialButton();
            this.btn_novo = new MaterialSkin.Controls.MaterialButton();
            this.pn_fields.SuspendLayout();
            this.pn_top_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_conexoes
            // 
            this.list_conexoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_conexoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colHost});
            this.list_conexoes.FullRowSelect = true;
            this.list_conexoes.GridLines = true;
            this.list_conexoes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_conexoes.Location = new System.Drawing.Point(6, 71);
            this.list_conexoes.MultiSelect = false;
            this.list_conexoes.Name = "list_conexoes";
            this.list_conexoes.Size = new System.Drawing.Size(290, 319);
            this.list_conexoes.TabIndex = 0;
            this.list_conexoes.UseCompatibleStateImageBehavior = false;
            this.list_conexoes.View = System.Windows.Forms.View.Details;
            this.list_conexoes.SelectedIndexChanged += new System.EventHandler(this.ClickSelecionarLista);
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 150;
            // 
            // colHost
            // 
            this.colHost.Text = "Host";
            this.colHost.Width = 109;
            // 
            // pn_fields
            // 
            this.pn_fields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_fields.Controls.Add(this.btn_save);
            this.pn_fields.Controls.Add(this.lab_senha);
            this.pn_fields.Controls.Add(this.txt_password);
            this.pn_fields.Controls.Add(this.lab_banco);
            this.pn_fields.Controls.Add(this.txt_database);
            this.pn_fields.Controls.Add(this.lab_usuario);
            this.pn_fields.Controls.Add(this.txt_user);
            this.pn_fields.Controls.Add(this.lab_porta);
            this.pn_fields.Controls.Add(this.txt_port);
            this.pn_fields.Controls.Add(this.lab_host);
            this.pn_fields.Controls.Add(this.txt_host);
            this.pn_fields.Controls.Add(this.lab_nome);
            this.pn_fields.Controls.Add(this.txt_name);
            this.pn_fields.Location = new System.Drawing.Point(302, 133);
            this.pn_fields.Name = "pn_fields";
            this.pn_fields.Size = new System.Drawing.Size(454, 257);
            this.pn_fields.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = false;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(327, 212);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(121, 36);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "SALVAR";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.ClickSave);
            // 
            // lab_senha
            // 
            this.lab_senha.Depth = 0;
            this.lab_senha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_senha.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_senha.Location = new System.Drawing.Point(168, 129);
            this.lab_senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_senha.Name = "lab_senha";
            this.lab_senha.Size = new System.Drawing.Size(151, 19);
            this.lab_senha.TabIndex = 11;
            this.lab_senha.Text = "Senha";
            this.lab_senha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.HideSelection = true;
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(168, 151);
            this.txt_password.MaskCustom = "AA.11";
            this.txt_password.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.None;
            this.txt_password.MaxLength = 25;
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
            this.txt_password.Size = new System.Drawing.Size(152, 36);
            this.txt_password.TabIndex = 9;
            this.txt_password.TabStop = false;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TrailingIcon = null;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.UseTallSize = false;
            // 
            // lab_banco
            // 
            this.lab_banco.Depth = 0;
            this.lab_banco.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_banco.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_banco.Location = new System.Drawing.Point(10, 190);
            this.lab_banco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_banco.Name = "lab_banco";
            this.lab_banco.Size = new System.Drawing.Size(310, 19);
            this.lab_banco.TabIndex = 9;
            this.lab_banco.Text = "Banco";
            this.lab_banco.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_database
            // 
            this.txt_database.AnimateReadOnly = false;
            this.txt_database.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_database.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_database.Depth = 0;
            this.txt_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_database.HideSelection = true;
            this.txt_database.LeadingIcon = null;
            this.txt_database.Location = new System.Drawing.Point(10, 212);
            this.txt_database.MaskCustom = "AA.11";
            this.txt_database.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.None;
            this.txt_database.MaxLength = 25;
            this.txt_database.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_database.Name = "txt_database";
            this.txt_database.PasswordChar = '\0';
            this.txt_database.PrefixSuffixText = null;
            this.txt_database.ReadOnly = false;
            this.txt_database.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_database.SelectedText = "";
            this.txt_database.SelectionLength = 0;
            this.txt_database.SelectionStart = 0;
            this.txt_database.ShortcutsEnabled = true;
            this.txt_database.Size = new System.Drawing.Size(310, 36);
            this.txt_database.TabIndex = 10;
            this.txt_database.TabStop = false;
            this.txt_database.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_database.TrailingIcon = null;
            this.txt_database.UseSystemPasswordChar = false;
            this.txt_database.UseTallSize = false;
            // 
            // lab_usuario
            // 
            this.lab_usuario.Depth = 0;
            this.lab_usuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_usuario.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_usuario.Location = new System.Drawing.Point(10, 129);
            this.lab_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_usuario.Name = "lab_usuario";
            this.lab_usuario.Size = new System.Drawing.Size(151, 19);
            this.lab_usuario.TabIndex = 7;
            this.lab_usuario.Text = "Usuário";
            this.lab_usuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_user
            // 
            this.txt_user.AnimateReadOnly = false;
            this.txt_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_user.Depth = 0;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_user.HideSelection = true;
            this.txt_user.LeadingIcon = null;
            this.txt_user.Location = new System.Drawing.Point(10, 151);
            this.txt_user.MaskCustom = "AA.11";
            this.txt_user.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.None;
            this.txt_user.MaxLength = 25;
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
            this.txt_user.Size = new System.Drawing.Size(152, 36);
            this.txt_user.TabIndex = 6;
            this.txt_user.TabStop = false;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user.TrailingIcon = null;
            this.txt_user.UseSystemPasswordChar = false;
            this.txt_user.UseTallSize = false;
            // 
            // lab_porta
            // 
            this.lab_porta.Depth = 0;
            this.lab_porta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_porta.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_porta.Location = new System.Drawing.Point(223, 68);
            this.lab_porta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_porta.Name = "lab_porta";
            this.lab_porta.Size = new System.Drawing.Size(97, 19);
            this.lab_porta.TabIndex = 5;
            this.lab_porta.Text = "Porta";
            this.lab_porta.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_port
            // 
            this.txt_port.AnimateReadOnly = false;
            this.txt_port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_port.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_port.Depth = 0;
            this.txt_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_port.HideSelection = true;
            this.txt_port.LeadingIcon = null;
            this.txt_port.Location = new System.Drawing.Point(223, 90);
            this.txt_port.MaskCustom = "";
            this.txt_port.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.Integer;
            this.txt_port.MaxLength = 5;
            this.txt_port.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_port.Name = "txt_port";
            this.txt_port.PasswordChar = '\0';
            this.txt_port.PrefixSuffixText = null;
            this.txt_port.ReadOnly = false;
            this.txt_port.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_port.SelectedText = "";
            this.txt_port.SelectionLength = 0;
            this.txt_port.SelectionStart = 0;
            this.txt_port.ShortcutsEnabled = true;
            this.txt_port.Size = new System.Drawing.Size(97, 36);
            this.txt_port.TabIndex = 4;
            this.txt_port.TabStop = false;
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_port.TrailingIcon = null;
            this.txt_port.UseSystemPasswordChar = false;
            this.txt_port.UseTallSize = false;
            // 
            // lab_host
            // 
            this.lab_host.Depth = 0;
            this.lab_host.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_host.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_host.Location = new System.Drawing.Point(10, 68);
            this.lab_host.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_host.Name = "lab_host";
            this.lab_host.Size = new System.Drawing.Size(207, 19);
            this.lab_host.TabIndex = 3;
            this.lab_host.Text = "Host";
            this.lab_host.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_host
            // 
            this.txt_host.AnimateReadOnly = false;
            this.txt_host.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_host.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_host.Depth = 0;
            this.txt_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_host.HideSelection = true;
            this.txt_host.LeadingIcon = null;
            this.txt_host.Location = new System.Drawing.Point(10, 90);
            this.txt_host.MaskCustom = "AA.11";
            this.txt_host.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.None;
            this.txt_host.MaxLength = 32767;
            this.txt_host.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_host.Name = "txt_host";
            this.txt_host.PasswordChar = '\0';
            this.txt_host.PrefixSuffixText = null;
            this.txt_host.ReadOnly = false;
            this.txt_host.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_host.SelectedText = "";
            this.txt_host.SelectionLength = 0;
            this.txt_host.SelectionStart = 0;
            this.txt_host.ShortcutsEnabled = true;
            this.txt_host.Size = new System.Drawing.Size(207, 36);
            this.txt_host.TabIndex = 2;
            this.txt_host.TabStop = false;
            this.txt_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_host.TrailingIcon = null;
            this.txt_host.UseSystemPasswordChar = false;
            this.txt_host.UseTallSize = false;
            // 
            // lab_nome
            // 
            this.lab_nome.Depth = 0;
            this.lab_nome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_nome.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lab_nome.Location = new System.Drawing.Point(10, 7);
            this.lab_nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_nome.Name = "lab_nome";
            this.lab_nome.Size = new System.Drawing.Size(310, 19);
            this.lab_nome.TabIndex = 1;
            this.lab_nome.Text = "Nome/Apelido";
            this.lab_nome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_name
            // 
            this.txt_name.AnimateReadOnly = false;
            this.txt_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_name.Depth = 0;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_name.HideSelection = true;
            this.txt_name.LeadingIcon = null;
            this.txt_name.Location = new System.Drawing.Point(10, 29);
            this.txt_name.MaskCustom = "AA.11";
            this.txt_name.MaskType = LG4.ApplicationDesktop.UI.Controls.LG4Mask.None;
            this.txt_name.MaxLength = 20;
            this.txt_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PrefixSuffixText = null;
            this.txt_name.ReadOnly = false;
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(310, 36);
            this.txt_name.TabIndex = 0;
            this.txt_name.TabStop = false;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.TrailingIcon = null;
            this.txt_name.UseSystemPasswordChar = false;
            this.txt_name.UseTallSize = false;
            // 
            // pn_top_buttons
            // 
            this.pn_top_buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_top_buttons.Controls.Add(this.btn_remover);
            this.pn_top_buttons.Controls.Add(this.btn_novo);
            this.pn_top_buttons.Location = new System.Drawing.Point(302, 71);
            this.pn_top_buttons.Name = "pn_top_buttons";
            this.pn_top_buttons.Size = new System.Drawing.Size(454, 56);
            this.pn_top_buttons.TabIndex = 2;
            // 
            // btn_remover
            // 
            this.btn_remover.AutoSize = false;
            this.btn_remover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_remover.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_remover.Depth = 0;
            this.btn_remover.HighEmphasis = true;
            this.btn_remover.Icon = null;
            this.btn_remover.Location = new System.Drawing.Point(135, 6);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_remover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_remover.Size = new System.Drawing.Size(121, 42);
            this.btn_remover.TabIndex = 14;
            this.btn_remover.Text = "remover selecionado";
            this.btn_remover.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_remover.UseAccentColor = false;
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.ClickRemoveSelected);
            // 
            // btn_novo
            // 
            this.btn_novo.AutoSize = false;
            this.btn_novo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_novo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_novo.Depth = 0;
            this.btn_novo.HighEmphasis = true;
            this.btn_novo.Icon = null;
            this.btn_novo.Location = new System.Drawing.Point(6, 6);
            this.btn_novo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_novo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_novo.Size = new System.Drawing.Size(121, 42);
            this.btn_novo.TabIndex = 13;
            this.btn_novo.Text = "adicionar";
            this.btn_novo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_novo.UseAccentColor = false;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.Click_NewConnection);
            // 
            // A0002_ConnectionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 396);
            this.Controls.Add(this.pn_top_buttons);
            this.Controls.Add(this.pn_fields);
            this.Controls.Add(this.list_conexoes);
            this.MaximizeBox = false;
            this.Name = "A0002_ConnectionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Conexões";
            this.Load += new System.EventHandler(this.Loading);
            this.pn_fields.ResumeLayout(false);
            this.pn_top_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView list_conexoes;
        private Panel pn_fields;
        private ColumnHeader colNome;
        private ColumnHeader colHost;
        private Panel pn_top_buttons;
        private Controls.LG4TextBox txt_name;
        private MaterialSkin.Controls.MaterialLabel lab_nome;
        private MaterialSkin.Controls.MaterialLabel lab_senha;
        private Controls.LG4TextBox txt_password;
        private MaterialSkin.Controls.MaterialLabel lab_banco;
        private Controls.LG4TextBox txt_database;
        private MaterialSkin.Controls.MaterialLabel lab_usuario;
        private Controls.LG4TextBox txt_user;
        private MaterialSkin.Controls.MaterialLabel lab_porta;
        private Controls.LG4TextBox txt_port;
        private MaterialSkin.Controls.MaterialLabel lab_host;
        private Controls.LG4TextBox txt_host;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_remover;
        private MaterialSkin.Controls.MaterialButton btn_novo;
    }
}