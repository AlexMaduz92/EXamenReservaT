namespace Presentacion
{
    partial class PNTeatro
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
            this.TXTASIENTO = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CLIENTES = new System.Windows.Forms.Label();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.DGVTEATRO = new System.Windows.Forms.DataGridView();
            this.teatroIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTeatroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTeatroesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exaIIRADDataSet3 = new Presentacion.ExaIIRADDataSet3();
            this.dTeatroesTableAdapter = new Presentacion.ExaIIRADDataSet3TableAdapters.DTeatroesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTEATRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTeatroesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTASIENTO
            // 
            this.TXTASIENTO.Location = new System.Drawing.Point(206, 105);
            this.TXTASIENTO.Name = "TXTASIENTO";
            this.TXTASIENTO.Size = new System.Drawing.Size(150, 20);
            this.TXTASIENTO.TabIndex = 34;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(206, 72);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(150, 20);
            this.TXTNOMBRE.TabIndex = 33;
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTID.Location = new System.Drawing.Point(55, 45);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 22);
            this.TXTID.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Asiento disponible:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre del teatro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID:";
            // 
            // CLIENTES
            // 
            this.CLIENTES.AutoSize = true;
            this.CLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTES.Location = new System.Drawing.Point(140, 9);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Size = new System.Drawing.Size(103, 25);
            this.CLIENTES.TabIndex = 28;
            this.CLIENTES.Text = "TEATRO";
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(240, 145);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BTNELIMINAR.TabIndex = 37;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Location = new System.Drawing.Point(145, 145);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BTNMODIFICAR.TabIndex = 36;
            this.BTNMODIFICAR.Text = "Modificar";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(47, 145);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.BTNGUARDAR.TabIndex = 35;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            // 
            // DGVTEATRO
            // 
            this.DGVTEATRO.AllowUserToDeleteRows = false;
            this.DGVTEATRO.AutoGenerateColumns = false;
            this.DGVTEATRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTEATRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teatroIdDataGridViewTextBoxColumn,
            this.nombreTeatroDataGridViewTextBoxColumn,
            this.numeroAsientoDataGridViewTextBoxColumn});
            this.DGVTEATRO.DataSource = this.dTeatroesBindingSource;
            this.DGVTEATRO.Location = new System.Drawing.Point(10, 174);
            this.DGVTEATRO.Name = "DGVTEATRO";
            this.DGVTEATRO.ReadOnly = true;
            this.DGVTEATRO.Size = new System.Drawing.Size(346, 264);
            this.DGVTEATRO.TabIndex = 38;
            this.DGVTEATRO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTEATRO_CellContentClick);
            // 
            // teatroIdDataGridViewTextBoxColumn
            // 
            this.teatroIdDataGridViewTextBoxColumn.DataPropertyName = "TeatroId";
            this.teatroIdDataGridViewTextBoxColumn.HeaderText = "TeatroId";
            this.teatroIdDataGridViewTextBoxColumn.Name = "teatroIdDataGridViewTextBoxColumn";
            this.teatroIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreTeatroDataGridViewTextBoxColumn
            // 
            this.nombreTeatroDataGridViewTextBoxColumn.DataPropertyName = "NombreTeatro";
            this.nombreTeatroDataGridViewTextBoxColumn.HeaderText = "NombreTeatro";
            this.nombreTeatroDataGridViewTextBoxColumn.Name = "nombreTeatroDataGridViewTextBoxColumn";
            this.nombreTeatroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroAsientoDataGridViewTextBoxColumn
            // 
            this.numeroAsientoDataGridViewTextBoxColumn.DataPropertyName = "NumeroAsiento";
            this.numeroAsientoDataGridViewTextBoxColumn.HeaderText = "NumeroAsiento";
            this.numeroAsientoDataGridViewTextBoxColumn.Name = "numeroAsientoDataGridViewTextBoxColumn";
            this.numeroAsientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTeatroesBindingSource
            // 
            this.dTeatroesBindingSource.DataMember = "DTeatroes";
            this.dTeatroesBindingSource.DataSource = this.exaIIRADDataSet3;
            // 
            // exaIIRADDataSet3
            // 
            this.exaIIRADDataSet3.DataSetName = "ExaIIRADDataSet3";
            this.exaIIRADDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTeatroesTableAdapter
            // 
            this.dTeatroesTableAdapter.ClearBeforeFill = true;
            // 
            // PNTeatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.DGVTEATRO);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNMODIFICAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.TXTASIENTO);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLIENTES);
            this.Name = "PNTeatro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNTeatro";
            this.Load += new System.EventHandler(this.PTeatro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTEATRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTeatroesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTASIENTO;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CLIENTES;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.DataGridView DGVTEATRO;
        private ExaIIRADDataSet3 exaIIRADDataSet3;
        private System.Windows.Forms.BindingSource dTeatroesBindingSource;
        private ExaIIRADDataSet3TableAdapters.DTeatroesTableAdapter dTeatroesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teatroIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTeatroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAsientoDataGridViewTextBoxColumn;
    }
}