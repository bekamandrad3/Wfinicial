namespace Wfinicial
{
    partial class FormsEx6
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
            btnCalcular = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblValorHora = new Label();
            lblQuantidadeHora = new Label();
            txtValorHora = new TextBox();
            txtQuantidadeHora = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(145, 242);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(145, 92);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(191, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(149, 128);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(78, 15);
            lblValorHora.TabIndex = 3;
            lblValorHora.Text = "Valor da Hora";
            // 
            // lblQuantidadeHora
            // 
            lblQuantidadeHora.AutoSize = true;
            lblQuantidadeHora.Location = new Point(156, 163);
            lblQuantidadeHora.Name = "lblQuantidadeHora";
            lblQuantidadeHora.Size = new Size(114, 15);
            lblQuantidadeHora.TabIndex = 4;
            lblQuantidadeHora.Text = "Quantidade da Hora";
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(235, 125);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 5;
            // 
            // txtQuantidadeHora
            // 
            txtQuantidadeHora.Location = new Point(276, 160);
            txtQuantidadeHora.Name = "txtQuantidadeHora";
            txtQuantidadeHora.Size = new Size(100, 23);
            txtQuantidadeHora.TabIndex = 6;
            // 
            // FormsEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuantidadeHora);
            Controls.Add(txtValorHora);
            Controls.Add(lblQuantidadeHora);
            Controls.Add(lblValorHora);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnCalcular);
            Name = "FormsEx6";
            Text = "FormsEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblValorHora;
        private Label lblQuantidadeHora;
        private TextBox txtValorHora;
        private TextBox txtQuantidadeHora;
    }
}