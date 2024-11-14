namespace SistemaCafeteria
{
    partial class FormPerfiles
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFechaRegistro = new TextBox();
            txtDescripcion = new TextBox();
            txtTipoPerfil = new TextBox();
            txtIdPerfil = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dtgvListaPerfiles = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListaPerfiles).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFechaRegistro);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtTipoPerfil);
            groupBox1.Controls.Add(txtIdPerfil);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 454);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 259);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 9;
            label3.Text = "Fecha de registro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 204);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 8;
            label2.Text = "Descripción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 136);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "Tipo de perfil:";
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Location = new Point(207, 251);
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.ReadOnly = true;
            txtFechaRegistro.Size = new Size(178, 23);
            txtFechaRegistro.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(207, 196);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(178, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // txtTipoPerfil
            // 
            txtTipoPerfil.Location = new Point(207, 137);
            txtTipoPerfil.Name = "txtTipoPerfil";
            txtTipoPerfil.Size = new Size(178, 23);
            txtTipoPerfil.TabIndex = 4;
            // 
            // txtIdPerfil
            // 
            txtIdPerfil.BackColor = SystemColors.Control;
            txtIdPerfil.Location = new Point(207, 43);
            txtIdPerfil.Name = "txtIdPerfil";
            txtIdPerfil.Size = new Size(178, 23);
            txtIdPerfil.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(295, 375);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 48);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(166, 375);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 48);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(34, 375);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 48);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Modificar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dtgvListaPerfiles
            // 
            dtgvListaPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaPerfiles.Location = new Point(513, 31);
            dtgvListaPerfiles.Name = "dtgvListaPerfiles";
            dtgvListaPerfiles.Size = new Size(379, 255);
            dtgvListaPerfiles.TabIndex = 1;
            dtgvListaPerfiles.CellContentClick += dtgvListaPerfiles_CellContentClick;
            // 
            // FormPerfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(895, 478);
            Controls.Add(dtgvListaPerfiles);
            Controls.Add(groupBox1);
            Name = "FormPerfiles";
            Text = "FormPerfiles";
            Load += FormPerfiles_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListaPerfiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dtgvListaPerfiles;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFechaRegistro;
        private TextBox txtDescripcion;
        private TextBox txtTipoPerfil;
        private TextBox txtIdPerfil;
    }
}