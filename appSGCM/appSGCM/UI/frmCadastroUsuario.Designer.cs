namespace appSGCM.UI
{
    partial class frmCadastroUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnAddFuncionario = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSenhaConfirmacao = new System.Windows.Forms.Label();
            this.txtSenhaConfirmacao = new System.Windows.Forms.TextBox();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.lbSenhaNova = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lbSenhaAtual = new System.Windows.Forms.Label();
            this.cbxCodFuncionario = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.gpbLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnCadastrar);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(327, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCadastrar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(50, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 30);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.Color.DarkRed;
            this.gpbLogin.Controls.Add(this.btnAddFuncionario);
            this.gpbLogin.Controls.Add(this.label1);
            this.gpbLogin.Controls.Add(this.cbxCodFuncionario);
            this.gpbLogin.Controls.Add(this.cbxTipo);
            this.gpbLogin.Controls.Add(this.lbTipoUsuario);
            this.gpbLogin.Controls.Add(this.lbUsuario);
            this.gpbLogin.Controls.Add(this.txtUsuario);
            this.gpbLogin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbLogin.Location = new System.Drawing.Point(12, 12);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(473, 85);
            this.gpbLogin.TabIndex = 9;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "[ Usuário ]";
            // 
            // btnAddFuncionario
            // 
            this.btnAddFuncionario.ImageIndex = 0;
            this.btnAddFuncionario.ImageList = this.imageList1;
            this.btnAddFuncionario.Location = new System.Drawing.Point(436, 46);
            this.btnAddFuncionario.Name = "btnAddFuncionario";
            this.btnAddFuncionario.Size = new System.Drawing.Size(26, 26);
            this.btnAddFuncionario.TabIndex = 29;
            this.btnAddFuncionario.UseVisualStyleBackColor = true;
            this.btnAddFuncionario.Click += new System.EventHandler(this.btnAddFuncionario_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1363751920_48761.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cod.Funcº";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Administrador",
            "SubAdministrador",
            "Básico"});
            this.cbxTipo.Location = new System.Drawing.Point(204, 47);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(147, 26);
            this.cbxTipo.TabIndex = 3;
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Location = new System.Drawing.Point(201, 26);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(40, 18);
            this.lbTipoUsuario.TabIndex = 2;
            this.lbTipoUsuario.Text = "Tipo";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(6, 27);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 18);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(9, 48);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 25);
            this.txtUsuario.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.lbSenhaConfirmacao);
            this.groupBox1.Controls.Add(this.txtSenhaConfirmacao);
            this.groupBox1.Controls.Add(this.txtSenhaNova);
            this.groupBox1.Controls.Add(this.lbSenhaNova);
            this.groupBox1.Controls.Add(this.txtSenhaAtual);
            this.groupBox1.Controls.Add(this.lbSenhaAtual);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Senha ]";
            // 
            // lbSenhaConfirmacao
            // 
            this.lbSenhaConfirmacao.AutoSize = true;
            this.lbSenhaConfirmacao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaConfirmacao.Location = new System.Drawing.Point(313, 30);
            this.lbSenhaConfirmacao.Name = "lbSenhaConfirmacao";
            this.lbSenhaConfirmacao.Size = new System.Drawing.Size(96, 18);
            this.lbSenhaConfirmacao.TabIndex = 11;
            this.lbSenhaConfirmacao.Text = "Confirmação";
            // 
            // txtSenhaConfirmacao
            // 
            this.txtSenhaConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaConfirmacao.Location = new System.Drawing.Point(316, 51);
            this.txtSenhaConfirmacao.MaxLength = 16;
            this.txtSenhaConfirmacao.Name = "txtSenhaConfirmacao";
            this.txtSenhaConfirmacao.PasswordChar = '●';
            this.txtSenhaConfirmacao.Size = new System.Drawing.Size(149, 22);
            this.txtSenhaConfirmacao.TabIndex = 10;
            this.txtSenhaConfirmacao.Tag = "";
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaNova.Location = new System.Drawing.Point(161, 51);
            this.txtSenhaNova.MaxLength = 16;
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '●';
            this.txtSenhaNova.Size = new System.Drawing.Size(149, 22);
            this.txtSenhaNova.TabIndex = 9;
            this.txtSenhaNova.Tag = "";
            // 
            // lbSenhaNova
            // 
            this.lbSenhaNova.AutoSize = true;
            this.lbSenhaNova.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaNova.Location = new System.Drawing.Point(158, 30);
            this.lbSenhaNova.Name = "lbSenhaNova";
            this.lbSenhaNova.Size = new System.Drawing.Size(40, 18);
            this.lbSenhaNova.TabIndex = 8;
            this.lbSenhaNova.Text = "Nova";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Enabled = false;
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(6, 51);
            this.txtSenhaAtual.MaxLength = 16;
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '●';
            this.txtSenhaAtual.Size = new System.Drawing.Size(149, 22);
            this.txtSenhaAtual.TabIndex = 7;
            this.txtSenhaAtual.Tag = "";
            // 
            // lbSenhaAtual
            // 
            this.lbSenhaAtual.AutoSize = true;
            this.lbSenhaAtual.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaAtual.Location = new System.Drawing.Point(6, 30);
            this.lbSenhaAtual.Name = "lbSenhaAtual";
            this.lbSenhaAtual.Size = new System.Drawing.Size(48, 18);
            this.lbSenhaAtual.TabIndex = 3;
            this.lbSenhaAtual.Text = "Atual";
            // 
            // cbxCodFuncionario
            // 
            this.cbxCodFuncionario.DisplayMember = "saasas";
            this.cbxCodFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodFuncionario.FormattingEnabled = true;
            this.cbxCodFuncionario.Location = new System.Drawing.Point(357, 47);
            this.cbxCodFuncionario.Name = "cbxCodFuncionario";
            this.cbxCodFuncionario.Size = new System.Drawing.Size(77, 26);
            this.cbxCodFuncionario.TabIndex = 4;
            // 
            // frmCadastroUsuario
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(494, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Cadastro de Usuário";
            this.groupBox2.ResumeLayout(false);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label lbSenhaAtual;
        private System.Windows.Forms.Label lbSenhaConfirmacao;
        private System.Windows.Forms.TextBox txtSenhaConfirmacao;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label lbSenhaNova;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lbTipoUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFuncionario;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbxCodFuncionario;
    }
}