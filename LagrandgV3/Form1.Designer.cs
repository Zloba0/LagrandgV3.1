namespace LagrandgV3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.f1 = new System.Windows.Forms.CheckBox();
            this.f2 = new System.Windows.Forms.CheckBox();
            this.f3 = new System.Windows.Forms.CheckBox();
            this.f4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(22, 30);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(346, 288);
            this.zedGraph.TabIndex = 0;
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Location = new System.Drawing.Point(635, 126);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(113, 17);
            this.f1.TabIndex = 1;
            this.f1.Text = "y = 1 / (1 + 25x^2)";
            this.f1.UseVisualStyleBackColor = true;
            // 
            // f2
            // 
            this.f2.AutoSize = true;
            this.f2.Location = new System.Drawing.Point(635, 149);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(60, 17);
            this.f2.TabIndex = 2;
            this.f2.Text = "y = x^2";
            this.f2.UseVisualStyleBackColor = true;
            // 
            // f3
            // 
            this.f3.AutoSize = true;
            this.f3.Location = new System.Drawing.Point(635, 172);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(52, 17);
            this.f3.TabIndex = 3;
            this.f3.Text = "y = |x|";
            this.f3.UseVisualStyleBackColor = true;
            // 
            // f4
            // 
            this.f4.AutoSize = true;
            this.f4.Location = new System.Drawing.Point(635, 195);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(70, 17);
            this.f4.TabIndex = 4;
            this.f4.Text = "e^(-kx^2)";
            this.f4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lagrange polynomial with equally spaced nodes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Lagrange polynomial with Chebyshev nodes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Input number of nods n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(635, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(502, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(93, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Input parameter k";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(635, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cubic splines";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.f4);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.CheckBox f1;
        private System.Windows.Forms.CheckBox f2;
        private System.Windows.Forms.CheckBox f3;
        private System.Windows.Forms.CheckBox f4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
    }
}
