namespace problema1
{
    partial class frmProblem1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.rdbRetiros = new System.Windows.Forms.RadioButton();
            this.lstRetiro = new System.Windows.Forms.ListBox();
            this.lstDeposito = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(22, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 649);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCuenta);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRetiros);
            this.groupBox2.Controls.Add(this.rdbDeposito);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transacciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lstDeposito);
            this.groupBox3.Controls.Add(this.lstRetiro);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 319);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta de Ahorro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto Inicial: ";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(206, 36);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(221, 27);
            this.txtCliente.TabIndex = 2;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(206, 76);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(221, 27);
            this.txtMonto.TabIndex = 3;
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(463, 26);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(171, 43);
            this.btnCuenta.TabIndex = 4;
            this.btnCuenta.Text = "Abrir Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Location = new System.Drawing.Point(154, 48);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(106, 24);
            this.rdbDeposito.TabIndex = 0;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Depósitos";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            // 
            // rdbRetiros
            // 
            this.rdbRetiros.AutoSize = true;
            this.rdbRetiros.Location = new System.Drawing.Point(388, 48);
            this.rdbRetiros.Name = "rdbRetiros";
            this.rdbRetiros.Size = new System.Drawing.Size(84, 24);
            this.rdbRetiros.TabIndex = 1;
            this.rdbRetiros.TabStop = true;
            this.rdbRetiros.Text = "Retiros";
            this.rdbRetiros.UseVisualStyleBackColor = true;
            // 
            // lstRetiro
            // 
            this.lstRetiro.FormattingEnabled = true;
            this.lstRetiro.ItemHeight = 20;
            this.lstRetiro.Location = new System.Drawing.Point(20, 79);
            this.lstRetiro.Name = "lstRetiro";
            this.lstRetiro.Size = new System.Drawing.Size(211, 224);
            this.lstRetiro.TabIndex = 0;
            // 
            // lstDeposito
            // 
            this.lstDeposito.FormattingEnabled = true;
            this.lstDeposito.ItemHeight = 20;
            this.lstDeposito.Location = new System.Drawing.Point(261, 79);
            this.lstDeposito.Name = "lstDeposito";
            this.lstDeposito.Size = new System.Drawing.Size(211, 224);
            this.lstDeposito.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Retiros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Depósitos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(545, 160);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(143, 27);
            this.txtSaldo.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(529, 206);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(171, 48);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmProblem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(846, 748);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProblem1";
            this.Text = "frmProblem1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.RadioButton rdbRetiros;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDeposito;
        private System.Windows.Forms.ListBox lstRetiro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}