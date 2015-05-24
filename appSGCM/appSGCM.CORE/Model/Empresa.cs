using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Empresa : Pessoa
    {
        private string cnpj;
        private int filiais;
        private string cpf;
        private string rg;
        private string proprietario;

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public int Filiais
        {
            get { return filiais; }
            set { filiais = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Proprietario
        {
            get { return proprietario; }
            set { proprietario = value; }
        }
    }
}
