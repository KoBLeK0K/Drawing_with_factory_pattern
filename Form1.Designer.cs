
namespace _6Drawing
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeOfFigure = new System.Windows.Forms.TextBox();
            this.xAxis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yAxis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anglesOfMult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Construct = new System.Windows.Forms.Button();
            this.drawingSpace = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Треугольник",
            "Квадрат",
            "Круг",
            "Многоугольник"});
            this.comboBox1.Location = new System.Drawing.Point(12, 352);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип фигуры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер";
            // 
            // SizeOfFigure
            // 
            this.SizeOfFigure.Location = new System.Drawing.Point(150, 352);
            this.SizeOfFigure.Name = "SizeOfFigure";
            this.SizeOfFigure.Size = new System.Drawing.Size(100, 23);
            this.SizeOfFigure.TabIndex = 5;
            this.SizeOfFigure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeOfFigure_KeyPress);
            // 
            // xAxis
            // 
            this.xAxis.Location = new System.Drawing.Point(271, 352);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(100, 23);
            this.xAxis.TabIndex = 7;
            this.xAxis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xAxis_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Координаты середины";
            // 
            // yAxis
            // 
            this.yAxis.Location = new System.Drawing.Point(388, 352);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(100, 23);
            this.yAxis.TabIndex = 8;
            this.yAxis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yAxis_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Х";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // anglesOfMult
            // 
            this.anglesOfMult.Enabled = false;
            this.anglesOfMult.Location = new System.Drawing.Point(12, 406);
            this.anglesOfMult.Name = "anglesOfMult";
            this.anglesOfMult.Size = new System.Drawing.Size(121, 23);
            this.anglesOfMult.TabIndex = 11;
            this.anglesOfMult.TextChanged += new System.EventHandler(this.anglesOfMult_TextChanged);
            this.anglesOfMult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anglesOfMult_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество углов многоугольника";
            // 
            // Construct
            // 
            this.Construct.Location = new System.Drawing.Point(548, 351);
            this.Construct.Name = "Construct";
            this.Construct.Size = new System.Drawing.Size(223, 87);
            this.Construct.TabIndex = 13;
            this.Construct.Text = "Построить фигуру";
            this.Construct.UseVisualStyleBackColor = true;
            this.Construct.Click += new System.EventHandler(this.Construct_Click);
            // 
            // drawingSpace
            // 
            this.drawingSpace.Location = new System.Drawing.Point(12, 12);
            this.drawingSpace.Name = "drawingSpace";
            this.drawingSpace.Size = new System.Drawing.Size(776, 304);
            this.drawingSpace.TabIndex = 14;
            this.drawingSpace.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(652, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Наименование фигуры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.drawingSpace);
            this.Controls.Add(this.Construct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.anglesOfMult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yAxis);
            this.Controls.Add(this.xAxis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SizeOfFigure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Construct;
        private System.Windows.Forms.PictureBox drawingSpace;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox SizeOfFigure;
        public System.Windows.Forms.TextBox xAxis;
        public System.Windows.Forms.TextBox yAxis;
        public System.Windows.Forms.TextBox anglesOfMult;
    }
}

