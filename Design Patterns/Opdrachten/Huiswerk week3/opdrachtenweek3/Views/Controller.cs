using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using opdrachtenweek3.Models;
using opdrachtenweek3.Controllers;

namespace opdrachtenweek3.Views
{
    public partial class Controller : Form
    {
        
        TreinController controller = new TreinController();

        public Controller()
        {
            InitializeComponent();
        }

        private void Controller_Load(object sender, EventArgs e)
        {

        }

        private void btnNextStation_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
