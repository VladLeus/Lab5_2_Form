
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
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSnumeric)).BeginInit();
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
            this.FPSnumeric.Name = "FPSnumeric";
            this.FPSnumeric.Size = new System.Drawing.Size(120, 23);
            this.FPSnumeric.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 520);
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
    }
}

