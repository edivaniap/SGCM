namespace appSGCM.UI
{
    partial class frmCadastroServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroServico));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.lbNome = new System.Windows.Forms.Label();
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBoxProduto.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnCadastrar);
            this.groupBox3.Location = new System.Drawing.Point(15, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 56);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(337, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "addp.png");
            // 
            // ofdFoto
            // 
            this.ofdFoto.Filter = "Imagens (*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP;*.JPG;*.GIF;*.PNG)";
            this.ofdFoto.ReadOnlyChecked = true;
            this.ofdFoto.RestoreDirectory = true;
            this.ofdFoto.ShowReadOnly = true;
            this.ofdFoto.Title = "Selecionar Imagem";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(159, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(80, 18);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Descrição";
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.BackColor = System.Drawing.Color.DarkRed;
            this.groupBoxProduto.Controls.Add(this.rtxtDescricao);
            this.groupBoxProduto.Controls.Add(this.txtTipo);
            this.groupBoxProduto.Controls.Add(this.lbTipo);
            this.groupBoxProduto.Controls.Add(this.lbNome);
            this.groupBoxProduto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduto.ForeColor = System.Drawing.Color.White;
            this.groupBoxProduto.Location = new System.Drawing.Point(15, 13);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(466, 135);
            this.groupBoxProduto.TabIndex = 31;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "[ Serviço ]";
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.Location = new System.Drawing.Point(162, 43);
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(293, 66);
            this.rtxtDescricao.TabIndex = 6;
            this.rtxtDescricao.Text = "";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(10, 44);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(142, 26);
            this.txtTipo.TabIndex = 5;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.Color.White;
            this.lbTipo.Location = new System.Drawing.Point(6, 22);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(40, 18);
            this.lbTipo.TabIndex = 4;
            this.lbTipo.Text = "Tipo";
            // 
            // frmCadastroServico
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(496, 221);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadastroServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Cadastro de Serviço";
            this.groupBox3.ResumeLayout(false);
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
    }
}