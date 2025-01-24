namespace Slug_A_Palooza
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(202, 288);
            button1.Name = "button1";
            button1.Size = new Size(156, 44);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 75);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "First Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 111);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Second Location";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 149);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 3;
            label3.Text = "Thrid Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 186);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 4;
            label4.Text = "Fourth Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 225);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 5;
            label5.Text = "Fifth Location";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(233, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(233, 222);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F);
            label6.Location = new Point(105, 32);
            label6.Name = "label6";
            label6.Size = new Size(304, 20);
            label6.TabIndex = 11;
            label6.Text = "Enter number of slugs into each location";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F);
            label7.Location = new Point(177, 350);
            label7.Name = "label7";
            label7.Size = new Size(206, 20);
            label7.TabIndex = 12;
            label7.Text = "Total number of slugs is ...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Slug_A_Palooza";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
    }
}
