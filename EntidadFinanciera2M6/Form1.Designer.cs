namespace EntidadFinanciera2M6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAgregarCliente = new Button();
            dgvClientes = new DataGridView();
            dgvCuentas = new DataGridView();
            btnAgregarCuenta = new Button();
            btnDesctivarCuenta = new Button();
            btnTransferencia = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarCliente.ForeColor = Color.FromArgb(0, 64, 0);
            btnAgregarCliente.Location = new Point(303, 57);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(156, 39);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "AgregarCliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Dock = DockStyle.Bottom;
            dgvClientes.GridColor = Color.FromArgb(0, 64, 0);
            dgvClientes.Location = new Point(0, 149);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(665, 301);
            dgvClientes.TabIndex = 1;
            // 
            // dgvCuentas
            // 
            dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentas.BackgroundColor = Color.White;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Dock = DockStyle.Bottom;
            dgvCuentas.GridColor = Color.FromArgb(0, 64, 0);
            dgvCuentas.Location = new Point(0, 149);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(682, 301);
            dgvCuentas.TabIndex = 2;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarCuenta.ForeColor = Color.FromArgb(0, 64, 0);
            btnAgregarCuenta.Location = new Point(477, 57);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(160, 39);
            btnAgregarCuenta.TabIndex = 3;
            btnAgregarCuenta.Text = "Agregar Cuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += btnAgregarCuenta_Click;
            // 
            // btnDesctivarCuenta
            // 
            btnDesctivarCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDesctivarCuenta.ForeColor = Color.FromArgb(0, 64, 0);
            btnDesctivarCuenta.Location = new Point(69, 57);
            btnDesctivarCuenta.Name = "btnDesctivarCuenta";
            btnDesctivarCuenta.Size = new Size(144, 39);
            btnDesctivarCuenta.TabIndex = 4;
            btnDesctivarCuenta.Text = "Desactivar Cuenta";
            btnDesctivarCuenta.UseVisualStyleBackColor = true;
            btnDesctivarCuenta.Click += btnDesctivarCuenta_Click;
            // 
            // btnTransferencia
            // 
            btnTransferencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransferencia.ForeColor = Color.FromArgb(0, 64, 0);
            btnTransferencia.Location = new Point(276, 57);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(121, 39);
            btnTransferencia.TabIndex = 5;
            btnTransferencia.Text = "Transferir";
            btnTransferencia.UseVisualStyleBackColor = true;
            btnTransferencia.Click += btnTransferencia_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(456, 57);
            button1.Name = "button1";
            button1.Size = new Size(158, 39);
            button1.TabIndex = 6;
            button1.Text = "Ver Trasnferencias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAgregarCliente);
            panel1.Controls.Add(btnAgregarCuenta);
            panel1.Controls.Add(dgvClientes);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.FromArgb(0, 64, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 450);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnTransferencia);
            panel2.Controls.Add(dgvCuentas);
            panel2.Controls.Add(btnDesctivarCuenta);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(667, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 450);
            panel2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1349, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarCliente;
        private DataGridView dgvClientes;
        private DataGridView dgvCuentas;
        private Button btnAgregarCuenta;
        private Button btnDesctivarCuenta;
        private Button btnTransferencia;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
