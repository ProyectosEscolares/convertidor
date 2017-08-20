namespace ProgramaConvertidor
{
    partial class frmPrincipal
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.stRuta = new System.Windows.Forms.StatusStrip();
            this.ruta = new System.Windows.Forms.ToolStripStatusLabel();
            this.stRuta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(23, 57);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(97, 39);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Examinar";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // stRuta
            // 
            this.stRuta.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stRuta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruta});
            this.stRuta.Location = new System.Drawing.Point(0, 625);
            this.stRuta.Name = "stRuta";
            this.stRuta.Size = new System.Drawing.Size(998, 25);
            this.stRuta.TabIndex = 1;
            this.stRuta.Text = "statusStrip1";
            // 
            // ruta
            // 
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(32, 20);
            this.ruta.Text = "._.)/";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 650);
            this.Controls.Add(this.stRuta);
            this.Controls.Add(this.btnAbrir);
            this.Name = "frmPrincipal";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stRuta.ResumeLayout(false);
            this.stRuta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.StatusStrip stRuta;
        private System.Windows.Forms.ToolStripStatusLabel ruta;
    }
}

