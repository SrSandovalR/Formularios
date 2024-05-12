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
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "resultado";
            // 
            // textBoxnumero1
            // 
            this.textBoxnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnumero1.Location = new System.Drawing.Point(129, 24);
            this.textBoxnumero1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxnumero1.Name = "textBoxnumero1";
            this.textBoxnumero1.Size = new System.Drawing.Size(76, 29);
            this.textBoxnumero1.TabIndex = 3;
            this.textBoxnumero1.TextChanged += new System.EventHandler(this.textBoxnumero1_TextChanged);
            // 
            // textBoxnumero2
            // 
            this.textBoxnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnumero2.Location = new System.Drawing.Point(129, 65);
            this.textBoxnumero2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxnumero2.Name = "textBoxnumero2";
            this.textBoxnumero2.Size = new System.Drawing.Size(76, 29);
            this.textBoxnumero2.TabIndex = 4;
            this.textBoxnumero2.TextChanged += new System.EventHandler(this.textBoxnumero2_TextChanged);
            // 
            // textBoxresultado
            // 
            this.textBoxresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxresultado.Location = new System.Drawing.Point(129, 107);
            this.textBoxresultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxresultado.Name = "textBoxresultado";
            this.textBoxresultado.Size = new System.Drawing.Size(76, 29);
            this.textBoxresultado.TabIndex = 5;
            this.textBoxresultado.TextChanged += new System.EventHandler(this.textBoxresultado_TextChanged);
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(253, 128);
            this.sumar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(62, 41);
            this.sumar.TabIndex = 6;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // comboBoxfacultades
            // 
            this.comboBoxfacultades.FormattingEnabled = true;
            this.comboBoxfacultades.Location = new System.Drawing.Point(224, 31);
            this.comboBoxfacultades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxfacultades.Name = "comboBoxfacultades";
            this.comboBoxfacultades.Size = new System.Drawing.Size(158, 21);
            this.comboBoxfacultades.TabIndex = 7;
            this.comboBoxfacultades.SelectedIndexChanged += new System.EventHandler(this.comboBoxfacultades_SelectedIndexChanged);
            // 
            // FRMingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.comboBoxfacultades);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.textBoxresultado);
            this.Controls.Add(this.textBoxnumero2);
            this.Controls.Add(this.textBoxnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRMingresos";
            this.Text = "FRMingresos";
            this.Load += new System.EventHandler(this.FRMingresos_Load);
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