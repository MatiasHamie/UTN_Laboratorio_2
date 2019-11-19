namespace _20190711_Final
{
    partial class FrmAerolinea
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudHorasDeVuelo = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasDeVuelo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(223, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Horas de vuelo";
            // 
            // nudHorasDeVuelo
            // 
            this.nudHorasDeVuelo.Location = new System.Drawing.Point(97, 30);
            this.nudHorasDeVuelo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHorasDeVuelo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHorasDeVuelo.Name = "nudHorasDeVuelo";
            this.nudHorasDeVuelo.Size = new System.Drawing.Size(120, 20);
            this.nudHorasDeVuelo.TabIndex = 2;
            this.nudHorasDeVuelo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem,
            this.binarioToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem1,
            this.binarioToolStripMenuItem1,
            this.xMLToolStripMenuItem1});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // binarioToolStripMenuItem
            // 
            this.binarioToolStripMenuItem.Name = "binarioToolStripMenuItem";
            this.binarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binarioToolStripMenuItem.Text = "Binario";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // baseDeDatosToolStripMenuItem1
            // 
            this.baseDeDatosToolStripMenuItem1.Name = "baseDeDatosToolStripMenuItem1";
            this.baseDeDatosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.baseDeDatosToolStripMenuItem1.Text = "Base de Datos";
            // 
            // binarioToolStripMenuItem1
            // 
            this.binarioToolStripMenuItem1.Name = "binarioToolStripMenuItem1";
            this.binarioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.binarioToolStripMenuItem1.Text = "Binario";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // FrmAerolinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 422);
            this.Controls.Add(this.nudHorasDeVuelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAerolinea";
            this.Text = "Aero UTN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAerolinea_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasDeVuelo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHorasDeVuelo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
    }
}

