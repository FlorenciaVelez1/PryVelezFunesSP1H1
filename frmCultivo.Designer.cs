namespace PryVelezFunesSP1H1
{
    partial class frmCultivos
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
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.txtCultivo = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.mskIdentificador = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdLimpiar.Location = new System.Drawing.Point(11, 95);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(62, 27);
            this.cmdLimpiar.TabIndex = 3;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Enabled = false;
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdCargar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdCargar.Location = new System.Drawing.Point(137, 94);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(62, 27);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCultivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCultivo.Location = new System.Drawing.Point(9, 58);
            this.lblCultivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(43, 15);
            this.lblCultivo.TabIndex = 9;
            this.lblCultivo.Text = "Cultivo";
            // 
            // txtCultivo
            // 
            this.txtCultivo.Location = new System.Drawing.Point(91, 58);
            this.txtCultivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCultivo.Name = "txtCultivo";
            this.txtCultivo.Size = new System.Drawing.Size(110, 20);
            this.txtCultivo.TabIndex = 2;
            this.txtCultivo.TextChanged += new System.EventHandler(this.txtCultivo_TextChanged);
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblIdentificador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIdentificador.Location = new System.Drawing.Point(9, 24);
            this.lblIdentificador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(74, 15);
            this.lblIdentificador.TabIndex = 7;
            this.lblIdentificador.Text = "Identificador";
            // 
            // mskIdentificador
            // 
            this.mskIdentificador.Location = new System.Drawing.Point(91, 24);
            this.mskIdentificador.Margin = new System.Windows.Forms.Padding(2);
            this.mskIdentificador.Mask = "99999";
            this.mskIdentificador.Name = "mskIdentificador";
            this.mskIdentificador.Size = new System.Drawing.Size(110, 20);
            this.mskIdentificador.TabIndex = 1;
            this.mskIdentificador.ValidatingType = typeof(int);
            this.mskIdentificador.TextChanged += new System.EventHandler(this.mskIdentidicador_TextChanged);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 130);
            this.Controls.Add(this.mskIdentificador);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.txtCultivo);
            this.Controls.Add(this.lblIdentificador);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCultivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cultivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.TextBox txtCultivo;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.MaskedTextBox mskIdentificador;
    }
}