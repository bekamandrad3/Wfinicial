namespace Wfinicial
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
            label1 = new Label();
            button2 = new Button();
            txtNota2 = new Label();
            textBox1 = new TextBox();
            txtNota1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 89);
            label1.Name = "label1";
            label1.Size = new Size(45, 30);
            label1.TabIndex = 0;
            label1.Text = "Nota 1:\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(63, 165);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 1;
            button2.Text = "Calcular Média:";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtNota2
            // 
            txtNota2.AutoSize = true;
            txtNota2.Location = new Point(63, 132);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(45, 15);
            txtNota2.TabIndex = 2;
            txtNota2.Text = "Nota 2:\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(114, 89);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 333);
            Controls.Add(txtNota1);
            Controls.Add(textBox1);
            Controls.Add(txtNota2);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Label txtNota2;
        private TextBox textBox1;
        private TextBox txtNota1;
    }
}
