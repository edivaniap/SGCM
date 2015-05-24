using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class ProdutoVendido
    {
        private int codProdVendido;
        private int codVenda;
        private int codProduto;
        private int quantidade;

        public int CodProdVendido
        {
            get { return codProdVendido;}
            set { codProdVendido = value; }
        }

        public int CodVenda
        {
            get { return codVenda; }
            set { codVenda = value; }
        }

        public int CodProduto
        {
            get { return codProduto; }
            set { codProduto = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
}
