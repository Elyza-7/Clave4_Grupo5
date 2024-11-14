namespace SistemaCafeteria
{
    partial class MenuPrincipal
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
            btnGestionarUsuario = new Button();
            btnGestionarLocales = new Button();
            btnGestionarPerfiles = new Button();
            btnGestionarProductos = new Button();
            btnGestionarPedido = new Button();
            SuspendLayout();
            // 
            // btnGestionarUsuario
            // 
            btnGestionarUsuario.Location = new Point(99, 214);
            btnGestionarUsuario.Name = "btnGestionarUsuario";
            btnGestionarUsuario.Size = new Size(122, 43);
            btnGestionarUsuario.TabIndex = 0;
            btnGestionarUsuario.Text = "Gestionar usuario";
            btnGestionarUsuario.UseVisualStyleBackColor = true;
            btnGestionarUsuario.Click += btnGestionarUsuario_Click;
            // 
            // btnGestionarLocales
            // 
            btnGestionarLocales.Location = new Point(274, 214);
            btnGestionarLocales.Name = "btnGestionarLocales";
            btnGestionarLocales.Size = new Size(110, 43);
            btnGestionarLocales.TabIndex = 1;
            btnGestionarLocales.Text = "Gestionar locales";
            btnGestionarLocales.UseVisualStyleBackColor = true;
            btnGestionarLocales.Click += btnGestionarLocales_Click;
            // 
            // btnGestionarPerfiles
            // 
            btnGestionarPerfiles.Location = new Point(435, 214);
            btnGestionarPerfiles.Name = "btnGestionarPerfiles";
            btnGestionarPerfiles.Size = new Size(105, 43);
            btnGestionarPerfiles.TabIndex = 2;
            btnGestionarPerfiles.Text = "Gestionar perfiles";
            btnGestionarPerfiles.UseVisualStyleBackColor = true;
            btnGestionarPerfiles.Click += btnGestionarPerfiles_Click;
            // 
            // btnGestionarProductos
            // 
            btnGestionarProductos.Location = new Point(580, 214);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.Size = new Size(112, 43);
            btnGestionarProductos.TabIndex = 3;
            btnGestionarProductos.Text = "Gestionar productos";
            btnGestionarProductos.UseVisualStyleBackColor = true;
            btnGestionarProductos.Click += btnGestionarProductos_Click;
            // 
            // btnGestionarPedido
            // 
            btnGestionarPedido.Location = new Point(336, 298);
            btnGestionarPedido.Name = "btnGestionarPedido";
            btnGestionarPedido.Size = new Size(111, 44);
            btnGestionarPedido.TabIndex = 4;
            btnGestionarPedido.Text = "Gestionar pedido";
            btnGestionarPedido.UseVisualStyleBackColor = true;
            btnGestionarPedido.Click += btnGestionarPedido_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionarPedido);
            Controls.Add(btnGestionarProductos);
            Controls.Add(btnGestionarPerfiles);
            Controls.Add(btnGestionarLocales);
            Controls.Add(btnGestionarUsuario);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionarUsuario;
        private Button btnGestionarLocales;
        private Button btnGestionarPerfiles;
        private Button btnGestionarProductos;
        private Button btnGestionarPedido;
    }
}