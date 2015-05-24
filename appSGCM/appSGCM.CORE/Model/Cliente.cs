using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Cliente : Pessoa
    {
        private DateTime nascimento;
        private string rg;
        private string cpf;
        private string sexo;

        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
