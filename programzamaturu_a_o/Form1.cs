using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programzamaturu_a_o
{
    public partial class Form1 : Form
    {
        public class Ucenik
        {
            public string ime, prezime, odelnje, skola, prvi_predmet, drugi_predmet, treci_predmet, jezik;
            public void unos(string ime, string prezime, string odelnje, string skola, string prvi_predmet, string drugi_predmet, string treci_predmet, string jezik)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.odelnje = odelnje;
                this.skola = skola;
                this.prvi_predmet = prvi_predmet;
                this.drugi_predmet = drugi_predmet;
                this.treci_predmet = treci_predmet;
                this.jezik = jezik;
            }
            public string ispis()
            {
                return ime + " " + prezime + " " + odelnje + " " + skola;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
