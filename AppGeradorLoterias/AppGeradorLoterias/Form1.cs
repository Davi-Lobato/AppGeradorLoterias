using AppGeradorLoterias.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLotoFacil_Click(object sender, EventArgs e)
        {
            FormLotoFacil form = new FormLotoFacil();
            form.ShowDialog();
        }

        private void btMega_Click(object sender, EventArgs e)
        {
            FormMegaSena form = new FormMegaSena();
            form.ShowDialog();
        }
    }
}
