using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo_WF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            c = Convert.ToInt32(txtC.Text);

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                MessageBox.Show("Representam os lados de um triângulo.");
            }
            else
            {
                MessageBox.Show("Não representam os lados de um triângulo.");
            }
        }
    }
}