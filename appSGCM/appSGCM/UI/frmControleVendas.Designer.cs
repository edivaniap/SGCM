namespace appSGCM.UI
{
    partial class frmControleVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleVendas));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalvarNota = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtxtNotaFiscal = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnProcurarCliente = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPagarComDesconto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDesconto = new System.Windows.Forms.NumericUpDown();
            this.lbValorCompra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.gbxAddProd = new System.Windows.Forms.GroupBox();
            this.btnAddServico = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.rtxtDescricaoProduto = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoUnd = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttpPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
            this.gbxAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 668);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.btnSalvarNota);
            this.groupBox3.Controls.Add(this.btnCalculadora);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 71);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btnSalvarNota
            // 
            this.btnSalvarNota.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarNota.FlatAppearance.BorderSize = 0;
            this.btnSalvarNota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSalvarNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSalvarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarNota.ImageIndex = 3;
            this.btnSalvarNota.ImageList = this.imageList1;
            this.btnSalvarNota.Location = new System.Drawing.Point(12, 17);
            this.btnSalvarNota.Name = "btnSalvarNota";
            this.btnSalvarNota.Size = new System.Drawing.Size(53, 48);
            this.btnSalvarNota.TabIndex = 8;
            this.ttpPrincipal.SetToolTip(this.btnSalvarNota, "Salvar Nota Fiscal");
            this.btnSalvarNota.UseVisualStyleBackColor = false;
            this.btnSalvarNota.Click += new System.EventHandler(this.btnSalvarNota_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "calculator.png");
            this.imageList1.Images.SetKeyName(1, "calculatora.png");
            this.imageList1.Images.SetKeyName(2, "addp.png");
            this.imageList1.Images.SetKeyName(3, "1362516551_type-list.png");
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalculadora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.ImageIndex = 1;
            this.btnCalculadora.ImageList = this.imageList1;
            this.btnCalculadora.Location = new System.Drawing.Point(81, 17);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(53, 48);
            this.btnCalculadora.TabIndex = 6;
            this.ttpPrincipal.SetToolTip(this.btnCalculadora, "Calculadora");
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer2.Panel1.Controls.Add(this.rtxtNotaFiscal);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.gbxAddProd);
            this.splitContainer2.Size = new System.Drawing.Size(800, 593);
            this.splitContainer2.SplitterDistance = 507;
            this.splitContainer2.TabIndex = 0;
            // 
            // rtxtNotaFiscal
            // 
            this.rtxtNotaFiscal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtxtNotaFiscal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNotaFiscal.Location = new System.Drawing.Point(37, 17);
            this.rtxtNotaFiscal.Name = "rtxtNotaFiscal";
            this.rtxtNotaFiscal.ReadOnly = true;
            this.rtxtNotaFiscal.Size = new System.Drawing.Size(430, 564);
            this.rtxtNotaFiscal.TabIndex = 1;
            this.rtxtNotaFiscal.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Black;
            this.groupBox5.Controls.Add(this.btnConfirmarCompra);
            this.groupBox5.Controls.Add(this.btnNovaVenda);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(3, 538);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 49);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarCompra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmarCompra.Location = new System.Drawing.Point(9, 15);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(103, 28);
            this.btnConfirmarCompra.TabIndex = 17;
            this.btnConfirmarCompra.Text = "Finalizar";
            this.btnConfirmarCompra.UseVisualStyleBackColor = false;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNovaVenda.Enabled = false;
            this.btnNovaVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovaVenda.Location = new System.Drawing.Point(159, 15);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(115, 28);
            this.btnNovaVenda.TabIndex = 23;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = false;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Controls.Add(this.txtCliente);
            this.groupBox4.Controls.Add(this.btnProcurarCliente);
            this.groupBox4.Controls.Add(this.btnNovoCliente);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtTroco);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtPagamento);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(3, 417);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 117);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "[ Cliente ]";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(11, 27);
            this.txtCliente.MaxLength = 13;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(200, 25);
            this.txtCliente.TabIndex = 32;
            // 
            // btnProcurarCliente
            // 
            this.btnProcurarCliente.ImageIndex = 0;
            this.btnProcurarCliente.ImageList = this.imageList2;
            this.btnProcurarCliente.Location = new System.Drawing.Point(217, 27);
            this.btnProcurarCliente.Name = "btnProcurarCliente";
            this.btnProcurarCliente.Size = new System.Drawing.Size(26, 26);
            this.btnProcurarCliente.TabIndex = 31;
            this.btnProcurarCliente.UseVisualStyleBackColor = true;
            this.btnProcurarCliente.Click += new System.EventHandler(this.btnProcurarCliente_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "search.png");
            this.imageList2.Images.SetKeyName(1, "1363752733_shopping_cart_add.png");
            this.imageList2.Images.SetKeyName(2, "adicionar.png");
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.ImageIndex = 2;
            this.btnNovoCliente.ImageList = this.imageList2;
            this.btnNovoCliente.Location = new System.Drawing.Point(245, 27);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(26, 26);
            this.btnNovoCliente.TabIndex = 30;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(128, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "Troco";
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(132, 77);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(140, 25);
            this.txtTroco.TabIndex = 21;
            this.txtTroco.Text = "0";
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "Valor Pago";
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(11, 77);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(101, 25);
            this.txtPagamento.TabIndex = 19;
            this.txtPagamento.Text = "0";
            this.txtPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.txtTipoServico);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPagarComDesconto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nudDesconto);
            this.groupBox2.Controls.Add(this.lbValorCompra);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotalPagar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(2, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 135);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Compra ]";
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoServico.Location = new System.Drawing.Point(11, 91);
            this.txtTipoServico.MaxLength = 13;
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.ReadOnly = true;
            this.txtTipoServico.Size = new System.Drawing.Size(144, 25);
            this.txtTipoServico.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Desconto (%)";
            // 
            // txtPagarComDesconto
            // 
            this.txtPagarComDesconto.Location = new System.Drawing.Point(173, 91);
            this.txtPagarComDesconto.Name = "txtPagarComDesconto";
            this.txtPagarComDesconto.ReadOnly = true;
            this.txtPagarComDesconto.Size = new System.Drawing.Size(99, 25);
            this.txtPagarComDesconto.TabIndex = 15;
            this.txtPagarComDesconto.Text = "0";
            this.txtPagarComDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Com Desconto";
            // 
            // nudDesconto
            // 
            this.nudDesconto.DecimalPlaces = 2;
            this.nudDesconto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDesconto.Location = new System.Drawing.Point(173, 42);
            this.nudDesconto.Name = "nudDesconto";
            this.nudDesconto.Size = new System.Drawing.Size(99, 25);
            this.nudDesconto.TabIndex = 18;
            this.nudDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDesconto.ValueChanged += new System.EventHandler(this.nudDesconto_ValueChanged);
            // 
            // lbValorCompra
            // 
            this.lbValorCompra.AutoSize = true;
            this.lbValorCompra.Location = new System.Drawing.Point(8, 21);
            this.lbValorCompra.Name = "lbValorCompra";
            this.lbValorCompra.Size = new System.Drawing.Size(104, 18);
            this.lbValorCompra.TabIndex = 11;
            this.lbValorCompra.Text = "Valor Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Serviço";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(11, 42);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(144, 25);
            this.txtTotalPagar.TabIndex = 8;
            this.txtTotalPagar.Text = "0";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
            // 
            // gbxAddProd
            // 
            this.gbxAddProd.BackColor = System.Drawing.Color.DarkRed;
            this.gbxAddProd.Controls.Add(this.btnAddServico);
            this.gbxAddProd.Controls.Add(this.btnAdicionar);
            this.gbxAddProd.Controls.Add(this.btnProcurar);
            this.gbxAddProd.Controls.Add(this.rtxtDescricaoProduto);
            this.gbxAddProd.Controls.Add(this.label4);
            this.gbxAddProd.Controls.Add(this.txtPrecoUnd);
            this.gbxAddProd.Controls.Add(this.btnCancelar);
            this.gbxAddProd.Controls.Add(this.txtValorTotal);
            this.gbxAddProd.Controls.Add(this.label6);
            this.gbxAddProd.Controls.Add(this.label3);
            this.gbxAddProd.Controls.Add(this.label1);
            this.gbxAddProd.Controls.Add(this.nudQtd);
            this.gbxAddProd.Controls.Add(this.txtCodProduto);
            this.gbxAddProd.Controls.Add(this.label2);
            this.gbxAddProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAddProd.Location = new System.Drawing.Point(3, 3);
            this.gbxAddProd.Name = "gbxAddProd";
            this.gbxAddProd.Size = new System.Drawing.Size(281, 266);
            this.gbxAddProd.TabIndex = 0;
            this.gbxAddProd.TabStop = false;
            this.gbxAddProd.Text = "[ Adicionar Produto ]";
            // 
            // btnAddServico
            // 
            this.btnAddServico.ImageIndex = 2;
            this.btnAddServico.ImageList = this.imageList2;
            this.btnAddServico.Location = new System.Drawing.Point(204, 47);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Size = new System.Drawing.Size(26, 26);
            this.btnAddServico.TabIndex = 31;
            this.ttpPrincipal.SetToolTip(this.btnAddServico, "Adicionar Produto");
            this.btnAddServico.UseVisualStyleBackColor = true;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(10, 225);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(103, 28);
            this.btnAdicionar.TabIndex = 30;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.ImageIndex = 0;
            this.btnProcurar.ImageList = this.imageList2;
            this.btnProcurar.Location = new System.Drawing.Point(173, 47);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(26, 26);
            this.btnProcurar.TabIndex = 29;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // rtxtDescricaoProduto
            // 
            this.rtxtDescricaoProduto.Location = new System.Drawing.Point(10, 97);
            this.rtxtDescricaoProduto.Name = "rtxtDescricaoProduto";
            this.rtxtDescricaoProduto.Size = new System.Drawing.Size(263, 62);
            this.rtxtDescricaoProduto.TabIndex = 0;
            this.rtxtDescricaoProduto.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço/UND";
            // 
            // txtPrecoUnd
            // 
            this.txtPrecoUnd.Location = new System.Drawing.Point(10, 188);
            this.txtPrecoUnd.Name = "txtPrecoUnd";
            this.txtPrecoUnd.ReadOnly = true;
            this.txtPrecoUnd.Size = new System.Drawing.Size(87, 25);
            this.txtPrecoUnd.TabIndex = 8;
            this.txtPrecoUnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(170, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 28);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(180, 188);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(93, 25);
            this.txtValorTotal.TabIndex = 11;
            this.txtValorTotal.Text = "0";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Produto";
            // 
            // nudQtd
            // 
            this.nudQtd.Enabled = false;
            this.nudQtd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtd.Location = new System.Drawing.Point(103, 188);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(71, 25);
            this.nudQtd.TabIndex = 6;
            this.nudQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtd.ValueChanged += new System.EventHandler(this.nudQtd_ValueChanged);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(10, 48);
            this.txtCodProduto.MaxLength = 13;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.ReadOnly = true;
            this.txtCodProduto.Size = new System.Drawing.Size(157, 25);
            this.txtCodProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qtd.";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "*.rtf";
            this.saveFileDialog1.Filter = "Texto (.rtf) | *.rtf";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Salvar nota fiscal...";
            // 
            // frmControleVendas
            // 
            this.AcceptButton = this.btnConfirmarCompra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmControleVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Controle de Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControleVendas_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
            this.gbxAddProd.ResumeLayout(false);
            this.gbxAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtxtNotaFiscal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPagarComDesconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbValorCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.GroupBox gbxAddProd;
        private System.Windows.Forms.RichTextBox rtxtDescricaoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecoUnd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip ttpPrincipal;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnSalvarNota;
        private System.Windows.Forms.NumericUpDown nudDesconto;
        private System.Windows.Forms.Button btnAddServico;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnProcurarCliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtTipoServico;
    }
}