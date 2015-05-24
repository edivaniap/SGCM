using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Venda
    {
        private int codVenda;
        private int codCliente;
        private int codFuncionario;
        private int codEmpresa;
        private int codServico;
        private string valorVenda;
        private string dataHora;

        public int CodVenda
        {
            get { return codVenda; }
            set { codVenda = value; }
        }

        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public int CodFuncionario
        {
            get { return codFuncionario; }
            set { codFuncionario = value; }
        }

        public int CodEmpresa
        {
            get { return codEmpresa; }
            set { codEmpresa = value; }
        }

        public int CodServico
        {
            get { return codServico; }
            set { codServico= value; }
        }

        public string ValorVenda
        {
            get { return valorVenda; }
            set { valorVenda = value; }
        }

        public string DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }
    }
}
