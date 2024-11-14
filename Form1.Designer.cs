namespace SistemaCafeteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgvListaUsuarios = new DataGridView();
            groupBox1 = new GroupBox();
            txtContrasena = new TextBox();
            label4 = new Label();
            txtIdUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtUsername = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvListaUsuarios
            // 
            dtgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaUsuarios.Location = new Point(612, 32);
            dtgvListaUsuarios.Margin = new Padding(3, 2, 3, 2);
            dtgvListaUsuarios.Name = "dtgvListaUsuarios";
            dtgvListaUsuarios.RowHeadersWidth = 51;
            dtgvListaUsuarios.Size = new Size(522, 454);
            dtgvListaUsuarios.TabIndex = 1;
            dtgvListaUsuarios.CellContentClick += dtgvListaUsuarios_CellContentClick;
            dtgvListaUsuarios.CellDoubleClick += dtgvListaUsuarios_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtContrasena);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIdUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Location = new Point(33, 32);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(556, 454);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(172, 254);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(289, 23);
            txtContrasena.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 256);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Contraseña:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(172, 12);
            txtIdUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(289, 23);
            txtIdUsuario.TabIndex = 9;
            txtIdUsuario.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 206);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 8;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 125);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 48);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // txtApellidos
            // 
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.Location = new Point(172, 201);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(289, 23);
            txtApellidos.TabIndex = 5;
            // 
            // txtNombres
            // 
            txtNombres.BorderStyle = BorderStyle.FixedSingle;
            txtNombres.Location = new Point(172, 120);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(289, 23);
            txtNombres.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(172, 43);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 23);
            txtUsername.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(142, 391);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(284, 22);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(293, 315);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 22);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Location = new Point(142, 315);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(132, 22);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Modificar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1185, 533);
            Controls.Add(groupBox1);
            Controls.Add(dtgvListaUsuarios);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgvListaUsuarios;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtUsername;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtIdUsuario;
        private TextBox txtContrasena;
        private Label label4;
    }
}
