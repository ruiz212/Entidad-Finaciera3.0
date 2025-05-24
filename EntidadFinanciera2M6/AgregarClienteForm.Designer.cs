namespace EntidadFinanciera2M6
{
    partial class AgregarClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClienteForm));
            label1 = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            txtIdentificacion = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(169, 111);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.FromArgb(0, 64, 0);
            txtNombre.Location = new Point(278, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = Color.FromArgb(0, 64, 0);
            btnAceptar.Location = new Point(157, 219);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(154, 34);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.ForeColor = Color.FromArgb(0, 64, 0);
            txtIdentificacion.Location = new Point(278, 161);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(227, 27);
            txtIdentificacion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(169, 159);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 3;
            label2.Text = "Identificacion";
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.FromArgb(0, 64, 0);
            btnCancelar.Location = new Point(351, 219);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // AgregarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(599, 273);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(txtIdentificacion);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "AgregarClienteForm";
            Text = "Form2";
            Load += AgregarClienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnAceptar;
        private TextBox txtIdentificacion;
        private Label label2;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}