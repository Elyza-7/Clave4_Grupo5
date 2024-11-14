namespace SistemaCafeteria
{
    partial class FormLocales
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
            dtgvListaLocales = new DataGridView();
            groupBox1 = new GroupBox();
            txtFechaRegistro = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefono = new TextBox();
            txtHorarioCierre = new TextBox();
            txtHorarioApertura = new TextBox();
            txtUbicacion = new TextBox();
            txtNombreLocal = new TextBox();
            txtIdLocal = new TextBox();
            horarioApertura = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgvListaLocales).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvListaLocales
            // 
            dtgvListaLocales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaLocales.Location = new Point(512, 32);
            dtgvListaLocales.Name = "dtgvListaLocales";
            dtgvListaLocales.Size = new Size(398, 236);
            dtgvListaLocales.TabIndex = 0;
            dtgvListaLocales.CellContentClick += dtgvListaLocales_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(horarioApertura);
            groupBox1.Controls.Add(txtFechaRegistro);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtHorarioCierre);
            groupBox1.Controls.Add(txtHorarioApertura);
            groupBox1.Controls.Add(txtUbicacion);
            groupBox1.Controls.Add(txtNombreLocal);
            groupBox1.Controls.Add(txtIdLocal);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 434);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Location = new Point(189, 280);
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.ReadOnly = true;
            txtFechaRegistro.Size = new Size(100, 23);
            txtFechaRegistro.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(349, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 46);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(213, 349);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 46);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(58, 349);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 47);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Modificar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 240);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 196);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 10;
            label4.Text = "Horario cierre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 151);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 9;
            label3.Text = "Horario apertura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 104);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Ubicacion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 59);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre local:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(166, 237);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(169, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtHorarioCierre
            // 
            txtHorarioCierre.Location = new Point(166, 196);
            txtHorarioCierre.Name = "txtHorarioCierre";
            txtHorarioCierre.Size = new Size(169, 23);
            txtHorarioCierre.TabIndex = 4;
            // 
            // txtHorarioApertura
            // 
            txtHorarioApertura.Location = new Point(166, 151);
            txtHorarioApertura.Name = "txtHorarioApertura";
            txtHorarioApertura.Size = new Size(169, 23);
            txtHorarioApertura.TabIndex = 3;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(166, 101);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(169, 23);
            txtUbicacion.TabIndex = 2;
            // 
            // txtNombreLocal
            // 
            txtNombreLocal.Location = new Point(166, 56);
            txtNombreLocal.Name = "txtNombreLocal";
            txtNombreLocal.Size = new Size(169, 23);
            txtNombreLocal.TabIndex = 1;
            // 
            // txtIdLocal
            // 
            txtIdLocal.BackColor = SystemColors.Control;
            txtIdLocal.Location = new Point(166, 10);
            txtIdLocal.Name = "txtIdLocal";
            txtIdLocal.Size = new Size(169, 23);
            txtIdLocal.TabIndex = 0;
            // 
            // horarioApertura
            // 
            horarioApertura.Format = DateTimePickerFormat.Time;
            horarioApertura.Location = new Point(341, 148);
            horarioApertura.Name = "horarioApertura";
            horarioApertura.Size = new Size(88, 23);
            horarioApertura.TabIndex = 17;
            // 
            // FormLocales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(922, 468);
            Controls.Add(groupBox1);
            Controls.Add(dtgvListaLocales);
            Name = "FormLocales";
            Text = "FormLocales";
            Load += FormLocales_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListaLocales).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvListaLocales;
        private GroupBox groupBox1;
        private TextBox txtHorarioCierre;
        private TextBox txtHorarioApertura;
        private TextBox txtUbicacion;
        private TextBox txtNombreLocal;
        private TextBox txtIdLocal;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtFechaRegistro;
        private DateTimePicker horarioApertura;
    }
}