namespace game
{
    partial class frmMenu
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
            this.btnIniciante = new System.Windows.Forms.Button();
            this.btnIntermediario = new System.Windows.Forms.Button();
            this.btnAvançado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o Nível  do jogo :";
            // 
            // btnIniciante
            // 
            this.btnIniciante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIniciante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciante.Location = new System.Drawing.Point(38, 59);
            this.btnIniciante.Name = "btnIniciante";
            this.btnIniciante.Size = new System.Drawing.Size(250, 55);
            this.btnIniciante.TabIndex = 1;
            this.btnIniciante.Text = "Iniciante";
            this.btnIniciante.UseVisualStyleBackColor = false;
            this.btnIniciante.Click += new System.EventHandler(this.btnIniciante_Click);
            // 
            // btnIntermediario
            // 
            this.btnIntermediario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIntermediario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntermediario.Location = new System.Drawing.Point(38, 132);
            this.btnIntermediario.Name = "btnIntermediario";
            this.btnIntermediario.Size = new System.Drawing.Size(250, 55);
            this.btnIntermediario.TabIndex = 2;
            this.btnIntermediario.Text = "Intermediário";
            this.btnIntermediario.UseVisualStyleBackColor = false;
            this.btnIntermediario.Click += new System.EventHandler(this.btnIntermediario_Click);
            // 
            // btnAvançado
            // 
            this.btnAvançado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAvançado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvançado.Location = new System.Drawing.Point(38, 208);
            this.btnAvançado.Name = "btnAvançado";
            this.btnAvançado.Size = new System.Drawing.Size(250, 55);
            this.btnAvançado.TabIndex = 3;
            this.btnAvançado.Text = "Avançado";
            this.btnAvançado.UseVisualStyleBackColor = false;
            this.btnAvançado.Click += new System.EventHandler(this.btnAvançado_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 285);
            this.Controls.Add(this.btnAvançado);
            this.Controls.Add(this.btnIntermediario);
            this.Controls.Add(this.btnIniciante);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciante;
        private System.Windows.Forms.Button btnIntermediario;
        private System.Windows.Forms.Button btnAvançado;
    }
}