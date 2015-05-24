namespace appSGCM.UI
{
    partial class frmLogin
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbDescricaoBotao = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbAcesso = new System.Windows.Forms.Label();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.lbMsgErro = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbDescricaoBotao);
            this.groupBox3.Location = new System.Drawing.Point(0, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 29);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // lbDescricaoBotao
            // 
            this.lbDescricaoBotao.AutoSize = true;
            this.lbDescricaoBotao.BackColor = System.Drawing.Color.Transparent;
            this.lbDescricaoBotao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDescricaoBotao.Location = new System.Drawing.Point(12, 10);
            this.lbDescricaoBotao.Name = "lbDescricaoBotao";
            this.lbDescricaoBotao.Size = new System.Drawing.Size(0, 13);
            this.lbDescricaoBotao.TabIndex = 0;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrar.Location = new System.Drawing.Point(220, 122);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(87, 30);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            this.btnEntrar.MouseHover += new System.EventHandler(this.btnEntrar_MouseHover);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Crimson;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(285, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            this.btnFechar.MouseHover += new System.EventHandler(this.btnFechar_MouseHover);
            // 
            // lbAcesso
            // 
            this.lbAcesso.AutoSize = true;
            this.lbAcesso.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcesso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAcesso.Location = new System.Drawing.Point(60, 9);
            this.lbAcesso.Name = "lbAcesso";
            this.lbAcesso.Size = new System.Drawing.Size(180, 22);
            this.lbAcesso.TabIndex = 7;
            this.lbAcesso.Text = "Acesso ao Sistema";
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.Color.Black;
            this.gpbLogin.Controls.Add(this.btnEntrar);
            this.gpbLogin.Controls.Add(this.lbMsgErro);
            this.gpbLogin.Controls.Add(this.txtSenha);
            this.gpbLogin.Controls.Add(this.lbSenha);
            this.gpbLogin.Controls.Add(this.lbUsuario);
            this.gpbLogin.Controls.Add(this.txtLogin);
            this.gpbLogin.Font = new System.Drawing.Font("MS Mincho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLogin.Location = new System.Drawing.Point(0, 43);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(319, 161);
            this.gpbLogin.TabIndex = 6;
            this.gpbLogin.TabStop = false;
            // 
            // lbMsgErro
            // 
            this.lbMsgErro.AutoSize = true;
            this.lbMsgErro.ForeColor = System.Drawing.Color.Gray;
            this.lbMsgErro.Location = new System.Drawing.Point(60, 92);
            this.lbMsgErro.Name = "lbMsgErro";
            this.lbMsgErro.Size = new System.Drawing.Size(208, 16);
            this.lbMsgErro.TabIndex = 8;
            this.lbMsgErro.Text = "Senha/User incorreto(os)!";
            this.lbMsgErro.Visible = false;
            this.lbMsgErro.MouseLeave += new System.EventHandler(this.lbMsgErro_MouseLeave);
            this.lbMsgErro.MouseHover += new System.EventHandler(this.lbMsgErro_MouseHover);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(116, 61);
            this.txtSenha.MaxLength = 16;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(149, 22);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.Tag = "";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSenha.Location = new System.Drawing.Point(47, 62);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(63, 19);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsuario.Location = new System.Drawing.Point(47, 32);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(63, 19);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(116, 32);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(149, 26);
            this.txtLogin.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(319, 244);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbAcesso);
            this.Controls.Add(this.gpbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Login";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbDescricaoBotao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lbAcesso;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbMsgErro;


    }
}