namespace PryVelezFunesSP1H1
{
    partial class frmLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalidad));
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.mskIdentificador = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblLocalidad
            // 
            resources.ApplyResources(this.lblLocalidad, "lblLocalidad");
            this.lblLocalidad.Name = "lblLocalidad";
            // 
            // txtLocalidad
            // 
            resources.ApplyResources(this.txtLocalidad, "txtLocalidad");
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.TextChanged += new System.EventHandler(this.txtLocalidad_TextChanged);
            // 
            // cmdCargar
            // 
            resources.ApplyResources(this.cmdCargar, "cmdCargar");
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdLimpiar
            // 
            resources.ApplyResources(this.cmdLimpiar, "cmdLimpiar");
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // lblIdentificador
            // 
            resources.ApplyResources(this.lblIdentificador, "lblIdentificador");
            this.lblIdentificador.Name = "lblIdentificador";
            // 
            // mskIdentificador
            // 
            resources.ApplyResources(this.mskIdentificador, "mskIdentificador");
            this.mskIdentificador.Name = "mskIdentificador";
            this.mskIdentificador.TextChanged += new System.EventHandler(this.mskIdentificador_TextChanged);
            // 
            // frmLocalidad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mskIdentificador);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Name = "frmLocalidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.MaskedTextBox mskIdentificador;
    }
}