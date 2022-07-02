namespace Mercearia
{
    partial class Entrar
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lblEntrarInvalido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(133, 150);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.Location = new System.Drawing.Point(65, 67);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(50, 15);
            this.lblEntrar.TabIndex = 1;
            this.lblEntrar.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(65, 108);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 15);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(133, 59);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(108, 23);
            this.tbUsuario.TabIndex = 3;
            // 
            // tbSenha
            // 
            this.tbSenha.AccessibleDescription = "Digite sua senha";
            this.tbSenha.AccessibleName = "Senha";
            this.tbSenha.Location = new System.Drawing.Point(133, 100);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(108, 23);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // lblEntrarInvalido
            // 
            this.lblEntrarInvalido.AutoSize = true;
            this.lblEntrarInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblEntrarInvalido.Location = new System.Drawing.Point(97, 33);
            this.lblEntrarInvalido.Name = "lblEntrarInvalido";
            this.lblEntrarInvalido.Size = new System.Drawing.Size(0, 15);
            this.lblEntrarInvalido.TabIndex = 5;
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 204);
            this.Controls.Add(this.lblEntrarInvalido);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEntrar);
            this.Controls.Add(this.btnEntrar);
            this.MaximizeBox = false;
            this.Name = "Entrar";
            this.Text = "Bem-vindo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEntrar;
        private Label lblEntrar;
        private Label lblSenha;
        private TextBox tbUsuario;
        private TextBox tbSenha;
        private Label lblEntrarInvalido;
    }
}