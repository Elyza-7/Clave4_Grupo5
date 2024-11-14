namespace SistemaCafeteria
{
    partial class FormProductos
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
            groupBox1 = new GroupBox();
            numCantidadMaxima = new NumericUpDown();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtIdProductos = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dtHorario = new DateTimePicker();
            label5 = new Label();
            cbxTipoProducto = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numPrecio = new NumericUpDown();
            numDisponible = new NumericUpDown();
            txtNombre = new TextBox();
            dtgvListaProductos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadMaxima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDisponible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numCantidadMaxima);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtIdProductos);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtHorario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbxTipoProducto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numPrecio);
            groupBox1.Controls.Add(numDisponible);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // numCantidadMaxima
            // 
            numCantidadMaxima.Location = new Point(165, 292);
            numCantidadMaxima.Name = "numCantidadMaxima";
            numCantidadMaxima.Size = new Size(138, 23);
            numCantidadMaxima.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(168, 76);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(146, 23);
            txtDescripcion.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(239, 390);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(141, 388);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(60, 387);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtIdProductos
            // 
            txtIdProductos.Location = new Point(183, 13);
            txtIdProductos.Name = "txtIdProductos";
            txtIdProductos.Size = new Size(100, 23);
            txtIdProductos.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 298);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 14;
            label7.Text = "Cantidad maxima";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 256);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 13;
            label6.Text = "Horario disponible";
            // 
            // dtHorario
            // 
            dtHorario.CustomFormat = "H:i:ss";
            dtHorario.Format = DateTimePickerFormat.Time;
            dtHorario.Location = new Point(163, 250);
            dtHorario.Name = "dtHorario";
            dtHorario.Size = new Size(140, 23);
            dtHorario.TabIndex = 12;
            dtHorario.Value = new DateTime(2024, 11, 13, 16, 13, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 215);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 11;
            label5.Text = "Tipo de Producto";
            // 
            // cbxTipoProducto
            // 
            cbxTipoProducto.FormattingEnabled = true;
            cbxTipoProducto.Items.AddRange(new object[] { "comida", "bebida", "antojitos" });
            cbxTipoProducto.Location = new Point(163, 207);
            cbxTipoProducto.Name = "cbxTipoProducto";
            cbxTipoProducto.Size = new Size(140, 23);
            cbxTipoProducto.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 86);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 9;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 45);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 164);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 127);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Disponible";
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(163, 162);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 5;
            // 
            // numDisponible
            // 
            numDisponible.Location = new Point(163, 119);
            numDisponible.Name = "numDisponible";
            numDisponible.Size = new Size(120, 23);
            numDisponible.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 23);
            txtNombre.TabIndex = 0;
            // 
            // dtgvListaProductos
            // 
            dtgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaProductos.Location = new Point(364, 37);
            dtgvListaProductos.Name = "dtgvListaProductos";
            dtgvListaProductos.Size = new Size(410, 261);
            dtgvListaProductos.TabIndex = 1;
            dtgvListaProductos.CellContentDoubleClick += dtgvListaProductos_CellContentDoubleClick;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvListaProductos);
            Controls.Add(groupBox1);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadMaxima).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDisponible).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox txtNombre;
        private DataGridView dtgvListaProductos;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numPrecio;
        private NumericUpDown numDisponible;
        private Label label7;
        private Label label6;
        private DateTimePicker dtHorario;
        private Label label5;
        private ComboBox cbxTipoProducto;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtIdProductos;
        private TextBox txtDescripcion;
        private NumericUpDown numCantidadMaxima;
    }
}