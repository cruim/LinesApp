namespace LinesApp
{
    partial class Form1
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
            this.canvass = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number_of_lines = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.increment = new System.Windows.Forms.TextBox();
            this.go_btn = new System.Windows.Forms.Button();
            this.canvass.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvass
            // 
            this.canvass.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.canvass.Controls.Add(this.go_btn);
            this.canvass.Controls.Add(this.increment);
            this.canvass.Controls.Add(this.length);
            this.canvass.Controls.Add(this.angle);
            this.canvass.Controls.Add(this.number_of_lines);
            this.canvass.Controls.Add(this.label4);
            this.canvass.Controls.Add(this.label3);
            this.canvass.Controls.Add(this.label2);
            this.canvass.Controls.Add(this.label1);
            this.canvass.Dock = System.Windows.Forms.DockStyle.Top;
            this.canvass.Location = new System.Drawing.Point(0, 0);
            this.canvass.Name = "canvass";
            this.canvass.Size = new System.Drawing.Size(584, 46);
            this.canvass.TabIndex = 0;
            this.canvass.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Info;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 46);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(584, 447);
            this.canvas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(139, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(257, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(381, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Increment";
            // 
            // number_of_lines
            // 
            this.number_of_lines.Location = new System.Drawing.Point(89, 8);
            this.number_of_lines.Name = "number_of_lines";
            this.number_of_lines.Size = new System.Drawing.Size(30, 20);
            this.number_of_lines.TabIndex = 1;
            this.number_of_lines.Text = "100";
            this.number_of_lines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(207, 8);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(30, 20);
            this.angle.TabIndex = 1;
            this.angle.Text = "36";
            this.angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(331, 8);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(30, 20);
            this.length.TabIndex = 1;
            this.length.Text = "50";
            this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(476, 8);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(30, 20);
            this.increment.TabIndex = 1;
            this.increment.Text = "1";
            this.increment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // go_btn
            // 
            this.go_btn.Location = new System.Drawing.Point(526, 8);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(44, 20);
            this.go_btn.TabIndex = 2;
            this.go_btn.Text = "Go";
            this.go_btn.UseVisualStyleBackColor = true;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 493);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.canvass);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abstract Lines";
            this.canvass.ResumeLayout(false);
            this.canvass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvass;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.TextBox increment;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.TextBox number_of_lines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel canvas;
    }
}

