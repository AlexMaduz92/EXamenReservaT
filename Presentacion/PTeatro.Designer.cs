namespace Presentacion
{
    partial class PTeatro
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
            this.label2 = new System.Windows.Forms.Label();
            this.CLIENTES = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTASIENTO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.DGVTEATRO = new System.Windows.Forms.DataGridView();
            this.exaIIRADDataSet1 = new Presentacion.ExaIIRADDataSet1();
            this.dTeatroesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTeatroesTableAdapter = new Presentacion.ExaIIRADDataSet1TableAdapters.DTeatroesTableAdapter();
            this.teatroIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTeatroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTEATRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTeatroesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id:";
            // 
            // CLIENTES
            // 
            this.CLIENTES.AutoSize = true;
            this.CLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTES.Location = new System.Drawing.Point(131, -2);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Size = new System.Drawing.Size(131, 31);
            this.CLIENTES.TabIndex = 2;
            this.CLIENTES.Text = "TEATRO";
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTID.Location = new System.Drawing.Point(53, 43);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(150, 24);
            this.TXTID.TabIndex = 8;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(209, 89);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(150, 20);
            this.TXTNOMBRE.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre teatro:";
            // 
            // TXTASIENTO
            // 
            this.TXTASIENTO.Location = new System.Drawing.Point(209, 122);
            this.TXTASIENTO.Name = "TXTASIENTO";
            this.TXTASIENTO.Size = new System.Drawing.Size(150, 20);
            this.TXTASIENTO.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Asiento disponible:";
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(195, 173);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(81, 25);
            this.BTNELIMINAR.TabIndex = 17;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Location = new System.Drawing.Point(108, 173);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(81, 25);
            this.BTNMODIFICAR.TabIndex = 16;
            this.BTNMODIFICAR.Text = "Modificar";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(21, 173);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(81, 25);
            this.BTNGUARDAR.TabIndex = 15;
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
            this.DGVTEATRO.Location = new System.Drawing.Point(12, 222);
            this.DGVTEATRO.Name = "DGVTEATRO";
            this.DGVTEATRO.ReadOnly = true;
            this.DGVTEATRO.Size = new System.Drawing.Size(347, 216);
            this.DGVTEATRO.TabIndex = 18;
            // 
            // exaIIRADDataSet1
            // 
            this.exaIIRADDataSet1.DataSetName = "ExaIIRADDataSet1";
            this.exaIIRADDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTeatroesBindingSource
            // 
            this.dTeatroesBindingSource.DataMember = "DTeatroes";
            this.dTeatroesBindingSource.DataSource = this.exaIIRADDataSet1;
            // 
            // dTeatroesTableAdapter
            // 
            this.dTeatroesTableAdapter.ClearBeforeFill = true;
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
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(342, -2);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(31, 27);
            this.BtnCerrar.TabIndex = 90;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // PTeatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DGVTEATRO);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNMODIFICAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.TXTASIENTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLIENTES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PTeatro";
            this.Text = "PTeatro";
            this.Load += new System.EventHandler(this.PTeatro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTEATRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTeatroesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CLIENTES;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTASIENTO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.DataGridView DGVTEATRO;
        private ExaIIRADDataSet1 exaIIRADDataSet1;
        private System.Windows.Forms.BindingSource dTeatroesBindingSource;
        private ExaIIRADDataSet1TableAdapters.DTeatroesTableAdapter dTeatroesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teatroIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTeatroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAsientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnCerrar;
    }
}