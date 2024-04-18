namespace Presentacion
{
    partial class PMENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMENU));
            this.BTNCLIENTE = new System.Windows.Forms.Button();
            this.BTNTEATRO = new System.Windows.Forms.Button();
            this.BTNRESERVAR = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNCLIENTE
            // 
            this.BTNCLIENTE.BackColor = System.Drawing.Color.OldLace;
            this.BTNCLIENTE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNCLIENTE.Location = new System.Drawing.Point(212, 12);
            this.BTNCLIENTE.Name = "BTNCLIENTE";
            this.BTNCLIENTE.Size = new System.Drawing.Size(190, 59);
            this.BTNCLIENTE.TabIndex = 0;
            this.BTNCLIENTE.Text = "CLIENTE";
            this.BTNCLIENTE.UseVisualStyleBackColor = false;
            // 
            // BTNTEATRO
            // 
            this.BTNTEATRO.BackColor = System.Drawing.Color.OldLace;
            this.BTNTEATRO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNTEATRO.Location = new System.Drawing.Point(212, 87);
            this.BTNTEATRO.Name = "BTNTEATRO";
            this.BTNTEATRO.Size = new System.Drawing.Size(190, 59);
            this.BTNTEATRO.TabIndex = 1;
            this.BTNTEATRO.Text = "TEATRO";
            this.BTNTEATRO.UseVisualStyleBackColor = false;
            // 
            // BTNRESERVAR
            // 
            this.BTNRESERVAR.BackColor = System.Drawing.Color.OldLace;
            this.BTNRESERVAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNRESERVAR.Location = new System.Drawing.Point(212, 161);
            this.BTNRESERVAR.Name = "BTNRESERVAR";
            this.BTNRESERVAR.Size = new System.Drawing.Size(190, 59);
            this.BTNRESERVAR.TabIndex = 2;
            this.BTNRESERVAR.Text = "RESERVAR";
            this.BTNRESERVAR.UseVisualStyleBackColor = false;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.OldLace;
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNSALIR.Location = new System.Drawing.Point(212, 235);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(190, 59);
            this.BTNSALIR.TabIndex = 3;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            // 
            // PMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(625, 306);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.BTNRESERVAR);
            this.Controls.Add(this.BTNTEATRO);
            this.Controls.Add(this.BTNCLIENTE);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PMENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNCLIENTE;
        private System.Windows.Forms.Button BTNTEATRO;
        private System.Windows.Forms.Button BTNRESERVAR;
        private System.Windows.Forms.Button BTNSALIR;
    }
}