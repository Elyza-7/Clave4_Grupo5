namespace SistemaCafeteria
{
    partial class FormPedidos
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
            txtLocales = new TextBox();
            txtProducto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numPrecioTotal = new NumericUpDown();
            numCantidadProducto = new NumericUpDown();
            numPrecioUnitario = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            txtNombreCliente = new TextBox();
            dtgvPedidos = new DataGridView();
            dtgvProductos = new DataGridView();
            dtgvLocales = new DataGridView();
            btnGuardar = new Button();
            btnRegistrar = new Button();
            btnRetirar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecioTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvLocales).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRetirar);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtLocales);
            groupBox1.Controls.Add(txtProducto);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numPrecioTotal);
            groupBox1.Controls.Add(numCantidadProducto);
            groupBox1.Controls.Add(numPrecioUnitario);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 498);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtLocales
            // 
            txtLocales.Location = new Point(255, 320);
            txtLocales.Name = "txtLocales";
            txtLocales.ReadOnly = true;
            txtLocales.Size = new Size(100, 23);
            txtLocales.TabIndex = 15;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(265, 62);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 215);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 13;
            label6.Text = "cantidad producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 328);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 12;
            label5.Text = "Local retiro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 271);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Precio total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 166);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 117);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 9;
            label2.Text = "Precio unitario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 70);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "Producto";
            // 
            // numPrecioTotal
            // 
            numPrecioTotal.Location = new Point(246, 263);
            numPrecioTotal.Name = "numPrecioTotal";
            numPrecioTotal.Size = new Size(120, 23);
            numPrecioTotal.TabIndex = 7;
            // 
            // numCantidadProducto
            // 
            numCantidadProducto.Location = new Point(255, 213);
            numCantidadProducto.Name = "numCantidadProducto";
            numCantidadProducto.Size = new Size(120, 23);
            numCantidadProducto.TabIndex = 6;
            // 
            // numPrecioUnitario
            // 
            numPrecioUnitario.Location = new Point(254, 109);
            numPrecioUnitario.Name = "numPrecioUnitario";
            numPrecioUnitario.ReadOnly = true;
            numPrecioUnitario.Size = new Size(120, 23);
            numPrecioUnitario.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 373);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(229, 158);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(146, 23);
            txtNombreCliente.TabIndex = 1;
            // 
            // dtgvPedidos
            // 
            dtgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPedidos.Location = new Point(446, 12);
            dtgvPedidos.Name = "dtgvPedidos";
            dtgvPedidos.Size = new Size(448, 210);
            dtgvPedidos.TabIndex = 1;
            // 
            // dtgvProductos
            // 
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Location = new Point(446, 240);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.Size = new Size(240, 150);
            dtgvProductos.TabIndex = 2;
            dtgvProductos.CellContentClick += dtgvProductos_CellContentClick;
            // 
            // dtgvLocales
            // 
            dtgvLocales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLocales.Location = new Point(704, 240);
            dtgvLocales.Name = "dtgvLocales";
            dtgvLocales.Size = new Size(240, 150);
            dtgvLocales.TabIndex = 3;
            dtgvLocales.CellContentClick += dtgvLocales_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(16, 426);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 33);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar pedido";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(139, 426);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(105, 33);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar pago";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(255, 426);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(105, 33);
            btnRetirar.TabIndex = 18;
            btnRetirar.Text = "Retirar pedido";
            btnRetirar.UseVisualStyleBackColor = true;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 502);
            Controls.Add(dtgvLocales);
            Controls.Add(dtgvProductos);
            Controls.Add(dtgvPedidos);
            Controls.Add(groupBox1);
            Name = "FormPedidos";
            Text = "FormPedidos";
            Load += FormPedidos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecioTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvLocales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNombreCliente;
        private TextBox textBox1;
        private DataGridView dtgvPedidos;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numPrecioTotal;
        private NumericUpDown numCantidadProducto;
        private NumericUpDown numPrecioUnitario;
        private Label label6;
        private TextBox txtProducto;
        private DataGridView dtgvProductos;
        private DataGridView dtgvLocales;
        private TextBox txtLocales;
        private Button btnRetirar;
        private Button btnRegistrar;
        private Button btnGuardar;
    }
}