namespace ClinicaFrba.Compra_Bono
{
    partial class FrmComprarBono
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
            this.tbNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.lblNumeroAfiliado = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblResultadoImporte = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.numCantidadBonos = new System.Windows.Forms.NumericUpDown();
            this.tbImporteTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAfilado = new System.Windows.Forms.Label();
            this.epNroAfiliadoNull = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadBonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNroAfiliadoNull)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumeroAfiliado
            // 
            this.tbNumeroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroAfiliado.Location = new System.Drawing.Point(172, 20);
            this.tbNumeroAfiliado.MaxLength = 10;
            this.tbNumeroAfiliado.Name = "tbNumeroAfiliado";
            this.tbNumeroAfiliado.ShortcutsEnabled = false;
            this.tbNumeroAfiliado.Size = new System.Drawing.Size(106, 26);
            this.tbNumeroAfiliado.TabIndex = 0;
            this.tbNumeroAfiliado.TextChanged += new System.EventHandler(this.tbNumeroAfiliado_TextChanged);
            this.tbNumeroAfiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroAfiliado_KeyPress);
            this.tbNumeroAfiliado.Validated += new System.EventHandler(this.tbNumeroAfiliado_Validated);
            // 
            // lblNumeroAfiliado
            // 
            this.lblNumeroAfiliado.AutoSize = true;
            this.lblNumeroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAfiliado.Location = new System.Drawing.Point(12, 20);
            this.lblNumeroAfiliado.Name = "lblNumeroAfiliado";
            this.lblNumeroAfiliado.Size = new System.Drawing.Size(86, 20);
            this.lblNumeroAfiliado.TabIndex = 2;
            this.lblNumeroAfiliado.Text = "Nº Afiliado:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(12, 113);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(68, 20);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe:";
            // 
            // lblResultadoImporte
            // 
            this.lblResultadoImporte.AutoSize = true;
            this.lblResultadoImporte.Location = new System.Drawing.Point(87, 123);
            this.lblResultadoImporte.Name = "lblResultadoImporte";
            this.lblResultadoImporte.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoImporte.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(69, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 32);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Comprar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(181, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 32);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // numCantidadBonos
            // 
            this.numCantidadBonos.Enabled = false;
            this.numCantidadBonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidadBonos.Location = new System.Drawing.Point(172, 63);
            this.numCantidadBonos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCantidadBonos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidadBonos.Name = "numCantidadBonos";
            this.numCantidadBonos.Size = new System.Drawing.Size(106, 26);
            this.numCantidadBonos.TabIndex = 9;
            this.numCantidadBonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCantidadBonos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidadBonos.ValueChanged += new System.EventHandler(this.numCantidadBonos_ValueChanged);
            // 
            // tbImporteTotal
            // 
            this.tbImporteTotal.Enabled = false;
            this.tbImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImporteTotal.Location = new System.Drawing.Point(172, 110);
            this.tbImporteTotal.Name = "tbImporteTotal";
            this.tbImporteTotal.Size = new System.Drawing.Size(106, 26);
            this.tbImporteTotal.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "$";
            // 
            // lblAfilado
            // 
            this.lblAfilado.AutoSize = true;
            this.lblAfilado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfilado.Location = new System.Drawing.Point(15, 20);
            this.lblAfilado.Name = "lblAfilado";
            this.lblAfilado.Size = new System.Drawing.Size(272, 16);
            this.lblAfilado.TabIndex = 12;
            this.lblAfilado.Text = "Seleccione la cantidad de bonos  a comprar";
            this.lblAfilado.Visible = false;
            // 
            // epNroAfiliadoNull
            // 
            this.epNroAfiliadoNull.ContainerControl = this;
            // 
            // FrmComprarBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 226);
            this.Controls.Add(this.lblAfilado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbImporteTotal);
            this.Controls.Add(this.numCantidadBonos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblResultadoImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNumeroAfiliado);
            this.Controls.Add(this.tbNumeroAfiliado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmComprarBono";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "COMPRAR BONOS";
            this.Load += new System.EventHandler(this.FrmComprarBono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadBonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNroAfiliadoNull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumeroAfiliado;
        private System.Windows.Forms.Label lblNumeroAfiliado;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblResultadoImporte;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown numCantidadBonos;
        private System.Windows.Forms.TextBox tbImporteTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAfilado;
        private System.Windows.Forms.ErrorProvider epNroAfiliadoNull;
    }
}