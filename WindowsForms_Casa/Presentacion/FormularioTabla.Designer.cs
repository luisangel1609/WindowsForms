
namespace WindowsForms_Casa.Presentacion
{
    partial class FormularioTabla
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
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.txtm2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(231, 170);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(87, 40);
            this.btnGuardar1.TabIndex = 13;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // txtm2
            // 
            this.txtm2.Location = new System.Drawing.Point(102, 87);
            this.txtm2.Name = "txtm2";
            this.txtm2.Size = new System.Drawing.Size(216, 20);
            this.txtm2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "M2:";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(102, 43);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(216, 20);
            this.txtcosto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Costo:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(102, 3);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(216, 20);
            this.txtUbicacion.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ubicacion:";
            // 
            // txtda
            // 
            this.txtda.Location = new System.Drawing.Point(102, 122);
            this.txtda.Name = "txtda";
            this.txtda.Size = new System.Drawing.Size(216, 20);
            this.txtda.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dueño Anterior:";
            // 
            // FormularioTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 294);
            this.Controls.Add(this.txtda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.txtm2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label4);
            this.Name = "FormularioTabla";
            this.Text = "FormularioTabla";
            this.Load += new System.EventHandler(this.FormularioTabla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.TextBox txtm2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtda;
        private System.Windows.Forms.Label label1;
    }
}