namespace tp_Modul3
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
            button1 = new Button();
            textBox1 = new TextBox();
            labelOutput = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(250, 50);
            button1.Name = "button1";
            button1.Size = new Size(100, 27);
            button1.TabIndex = 0;
            button1.Text = "Button";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.OrangeRed;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(50, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "INPUT";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // labelOutput
            // 
            labelOutput.BackColor = Color.OrangeRed;
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(50, 121);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(300, 30);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "OUTPUT";
            labelOutput.TextAlign = ContentAlignment.MiddleCenter;
            labelOutput.Click += labelOutput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 300);
            Controls.Add(labelOutput);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Praktikum GUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label labelOutput;
    }
}
