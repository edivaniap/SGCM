namespace appSGCM.UI
{
    partial class frmConsultaProdutos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCampoFiltro = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtCampoFiltro);
            this.groupBox2.Controls.Add(this.cbxFiltro);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Filtro ]";
            // 
            // txtCampoFiltro
            // 
            this.txtCampoFiltro.Location = new System.Drawing.Point(21, 32);
            this.txtCampoFiltro.Name = "txtCampoFiltro";
            this.txtCampoFiltro.Size = new System.Drawing.Size(339, 25);
            this.txtCampoFiltro.TabIndex = 2;
            this.txtCampoFiltro.TextChanged += new System.EventHandler(this.txtCampoFiltro_TextChanged);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CodProduto",
            "Nome",
            "Tipo",
            "CodigoProduto",
            "Descricao",
            "Fornecedor",
            "CodFornecedor",
            "PrecoVenda"});
            this.cbxFiltro.Location = new System.Drawing.Point(366, 31);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(132, 26);
            this.cbxFiltro.TabIndex = 0;
            this.cbxFiltro.TextChanged += new System.EventHandler(this.cbxFiltro_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 469);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 39);
            this.panel1.TabIndex = 11;
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(9, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 29);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(12, 104);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(108, 29);
            this.btnVisualizar.TabIndex = 10;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(12, 228);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(108, 29);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(12, 167);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 29);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(12, 44);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(108, 29);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdicionar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(12, 44);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(108, 29);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Visible = false;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(140, 83);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(633, 469);
            this.dgvProdutos.TabIndex = 5;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbRegistros);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(594, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 59);
            this.panel2.TabIndex = 6;
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Location = new System.Drawing.Point(70, 24);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(16, 18);
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Registros";
            // 
            // frmConsultaProdutos
            // 
            this.AcceptButton = this.btnAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(773, 552);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmConsultaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmConsultaProdutos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCampoFiltro;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.Label label1;
    }
}