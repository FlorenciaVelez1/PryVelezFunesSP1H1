
namespace PryVelezFunesSP1H1
{
    partial class frmProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduccion));
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.mskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdLimpiar.Location = new System.Drawing.Point(19, 199);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(83, 33);
            this.cmdLimpiar.TabIndex = 5;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdCargar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdCargar.Location = new System.Drawing.Point(173, 199);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(83, 33);
            this.cmdCargar.TabIndex = 6;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(15, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 18);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCantidad.Location = new System.Drawing.Point(15, 155);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 18);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLocalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLocalidad.Location = new System.Drawing.Point(15, 66);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(71, 18);
            this.lblLocalidad.TabIndex = 13;
            this.lblLocalidad.Text = "Localidad";
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(109, 21);
            this.mskDate.Margin = new System.Windows.Forms.Padding(4);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(145, 22);
            this.mskDate.TabIndex = 1;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivo.Location = new System.Drawing.Point(15, 111);
            this.lblCultivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(53, 18);
            this.lblCultivo.TabIndex = 18;
            this.lblCultivo.Text = "Cultivo";
            // 
            // mskCantidad
            // 
            this.mskCantidad.Location = new System.Drawing.Point(109, 154);
            this.mskCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.mskCantidad.Name = "mskCantidad";
            this.mskCantidad.Size = new System.Drawing.Size(145, 22);
            this.mskCantidad.TabIndex = 4;
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(109, 60);
            this.lstLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(145, 24);
            this.lstLocalidad.TabIndex = 2;
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(109, 105);
            this.lstCultivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(145, 24);
            this.lstCultivo.TabIndex = 3;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 246);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.mskCantidad);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.mskDate);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.MaskedTextBox mskCantidad;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.ComboBox lstCultivo;
    }
}