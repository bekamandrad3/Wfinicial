namespace Wfinicial
{
    partial class FormEx5
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
            label3 = new Label();
            txtNum3 = new TextBox();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            btnMaior = new Button();
            lblNum3 = new Label();
            lblNum2 = new Label();
            lblNum1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 137);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(405, 240);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 16;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(405, 198);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 15;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(405, 151);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 14;
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(320, 277);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(169, 23);
            btnMaior.TabIndex = 13;
            btnMaior.Text = "Mostrar Maior e Menor";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(295, 240);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(60, 15);
            lblNum3.TabIndex = 12;
            lblNum3.Text = "Numero 3";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(295, 206);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 11;
            lblNum2.Text = "Numero 2";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(295, 154);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 10;
            lblNum1.Text = "Numero 1";
            // 
            // FormsEx5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnMaior);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(label3);
            Name = "FormsEx5";
            Text = "FormsEx5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtNum3;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Button btnMaior;
        private Label lblNum3;
        private Label lblNum2;
        private Label lblNum1;
    }
}