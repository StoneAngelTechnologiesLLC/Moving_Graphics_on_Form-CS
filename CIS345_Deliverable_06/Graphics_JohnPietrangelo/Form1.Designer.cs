namespace Graphics_JohnPietrangelo
{
    partial class graphicsFrm
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
            this.components = new System.ComponentModel.Container();
            this.movementCounterTmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // movementCounterTmr
            // 
            this.movementCounterTmr.Enabled = true;
            this.movementCounterTmr.Interval = 10;
            this.movementCounterTmr.Tick += new System.EventHandler(this.MovementToThe_TickTockAndWeDontStop);
            // 
            // graphicsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Name = "graphicsFrm";
            this.Text = "Graphics_Practice";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.whichWayDidHeGoGeorge_ManDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer movementCounterTmr;
    }
}

