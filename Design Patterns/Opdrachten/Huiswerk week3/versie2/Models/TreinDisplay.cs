using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace versie2.Models
{
    class TreinDisplay : Form, ITreinDisplay
    {
        private Label lblHuidigeStation;
        private Label lblVertrek;
        ITreinReis treinreis;

        public TreinDisplay(ITreinReis treinreis)
        {
            InitializeComponent();
            this.treinreis = treinreis;
            this.treinreis.AddDisplay((ITreinDisplay)this);
        }

        public void Update(int huidigstation)
        {
            Station station = treinreis.GetStation(huidigstation);

            lblHuidigeStation.Text = station.station;
            lblVertrek.Text = station.vertrekTijd.ToString();
        }

        private void TreinDisplay_Load(object sender, EventArgs e)
        {
            lblHuidigeStation.Text = "Station 1";
        }

        private void InitializeComponent()
        {
            this.lblHuidigeStation = new System.Windows.Forms.Label();
            this.lblVertrek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHuidigeStation
            // 
            this.lblHuidigeStation.AutoSize = true;
            this.lblHuidigeStation.Location = new System.Drawing.Point(45, 101);
            this.lblHuidigeStation.Name = "lblHuidigeStation";
            this.lblHuidigeStation.Size = new System.Drawing.Size(35, 13);
            this.lblHuidigeStation.TabIndex = 0;
            this.lblHuidigeStation.Text = "label1";
            this.lblHuidigeStation.Click += new System.EventHandler(this.lblHuidigeStation_Click);
            // 
            // lblVertrek
            // 
            this.lblVertrek.AutoSize = true;
            this.lblVertrek.Location = new System.Drawing.Point(188, 101);
            this.lblVertrek.Name = "lblVertrek";
            this.lblVertrek.Size = new System.Drawing.Size(35, 13);
            this.lblVertrek.TabIndex = 1;
            this.lblVertrek.Text = "label1";
            // 
            // TreinDisplay
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblVertrek);
            this.Controls.Add(this.lblHuidigeStation);
            this.Name = "TreinDisplay";
            this.Load += new System.EventHandler(this.TreinDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblHuidigeStation_Click(object sender, EventArgs e)
        {

        }
    }
}
