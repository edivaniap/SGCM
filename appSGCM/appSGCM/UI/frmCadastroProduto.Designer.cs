namespace appSGCM.UI
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lbQtd = new System.Windows.Forms.Label();
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.btnAddFornecedor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.nudPrecoCompra = new System.Windows.Forms.NumericUpDown();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.picbxProduto = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbDataAtualizacao = new System.Windows.Forms.Label();
            this.groupBoxProduto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCompra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProduto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(13, 49);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(324, 25);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(11, 28);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 18);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.Color.White;
            this.lbTipo.Location = new System.Drawing.Point(347, 27);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(40, 18);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(133, 100);
            this.txtQtd.MaxLength = 15;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(75, 25);
            this.txtQtd.TabIndex = 4;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbQtd
            // 
            this.lbQtd.AutoSize = true;
            this.lbQtd.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtd.ForeColor = System.Drawing.Color.White;
            this.lbQtd.Location = new System.Drawing.Point(130, 77);
            this.lbQtd.Name = "lbQtd";
            this.lbQtd.Size = new System.Drawing.Size(40, 18);
            this.lbQtd.TabIndex = 6;
            this.lbQtd.Text = "Qtd.";
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.BackColor = System.Drawing.Color.DarkRed;
            this.groupBoxProduto.Controls.Add(this.btnAddFornecedor);
            this.groupBoxProduto.Controls.Add(this.txtCodigoProd);
            this.groupBoxProduto.Controls.Add(this.label4);
            this.groupBoxProduto.Controls.Add(this.cbxTipo);
            this.groupBoxProduto.Controls.Add(this.cbxFornecedor);
            this.groupBoxProduto.Controls.Add(this.label2);
            this.groupBoxProduto.Controls.Add(this.txtNomeProduto);
            this.groupBoxProduto.Controls.Add(this.lbNome);
            this.groupBoxProduto.Controls.Add(this.lbQtd);
            this.groupBoxProduto.Controls.Add(this.lbTipo);
            this.groupBoxProduto.Controls.Add(this.txtQtd);
            this.groupBoxProduto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduto.ForeColor = System.Drawing.Color.White;
            this.groupBoxProduto.Location = new System.Drawing.Point(12, 57);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(492, 143);
            this.groupBoxProduto.TabIndex = 8;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "[ Produto ]";
            // 
            // btnAddFornecedor
            // 
            this.btnAddFornecedor.ImageIndex = 0;
            this.btnAddFornecedor.ImageList = this.imageList1;
            this.btnAddFornecedor.Location = new System.Drawing.Point(451, 100);
            this.btnAddFornecedor.Name = "btnAddFornecedor";
            this.btnAddFornecedor.Size = new System.Drawing.Size(26, 26);
            this.btnAddFornecedor.TabIndex = 29;
            this.btnAddFornecedor.UseVisualStyleBackColor = true;
            this.btnAddFornecedor.Click += new System.EventHandler(this.btnAddFornecedor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "addp.png");
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProd.Location = new System.Drawing.Point(14, 100);
            this.txtCodigoProd.MaxLength = 13;
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(113, 25);
            this.txtCodigoProd.TabIndex = 16;
            this.txtCodigoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Código";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Acessórios",
            "Adesivos",
            "Direção",
            "Equipamentos",
            "Motor",
            "Óleos",
            "Peças",
            "Plásticos",
            "Protetores",
            "Rodas"});
            this.cbxTipo.Location = new System.Drawing.Point(343, 47);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(134, 27);
            this.cbxTipo.TabIndex = 14;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFornecedor.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(214, 100);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(231, 26);
            this.cbxFornecedor.TabIndex = 13;
            this.cbxFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbxFornecedor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fornecedor";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.nudPrecoVenda);
            this.groupBox1.Controls.Add(this.nudPrecoCompra);
            this.groupBox1.Controls.Add(this.rtxtDescricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Valores]";
            // 
            // nudPrecoVenda
            // 
            this.nudPrecoVenda.DecimalPlaces = 2;
            this.nudPrecoVenda.Location = new System.Drawing.Point(167, 54);
            this.nudPrecoVenda.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPrecoVenda.Name = "nudPrecoVenda";
            this.nudPrecoVenda.Size = new System.Drawing.Size(131, 26);
            this.nudPrecoVenda.TabIndex = 23;
            this.nudPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPrecoCompra
            // 
            this.nudPrecoCompra.DecimalPlaces = 2;
            this.nudPrecoCompra.Location = new System.Drawing.Point(14, 55);
            this.nudPrecoCompra.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPrecoCompra.Name = "nudPrecoCompra";
            this.nudPrecoCompra.Size = new System.Drawing.Size(131, 26);
            this.nudPrecoCompra.TabIndex = 22;
            this.nudPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.Location = new System.Drawing.Point(314, 25);
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(163, 63);
            this.rtxtDescricao.TabIndex = 4;
            this.rtxtDescricao.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço de Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preço de Venda";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.picbxProduto);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(519, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 249);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Foto ]";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 204);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(87, 33);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(150, 204);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 33);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // picbxProduto
            // 
            this.picbxProduto.Image = global::appSGCM.Properties.Resources.pictureboxinitial;
            this.picbxProduto.InitialImage = global::appSGCM.Properties.Resources.pictureboxinitial;
            this.picbxProduto.Location = new System.Drawing.Point(12, 24);
            this.picbxProduto.Name = "picbxProduto";
            this.picbxProduto.Size = new System.Drawing.Size(225, 174);
            this.picbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxProduto.TabIndex = 0;
            this.picbxProduto.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnCadastrar);
            this.groupBox3.Location = new System.Drawing.Point(12, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 56);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(616, 16);
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
            this.btnCadastrar.Location = new System.Drawing.Point(50, 16);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 30);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.Filter = "Imagens (*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP;*.JPG;*.GIF;*.PNG)";
            this.ofdFoto.ReadOnlyChecked = true;
            this.ofdFoto.RestoreDirectory = true;
            this.ofdFoto.ShowReadOnly = true;
            this.ofdFoto.Title = "Selecionar Imagem";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbDataAtualizacao);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 48);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "[ Última Atualização ]";
            // 
            // lbDataAtualizacao
            // 
            this.lbDataAtualizacao.AutoSize = true;
            this.lbDataAtualizacao.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDataAtualizacao.Location = new System.Drawing.Point(711, 21);
            this.lbDataAtualizacao.Name = "lbDataAtualizacao";
            this.lbDataAtualizacao.Size = new System.Drawing.Size(40, 18);
            this.lbDataAtualizacao.TabIndex = 1;
            this.lbDataAtualizacao.Text = "Data";
            // 
            // frmCadastroProduto
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(783, 383);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCompra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbxProduto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lbQtd;
        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox picbxProduto;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddFornecedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbDataAtualizacao;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
        private System.Windows.Forms.NumericUpDown nudPrecoVenda;
        private System.Windows.Forms.NumericUpDown nudPrecoCompra;
    }
}