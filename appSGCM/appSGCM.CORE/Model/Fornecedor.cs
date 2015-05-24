using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Fornecedor : Pessoa
    {
        private string cnpj;

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}
