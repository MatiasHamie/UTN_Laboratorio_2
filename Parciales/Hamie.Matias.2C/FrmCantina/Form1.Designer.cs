namespace FrmCantina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbtnCerveza = new System.Windows.Forms.RadioButton();
            this.rbtnAgua = new System.Windows.Forms.RadioButton();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.nudContenido = new System.Windows.Forms.NumericUpDown();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(178, 325);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(308, 368);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbtnCerveza
            // 
            this.rbtnCerveza.AutoSize = true;
            this.rbtnCerveza.Checked = true;
            this.rbtnCerveza.Location = new System.Drawing.Point(90, 339);
            this.rbtnCerveza.Name = "rbtnCerveza";
            this.rbtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.rbtnCerveza.TabIndex = 3;
            this.rbtnCerveza.TabStop = true;
            this.rbtnCerveza.Text = "Cerveza";
            this.rbtnCerveza.UseVisualStyleBackColor = true;
            // 
            // rbtnAgua
            // 
            this.rbtnAgua.AutoSize = true;
            this.rbtnAgua.Location = new System.Drawing.Point(90, 362);
            this.rbtnAgua.Name = "rbtnAgua";
            this.rbtnAgua.Size = new System.Drawing.Size(50, 17);
            this.rbtnAgua.TabIndex = 4;
            this.rbtnAgua.Text = "Agua";
            this.rbtnAgua.UseVisualStyleBackColor = true;
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(305, 325);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 5;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(308, 341);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(181, 384);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(55, 20);
            this.nudCapacidad.TabIndex = 7;
            this.nudCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudContenido
            // 
            this.nudContenido.Location = new System.Drawing.Point(250, 384);
            this.nudContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContenido.Name = "nudContenido";
            this.nudContenido.Size = new System.Drawing.Size(52, 20);
            this.nudContenido.TabIndex = 8;
            this.nudContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(247, 368);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 10;
            this.lblContenido.Text = "Contenido";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(178, 368);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 9;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(181, 341);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 11;
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(13, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(595, 302);
            this.barra1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 414);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.nudContenido);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.rbtnAgua);
            this.Controls.Add(this.rbtnCerveza);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMarca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbtnCerveza;
        private System.Windows.Forms.RadioButton rbtnAgua;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.NumericUpDown nudContenido;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtMarca;
        private ControlCantina.Barra barra1;
    }
}

