namespace appSGCM.UI
{
    partial class frmCadastroCliente
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
            this.gbxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.dateNasc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.gbxDadosParaContatos = new System.Windows.Forms.GroupBox();
            this.txtNumResidencia = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFaceBook = new System.Windows.Forms.TextBox();
            this.lbFacebook = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDataAtualizacao = new System.Windows.Forms.Label();
            this.gbxDadosPessoais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxDadosParaContatos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDadosPessoais
            // 
            this.gbxDadosPessoais.BackColor = System.Drawing.Color.DarkRed;
            this.gbxDadosPessoais.Controls.Add(this.dateNasc);
            this.gbxDadosPessoais.Controls.Add(this.label2);
            this.gbxDadosPessoais.Controls.Add(this.groupBox1);
            this.gbxDadosPessoais.Controls.Add(this.mskCPF);
            this.gbxDadosPessoais.Controls.Add(this.lbCPF);
            this.gbxDadosPessoais.Controls.Add(this.mskRG);
            this.gbxDadosPessoais.Controls.Add(this.lbNome);
            this.gbxDadosPessoais.Controls.Add(this.txtNome);
            this.gbxDadosPessoais.Controls.Add(this.lbRG);
            this.gbxDadosPessoais.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosPessoais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxDadosPessoais.Location = new System.Drawing.Point(12, 66);
            this.gbxDadosPessoais.Name = "gbxDadosPessoais";
            this.gbxDadosPessoais.Size = new System.Drawing.Size(512, 126);
            this.gbxDadosPessoais.TabIndex = 19;
            this.gbxDadosPessoais.TabStop = false;
            this.gbxDadosPessoais.Text = "[ Dados Pessoais ]";
            // 
            // dateNasc
            // 
            this.dateNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNasc.Location = new System.Drawing.Point(6, 91);
            this.dateNasc.Name = "dateNasc";
            this.dateNasc.Size = new System.Drawing.Size(118, 25);
            this.dateNasc.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nascimento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtFeminino);
            this.groupBox1.Controls.Add(this.rbtMasculino);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(374, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 95);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Sexo ]";
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(6, 52);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(90, 22);
            this.rbtFeminino.TabIndex = 19;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(6, 24);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(98, 22);
            this.rbtMasculino.TabIndex = 18;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(240, 91);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(128, 25);
            this.mskCPF.TabIndex = 6;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(237, 70);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(32, 18);
            this.lbCPF.TabIndex = 5;
            this.lbCPF.Text = "CPF";
            // 
            // mskRG
            // 
            this.mskRG.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRG.Location = new System.Drawing.Point(130, 91);
            this.mskRG.Mask = "000,000,000";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(104, 25);
            this.mskRG.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(8, 21);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 18);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(8, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 25);
            this.txtNome.TabIndex = 0;
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRG.Location = new System.Drawing.Point(127, 70);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(24, 18);
            this.lbRG.TabIndex = 3;
            this.lbRG.Text = "RG";
            // 
            // gbxDadosParaContatos
            // 
            this.gbxDadosParaContatos.BackColor = System.Drawing.Color.DarkRed;
            this.gbxDadosParaContatos.Controls.Add(this.txtNumResidencia);
            this.gbxDadosParaContatos.Controls.Add(this.mskCEP);
            this.gbxDadosParaContatos.Controls.Add(this.label3);
            this.gbxDadosParaContatos.Controls.Add(this.cbxUF);
            this.gbxDadosParaContatos.Controls.Add(this.txtCidade);
            this.gbxDadosParaContatos.Controls.Add(this.label4);
            this.gbxDadosParaContatos.Controls.Add(this.label5);
            this.gbxDadosParaContatos.Controls.Add(this.txtComplemento);
            this.gbxDadosParaContatos.Controls.Add(this.label6);
            this.gbxDadosParaContatos.Controls.Add(this.txtBairro);
            this.gbxDadosParaContatos.Controls.Add(this.label7);
            this.gbxDadosParaContatos.Controls.Add(this.label8);
            this.gbxDadosParaContatos.Controls.Add(this.txtEndereco);
            this.gbxDadosParaContatos.Controls.Add(this.label9);
            this.gbxDadosParaContatos.Controls.Add(this.txtFaceBook);
            this.gbxDadosParaContatos.Controls.Add(this.lbFacebook);
            this.gbxDadosParaContatos.Controls.Add(this.txtSite);
            this.gbxDadosParaContatos.Controls.Add(this.label1);
            this.gbxDadosParaContatos.Controls.Add(this.txtEmail);
            this.gbxDadosParaContatos.Controls.Add(this.label10);
            this.gbxDadosParaContatos.Controls.Add(this.mskTelefone);
            this.gbxDadosParaContatos.Controls.Add(this.mskCelular);
            this.gbxDadosParaContatos.Controls.Add(this.label11);
            this.gbxDadosParaContatos.Controls.Add(this.label12);
            this.gbxDadosParaContatos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosParaContatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxDadosParaContatos.Location = new System.Drawing.Point(12, 198);
            this.gbxDadosParaContatos.Name = "gbxDadosParaContatos";
            this.gbxDadosParaContatos.Size = new System.Drawing.Size(512, 230);
            this.gbxDadosParaContatos.TabIndex = 31;
            this.gbxDadosParaContatos.TabStop = false;
            this.gbxDadosParaContatos.Text = "[ Dados para Contato ]";
            // 
            // txtNumResidencia
            // 
            this.txtNumResidencia.Location = new System.Drawing.Point(284, 41);
            this.txtNumResidencia.MaxLength = 7;
            this.txtNumResidencia.Name = "txtNumResidencia";
            this.txtNumResidencia.Size = new System.Drawing.Size(62, 25);
            this.txtNumResidencia.TabIndex = 30;
            this.txtNumResidencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.Location = new System.Drawing.Point(409, 91);
            this.mskCEP.Mask = "00000-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(90, 25);
            this.mskCEP.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "CEP";
            // 
            // cbxUF
            // 
            this.cbxUF.DisplayMember = "0";
            this.cbxUF.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MT",
            "MS",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbxUF.Location = new System.Drawing.Point(353, 90);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(46, 26);
            this.cbxUF.TabIndex = 27;
            this.cbxUF.Tag = "";
            this.cbxUF.Text = "AC";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(183, 91);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(164, 25);
            this.txtCidade.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cidade";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(353, 41);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(144, 25);
            this.txtComplemento.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(10, 91);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(164, 25);
            this.txtBairro.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nº";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(10, 42);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(268, 25);
            this.txtEndereco.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Endereço";
            // 
            // txtFaceBook
            // 
            this.txtFaceBook.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaceBook.Location = new System.Drawing.Point(321, 189);
            this.txtFaceBook.Name = "txtFaceBook";
            this.txtFaceBook.Size = new System.Drawing.Size(178, 25);
            this.txtFaceBook.TabIndex = 12;
            // 
            // lbFacebook
            // 
            this.lbFacebook.AutoSize = true;
            this.lbFacebook.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacebook.Location = new System.Drawing.Point(318, 168);
            this.lbFacebook.Name = "lbFacebook";
            this.lbFacebook.Size = new System.Drawing.Size(72, 18);
            this.lbFacebook.TabIndex = 11;
            this.lbFacebook.Text = "Facebook";
            // 
            // txtSite
            // 
            this.txtSite.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(11, 189);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(301, 25);
            this.txtSite.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Site";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(263, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 25);
            this.txtEmail.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(260, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "E-mail";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(137, 140);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(120, 25);
            this.mskTelefone.TabIndex = 6;
            // 
            // mskCelular
            // 
            this.mskCelular.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelular.Location = new System.Drawing.Point(11, 140);
            this.mskCelular.Mask = "(99) 0000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(120, 25);
            this.mskCelular.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(134, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Celular";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnCadastrar);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(512, 57);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(355, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 28);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCadastrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(50, 17);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(99, 28);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDataAtualizacao);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 48);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Última Atualização ]";
            // 
            // lbDataAtualizacao
            // 
            this.lbDataAtualizacao.AutoSize = true;
            this.lbDataAtualizacao.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDataAtualizacao.Location = new System.Drawing.Point(469, 21);
            this.lbDataAtualizacao.Name = "lbDataAtualizacao";
            this.lbDataAtualizacao.Size = new System.Drawing.Size(40, 18);
            this.lbDataAtualizacao.TabIndex = 1;
            this.lbDataAtualizacao.Text = "Data";
            // 
            // frmCadastroCliente
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(536, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbxDadosParaContatos);
            this.Controls.Add(this.gbxDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Cadastro de Cliente";
            this.gbxDadosPessoais.ResumeLayout(false);
            this.gbxDadosPessoais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxDadosParaContatos.ResumeLayout(false);
            this.gbxDadosParaContatos.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosPessoais;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.GroupBox gbxDadosParaContatos;
        private System.Windows.Forms.TextBox txtNumResidencia;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFaceBook;
        private System.Windows.Forms.Label lbFacebook;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.DateTimePicker dateNasc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbDataAtualizacao;

    }
}