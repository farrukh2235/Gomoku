namespace gomoku
{
    partial class GForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_click = new System.Windows.Forms.Button();
            this.fifteenX15 = new System.Windows.Forms.RadioButton();
            this.tenX10 = new System.Windows.Forms.RadioButton();
            this.fiveX5 = new System.Windows.Forms.RadioButton();
            this.grid = new System.Windows.Forms.FlowLayoutPanel();
            this.vshuman = new System.Windows.Forms.RadioButton();
            this.vsmachine = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.start_click);
            this.panel1.Controls.Add(this.fifteenX15);
            this.panel1.Controls.Add(this.tenX10);
            this.panel1.Controls.Add(this.fiveX5);
            this.panel1.Location = new System.Drawing.Point(16, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1933, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // start_click
            // 
            this.start_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_click.Location = new System.Drawing.Point(780, 57);
            this.start_click.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_click.Name = "start_click";
            this.start_click.Size = new System.Drawing.Size(209, 63);
            this.start_click.TabIndex = 3;
            this.start_click.Text = "START";
            this.start_click.UseVisualStyleBackColor = true;
            this.start_click.Click += new System.EventHandler(this.start_Click);
            // 
            // fifteenX15
            // 
            this.fifteenX15.AutoSize = true;
            this.fifteenX15.Location = new System.Drawing.Point(1431, 28);
            this.fifteenX15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fifteenX15.Name = "fifteenX15";
            this.fifteenX15.Size = new System.Drawing.Size(67, 21);
            this.fifteenX15.TabIndex = 2;
            this.fifteenX15.TabStop = true;
            this.fifteenX15.Text = "15x15";
            this.fifteenX15.UseVisualStyleBackColor = true;
            this.fifteenX15.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // tenX10
            // 
            this.tenX10.AutoSize = true;
            this.tenX10.Location = new System.Drawing.Point(837, 28);
            this.tenX10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenX10.Name = "tenX10";
            this.tenX10.Size = new System.Drawing.Size(67, 21);
            this.tenX10.TabIndex = 1;
            this.tenX10.TabStop = true;
            this.tenX10.Text = "10x10";
            this.tenX10.UseVisualStyleBackColor = true;
            this.tenX10.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // fiveX5
            // 
            this.fiveX5.AutoSize = true;
            this.fiveX5.Location = new System.Drawing.Point(253, 28);
            this.fiveX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fiveX5.Name = "fiveX5";
            this.fiveX5.Size = new System.Drawing.Size(51, 21);
            this.fiveX5.TabIndex = 0;
            this.fiveX5.TabStop = true;
            this.fiveX5.Text = "5x5";
            this.fiveX5.UseVisualStyleBackColor = true;
            this.fiveX5.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(16, 137);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1952, 638);
            this.grid.TabIndex = 1;
            // 
            // vshuman
            // 
            this.vshuman.AutoSize = true;
            this.vshuman.Location = new System.Drawing.Point(85, 3);
            this.vshuman.Name = "vshuman";
            this.vshuman.Size = new System.Drawing.Size(90, 21);
            this.vshuman.TabIndex = 2;
            this.vshuman.TabStop = true;
            this.vshuman.Text = "vs human";
            this.vshuman.UseVisualStyleBackColor = true;
            this.vshuman.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // vsmachine
            // 
            this.vsmachine.AutoSize = true;
            this.vsmachine.Location = new System.Drawing.Point(75, 51);
            this.vsmachine.Name = "vsmachine";
            this.vsmachine.Size = new System.Drawing.Size(100, 21);
            this.vsmachine.TabIndex = 4;
            this.vsmachine.TabStop = true;
            this.vsmachine.Text = "vs machine";
            this.vsmachine.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vshuman);
            this.panel2.Controls.Add(this.vsmachine);
            this.panel2.Location = new System.Drawing.Point(370, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 789);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GForm";
            this.Text = "GOMUKO";
            this.Load += new System.EventHandler(this.GForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton fifteenX15;
        private System.Windows.Forms.RadioButton tenX10;
        private System.Windows.Forms.RadioButton fiveX5;
        private System.Windows.Forms.Button start_click;
        private System.Windows.Forms.FlowLayoutPanel grid;
        private System.Windows.Forms.RadioButton vshuman;
        private System.Windows.Forms.RadioButton vsmachine;
        private System.Windows.Forms.Panel panel2;
    }
}

