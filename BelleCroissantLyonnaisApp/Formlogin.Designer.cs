namespace BelleCroissantLyonnaisApp
{
    partial class FormLogin
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

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel lnkOlvidoContrasena;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCrear_cuenta;

        private void InitializeComponent()
        {
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lnkOlvidoContrasena = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCrear_cuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblCorreo
            //
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(20, 30);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(120, 13);
            this.lblCorreo.Text = "Correo electrónico:";
            //
            // txtCorreo
            //
            this.txtCorreo.Location = new System.Drawing.Point(160, 27);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(190, 20);
            //
            // lblContrasena
            //
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(20, 70);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(70, 13);
            this.lblContrasena.Text = "Contraseña:";
            //
            // txtContrasena
            //
            this.txtContrasena.Location = new System.Drawing.Point(160, 67);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(190, 20);
            this.txtContrasena.UseSystemPasswordChar = true;
            //
            // lblError
            //
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(20, 105);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(330, 30);
            //
            // lnkOlvidoContrasena
            //
            this.lnkOlvidoContrasena.AutoSize = true;
            this.lnkOlvidoContrasena.Location = new System.Drawing.Point(160, 185);
            this.lnkOlvidoContrasena.Name = "lnkOlvidoContrasena";
            this.lnkOlvidoContrasena.Size = new System.Drawing.Size(150, 13);
            this.lnkOlvidoContrasena.TabStop = true;
            this.lnkOlvidoContrasena.Text = "¿Ha olvidado su contraseña?";
            //
            // buttonLogin
            //
            this.buttonLogin.Location = new System.Drawing.Point(160, 140);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 30);
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            //
            // buttonCrear_cuenta
            //
            this.buttonCrear_cuenta.Location = new System.Drawing.Point(260, 140);
            this.buttonCrear_cuenta.Name = "buttonCrear_cuenta";
            this.buttonCrear_cuenta.Size = new System.Drawing.Size(90, 30);
            this.buttonCrear_cuenta.Text = "Crear cuenta";
            this.buttonCrear_cuenta.UseVisualStyleBackColor = true;
            this.buttonCrear_cuenta.Click += new System.EventHandler(this.buttonCrear_cuenta_Click);
            //
            // FormLogin
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.buttonCrear_cuenta);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.lnkOlvidoContrasena);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belle Croissant Lyonnais - Iniciar sesión";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}