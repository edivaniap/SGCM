using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Servico
    {
        private int codigo;
        private string tipo;
        private string descricao;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
