namespace Biblioteca_123
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnGestionLibros = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOTECA";
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Location = new System.Drawing.Point(98, 137);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnGestionUsuarios.TabIndex = 1;
            this.btnGestionUsuarios.Text = "button1";
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnGestionLibros
            // 
            this.btnGestionLibros.Location = new System.Drawing.Point(98, 188);
            this.btnGestionLibros.Name = "btnGestionLibros";
            this.btnGestionLibros.Size = new System.Drawing.Size(75, 23);
            this.btnGestionLibros.TabIndex = 2;
            this.btnGestionLibros.Text = "button1";
            this.btnGestionLibros.UseVisualStyleBackColor = true;
            this.btnGestionLibros.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(98, 232);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "button2";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnGestionLibros);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnGestionLibros;
        private System.Windows.Forms.Button btnReportes;
    }
}