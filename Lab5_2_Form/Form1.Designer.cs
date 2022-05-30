
namespace Lab5_2_Form
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
            this.components = new System.ComponentModel.Container();
            this.Block1 = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.Block2 = new System.Windows.Forms.Button();
            this.Block3 = new System.Windows.Forms.Button();
            this.Block4 = new System.Windows.Forms.Button();
            this.FPSnumeric = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.x_factor = new System.Windows.Forms.Label();
            this.y_factor = new System.Windows.Forms.Label();
            this.x_period = new System.Windows.Forms.Label();
            this.y_period = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // Block1
            // 
            this.Block1.Location = new System.Drawing.Point(96, 12);
            this.Block1.Name = "Block1";
            this.Block1.Size = new System.Drawing.Size(114, 48);
            this.Block1.TabIndex = 0;
            this.Block1.Text = "Block1";
            this.Block1.UseVisualStyleBackColor = true;
            this.Block1.Click += new System.EventHandler(this.Block1_Click);
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(12, 109);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(600, 400);
            this.Canvas.TabIndex = 1;
            this.Canvas.TabStop = false;
            // 
            // Block2
            // 
            this.Block2.Location = new System.Drawing.Point(244, 12);
            this.Block2.Name = "Block2";
            this.Block2.Size = new System.Drawing.Size(114, 48);
            this.Block2.TabIndex = 2;
            this.Block2.Text = "Block2";
            this.Block2.UseVisualStyleBackColor = true;
            this.Block2.Click += new System.EventHandler(this.Block2_Click);
            // 
            // Block3
            // 
            this.Block3.Location = new System.Drawing.Point(388, 12);
            this.Block3.Name = "Block3";
            this.Block3.Size = new System.Drawing.Size(114, 48);
            this.Block3.TabIndex = 3;
            this.Block3.Text = "Block3";
            this.Block3.UseVisualStyleBackColor = true;
            this.Block3.Click += new System.EventHandler(this.Block3_Click);
            // 
            // Block4
            // 
            this.Block4.Location = new System.Drawing.Point(530, 12);
            this.Block4.Name = "Block4";
            this.Block4.Size = new System.Drawing.Size(114, 48);
            this.Block4.TabIndex = 4;
            this.Block4.Text = "Block4";
            this.Block4.UseVisualStyleBackColor = true;
            this.Block4.Click += new System.EventHandler(this.Block4_Click);
            // 
            // FPSnumeric
            // 
            this.FPSnumeric.Location = new System.Drawing.Point(663, 179);
            this.FPSnumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FPSnumeric.Name = "FPSnumeric";
            this.FPSnumeric.Size = new System.Drawing.Size(120, 23);
            this.FPSnumeric.TabIndex = 5;
            this.FPSnumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "FPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(820, 295);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(820, 324);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(820, 353);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown3.TabIndex = 11;
            this.numericUpDown3.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(820, 382);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown4.TabIndex = 12;
            this.numericUpDown4.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // x_factor
            // 
            this.x_factor.AutoSize = true;
            this.x_factor.Location = new System.Drawing.Point(946, 297);
            this.x_factor.Name = "x_factor";
            this.x_factor.Size = new System.Drawing.Size(49, 15);
            this.x_factor.TabIndex = 13;
            this.x_factor.Text = "x_factor";
            // 
            // y_factor
            // 
            this.y_factor.AutoSize = true;
            this.y_factor.Location = new System.Drawing.Point(946, 326);
            this.y_factor.Name = "y_factor";
            this.y_factor.Size = new System.Drawing.Size(49, 15);
            this.y_factor.TabIndex = 14;
            this.y_factor.Text = "y_factor";
            // 
            // x_period
            // 
            this.x_period.AutoSize = true;
            this.x_period.Location = new System.Drawing.Point(946, 355);
            this.x_period.Name = "x_period";
            this.x_period.Size = new System.Drawing.Size(52, 15);
            this.x_period.TabIndex = 15;
            this.x_period.Text = "x_period";
            // 
            // y_period
            // 
            this.y_period.AutoSize = true;
            this.y_period.Location = new System.Drawing.Point(946, 384);
            this.y_period.Name = "y_period";
            this.y_period.Size = new System.Drawing.Size(52, 15);
            this.y_period.TabIndex = 16;
            this.y_period.Text = "y_peroid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Enter ur parameters for changing the ball\'s movement";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "This fields are using for Block3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 606);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.y_period);
            this.Controls.Add(this.x_period);
            this.Controls.Add(this.y_factor);
            this.Controls.Add(this.x_factor);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FPSnumeric);
            this.Controls.Add(this.Block4);
            this.Controls.Add(this.Block3);
            this.Controls.Add(this.Block2);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.Block1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Block1;
        private System.Windows.Forms.PictureBox Canvas;
        internal System.Windows.Forms.Button Block2;
        internal System.Windows.Forms.Button Block3;
        internal System.Windows.Forms.Button Block4;
        private System.Windows.Forms.NumericUpDown FPSnumeric;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label x_factor;
        private System.Windows.Forms.Label y_factor;
        private System.Windows.Forms.Label x_period;
        private System.Windows.Forms.Label y_period;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
    }
}

