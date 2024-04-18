namespace Presentacion
{
    partial class PNClientes
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
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exaIIRADDataSet2 = new Presentacion.ExaIIRADDataSet2();
            this.dClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exaIIRADDataSet1 = new Presentacion.ExaIIRADDataSet1();
            this.TXTCELULAR = new System.Windows.Forms.TextBox();
            this.TXTCORREO = new System.Windows.Forms.TextBox();
            this.TXTAPELLIDO = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTIDENTIDAD = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CLIENTES = new System.Windows.Forms.Label();
            this.dClientesTableAdapter = new Presentacion.ExaIIRADDataSet1TableAdapters.DClientesTableAdapter();
            this.dClientesTableAdapter1 = new Presentacion.ExaIIRADDataSet2TableAdapters.DClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(451, 142);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BTNELIMINAR.TabIndex = 33;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Location = new System.Drawing.Point(356, 142);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BTNMODIFICAR.TabIndex = 32;
            this.BTNMODIFICAR.Text = "Modificar";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(258, 142);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.BTNGUARDAR.TabIndex = 31;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIdDataGridViewTextBoxColumn,
            this.identidadDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dClientesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 203);
            this.dataGridView1.TabIndex = 30;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identidadDataGridViewTextBoxColumn
            // 
            this.identidadDataGridViewTextBoxColumn.DataPropertyName = "Identidad";
            this.identidadDataGridViewTextBoxColumn.HeaderText = "Identidad";
            this.identidadDataGridViewTextBoxColumn.Name = "identidadDataGridViewTextBoxColumn";
            this.identidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dClientesBindingSource1
            // 
            this.dClientesBindingSource1.DataMember = "DClientes";
            this.dClientesBindingSource1.DataSource = this.exaIIRADDataSet2;
            // 
            // exaIIRADDataSet2
            // 
            this.exaIIRADDataSet2.DataSetName = "ExaIIRADDataSet2";
            this.exaIIRADDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dClientesBindingSource
            // 
            this.dClientesBindingSource.DataMember = "DClientes";
            this.dClientesBindingSource.DataSource = this.exaIIRADDataSet1;
            // 
            // exaIIRADDataSet1
            // 
            this.exaIIRADDataSet1.DataSetName = "ExaIIRADDataSet1";
            this.exaIIRADDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TXTCELULAR
            // 
            this.TXTCELULAR.Location = new System.Drawing.Point(451, 100);
            this.TXTCELULAR.Name = "TXTCELULAR";
            this.TXTCELULAR.Size = new System.Drawing.Size(100, 20);
            this.TXTCELULAR.TabIndex = 29;
            // 
            // TXTCORREO
            // 
            this.TXTCORREO.Location = new System.Drawing.Point(451, 71);
            this.TXTCORREO.Name = "TXTCORREO";
            this.TXTCORREO.Size = new System.Drawing.Size(100, 20);
            this.TXTCORREO.TabIndex = 28;
            // 
            // TXTAPELLIDO
            // 
            this.TXTAPELLIDO.Location = new System.Drawing.Point(119, 117);
            this.TXTAPELLIDO.Name = "TXTAPELLIDO";
            this.TXTAPELLIDO.Size = new System.Drawing.Size(100, 20);
            this.TXTAPELLIDO.TabIndex = 27;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(119, 84);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TXTNOMBRE.TabIndex = 26;
            // 
            // TXTIDENTIDAD
            // 
            this.TXTIDENTIDAD.Location = new System.Drawing.Point(119, 151);
            this.TXTIDENTIDAD.Name = "TXTIDENTIDAD";
            this.TXTIDENTIDAD.Size = new System.Drawing.Size(100, 20);
            this.TXTIDENTIDAD.TabIndex = 25;
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTID.Location = new System.Drawing.Point(51, 56);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 22);
            this.TXTID.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Identidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID:";
            // 
            // CLIENTES
            // 
            this.CLIENTES.AutoSize = true;
            this.CLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTES.Location = new System.Drawing.Point(253, 5);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Size = new System.Drawing.Size(122, 25);
            this.CLIENTES.TabIndex = 17;
            this.CLIENTES.Text = "CLIENTES";
            // 
            // dClientesTableAdapter
            // 
            this.dClientesTableAdapter.ClearBeforeFill = true;
            // 
            // dClientesTableAdapter1
            // 
            this.dClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // PNClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(680, 394);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNMODIFICAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTCELULAR);
            this.Controls.Add(this.TXTCORREO);
            this.Controls.Add(this.TXTAPELLIDO);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.TXTIDENTIDAD);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLIENTES);
            this.Name = "PNClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNClientes";
            this.Load += new System.EventHandler(this.PNClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXTCELULAR;
        private System.Windows.Forms.TextBox TXTCORREO;
        private System.Windows.Forms.TextBox TXTAPELLIDO;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTIDENTIDAD;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CLIENTES;
        private ExaIIRADDataSet1 exaIIRADDataSet1;
        private System.Windows.Forms.BindingSource dClientesBindingSource;
        private ExaIIRADDataSet1TableAdapters.DClientesTableAdapter dClientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private ExaIIRADDataSet2 exaIIRADDataSet2;
        private System.Windows.Forms.BindingSource dClientesBindingSource1;
        private ExaIIRADDataSet2TableAdapters.DClientesTableAdapter dClientesTableAdapter1;
    }
}