using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using versie2.Controllers;


namespace opdrachtenweek3.Models
{
    public partial class TreinDisplay : Form, ITreinDisplay
    {
        private Label lblHuidigeStation;
        
        private Button btnVolgendeStation;
        ITreinReis treinreis;

        public TreinDisplay(ITreinReis treinreis, ITreinController treincontroller)
        {
            InitializeComponent();

            this.treinreis = treinreis;
            this.treinreis.AddDisplay(this);
            this.treincontroller = treincontroller;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void Update(int huidigstation)
        {
            lblHuidigeStation.Text = huidigstation.ToString();
        }

        private void InitializeComponent()
        {
            this.lblHuidigeStation = new System.Windows.Forms.Label();
            this.btnVolgendeStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHuidigeStation
            // 
            this.lblHuidigeStation.AutoSize = true;
            this.lblHuidigeStation.Location = new System.Drawing.Point(258, 89);
            this.lblHuidigeStation.Name = "lblHuidigeStation";
            this.lblHuidigeStation.Size = new System.Drawing.Size(35, 13);
            this.lblHuidigeStation.TabIndex = 0;
            this.lblHuidigeStation.Text = "label1";
            // 
            // btnVolgendeStation
            // 
            this.btnVolgendeStation.Location = new System.Drawing.Point(360, 148);
            this.btnVolgendeStation.Name = "btnVolgendeStation";
            this.btnVolgendeStation.Size = new System.Drawing.Size(75, 23);
            this.btnVolgendeStation.TabIndex = 1;
            this.btnVolgendeStation.Text = "button1";
            this.btnVolgendeStation.UseVisualStyleBackColor = true;
            this.btnVolgendeStation.Click += new System.EventHandler(this.btnVolgendeStation_Click_1);
            // 
            // TreinDisplay
            // 
            this.ClientSize = new System.Drawing.Size(653, 477);
            this.Controls.Add(this.btnVolgendeStation);
            this.Controls.Add(this.lblHuidigeStation);
            this.Name = "TreinDisplay";
            this.Load += new System.EventHandler(this.TreinDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TreinDisplay_Load(object sender, EventArgs e)
        {

        }

        private void btnVolgendeStation_Click_1(object sender, EventArgs e)
        {
            treincontroller.VolgendeStation();
        }
    }
}
