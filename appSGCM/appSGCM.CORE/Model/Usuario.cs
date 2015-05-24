using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Usuario
    {
        private string login;
        private string senha;
        private string tipo;
        private int codigo;
        private int codFuncionario;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int CodFuncionario
        {
            get { return codFuncionario; }
            set { codFuncionario = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        } 
    }
}
