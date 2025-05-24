namespace EntidadFinanciera2M6
{
    partial class AgregarCuetasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCuetasForm));
            label1 = new Label();
            txtNumCuenta = new TextBox();
            numSaldoInicial = new NumericUpDown();
            btnAceptar = new Button();
            label2 = new Label();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numSaldoInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(142, 104);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero Cuenta";
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.ForeColor = Color.FromArgb(0, 64, 0);
            txtNumCuenta.Location = new Point(295, 101);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(148, 27);
            txtNumCuenta.TabIndex = 1;
            // 
            // numSaldoInicial
            // 
            numSaldoInicial.ForeColor = Color.FromArgb(0, 64, 0);
            numSaldoInicial.Location = new Point(294, 158);
            numSaldoInicial.Name = "numSaldoInicial";
            numSaldoInicial.Size = new Size(149, 27);
            numSaldoInicial.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = Color.FromArgb(0, 64, 0);
            btnAceptar.Location = new Point(157, 231);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 37);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(142, 160);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Saldo";
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.FromArgb(0, 64, 0);
            btnCancelar.Location = new Point(450, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // AgregarCuetasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 291);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(numSaldoInicial);
            Controls.Add(txtNumCuenta);
            Controls.Add(label1);
            Name = "AgregarCuetasForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numSaldoInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumCuenta;
        private NumericUpDown numSaldoInicial;
        private Button btnAceptar;
        private Label label2;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}