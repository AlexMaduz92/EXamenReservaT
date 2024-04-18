namespace Presentacion
{
    partial class PNReserva
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
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CLIENTES = new System.Windows.Forms.Label();
            this.DTFRESERVA = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBXCTEATRO = new System.Windows.Forms.ComboBox();
            this.TXTCLIENTE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTTEATRO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBXCCLIENTE = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBXASIENTO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teatroIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientoNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteClienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exaIIRADDataSet4 = new Presentacion.ExaIIRADDataSet4();
            this.dReservasTableAdapter = new Presentacion.ExaIIRADDataSet4TableAdapters.DReservasTableAdapter();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dReservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTID.Location = new System.Drawing.Point(56, 44);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 22);
            this.TXTID.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID:";
            // 
            // CLIENTES
            // 
            this.CLIENTES.AutoSize = true;
            this.CLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTES.Location = new System.Drawing.Point(278, 9);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Size = new System.Drawing.Size(103, 25);
            this.CLIENTES.TabIndex = 33;
            this.CLIENTES.Text = "TEATRO";
            // 
            // DTFRESERVA
            // 
            this.DTFRESERVA.Location = new System.Drawing.Point(438, 49);
            this.DTFRESERVA.Name = "DTFRESERVA";
            this.DTFRESERVA.Size = new System.Drawing.Size(200, 20);
            this.DTFRESERVA.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha reserva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Id teatro:";
            // 
            // CBXCTEATRO
            // 
            this.CBXCTEATRO.FormattingEnabled = true;
            this.CBXCTEATRO.Location = new System.Drawing.Point(114, 131);
            this.CBXCTEATRO.Name = "CBXCTEATRO";
            this.CBXCTEATRO.Size = new System.Drawing.Size(121, 21);
            this.CBXCTEATRO.TabIndex = 39;
            // 
            // TXTCLIENTE
            // 
            this.TXTCLIENTE.Enabled = false;
            this.TXTCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCLIENTE.Location = new System.Drawing.Point(354, 95);
            this.TXTCLIENTE.Name = "TXTCLIENTE";
            this.TXTCLIENTE.Size = new System.Drawing.Size(147, 22);
            this.TXTCLIENTE.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cliente:";
            // 
            // TXTTEATRO
            // 
            this.TXTTEATRO.Enabled = false;
            this.TXTTEATRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTEATRO.Location = new System.Drawing.Point(354, 134);
            this.TXTTEATRO.Name = "TXTTEATRO";
            this.TXTTEATRO.Size = new System.Drawing.Size(147, 22);
            this.TXTTEATRO.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Teatro";
            // 
            // CBXCCLIENTE
            // 
            this.CBXCCLIENTE.FormattingEnabled = true;
            this.CBXCCLIENTE.Location = new System.Drawing.Point(114, 84);
            this.CBXCCLIENTE.Name = "CBXCCLIENTE";
            this.CBXCCLIENTE.Size = new System.Drawing.Size(121, 21);
            this.CBXCCLIENTE.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Id teatro:";
            // 
            // CBXASIENTO
            // 
            this.CBXASIENTO.FormattingEnabled = true;
            this.CBXASIENTO.Location = new System.Drawing.Point(114, 169);
            this.CBXASIENTO.Name = "CBXASIENTO";
            this.CBXASIENTO.Size = new System.Drawing.Size(121, 21);
            this.CBXASIENTO.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Asiento:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservaIdDataGridViewTextBoxColumn,
            this.fechaReservaDataGridViewTextBoxColumn,
            this.teatroIdDataGridViewTextBoxColumn,
            this.cienteIdDataGridViewTextBoxColumn,
            this.asientoNDataGridViewTextBoxColumn,
            this.clienteClienteIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dReservasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(653, 214);
            this.dataGridView1.TabIndex = 48;
            // 
            // reservaIdDataGridViewTextBoxColumn
            // 
            this.reservaIdDataGridViewTextBoxColumn.DataPropertyName = "ReservaId";
            this.reservaIdDataGridViewTextBoxColumn.HeaderText = "ReservaId";
            this.reservaIdDataGridViewTextBoxColumn.Name = "reservaIdDataGridViewTextBoxColumn";
            this.reservaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaReservaDataGridViewTextBoxColumn
            // 
            this.fechaReservaDataGridViewTextBoxColumn.DataPropertyName = "FechaReserva";
            this.fechaReservaDataGridViewTextBoxColumn.HeaderText = "FechaReserva";
            this.fechaReservaDataGridViewTextBoxColumn.Name = "fechaReservaDataGridViewTextBoxColumn";
            this.fechaReservaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teatroIdDataGridViewTextBoxColumn
            // 
            this.teatroIdDataGridViewTextBoxColumn.DataPropertyName = "TeatroId";
            this.teatroIdDataGridViewTextBoxColumn.HeaderText = "TeatroId";
            this.teatroIdDataGridViewTextBoxColumn.Name = "teatroIdDataGridViewTextBoxColumn";
            this.teatroIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cienteIdDataGridViewTextBoxColumn
            // 
            this.cienteIdDataGridViewTextBoxColumn.DataPropertyName = "CienteId";
            this.cienteIdDataGridViewTextBoxColumn.HeaderText = "CienteId";
            this.cienteIdDataGridViewTextBoxColumn.Name = "cienteIdDataGridViewTextBoxColumn";
            this.cienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asientoNDataGridViewTextBoxColumn
            // 
            this.asientoNDataGridViewTextBoxColumn.DataPropertyName = "AsientoN";
            this.asientoNDataGridViewTextBoxColumn.HeaderText = "AsientoN";
            this.asientoNDataGridViewTextBoxColumn.Name = "asientoNDataGridViewTextBoxColumn";
            this.asientoNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteClienteIdDataGridViewTextBoxColumn
            // 
            this.clienteClienteIdDataGridViewTextBoxColumn.DataPropertyName = "cliente_ClienteId";
            this.clienteClienteIdDataGridViewTextBoxColumn.HeaderText = "cliente_ClienteId";
            this.clienteClienteIdDataGridViewTextBoxColumn.Name = "clienteClienteIdDataGridViewTextBoxColumn";
            this.clienteClienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dReservasBindingSource
            // 
            this.dReservasBindingSource.DataMember = "DReservas";
            this.dReservasBindingSource.DataSource = this.exaIIRADDataSet4;
            // 
            // exaIIRADDataSet4
            // 
            this.exaIIRADDataSet4.DataSetName = "ExaIIRADDataSet4";
            this.exaIIRADDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dReservasTableAdapter
            // 
            this.dReservasTableAdapter.ClearBeforeFill = true;
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(461, 169);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BTNELIMINAR.TabIndex = 51;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Location = new System.Drawing.Point(366, 169);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BTNMODIFICAR.TabIndex = 50;
            this.BTNMODIFICAR.Text = "Modificar";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(268, 169);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.BTNGUARDAR.TabIndex = 49;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            // 
            // PNReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNMODIFICAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CBXASIENTO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTTEATRO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBXCCLIENTE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTCLIENTE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBXCTEATRO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTFRESERVA);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLIENTES);
            this.Name = "PNReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PNReserva";
            this.Load += new System.EventHandler(this.PNReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dReservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exaIIRADDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CLIENTES;
        private System.Windows.Forms.DateTimePicker DTFRESERVA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBXCTEATRO;
        private System.Windows.Forms.TextBox TXTCLIENTE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTTEATRO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBXCCLIENTE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBXASIENTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ExaIIRADDataSet4 exaIIRADDataSet4;
        private System.Windows.Forms.BindingSource dReservasBindingSource;
        private ExaIIRADDataSet4TableAdapters.DReservasTableAdapter dReservasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teatroIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientoNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteClienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNGUARDAR;
    }
}