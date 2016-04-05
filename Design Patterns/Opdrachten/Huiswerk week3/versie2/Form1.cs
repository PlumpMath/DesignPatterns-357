using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using versie2.Controllers;
using versie2.Models;


namespace versie2
{
    public partial class Form1 : Form
    {
        private ITreinReis treinreis;
        private ITreinController controller;

        public Form1(ITreinController controller, ITreinReis treinreis)
        {
            InitializeComponent();
            this.controller = controller;
            this.treinreis = treinreis;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVolgendeStation_Click(object sender, EventArgs e)
        {
            controller.VolgendeStation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreinDisplay display = new TreinDisplay(treinreis);
            display.Show();
        }
    }
}
