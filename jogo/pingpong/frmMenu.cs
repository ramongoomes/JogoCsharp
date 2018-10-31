using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnIniciante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(200);
            frm1.Show();
        }

        private void btnIntermediario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(100);
            frm1.Show();
        }

        private void btnAvançado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(50);
            frm1.Show();
        }
    }
}
