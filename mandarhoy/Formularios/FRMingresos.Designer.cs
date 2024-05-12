namespace mandarhoy.Formularios
{
    partial class FRMingresos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnumero1 = new System.Windows.Forms.TextBox();
            this.textBoxnumero2 = new System.Windows.Forms.TextBox();
            this.textBoxresultado = new System.Windows.Forms.TextBox();
            this.sumar = new System.Windows.Forms.Button();
            this.comboBoxfacultades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "resultado";
            // 
            // textBoxnumero1
            // 
            this.textBoxnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnumero1.Location = new System.Drawing.Point(172, 29);
            this.textBoxnumero1.Name = "textBoxnumero1";
            this.textBoxnumero1.Size = new System.Drawing.Size(100, 34);
            this.textBoxnumero1.TabIndex = 3;
            this.textBoxnumero1.TextChanged += new System.EventHandler(this.textBoxnumero1_TextChanged);
            // 
            // textBoxnumero2
            // 
            this.textBoxnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnumero2.Location = new System.Drawing.Point(172, 80);
            this.textBoxnumero2.Name = "textBoxnumero2";
            this.textBoxnumero2.Size = new System.Drawing.Size(100, 34);
            this.textBoxnumero2.TabIndex = 4;
            this.textBoxnumero2.TextChanged += new System.EventHandler(this.textBoxnumero2_TextChanged);
            // 
            // textBoxresultado
            // 
            this.textBoxresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxresultado.Location = new System.Drawing.Point(172, 132);
            this.textBoxresultado.Name = "textBoxresultado";
            this.textBoxresultado.Size = new System.Drawing.Size(100, 34);
            this.textBoxresultado.TabIndex = 5;
            this.textBoxresultado.TextChanged += new System.EventHandler(this.textBoxresultado_TextChanged);
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(337, 158);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(83, 50);
            this.sumar.TabIndex = 6;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // comboBoxfacultades
            // 
            this.comboBoxfacultades.FormattingEnabled = true;
            this.comboBoxfacultades.Location = new System.Drawing.Point(298, 38);
            this.comboBoxfacultades.Name = "comboBoxfacultades";
            this.comboBoxfacultades.Size = new System.Drawing.Size(210, 24);
            this.comboBoxfacultades.TabIndex = 7;
            this.comboBoxfacultades.SelectedIndexChanged += new System.EventHandler(this.comboBoxfacultades_SelectedIndexChanged);
            // 
            // FRMingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxfacultades);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.textBoxresultado);
            this.Controls.Add(this.textBoxnumero2);
            this.Controls.Add(this.textBoxnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMingresos";
            this.Text = "FRMingresos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxnumero1;
        private System.Windows.Forms.TextBox textBoxnumero2;
        private System.Windows.Forms.TextBox textBoxresultado;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.ComboBox comboBoxfacultades;
    }
}