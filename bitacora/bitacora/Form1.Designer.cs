namespace bitacora
{
    partial class Bitacora
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
            this.navegadorDiseño1 = new Navegador.navegadorDiseño();
            this.SuspendLayout();
            // 
            // navegadorDiseño1
            // 
            this.navegadorDiseño1.BackColor = System.Drawing.Color.Gainsboro;
            this.navegadorDiseño1.Location = new System.Drawing.Point(1, -1);
            this.navegadorDiseño1.Name = "navegadorDiseño1";
            this.navegadorDiseño1.Size = new System.Drawing.Size(827, 63);
            this.navegadorDiseño1.TabIndex = 0;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(153)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.navegadorDiseño1);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.navegadorDiseño navegadorDiseño1;
    }
}