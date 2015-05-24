using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Produto
    {
        private string nome;
        private string tipo;
        private string fornecedor;
        private int codFornecedor;
        private int quantidade;
        private decimal codigo_barras;
        private string preco_venda;
        private string preco_compra;
        private int codigo;
        private string dataAtualizacao;
        private string descricao;
        private string imagem;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int CodFornecedor
        {
            get { return codFornecedor; }
            set { codFornecedor = value; }
        }

        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value;  }
        }
        
        public decimal Codigo_Barras
        {
            get { return codigo_barras; }
            set { codigo_barras = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string Preco_Compra
        {
            get { return preco_compra; }
            set { preco_compra = value; }
        }

        public string Preco_Venda
        {
            get { return preco_venda; }
            set { preco_venda = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string DataAtualizacao
        {
            get { return dataAtualizacao; }
            set { dataAtualizacao = value; }
        }

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }
    }
}
