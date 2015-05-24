namespace appSGCM.UI
{
    partial class frmAgendaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendaAtendimento));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddServico = new System.Windows.Forms.Button();
            this.btnProcurarCliente = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxAgendarNovo = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.rbtAntendido = new System.Windows.Forms.RadioButton();
            this.rbtCancelado = new System.Windows.Forms.RadioButton();
            this.rbtPendente = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.rtxtDescricaoServico = new System.Windows.Forms.RichTextBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.mskHorario = new System.Windows.Forms.MaskedTextBox();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbServico = new System.Windows.Forms.Label();
            this.cbxServico = new System.Windows.Forms.ComboBox();
            this.lbData = new System.Windows.Forms.Label();
            this.dateTimeData = new System.Windows.Forms.DateTimePicker();
            this.lbNomeEmpresa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtender = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gbxDatasDisponiveis = new System.Windows.Forms.GroupBox();
            this.listBoxDatasDisponiveis = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbNumTotal = new System.Windows.Forms.Label();
            this.lbPendentes = new System.Windows.Forms.Label();
            this.lbCancelados = new System.Windows.Forms.Label();
            this.lbNumCancelados = new System.Windows.Forms.Label();
            this.lbNumPendentes = new System.Windows.Forms.Label();
            this.lbAtivos = new System.Windows.Forms.Label();
            this.lbAtendidos = new System.Windows.Forms.Label();
            this.lbNumAtendidos = new System.Windows.Forms.Label();
            this.lbNumAtivos = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAtendimentos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxAgendarNovo.SuspendLayout();
            this.gbxStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxDatasDisponiveis.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "1363751619_9254.ico");
            this.imageList1.Images.SetKeyName(2, "1363751920_48761.ico");
            // 
            // btnAddServico
            // 
            this.btnAddServico.ImageIndex = 2;
            this.btnAddServico.ImageList = this.imageList1;
            this.btnAddServico.Location = new System.Drawing.Point(220, 94);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Size = new System.Drawing.Size(26, 26);
            this.btnAddServico.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnAddServico, "Novo Serviço");
            this.btnAddServico.UseVisualStyleBackColor = true;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
            // 
            // btnProcurarCliente
            // 
            this.btnProcurarCliente.ImageIndex = 0;
            this.btnProcurarCliente.ImageList = this.imageList1;
            this.btnProcurarCliente.Location = new System.Drawing.Point(220, 45);
            this.btnProcurarCliente.Name = "btnProcurarCliente";
            this.btnProcurarCliente.Size = new System.Drawing.Size(26, 26);
            this.btnProcurarCliente.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnProcurarCliente, "Busca Avançada");
            this.btnProcurarCliente.UseVisualStyleBackColor = true;
            this.btnProcurarCliente.Click += new System.EventHandler(this.btnProcurarCliente_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.ImageIndex = 2;
            this.btnAddCliente.ImageList = this.imageList1;
            this.btnAddCliente.Location = new System.Drawing.Point(250, 45);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(26, 26);
            this.btnAddCliente.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnAddCliente, "Novo Cliente");
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbxAgendarNovo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 575);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gbxAgendarNovo
            // 
            this.gbxAgendarNovo.BackColor = System.Drawing.Color.DarkRed;
            this.gbxAgendarNovo.Controls.Add(this.btnCancelar);
            this.gbxAgendarNovo.Controls.Add(this.txtCliente);
            this.gbxAgendarNovo.Controls.Add(this.gbxStatus);
            this.gbxAgendarNovo.Controls.Add(this.btnAddServico);
            this.gbxAgendarNovo.Controls.Add(this.btnProcurarCliente);
            this.gbxAgendarNovo.Controls.Add(this.rtxtDescricaoServico);
            this.gbxAgendarNovo.Controls.Add(this.btnAgendar);
            this.gbxAgendarNovo.Controls.Add(this.btnAddCliente);
            this.gbxAgendarNovo.Controls.Add(this.lbDescricao);
            this.gbxAgendarNovo.Controls.Add(this.mskHorario);
            this.gbxAgendarNovo.Controls.Add(this.lbHora);
            this.gbxAgendarNovo.Controls.Add(this.lbServico);
            this.gbxAgendarNovo.Controls.Add(this.cbxServico);
            this.gbxAgendarNovo.Controls.Add(this.lbData);
            this.gbxAgendarNovo.Controls.Add(this.dateTimeData);
            this.gbxAgendarNovo.Controls.Add(this.lbNomeEmpresa);
            this.gbxAgendarNovo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAgendarNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAgendarNovo.Location = new System.Drawing.Point(12, 19);
            this.gbxAgendarNovo.Name = "gbxAgendarNovo";
            this.gbxAgendarNovo.Size = new System.Drawing.Size(290, 434);
            this.gbxAgendarNovo.TabIndex = 25;
            this.gbxAgendarNovo.TabStop = false;
            this.gbxAgendarNovo.Text = "[ Gerenciar Atendimento ]";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(15, 46);
            this.txtCliente.MaxLength = 13;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(200, 25);
            this.txtCliente.TabIndex = 33;
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.rbtAntendido);
            this.gbxStatus.Controls.Add(this.rbtCancelado);
            this.gbxStatus.Controls.Add(this.rbtPendente);
            this.gbxStatus.Controls.Add(this.rbtAtivo);
            this.gbxStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxStatus.Location = new System.Drawing.Point(15, 249);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(133, 139);
            this.gbxStatus.TabIndex = 29;
            this.gbxStatus.TabStop = false;
            this.gbxStatus.Text = "Status";
            // 
            // rbtAntendido
            // 
            this.rbtAntendido.AutoSize = true;
            this.rbtAntendido.Enabled = false;
            this.rbtAntendido.Location = new System.Drawing.Point(17, 55);
            this.rbtAntendido.Name = "rbtAntendido";
            this.rbtAntendido.Size = new System.Drawing.Size(98, 22);
            this.rbtAntendido.TabIndex = 3;
            this.rbtAntendido.Text = "Antendido";
            this.rbtAntendido.UseVisualStyleBackColor = true;
            this.rbtAntendido.Click += new System.EventHandler(this.rbtAntendido_Click);
            // 
            // rbtCancelado
            // 
            this.rbtCancelado.AutoSize = true;
            this.rbtCancelado.Enabled = false;
            this.rbtCancelado.Location = new System.Drawing.Point(17, 111);
            this.rbtCancelado.Name = "rbtCancelado";
            this.rbtCancelado.Size = new System.Drawing.Size(98, 22);
            this.rbtCancelado.TabIndex = 2;
            this.rbtCancelado.Text = "Cancelado";
            this.rbtCancelado.UseVisualStyleBackColor = true;
            this.rbtCancelado.CheckedChanged += new System.EventHandler(this.rbtCancelado_CheckedChanged);
            // 
            // rbtPendente
            // 
            this.rbtPendente.AutoSize = true;
            this.rbtPendente.Enabled = false;
            this.rbtPendente.Location = new System.Drawing.Point(17, 83);
            this.rbtPendente.Name = "rbtPendente";
            this.rbtPendente.Size = new System.Drawing.Size(90, 22);
            this.rbtPendente.TabIndex = 1;
            this.rbtPendente.Text = "Pendente";
            this.rbtPendente.UseVisualStyleBackColor = true;
            this.rbtPendente.Click += new System.EventHandler(this.rbtPendente_Click);
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Checked = true;
            this.rbtAtivo.Location = new System.Drawing.Point(17, 27);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(66, 22);
            this.rbtAtivo.TabIndex = 0;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            this.rbtAtivo.Click += new System.EventHandler(this.rbtAtivo_Click);
            // 
            // rtxtDescricaoServico
            // 
            this.rtxtDescricaoServico.Location = new System.Drawing.Point(15, 154);
            this.rtxtDescricaoServico.Name = "rtxtDescricaoServico";
            this.rtxtDescricaoServico.Size = new System.Drawing.Size(261, 84);
            this.rtxtDescricaoServico.TabIndex = 26;
            this.rtxtDescricaoServico.Text = "";
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgendar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgendar.Location = new System.Drawing.Point(159, 360);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(117, 28);
            this.btnAgendar.TabIndex = 24;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(12, 127);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(168, 18);
            this.lbDescricao.TabIndex = 17;
            this.lbDescricao.Text = "Descrição do Serviço";
            // 
            // mskHorario
            // 
            this.mskHorario.Location = new System.Drawing.Point(159, 319);
            this.mskHorario.Mask = "90:00";
            this.mskHorario.Name = "mskHorario";
            this.mskHorario.Size = new System.Drawing.Size(51, 25);
            this.mskHorario.TabIndex = 16;
            this.mskHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskHorario.ValidatingType = typeof(System.DateTime);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(156, 298);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(40, 18);
            this.lbHora.TabIndex = 15;
            this.lbHora.Text = "Hora";
            // 
            // lbServico
            // 
            this.lbServico.AutoSize = true;
            this.lbServico.Location = new System.Drawing.Point(12, 74);
            this.lbServico.Name = "lbServico";
            this.lbServico.Size = new System.Drawing.Size(64, 18);
            this.lbServico.TabIndex = 13;
            this.lbServico.Text = "Serviço";
            // 
            // cbxServico
            // 
            this.cbxServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServico.FormattingEnabled = true;
            this.cbxServico.Location = new System.Drawing.Point(15, 95);
            this.cbxServico.Name = "cbxServico";
            this.cbxServico.Size = new System.Drawing.Size(199, 26);
            this.cbxServico.TabIndex = 12;
            this.cbxServico.SelectedIndexChanged += new System.EventHandler(this.cbxServico_SelectedIndexChanged);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(156, 249);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(40, 18);
            this.lbData.TabIndex = 8;
            this.lbData.Text = "Data";
            // 
            // dateTimeData
            // 
            this.dateTimeData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeData.Location = new System.Drawing.Point(159, 270);
            this.dateTimeData.Name = "dateTimeData";
            this.dateTimeData.Size = new System.Drawing.Size(117, 25);
            this.dateTimeData.TabIndex = 0;
            // 
            // lbNomeEmpresa
            // 
            this.lbNomeEmpresa.AutoSize = true;
            this.lbNomeEmpresa.Location = new System.Drawing.Point(12, 25);
            this.lbNomeEmpresa.Name = "lbNomeEmpresa";
            this.lbNomeEmpresa.Size = new System.Drawing.Size(64, 18);
            this.lbNomeEmpresa.TabIndex = 5;
            this.lbNomeEmpresa.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.gbxDatasDisponiveis);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(904, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 575);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAtender);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 43);
            this.panel2.TabIndex = 42;
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAtender.Enabled = false;
            this.btnAtender.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtender.Location = new System.Drawing.Point(55, 3);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(90, 33);
            this.btnAtender.TabIndex = 33;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 43);
            this.panel1.TabIndex = 41;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Location = new System.Drawing.Point(55, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 33);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gbxDatasDisponiveis
            // 
            this.gbxDatasDisponiveis.BackColor = System.Drawing.Color.DarkRed;
            this.gbxDatasDisponiveis.Controls.Add(this.listBoxDatasDisponiveis);
            this.gbxDatasDisponiveis.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxDatasDisponiveis.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatasDisponiveis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxDatasDisponiveis.Location = new System.Drawing.Point(3, 222);
            this.gbxDatasDisponiveis.Name = "gbxDatasDisponiveis";
            this.gbxDatasDisponiveis.Size = new System.Drawing.Size(191, 221);
            this.gbxDatasDisponiveis.TabIndex = 40;
            this.gbxDatasDisponiveis.TabStop = false;
            this.gbxDatasDisponiveis.Text = "[ Datas Disponíveis ]";
            // 
            // listBoxDatasDisponiveis
            // 
            this.listBoxDatasDisponiveis.BackColor = System.Drawing.Color.MistyRose;
            this.listBoxDatasDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDatasDisponiveis.FormatString = "g";
            this.listBoxDatasDisponiveis.FormattingEnabled = true;
            this.listBoxDatasDisponiveis.ItemHeight = 18;
            this.listBoxDatasDisponiveis.Location = new System.Drawing.Point(11, 24);
            this.listBoxDatasDisponiveis.Name = "listBoxDatasDisponiveis";
            this.listBoxDatasDisponiveis.Size = new System.Drawing.Size(170, 180);
            this.listBoxDatasDisponiveis.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Controls.Add(this.lbTotal);
            this.groupBox4.Controls.Add(this.lbNumTotal);
            this.groupBox4.Controls.Add(this.lbPendentes);
            this.groupBox4.Controls.Add(this.lbCancelados);
            this.groupBox4.Controls.Add(this.lbNumCancelados);
            this.groupBox4.Controls.Add(this.lbNumPendentes);
            this.groupBox4.Controls.Add(this.lbAtivos);
            this.groupBox4.Controls.Add(this.lbAtendidos);
            this.groupBox4.Controls.Add(this.lbNumAtendidos);
            this.groupBox4.Controls.Add(this.lbNumAtivos);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 206);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTotal.Location = new System.Drawing.Point(11, 179);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 18);
            this.lbTotal.TabIndex = 52;
            this.lbTotal.Text = "Total:";
            // 
            // lbNumTotal
            // 
            this.lbNumTotal.AutoSize = true;
            this.lbNumTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNumTotal.Location = new System.Drawing.Point(104, 182);
            this.lbNumTotal.Name = "lbNumTotal";
            this.lbNumTotal.Size = new System.Drawing.Size(13, 13);
            this.lbNumTotal.TabIndex = 53;
            this.lbNumTotal.Text = "0";
            // 
            // lbPendentes
            // 
            this.lbPendentes.AutoSize = true;
            this.lbPendentes.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPendentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPendentes.Location = new System.Drawing.Point(11, 138);
            this.lbPendentes.Name = "lbPendentes";
            this.lbPendentes.Size = new System.Drawing.Size(88, 18);
            this.lbPendentes.TabIndex = 48;
            this.lbPendentes.Text = "Pendentes:";
            // 
            // lbCancelados
            // 
            this.lbCancelados.AutoSize = true;
            this.lbCancelados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancelados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCancelados.Location = new System.Drawing.Point(11, 159);
            this.lbCancelados.Name = "lbCancelados";
            this.lbCancelados.Size = new System.Drawing.Size(96, 18);
            this.lbCancelados.TabIndex = 49;
            this.lbCancelados.Text = "Cancelados:";
            // 
            // lbNumCancelados
            // 
            this.lbNumCancelados.AutoSize = true;
            this.lbNumCancelados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNumCancelados.Location = new System.Drawing.Point(104, 162);
            this.lbNumCancelados.Name = "lbNumCancelados";
            this.lbNumCancelados.Size = new System.Drawing.Size(13, 13);
            this.lbNumCancelados.TabIndex = 50;
            this.lbNumCancelados.Text = "0";
            // 
            // lbNumPendentes
            // 
            this.lbNumPendentes.AutoSize = true;
            this.lbNumPendentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNumPendentes.Location = new System.Drawing.Point(104, 141);
            this.lbNumPendentes.Name = "lbNumPendentes";
            this.lbNumPendentes.Size = new System.Drawing.Size(13, 13);
            this.lbNumPendentes.TabIndex = 51;
            this.lbNumPendentes.Text = "0";
            // 
            // lbAtivos
            // 
            this.lbAtivos.AutoSize = true;
            this.lbAtivos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAtivos.Location = new System.Drawing.Point(11, 98);
            this.lbAtivos.Name = "lbAtivos";
            this.lbAtivos.Size = new System.Drawing.Size(64, 18);
            this.lbAtivos.TabIndex = 42;
            this.lbAtivos.Text = "Ativos:";
            // 
            // lbAtendidos
            // 
            this.lbAtendidos.AutoSize = true;
            this.lbAtendidos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtendidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAtendidos.Location = new System.Drawing.Point(11, 117);
            this.lbAtendidos.Name = "lbAtendidos";
            this.lbAtendidos.Size = new System.Drawing.Size(88, 18);
            this.lbAtendidos.TabIndex = 43;
            this.lbAtendidos.Text = "Atendidos:";
            // 
            // lbNumAtendidos
            // 
            this.lbNumAtendidos.AutoSize = true;
            this.lbNumAtendidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNumAtendidos.Location = new System.Drawing.Point(104, 121);
            this.lbNumAtendidos.Name = "lbNumAtendidos";
            this.lbNumAtendidos.Size = new System.Drawing.Size(13, 13);
            this.lbNumAtendidos.TabIndex = 44;
            this.lbNumAtendidos.Text = "0";
            // 
            // lbNumAtivos
            // 
            this.lbNumAtivos.AutoSize = true;
            this.lbNumAtivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNumAtivos.Location = new System.Drawing.Point(104, 101);
            this.lbNumAtivos.Name = "lbNumAtivos";
            this.lbNumAtivos.Size = new System.Drawing.Size(13, 13);
            this.lbNumAtivos.TabIndex = 45;
            this.lbNumAtivos.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxFiltro);
            this.groupBox6.Controls.Add(this.txtBuscar);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(3, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(185, 82);
            this.groupBox6.TabIndex = 55;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "[ Filtro ]";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DisplayMember = "1";
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CodAgendamento",
            "CodServico",
            "CodCliente",
            "NomeCliente",
            "TipoServico",
            "Descricao",
            "Data",
            "Horario",
            "Status"});
            this.cbxFiltro.Location = new System.Drawing.Point(9, 50);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(167, 26);
            this.cbxFiltro.TabIndex = 57;
            this.cbxFiltro.TextChanged += new System.EventHandler(this.cbxFiltro_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(9, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(167, 25);
            this.txtBuscar.TabIndex = 55;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeletar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 529);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 43);
            this.panel3.TabIndex = 37;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Crimson;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletar.Location = new System.Drawing.Point(55, 3);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(90, 33);
            this.btnDeletar.TabIndex = 33;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.dgvAtendimentos);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(316, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 575);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[ Agendados ]";
            // 
            // dgvAtendimentos
            // 
            this.dgvAtendimentos.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtendimentos.Location = new System.Drawing.Point(3, 21);
            this.dgvAtendimentos.Name = "dgvAtendimentos";
            this.dgvAtendimentos.Size = new System.Drawing.Size(582, 551);
            this.dgvAtendimentos.TabIndex = 3;
            this.dgvAtendimentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtendimentos_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(159, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 28);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgendaAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1101, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAgendaAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Agenda de Atendimento";
            this.Load += new System.EventHandler(this.frmAgendaAtendimento_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbxAgendarNovo.ResumeLayout(false);
            this.gbxAgendarNovo.PerformLayout();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbxDatasDisponiveis.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxAgendarNovo;
        private System.Windows.Forms.Button btnAddServico;
        private System.Windows.Forms.Button btnProcurarCliente;
        private System.Windows.Forms.RichTextBox rtxtDescricaoServico;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.MaskedTextBox mskHorario;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbServico;
        private System.Windows.Forms.ComboBox cbxServico;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker dateTimeData;
        private System.Windows.Forms.Label lbNomeEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAtendimentos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbAtivos;
        private System.Windows.Forms.Label lbAtendidos;
        private System.Windows.Forms.Label lbNumAtendidos;
        private System.Windows.Forms.Label lbNumAtivos;
        private System.Windows.Forms.GroupBox gbxStatus;
        private System.Windows.Forms.RadioButton rbtCancelado;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.GroupBox gbxDatasDisponiveis;
        private System.Windows.Forms.ListBox listBoxDatasDisponiveis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lbPendentes;
        private System.Windows.Forms.Label lbCancelados;
        private System.Windows.Forms.Label lbNumCancelados;
        private System.Windows.Forms.Label lbNumPendentes;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbNumTotal;
        private System.Windows.Forms.RadioButton rbtAntendido;
        private System.Windows.Forms.RadioButton rbtPendente;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCancelar;
    }
}