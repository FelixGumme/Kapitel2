using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning2._3
{
    public partial class Form1 : Form
    {
        List<Bank> bankLista = new List<Bank>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIntättning_Click(object sender, EventArgs e)
        {

        }

        private void BtnUttag_Click(object sender, EventArgs e)
        {
            if(lbxKonto.SelectedIndex != null)
            {

            }
        }

        private void BtnRegistrera_Click(object sender, EventArgs e)
        {

        }

        private void BtnUppdatera_Click(object sender, EventArgs e)
        {

        }
    }
}
