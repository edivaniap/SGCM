namespace appSGCM.UI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuItens = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteTSMenuItens = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorTSMenuItens = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioTSMenuItens = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoTSMenuItens = new System.Windows.Forms.ToolStripMenuItem();
            this.servicoTSMenuItens = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioTSMenuItens = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusData = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTipo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEsconder = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnConsultarUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultarFornecedores = new System.Windows.Forms.Button();
            this.btnConsultarFuncionarios = new System.Windows.Forms.Button();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.ttpPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.informativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItens,
            this.gerenciamentoToolStripMenuItem,
            this.informaçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenuItens
            // 
            this.tsMenuItens.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteTSMenuItens,
            this.fornecedorTSMenuItens,
            this.funcionarioTSMenuItens,
            this.produtoTSMenuItens,
            this.servicoTSMenuItens,
            this.toolStripSeparator1,
            this.usuárioTSMenuItens});
            this.tsMenuItens.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsMenuItens.Image = global::appSGCM.Properties.Resources.add;
            this.tsMenuItens.Name = "tsMenuItens";
            this.tsMenuItens.Size = new System.Drawing.Size(82, 20);
            this.tsMenuItens.Text = "&Cadastro";
            // 
            // clienteTSMenuItens
            // 
            this.clienteTSMenuItens.Name = "clienteTSMenuItens";
            this.clienteTSMenuItens.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clienteTSMenuItens.Size = new System.Drawing.Size(177, 22);
            this.clienteTSMenuItens.Text = "Cliente";
            this.clienteTSMenuItens.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // fornecedorTSMenuItens
            // 
            this.fornecedorTSMenuItens.Name = "fornecedorTSMenuItens";
            this.fornecedorTSMenuItens.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fornecedorTSMenuItens.Size = new System.Drawing.Size(177, 22);
            this.fornecedorTSMenuItens.Text = "Fornecedor";
            this.fornecedorTSMenuItens.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // funcionarioTSMenuItens
            // 
            this.funcionarioTSMenuItens.Name = "funcionarioTSMenuItens";
            this.funcionarioTSMenuItens.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.funcionarioTSMenuItens.Size = new System.Drawing.Size(177, 22);
            this.funcionarioTSMenuItens.Text = "Funcionário";
            this.funcionarioTSMenuItens.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // produtoTSMenuItens
            // 
            this.produtoTSMenuItens.Name = "produtoTSMenuItens";
            this.produtoTSMenuItens.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.produtoTSMenuItens.Size = new System.Drawing.Size(177, 22);
            this.produtoTSMenuItens.Text = "Produto";
            this.produtoTSMenuItens.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // servicoTSMenuItens
            // 
            this.servicoTSMenuItens.Name = "servicoTSMenuItens";
            this.servicoTSMenuItens.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.servicoTSMenuItens.Size = new System.Drawing.Size(177, 22);
            this.servicoTSMenuItens.Text = "Serviço";
            this.servicoTSMenuItens.Click += new System.EventHandler(this.servicoTSMenuItens_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // usuárioTSMenuItens
            // 
            this.usuárioTSMenuItens.Name = "usuárioTSMenuItens";
            this.usuárioTSMenuItens.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.usuárioTSMenuItens.Size = new System.Drawing.Size(177, 22);
            this.usuárioTSMenuItens.Text = "Usuário";
            this.usuárioTSMenuItens.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.gerenciamentoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gerenciamentoToolStripMenuItem.Image = global::appSGCM.Properties.Resources.building;
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gerenciamentoToolStripMenuItem.Text = "&Gerenciamento";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.E)));
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.V)));
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.U)));
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.informaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.usuárioToolStripMenuItem,
            this.toolStripMenuItem2});
            this.informaçõesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.informaçõesToolStripMenuItem.Image = global::appSGCM.Properties.Resources.configuracoes;
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.informaçõesToolStripMenuItem.Text = "&Configurações";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.empresaToolStripMenuItem.Text = "&Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informativoToolStripMenuItem});
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sobreToolStripMenuItem.Image = global::appSGCM.Properties.Resources.info;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusHora,
            this.statusData,
            this.statusUsuario,
            this.statusTipo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusHora
            // 
            this.statusHora.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusHora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusHora.Name = "statusHora";
            this.statusHora.Size = new System.Drawing.Size(37, 19);
            this.statusHora.Text = "Hora";
            // 
            // statusData
            // 
            this.statusData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusData.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusData.Name = "statusData";
            this.statusData.Size = new System.Drawing.Size(35, 19);
            this.statusData.Text = "Data";
            // 
            // statusUsuario
            // 
            this.statusUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusUsuario.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusUsuario.Name = "statusUsuario";
            this.statusUsuario.Size = new System.Drawing.Size(57, 19);
            this.statusUsuario.Text = "Usuário: ";
            // 
            // statusTipo
            // 
            this.statusTipo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusTipo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusTipo.Name = "statusTipo";
            this.statusTipo.Size = new System.Drawing.Size(41, 19);
            this.statusTipo.Text = "Tipo: ";
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Interval = 1000;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.btnConsultarUsuarios);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnConsultarFornecedores);
            this.groupBox1.Controls.Add(this.btnConsultarFuncionarios);
            this.groupBox1.Controls.Add(this.btnConsultarClientes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEsconder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(649, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 59);
            this.panel3.TabIndex = 19;
            // 
            // btnEsconder
            // 
            this.btnEsconder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsconder.FlatAppearance.BorderSize = 0;
            this.btnEsconder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEsconder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnEsconder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsconder.ImageIndex = 15;
            this.btnEsconder.ImageList = this.imageList1;
            this.btnEsconder.Location = new System.Drawing.Point(8, 3);
            this.btnEsconder.Name = "btnEsconder";
            this.btnEsconder.Size = new System.Drawing.Size(29, 48);
            this.btnEsconder.TabIndex = 22;
            this.ttpPrincipal.SetToolTip(this.btnEsconder, "Esconder");
            this.btnEsconder.UseVisualStyleBackColor = true;
            this.btnEsconder.Click += new System.EventHandler(this.btnEsconder_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EXIT2.ico");
            this.imageList1.Images.SetKeyName(1, "EXIT2.png");
            this.imageList1.Images.SetKeyName(2, "1362717099_contacts.png");
            this.imageList1.Images.SetKeyName(3, "1362717208_administrator.png");
            this.imageList1.Images.SetKeyName(4, "1362717185_stock_task.png");
            this.imageList1.Images.SetKeyName(5, "calculatora.png");
            this.imageList1.Images.SetKeyName(6, "1362717797_cash_register.png");
            this.imageList1.Images.SetKeyName(7, "1362718073_09.png");
            this.imageList1.Images.SetKeyName(8, "1362722695_people.png");
            this.imageList1.Images.SetKeyName(9, "1362723151_user_accounts.png");
            this.imageList1.Images.SetKeyName(10, "1362723271_provider.png");
            this.imageList1.Images.SetKeyName(11, "1362723557_palet02.png");
            this.imageList1.Images.SetKeyName(12, "1362723584_Wood2.png");
            this.imageList1.Images.SetKeyName(13, "user.png");
            this.imageList1.Images.SetKeyName(14, "1364865390_Gnome-Web-Browser-48.png");
            this.imageList1.Images.SetKeyName(15, "hide-right-icon.png");
            // 
            // btnConsultarUsuarios
            // 
            this.btnConsultarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnConsultarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConsultarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnConsultarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarUsuarios.ImageIndex = 13;
            this.btnConsultarUsuarios.ImageList = this.imageList1;
            this.btnConsultarUsuarios.Location = new System.Drawing.Point(261, 19);
            this.btnConsultarUsuarios.Name = "btnConsultarUsuarios";
            this.btnConsultarUsuarios.Size = new System.Drawing.Size(53, 48);
            this.btnConsultarUsuarios.TabIndex = 18;
            this.ttpPrincipal.SetToolTip(this.btnConsultarUsuarios, "Usuários");
            this.btnConsultarUsuarios.UseVisualStyleBackColor = true;
            this.btnConsultarUsuarios.Click += new System.EventHandler(this.btnConsultarUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(739, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 59);
            this.panel1.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ImageIndex = 1;
            this.btnSair.ImageList = this.imageList1;
            this.btnSair.Location = new System.Drawing.Point(11, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(53, 44);
            this.btnSair.TabIndex = 9;
            this.ttpPrincipal.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultarFornecedores
            // 
            this.btnConsultarFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFornecedores.FlatAppearance.BorderSize = 0;
            this.btnConsultarFornecedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConsultarFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnConsultarFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornecedores.ImageIndex = 10;
            this.btnConsultarFornecedores.ImageList = this.imageList1;
            this.btnConsultarFornecedores.Location = new System.Drawing.Point(170, 19);
            this.btnConsultarFornecedores.Name = "btnConsultarFornecedores";
            this.btnConsultarFornecedores.Size = new System.Drawing.Size(53, 48);
            this.btnConsultarFornecedores.TabIndex = 12;
            this.ttpPrincipal.SetToolTip(this.btnConsultarFornecedores, "Fornecedores");
            this.btnConsultarFornecedores.UseVisualStyleBackColor = true;
            this.btnConsultarFornecedores.Click += new System.EventHandler(this.btnConsultarFornecedores_Click);
            // 
            // btnConsultarFuncionarios
            // 
            this.btnConsultarFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnConsultarFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConsultarFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnConsultarFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFuncionarios.ImageIndex = 9;
            this.btnConsultarFuncionarios.ImageList = this.imageList1;
            this.btnConsultarFuncionarios.Location = new System.Drawing.Point(100, 19);
            this.btnConsultarFuncionarios.Name = "btnConsultarFuncionarios";
            this.btnConsultarFuncionarios.Size = new System.Drawing.Size(53, 48);
            this.btnConsultarFuncionarios.TabIndex = 11;
            this.ttpPrincipal.SetToolTip(this.btnConsultarFuncionarios, "Funcionários");
            this.btnConsultarFuncionarios.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionarios.Click += new System.EventHandler(this.btnConsultarFuncionarios_Click);
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConsultarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.ImageIndex = 8;
            this.btnConsultarClientes.ImageList = this.imageList1;
            this.btnConsultarClientes.Location = new System.Drawing.Point(28, 19);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(53, 48);
            this.btnConsultarClientes.TabIndex = 10;
            this.ttpPrincipal.SetToolTip(this.btnConsultarClientes, "Clientes");
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnNavegador);
            this.groupBox2.Controls.Add(this.btnEstoque);
            this.groupBox2.Controls.Add(this.btnCalculadora);
            this.groupBox2.Controls.Add(this.btnAgendamentos);
            this.groupBox2.Controls.Add(this.btnCaixa);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 482);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnNavegador
            // 
            this.btnNavegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavegador.FlatAppearance.BorderSize = 0;
            this.btnNavegador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnNavegador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavegador.ImageIndex = 14;
            this.btnNavegador.ImageList = this.imageList1;
            this.btnNavegador.Location = new System.Drawing.Point(28, 392);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(53, 48);
            this.btnNavegador.TabIndex = 21;
            this.ttpPrincipal.SetToolTip(this.btnNavegador, "Site da Empresa");
            this.btnNavegador.UseVisualStyleBackColor = true;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.ImageIndex = 11;
            this.btnEstoque.ImageList = this.imageList1;
            this.btnEstoque.Location = new System.Drawing.Point(28, 49);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(53, 48);
            this.btnEstoque.TabIndex = 6;
            this.ttpPrincipal.SetToolTip(this.btnEstoque, "Acessar o Estoque");
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalculadora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.ImageIndex = 5;
            this.btnCalculadora.ImageList = this.imageList1;
            this.btnCalculadora.Location = new System.Drawing.Point(28, 302);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(53, 48);
            this.btnCalculadora.TabIndex = 5;
            this.ttpPrincipal.SetToolTip(this.btnCalculadora, "Calculadora");
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendamentos.FlatAppearance.BorderSize = 0;
            this.btnAgendamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAgendamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.ImageIndex = 2;
            this.btnAgendamentos.ImageList = this.imageList1;
            this.btnAgendamentos.Location = new System.Drawing.Point(28, 219);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Size = new System.Drawing.Size(53, 48);
            this.btnAgendamentos.TabIndex = 8;
            this.ttpPrincipal.SetToolTip(this.btnAgendamentos, "Agenda de Atendimentos");
            this.btnAgendamentos.UseVisualStyleBackColor = true;
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.ImageIndex = 6;
            this.btnCaixa.ImageList = this.imageList1;
            this.btnCaixa.Location = new System.Drawing.Point(28, 127);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(53, 48);
            this.btnCaixa.TabIndex = 7;
            this.ttpPrincipal.SetToolTip(this.btnCaixa, "Ir para o Caixa");
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SGCM";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // informativoToolStripMenuItem
            // 
            this.informativoToolStripMenuItem.Name = "informativoToolStripMenuItem";
            this.informativoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informativoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.informativoToolStripMenuItem.Text = "Informativo";
            this.informativoToolStripMenuItem.Click += new System.EventHandler(this.informativoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(815, 608);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Comercial Motociclístico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItens;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteTSMenuItens;
        private System.Windows.Forms.ToolStripStatusLabel statusHora;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.ToolStripStatusLabel statusData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorTSMenuItens;
        private System.Windows.Forms.ToolStripMenuItem funcionarioTSMenuItens;
        private System.Windows.Forms.ToolStripMenuItem produtoTSMenuItens;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip ttpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem usuárioTSMenuItens;
        private System.Windows.Forms.Button btnConsultarFornecedores;
        private System.Windows.Forms.Button btnConsultarFuncionarios;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusUsuario;
        private System.Windows.Forms.ToolStripStatusLabel statusTipo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConsultarUsuarios;
        private System.Windows.Forms.Button btnNavegador;
        private System.Windows.Forms.Button btnEsconder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem servicoTSMenuItens;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informativoToolStripMenuItem;

    }
}