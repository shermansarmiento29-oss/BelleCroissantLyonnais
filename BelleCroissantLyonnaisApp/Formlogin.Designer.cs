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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblError = new Label();
            lnkOlvidoContrasena = new LinkLabel();
            buttonLogin = new Button();
            buttonCrear_cuenta = new Button();
            SuspendLayout();
            // 
            // lblCorreo
            // 
            resources.ApplyResources(lblCorreo, "lblCorreo");
            lblCorreo.Name = "lblCorreo";
            // 
            // txtCorreo
            // 
            resources.ApplyResources(txtCorreo, "txtCorreo");
            txtCorreo.Name = "txtCorreo";
            // 
            // lblContrasena
            // 
            resources.ApplyResources(lblContrasena, "lblContrasena");
            lblContrasena.Name = "lblContrasena";
            // 
            // txtContrasena
            // 
            resources.ApplyResources(txtContrasena, "txtContrasena");
            txtContrasena.Name = "txtContrasena";
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            resources.ApplyResources(lblError, "lblError");
            lblError.Name = "lblError";
            // 
            // lnkOlvidoContrasena
            // 
            resources.ApplyResources(lnkOlvidoContrasena, "lnkOlvidoContrasena");
            lnkOlvidoContrasena.Name = "lnkOlvidoContrasena";
            lnkOlvidoContrasena.TabStop = true;
            // 
            // buttonLogin
            // 
            resources.ApplyResources(buttonLogin, "buttonLogin");
            buttonLogin.Name = "buttonLogin";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCrear_cuenta
            // 
            resources.ApplyResources(buttonCrear_cuenta, "buttonCrear_cuenta");
            buttonCrear_cuenta.Name = "buttonCrear_cuenta";
            buttonCrear_cuenta.UseVisualStyleBackColor = true;
            buttonCrear_cuenta.Click += buttonCrear_cuenta_Click;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonCrear_cuenta);
            Controls.Add(buttonLogin);
            Controls.Add(lnkOlvidoContrasena);
            Controls.Add(lblError);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}