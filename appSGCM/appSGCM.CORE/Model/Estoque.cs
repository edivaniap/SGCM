using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Estoque
    {
        private List<Produto> produtos;

        public Estoque()
        {
            produtos = new List<Produto>();
        }

        public List<Produto> Produtos
        {
            get { return produtos; }
        }
    }
}
