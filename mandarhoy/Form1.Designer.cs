namespace mandarhoy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttoningreso = new System.Windows.Forms.Button();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelcontra = new System.Windows.Forms.Label();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.textBoxcontra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(188, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(88, 66);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "label1";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "nuevo label";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mandarhoy.Properties.Resources.RobloxScreenShot20240405_163435858;
            this.pictureBox1.Location = new System.Drawing.Point(16, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttoningreso
            // 
            this.buttoningreso.Location = new System.Drawing.Point(32, 158);
            this.buttoningreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoningreso.Name = "buttoningreso";
            this.buttoningreso.Size = new System.Drawing.Size(92, 31);
            this.buttoningreso.TabIndex = 3;
            this.buttoningreso.Text = "Ingresos";
            this.buttoningreso.UseVisualStyleBackColor = true;
            this.buttoningreso.Click += new System.EventHandler(this.buttoningreso_Click);
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Location = new System.Drawing.Point(242, 120);
            this.labelusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(43, 13);
            this.labelusuario.TabIndex = 4;
            this.labelusuario.Text = "Usuario";
            // 
            // labelcontra
            // 
            this.labelcontra.AutoSize = true;
            this.labelcontra.Location = new System.Drawing.Point(242, 158);
            this.labelcontra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcontra.Name = "labelcontra";
            this.labelcontra.Size = new System.Drawing.Size(61, 13);
            this.labelcontra.TabIndex = 5;
            this.labelcontra.Text = "Contrasena";
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.Location = new System.Drawing.Point(327, 120);
            this.textBoxusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(76, 20);
            this.textBoxusuario.TabIndex = 6;
            // 
            // textBoxcontra
            // 
            this.textBoxcontra.Location = new System.Drawing.Point(327, 158);
            this.textBoxcontra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxcontra.Name = "textBoxcontra";
            this.textBoxcontra.PasswordChar = 'X';
            this.textBoxcontra.Size = new System.Drawing.Size(76, 20);
            this.textBoxcontra.TabIndex = 7;
            this.textBoxcontra.TextChanged += new System.EventHandler(this.textBoxcontra_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxcontra);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.labelcontra);
            this.Controls.Add(this.labelusuario);
            this.Controls.Add(this.buttoningreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mytexto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoningreso;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label labelcontra;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.TextBox textBoxcontra;
    }
}

