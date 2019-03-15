namespace WindowsFormsApplication3
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
            this.textboxnum1 = new System.Windows.Forms.TextBox();
            this.textboxnum2 = new System.Windows.Forms.TextBox();
            this.labelnum1 = new System.Windows.Forms.Label();
            this.labelnum2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxnum1
            // 
            this.textboxnum1.Location = new System.Drawing.Point(115, 64);
            this.textboxnum1.Name = "textboxnum1";
            this.textboxnum1.Size = new System.Drawing.Size(100, 22);
            this.textboxnum1.TabIndex = 0;
            this.textboxnum1.Tag = "textboxnum1";
            this.textboxnum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textboxnum2
            // 
            this.textboxnum2.Location = new System.Drawing.Point(115, 121);
            this.textboxnum2.Name = "textboxnum2";
            this.textboxnum2.Size = new System.Drawing.Size(100, 22);
            this.textboxnum2.TabIndex = 1;
            this.textboxnum2.Tag = "textboxnum2";
            // 
            // labelnum1
            // 
            this.labelnum1.AutoSize = true;
            this.labelnum1.Location = new System.Drawing.Point(48, 64);
            this.labelnum1.Name = "labelnum1";
            this.labelnum1.Size = new System.Drawing.Size(45, 17);
            this.labelnum1.TabIndex = 2;
            this.labelnum1.Tag = "labelnum1";
            this.labelnum1.Text = "Num1";
            // 
            // labelnum2
            // 
            this.labelnum2.AutoSize = true;
            this.labelnum2.Location = new System.Drawing.Point(48, 121);
            this.labelnum2.Name = "labelnum2";
            this.labelnum2.Size = new System.Drawing.Size(45, 17);
            this.labelnum2.TabIndex = 3;
            this.labelnum2.Tag = "labelnum2";
            this.labelnum2.Text = "Num2";
            this.labelnum2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide"});
            this.comboBox1.Location = new System.Drawing.Point(269, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.AccessibleName = "cbOperation";
            this.btnCalc.Location = new System.Drawing.Point(269, 114);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(121, 29);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Tag = "btnCalc";
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtresult
            // 
            this.txtresult.AccessibleName = "txtresult";
            this.txtresult.Location = new System.Drawing.Point(115, 174);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(275, 22);
            this.txtresult.TabIndex = 6;
            this.txtresult.Tag = "txtresult";
            this.txtresult.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 408);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelnum2);
            this.Controls.Add(this.labelnum1);
            this.Controls.Add(this.textboxnum2);
            this.Controls.Add(this.textboxnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxnum1;
        private System.Windows.Forms.TextBox textboxnum2;
        private System.Windows.Forms.Label labelnum1;
        private System.Windows.Forms.Label labelnum2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtresult;
    }
}

