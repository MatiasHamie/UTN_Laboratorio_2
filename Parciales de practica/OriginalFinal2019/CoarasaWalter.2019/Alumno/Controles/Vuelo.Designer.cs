namespace Controles
{
    partial class Vuelo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vuelo));
            this.picDeparture = new System.Windows.Forms.PictureBox();
            this.picArrival = new System.Windows.Forms.PictureBox();
            this.picAvion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDeparture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // picDeparture
            // 
            this.picDeparture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picDeparture.ErrorImage")));
            this.picDeparture.Image = ((System.Drawing.Image)(resources.GetObject("picDeparture.Image")));
            this.picDeparture.Location = new System.Drawing.Point(3, 3);
            this.picDeparture.Name = "picDeparture";
            this.picDeparture.Size = new System.Drawing.Size(49, 48);
            this.picDeparture.TabIndex = 0;
            this.picDeparture.TabStop = false;
            // 
            // picArrival
            // 
            this.picArrival.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picArrival.ErrorImage")));
            this.picArrival.Image = ((System.Drawing.Image)(resources.GetObject("picArrival.Image")));
            this.picArrival.Location = new System.Drawing.Point(778, 3);
            this.picArrival.Name = "picArrival";
            this.picArrival.Size = new System.Drawing.Size(49, 48);
            this.picArrival.TabIndex = 1;
            this.picArrival.TabStop = false;
            // 
            // picAvion
            // 
            this.picAvion.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picAvion.ErrorImage")));
            this.picAvion.Image = ((System.Drawing.Image)(resources.GetObject("picAvion.Image")));
            this.picAvion.Location = new System.Drawing.Point(58, 3);
            this.picAvion.Name = "picAvion";
            this.picAvion.Size = new System.Drawing.Size(49, 48);
            this.picAvion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvion.TabIndex = 2;
            this.picAvion.TabStop = false;
            this.picAvion.Visible = false;
            // 
            // Vuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picAvion);
            this.Controls.Add(this.picArrival);
            this.Controls.Add(this.picDeparture);
            this.Name = "Vuelo";
            this.Size = new System.Drawing.Size(830, 54);
            ((System.ComponentModel.ISupportInitialize)(this.picDeparture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDeparture;
        private System.Windows.Forms.PictureBox picArrival;
        private System.Windows.Forms.PictureBox picAvion;
    }
}
