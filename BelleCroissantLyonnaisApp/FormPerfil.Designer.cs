namespace BelleCroissantLyonnaisApp
{
    partial class FormPerfil
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox chkSuscripcion;
        private System.Windows.Forms.Label lblMetodoEntrega;
        private System.Windows.Forms.RadioButton radioRecogida;
        private System.Windows.Forms.RadioButton radioEntrega;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDirecciones;
        private System.Windows.Forms.ListBox listBoxDirecciones;
        private System.Windows.Forms.TextBox txtDireccionTexto;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.CheckBox chkEsPreferida;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Button btnGuardarDireccion;
        private System.Windows.Forms.Button btnEliminarDireccion;

        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            chkSuscripcion = new CheckBox();
            lblMetodoEntrega = new Label();
            radioRecogida = new RadioButton();
            radioEntrega = new RadioButton();
            lblMensaje = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBoxPerfil = new PictureBox();
            buttonImagen = new Button();
            lblDirecciones = new Label();
            listBoxDirecciones = new ListBox();
            txtDireccionTexto = new TextBox();
            txtCodigoPostal = new TextBox();
            txtCiudad = new TextBox();
            txtPais = new TextBox();
            txtEtiqueta = new TextBox();
            chkEsPreferida = new CheckBox();
            btnAgregarDireccion = new Button();
            btnGuardarDireccion = new Button();
            btnEliminarDireccion = new Button();
            listViewPedidos = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(81, 230);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(267, 225);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(391, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(81, 284);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(267, 279);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(391, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(81, 337);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(135, 20);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.Control;
            txtCorreo.Location = new Point(267, 333);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.RightToLeft = RightToLeft.No;
            txtCorreo.Size = new Size(391, 27);
            txtCorreo.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(81, 391);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(267, 387);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(391, 27);
            txtTelefono.TabIndex = 7;
            // 
            // chkSuscripcion
            // 
            chkSuscripcion.AutoSize = true;
            chkSuscripcion.Location = new Point(321, 449);
            chkSuscripcion.Margin = new Padding(4, 5, 4, 5);
            chkSuscripcion.Name = "chkSuscripcion";
            chkSuscripcion.Size = new Size(228, 24);
            chkSuscripcion.TabIndex = 8;
            chkSuscripcion.Text = "Suscribirse a la lista de correo";
            chkSuscripcion.UseVisualStyleBackColor = true;
            // 
            // lblMetodoEntrega
            // 
            lblMetodoEntrega.AutoSize = true;
            lblMetodoEntrega.Location = new Point(81, 485);
            lblMetodoEntrega.Margin = new Padding(4, 0, 4, 0);
            lblMetodoEntrega.Name = "lblMetodoEntrega";
            lblMetodoEntrega.Size = new Size(207, 20);
            lblMetodoEntrega.TabIndex = 9;
            lblMetodoEntrega.Text = "Método de entrega preferido:";
            // 
            // radioRecogida
            // 
            radioRecogida.AutoSize = true;
            radioRecogida.Location = new Point(267, 523);
            radioRecogida.Margin = new Padding(4, 5, 4, 5);
            radioRecogida.Name = "radioRecogida";
            radioRecogida.Size = new Size(93, 24);
            radioRecogida.TabIndex = 10;
            radioRecogida.Text = "Recogida";
            radioRecogida.UseVisualStyleBackColor = true;
            // 
            // radioEntrega
            // 
            radioEntrega.AutoSize = true;
            radioEntrega.Location = new Point(401, 523);
            radioEntrega.Margin = new Padding(4, 5, 4, 5);
            radioEntrega.Name = "radioEntrega";
            radioEntrega.Size = new Size(81, 24);
            radioEntrega.TabIndex = 11;
            radioEntrega.Text = "Entrega";
            radioEntrega.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            lblMensaje.ForeColor = Color.Green;
            lblMensaje.Location = new Point(69, 564);
            lblMensaje.Margin = new Padding(4, 0, 4, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(480, 46);
            lblMensaje.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(240, 628);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 46);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(387, 628);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 46);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBoxPerfil
            // 
            pictureBoxPerfil.Location = new Point(240, 12);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(220, 127);
            pictureBoxPerfil.TabIndex = 15;
            pictureBoxPerfil.TabStop = false;
            // 
            // buttonImagen
            // 
            buttonImagen.Location = new Point(278, 165);
            buttonImagen.Margin = new Padding(4, 5, 4, 5);
            buttonImagen.Name = "buttonImagen";
            buttonImagen.Size = new Size(133, 37);
            buttonImagen.TabIndex = 16;
            buttonImagen.Text = "cambiar imagen ";
            buttonImagen.UseVisualStyleBackColor = true;
            buttonImagen.Click += buttonImagen_Click;
            // 
            // lblDirecciones
            // 
            lblDirecciones.AutoSize = true;
            lblDirecciones.Location = new Point(60, 680);
            lblDirecciones.Name = "lblDirecciones";
            lblDirecciones.Size = new Size(114, 20);
            lblDirecciones.TabIndex = 17;
            lblDirecciones.Text = "Mis direcciones:";
            // 
            // listBoxDirecciones
            // 
            listBoxDirecciones.Location = new Point(60, 707);
            listBoxDirecciones.Name = "listBoxDirecciones";
            listBoxDirecciones.Size = new Size(300, 144);
            listBoxDirecciones.TabIndex = 18;
            // 
            // txtDireccionTexto
            // 
            txtDireccionTexto.Location = new Point(383, 707);
            txtDireccionTexto.Name = "txtDireccionTexto";
            txtDireccionTexto.PlaceholderText = "Dirección (calle y número)";
            txtDireccionTexto.Size = new Size(292, 27);
            txtDireccionTexto.TabIndex = 19;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(383, 742);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.PlaceholderText = "Código postal";
            txtCodigoPostal.Size = new Size(140, 27);
            txtCodigoPostal.TabIndex = 20;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(535, 742);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PlaceholderText = "Ciudad";
            txtCiudad.Size = new Size(140, 27);
            txtCiudad.TabIndex = 21;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(383, 777);
            txtPais.Name = "txtPais";
            txtPais.PlaceholderText = "País";
            txtPais.Size = new Size(292, 27);
            txtPais.TabIndex = 22;
            // 
            // txtEtiqueta
            // 
            txtEtiqueta.Location = new Point(383, 812);
            txtEtiqueta.Name = "txtEtiqueta";
            txtEtiqueta.PlaceholderText = "Etiqueta (ej: Casa, Trabajo)";
            txtEtiqueta.Size = new Size(292, 27);
            txtEtiqueta.TabIndex = 23;
            // 
            // chkEsPreferida
            // 
            chkEsPreferida.AutoSize = true;
            chkEsPreferida.Location = new Point(383, 847);
            chkEsPreferida.Name = "chkEsPreferida";
            chkEsPreferida.Size = new Size(184, 24);
            chkEsPreferida.TabIndex = 24;
            chkEsPreferida.Text = "Marcar como preferida";
            chkEsPreferida.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDireccion
            // 
            btnAgregarDireccion.Location = new Point(187, 877);
            btnAgregarDireccion.Name = "btnAgregarDireccion";
            btnAgregarDireccion.Size = new Size(120, 37);
            btnAgregarDireccion.TabIndex = 25;
            btnAgregarDireccion.Text = "Agregar";
            btnAgregarDireccion.UseVisualStyleBackColor = true;
            btnAgregarDireccion.Click += btnAgregarDireccion_Click;
            // 
            // btnGuardarDireccion
            // 
            btnGuardarDireccion.Location = new Point(315, 877);
            btnGuardarDireccion.Name = "btnGuardarDireccion";
            btnGuardarDireccion.Size = new Size(120, 37);
            btnGuardarDireccion.TabIndex = 26;
            btnGuardarDireccion.Text = "Editar";
            btnGuardarDireccion.UseVisualStyleBackColor = true;
            btnGuardarDireccion.Click += btnGuardarDireccion_Click_1;
            // 
            // btnEliminarDireccion
            // 
            btnEliminarDireccion.Location = new Point(443, 877);
            btnEliminarDireccion.Name = "btnEliminarDireccion";
            btnEliminarDireccion.Size = new Size(120, 37);
            btnEliminarDireccion.TabIndex = 27;
            btnEliminarDireccion.Text = "Eliminar";
            btnEliminarDireccion.UseVisualStyleBackColor = true;
            btnEliminarDireccion.Click += btnEliminarDireccion_Click_1;
            // 
            // listViewPedidos
            // 
            listViewPedidos.Location = new Point(60, 934);
            listViewPedidos.Name = "listViewPedidos";
            listViewPedidos.Size = new Size(615, 121);
            listViewPedidos.TabIndex = 28;
            listViewPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 1091);
            Controls.Add(listViewPedidos);
            Controls.Add(buttonImagen);
            Controls.Add(pictureBoxPerfil);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(chkSuscripcion);
            Controls.Add(lblMetodoEntrega);
            Controls.Add(radioRecogida);
            Controls.Add(radioEntrega);
            Controls.Add(lblMensaje);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(lblDirecciones);
            Controls.Add(listBoxDirecciones);
            Controls.Add(txtDireccionTexto);
            Controls.Add(txtCodigoPostal);
            Controls.Add(txtCiudad);
            Controls.Add(txtPais);
            Controls.Add(txtEtiqueta);
            Controls.Add(chkEsPreferida);
            Controls.Add(btnAgregarDireccion);
            Controls.Add(btnGuardarDireccion);
            Controls.Add(btnEliminarDireccion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Belle Croissant Lyonnais - Mi Perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBoxPerfil;
        private Button buttonImagen;
        private ListView listViewPedidos;
    }
}