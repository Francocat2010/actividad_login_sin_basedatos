namespace EjemploLogin
{
    partial class frmLogin
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
            this.lblnUsuario = new System.Windows.Forms.Label();
            this.lblnContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnSalir_Click = new System.Windows.Forms.Button();
            this.btnIngresar_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnUsuario
            // 
            this.lblnUsuario.AutoSize = true;
            this.lblnUsuario.Location = new System.Drawing.Point(12, 35);
            this.lblnUsuario.Name = "lblnUsuario";
            this.lblnUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblnUsuario.TabIndex = 0;
            this.lblnUsuario.Text = "Usuario:";
            // 
            // lblnContraseña
            // 
            this.lblnContraseña.AutoSize = true;
            this.lblnContraseña.Location = new System.Drawing.Point(12, 74);
            this.lblnContraseña.Name = "lblnContraseña";
            this.lblnContraseña.Size = new System.Drawing.Size(70, 15);
            this.lblnContraseña.TabIndex = 1;
            this.lblnContraseña.Text = "Contraseña:";
            this.lblnContraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(104, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(104, 74);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(227, 23);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnSalir_Click
            // 
            this.btnSalir_Click.Location = new System.Drawing.Point(281, 127);
            this.btnSalir_Click.Name = "btnSalir_Click";
            this.btnSalir_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSalir_Click.TabIndex = 4;
            this.btnSalir_Click.Text = "Salir";
            this.btnSalir_Click.UseVisualStyleBackColor = true;
            // 
            // btnIngresar_Click
            // 
            this.btnIngresar_Click.Location = new System.Drawing.Point(199, 127);
            this.btnIngresar_Click.Name = "btnIngresar_Click";
            this.btnIngresar_Click.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar_Click.TabIndex = 5;
            this.btnIngresar_Click.Text = "Ingresar";
            this.btnIngresar_Click.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(368, 162);
            this.Controls.Add(this.btnIngresar_Click);
            this.Controls.Add(this.btnSalir_Click);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblnContraseña);
            this.Controls.Add(this.lblnUsuario);
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.label1_Click);
            this.Click += new System.EventHandler(this.label1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblnUsuario;
        private Label lblnContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnSalir_Click;
        private Button btnIngresar_Click;
    }
}