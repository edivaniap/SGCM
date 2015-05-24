using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public abstract class Pessoa
    {
        private string nome;
        private string endereco;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private string celular;
        private string telefone;
        private string email;
        private string site;
        private string facebook;
        private int codigo;
        private string dataAtualizacao;
 
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

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }

        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Site
        {
            get { return site; }
            set { site = value; }
        }

        public string Facebook
        {
            get { return facebook; }
            set { facebook = value; }
        }

        public string DataAtualizacao
        {
            get { return dataAtualizacao; }
            set { dataAtualizacao = value; }
        }
    }
}
