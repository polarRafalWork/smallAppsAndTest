namespace FarmerTester
{
    partial class FarmerTester
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
            this.labelDescript1 = new System.Windows.Forms.Label();
            this.numericUpDownCowQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCowQuantity)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescript1
            // 
            this.labelDescript1.AutoSize = true;
            this.labelDescript1.Location = new System.Drawing.Point(6, 32);
            this.labelDescript1.Name = "labelDescript1";
            this.labelDescript1.Size = new System.Drawing.Size(58, 13);
            this.labelDescript1.TabIndex = 0;
            this.labelDescript1.Text = "Ilość krów:";
            // 
            // numericUpDownCowQuantity
            // 
            this.numericUpDownCowQuantity.Location = new System.Drawing.Point(93, 30);
            this.numericUpDownCowQuantity.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownCowQuantity.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownCowQuantity.Name = "numericUpDownCowQuantity";
            this.numericUpDownCowQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCowQuantity.TabIndex = 1;
            this.numericUpDownCowQuantity.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownCowQuantity.ValueChanged += new System.EventHandler(this.numericUpDownCowQuantity_ValueChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(118, 66);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(306, 130);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelDescript1);
            this.tabPage1.Controls.Add(this.numericUpDownCowQuantity);
            this.tabPage1.Controls.Add(this.buttonCalculate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(298, 104);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(298, 104);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FarmerTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 236);
            this.Controls.Add(this.tabControl1);
            this.Name = "FarmerTester";
            this.Text = "KalkulatorKrow";
            this.Load += new System.EventHandler(this.FarmerTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCowQuantity)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDescript1;
        private System.Windows.Forms.NumericUpDown numericUpDownCowQuantity;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

