using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Agendamento
    {
        private int codigo;
        private int codCliente;
        private string cliente;
        private int codServico;
        private string tipoServico;
        private string descricaoServico;
        private DateTime data;
        private string horario;
        private string status;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public int CodServico
        {
            get { return codServico; }
            set { codServico = value; }
        }

        public string TipoServico
        {
            get { return tipoServico; }
            set { tipoServico = value; }
        }

        public string Descricao
        {
            get { return descricaoServico; }
            set { descricaoServico = value; }
        }
        
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
