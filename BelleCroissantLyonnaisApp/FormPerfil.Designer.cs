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
            pictureBox1 = new PictureBox();
            buttonImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 31);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(213, 26);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(292, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(27, 85);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(213, 80);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(292, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(27, 138);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(135, 20);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.Control;
            txtCorreo.Location = new Point(213, 134);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.RightToLeft = RightToLeft.No;
            txtCorreo.Size = new Size(292, 27);
            txtCorreo.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(27, 192);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(213, 188);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(292, 27);
            txtTelefono.TabIndex = 7;
            // 
            // chkSuscripcion
            // 
            chkSuscripcion.AutoSize = true;
            chkSuscripcion.Location = new Point(213, 246);
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
            lblMetodoEntrega.Location = new Point(27, 300);
            lblMetodoEntrega.Margin = new Padding(4, 0, 4, 0);
            lblMetodoEntrega.Name = "lblMetodoEntrega";
            lblMetodoEntrega.Size = new Size(207, 20);
            lblMetodoEntrega.TabIndex = 9;
            lblMetodoEntrega.Text = "Método de entrega preferido:";
            // 
            // radioRecogida
            // 
            radioRecogida.AutoSize = true;
            radioRecogida.Location = new Point(213, 338);
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
            radioEntrega.Location = new Point(347, 338);
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
            lblMensaje.Location = new Point(27, 392);
            lblMensaje.Margin = new Padding(4, 0, 4, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(480, 46);
            lblMensaje.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(213, 454);
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
            btnCancelar.Location = new Point(360, 454);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 46);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(561, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 127);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // buttonImagen
            // 
            buttonImagen.Location = new Point(599, 184);
            buttonImagen.Margin = new Padding(4, 5, 4, 5);
            buttonImagen.Name = "buttonImagen";
            buttonImagen.Size = new Size(133, 37);
            buttonImagen.TabIndex = 16;
            buttonImagen.Text = "cambiar imagen ";
            buttonImagen.UseVisualStyleBackColor = true;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 538);
            Controls.Add(buttonImagen);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Belle Croissant Lyonnais - Mi Perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Button buttonImagen;
    }
}