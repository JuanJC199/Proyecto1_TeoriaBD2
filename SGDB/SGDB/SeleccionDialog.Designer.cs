namespace SGDB
{
    partial class SeleccionDialog
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
            this.btTabla = new System.Windows.Forms.Button();
            this.btIndice = new System.Windows.Forms.Button();
            this.btAlmacenado = new System.Windows.Forms.Button();
            this.btTrigger = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una opcion";
            // 
            // btTabla
            // 
            this.btTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTabla.Location = new System.Drawing.Point(36, 95);
            this.btTabla.Name = "btTabla";
            this.btTabla.Size = new System.Drawing.Size(199, 69);
            this.btTabla.TabIndex = 1;
            this.btTabla.Text = "Tabla";
            this.btTabla.UseVisualStyleBackColor = true;
            this.btTabla.Click += new System.EventHandler(this.BtTabla_Click);
            // 
            // btIndice
            // 
            this.btIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIndice.Location = new System.Drawing.Point(36, 181);
            this.btIndice.Name = "btIndice";
            this.btIndice.Size = new System.Drawing.Size(199, 69);
            this.btIndice.TabIndex = 2;
            this.btIndice.Text = "Indice";
            this.btIndice.UseVisualStyleBackColor = true;
            this.btIndice.Click += new System.EventHandler(this.BtIndice_Click);
            // 
            // btAlmacenado
            // 
            this.btAlmacenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlmacenado.Location = new System.Drawing.Point(36, 277);
            this.btAlmacenado.Name = "btAlmacenado";
            this.btAlmacenado.Size = new System.Drawing.Size(199, 69);
            this.btAlmacenado.TabIndex = 3;
            this.btAlmacenado.Text = "Procedimiento Almacenamiento";
            this.btAlmacenado.UseVisualStyleBackColor = true;
            // 
            // btTrigger
            // 
            this.btTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrigger.Location = new System.Drawing.Point(421, 95);
            this.btTrigger.Name = "btTrigger";
            this.btTrigger.Size = new System.Drawing.Size(199, 69);
            this.btTrigger.TabIndex = 4;
            this.btTrigger.Text = "Triggers";
            this.btTrigger.UseVisualStyleBackColor = true;
            this.btTrigger.Click += new System.EventHandler(this.BtTrigger_Click);
            // 
            // btView
            // 
            this.btView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btView.Location = new System.Drawing.Point(421, 181);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(199, 69);
            this.btView.TabIndex = 5;
            this.btView.Text = "Vistas";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.BtView_Click);
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.Location = new System.Drawing.Point(421, 277);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(199, 69);
            this.btCheck.TabIndex = 6;
            this.btCheck.Text = "Checks";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.Button4_Click);
            // 
            // SeleccionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 377);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btTrigger);
            this.Controls.Add(this.btAlmacenado);
            this.Controls.Add(this.btIndice);
            this.Controls.Add(this.btTabla);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionDialog";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTabla;
        private System.Windows.Forms.Button btIndice;
        private System.Windows.Forms.Button btAlmacenado;
        private System.Windows.Forms.Button btTrigger;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Button btCheck;
    }
}