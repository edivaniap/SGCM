using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSGCM.UI
{
    public partial class frmInformativo : Form
    {
        public frmInformativo()
        {
            InitializeComponent();
            lbInfo.Text = "Sistema desenvolvido pelos alunos: Edivânia Pontes de Oliveira," + Environment.NewLine +
                          "                                   Francisco Cleiton Soares Barbosa e" + Environment.NewLine +
                          "                                   Lucas Ramon Bandeira da Silva," + Environment.NewLine + Environment.NewLine +
                          "Durante o período letivo de 2012.1/2012.2  do curso de Informática Integrado," + Environment.NewLine +
                          "turma 3AV, no Instituto Federal do Rio Grande do Norte - Campus João Câmara," + Environment.NewLine +
                          "orientado pelo professor Edmilson Barbalho Campos Neto.";
        }
    }
}
