namespace EntidadFinanciera2M6
{
    partial class TransferenciaForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferenciaForms));
            lblCuentaOrigen = new Label();
            btnAceptar = new Button();
            numMonto = new NumericUpDown();
            lblSaldo = new Label();
            lblCuentaDestino = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCuentaOrigen
            // 
            lblCuentaOrigen.AutoSize = true;
            lblCuentaOrigen.ForeColor = Color.FromArgb(0, 64, 0);
            lblCuentaOrigen.Location = new Point(35, 118);
            lblCuentaOrigen.Name = "lblCuentaOrigen";
            lblCuentaOrigen.Size = new Size(50, 20);
            lblCuentaOrigen.TabIndex = 0;
            lblCuentaOrigen.Text = "label1";
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = Color.FromArgb(0, 64, 0);
            btnAceptar.Location = new Point(118, 272);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(104, 38);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // numMonto
            // 
            numMonto.BackColor = Color.White;
            numMonto.ForeColor = Color.FromArgb(0, 64, 0);
            numMonto.Location = new Point(264, 152);
            numMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(105, 27);
            numMonto.TabIndex = 2;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.ForeColor = Color.FromArgb(0, 64, 0);
            lblSaldo.Location = new Point(35, 154);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(50, 20);
            lblSaldo.TabIndex = 3;
            lblSaldo.Text = "label2";
            // 
            // lblCuentaDestino
            // 
            lblCuentaDestino.AutoSize = true;
            lblCuentaDestino.ForeColor = Color.FromArgb(0, 64, 0);
            lblCuentaDestino.Location = new Point(35, 202);
            lblCuentaDestino.Name = "lblCuentaDestino";
            lblCuentaDestino.Size = new Size(50, 20);
            lblCuentaDestino.TabIndex = 4;
            lblCuentaDestino.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(389, 159);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 6;
            label1.Text = "Monto a Transferir";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.FromArgb(0, 64, 0);
            btnCancelar.Location = new Point(389, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 38);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TransferenciaForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(595, 337);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(lblCuentaDestino);
            Controls.Add(lblSaldo);
            Controls.Add(numMonto);
            Controls.Add(btnAceptar);
            Controls.Add(lblCuentaOrigen);
            Name = "TransferenciaForms";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuentaOrigen;
        private Button btnAceptar;
        private NumericUpDown numMonto;
        private Label lblSaldo;
        private Label lblCuentaDestino;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCancelar;
    }
}