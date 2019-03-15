namespace WindowsFormsApplication2
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
            this.Num1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOperation = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxnum1
            // 
            this.textboxnum1.Location = new System.Drawing.Point(113, 23);
            this.textboxnum1.Name = "textboxnum1";
            this.textboxnum1.Size = new System.Drawing.Size(100, 22);
            this.textboxnum1.TabIndex = 0;
            // 
            // textboxnum2
            // 
            this.textboxnum2.Location = new System.Drawing.Point(113, 65);
            this.textboxnum2.Name = "textboxnum2";
            this.textboxnum2.Size = new System.Drawing.Size(100, 22);
            this.textboxnum2.TabIndex = 1;
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(61, 26);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(49, 17);
            this.Num1.TabIndex = 2;
            this.Num1.Text = "Num 1";
            this.Num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num 2";
            // 
            // cboOperation
            // 
            this.cboOperation.FormattingEnabled = true;
            this.cboOperation.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide"});
            this.cboOperation.Location = new System.Drawing.Point(238, 21);
            this.cboOperation.Name = "cboOperation";
            this.cboOperation.Size = new System.Drawing.Size(152, 24);
            this.cboOperation.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.AccessibleName = "btnCalc";
            this.btnCalc.Location = new System.Drawing.Point(238, 65);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(117, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Tag = "btnCalc";
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 380);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cboOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num1);
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
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOperation;
        private System.Windows.Forms.Button btnCalc;
    }
}

