namespace Lab3_Sotf4
{
    partial class FrmCalcularOrden
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
            this.dgvCalculo = new System.Windows.Forms.DataGridView();
            this.Ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas Realizadas";
            // 
            // dgvCalculo
            // 
            this.dgvCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ventas});
            this.dgvCalculo.Location = new System.Drawing.Point(330, 172);
            this.dgvCalculo.Name = "dgvCalculo";
            this.dgvCalculo.RowHeadersWidth = 51;
            this.dgvCalculo.RowTemplate.Height = 24;
            this.dgvCalculo.Size = new System.Drawing.Size(468, 421);
            this.dgvCalculo.TabIndex = 1;
            // 
            // Ventas
            // 
            this.Ventas.HeaderText = "Ventas";
            this.Ventas.MinimumWidth = 6;
            this.Ventas.Name = "Ventas";
            this.Ventas.Width = 125;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(330, 627);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(211, 67);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(579, 627);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(219, 67);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(579, 99);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(197, 43);
            this.txtDatos.TabIndex = 4;
            this.txtDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese las ventas:\r\n(separado por comas)\r\n";
            // 
            // FrmCalcularOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1129, 756);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dgvCalculo);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalcularOrden";
            this.Text = "CalcularOrden";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCalculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ventas;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label2;
    }
}