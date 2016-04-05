namespace opdrachtenweek3.Views
{
    partial class Controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNextStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNextStation
            // 
            this.btnNextStation.Location = new System.Drawing.Point(92, 132);
            this.btnNextStation.Name = "btnNextStation";
            this.btnNextStation.Size = new System.Drawing.Size(75, 23);
            this.btnNextStation.TabIndex = 0;
            this.btnNextStation.Text = "button1";
            this.btnNextStation.UseVisualStyleBackColor = true;
            this.btnNextStation.Click += new System.EventHandler(this.btnNextStation_Click);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnNextStation);
            this.Name = "Controller";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.Controller_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNextStation;
    }
}