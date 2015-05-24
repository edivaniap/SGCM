using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class Funcionario : Pessoa
    {
        private string sexo;
        private DateTime nascimento;
        private string rg;
        private string cpf;
        private string estado_civil;
        private string carteita_trabalho;
        private DateTime expedicao_ct;
        private string nacionalidade;
        private string cargo;
        private string turno;
        private string salario;
        private int dependentes;
        private string horas_diarias;
        private string tipo_contrato;
        private string imagem;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

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

        public string Estado_Civil
        {
            get { return estado_civil; }
            set { estado_civil = value; }
        }

        public string Carteira_Trabalho
        {
            get { return carteita_trabalho; }
            set { carteita_trabalho = value; }
        }

        public DateTime Expedicao_CT
        {
            get { return expedicao_ct; }
            set { expedicao_ct = value; }
        }

        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public int Dependentes
        {
            get { return dependentes; }
            set { dependentes = value; }
        }

        public string Horas_Diarias
        {
            get { return horas_diarias; }
            set { horas_diarias = value; }
        }

        public string Tipo_Contrato
        {
            get { return tipo_contrato; }
            set { tipo_contrato = value; }
        }

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }
    }
}
