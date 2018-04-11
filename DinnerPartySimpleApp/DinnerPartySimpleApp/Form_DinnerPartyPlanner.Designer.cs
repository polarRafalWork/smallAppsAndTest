namespace DinnerPartySimpleApp
{
    partial class Form_DinnerPartyPlanner
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
            this.numericUpDownIloscOsob = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFancy = new System.Windows.Forms.CheckBox();
            this.checkBoxHealthyOption = new System.Windows.Forms.CheckBox();
            this.labelDescript2 = new System.Windows.Forms.Label();
            this.labelKoszt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscOsob)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescript1
            // 
            this.labelDescript1.AutoSize = true;
            this.labelDescript1.Location = new System.Drawing.Point(58, 36);
            this.labelDescript1.Name = "labelDescript1";
            this.labelDescript1.Size = new System.Drawing.Size(58, 13);
            this.labelDescript1.TabIndex = 0;
            this.labelDescript1.Text = "Ilość osób:";
            // 
            // numericUpDownIloscOsob
            // 
            this.numericUpDownIloscOsob.Location = new System.Drawing.Point(61, 62);
            this.numericUpDownIloscOsob.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIloscOsob.Name = "numericUpDownIloscOsob";
            this.numericUpDownIloscOsob.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownIloscOsob.TabIndex = 1;
            this.numericUpDownIloscOsob.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownIloscOsob.ValueChanged += new System.EventHandler(this.numericUpDownIloscOsob_ValueChanged);
            // 
            // checkBoxFancy
            // 
            this.checkBoxFancy.AutoSize = true;
            this.checkBoxFancy.Checked = true;
            this.checkBoxFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFancy.Location = new System.Drawing.Point(61, 99);
            this.checkBoxFancy.Name = "checkBoxFancy";
            this.checkBoxFancy.Size = new System.Drawing.Size(126, 17);
            this.checkBoxFancy.TabIndex = 2;
            this.checkBoxFancy.Text = "Dekoracje fantazyjne";
            this.checkBoxFancy.UseVisualStyleBackColor = true;
            this.checkBoxFancy.CheckedChanged += new System.EventHandler(this.checkBoxFancy_CheckedChanged);
            // 
            // checkBoxHealthyOption
            // 
            this.checkBoxHealthyOption.AutoSize = true;
            this.checkBoxHealthyOption.Location = new System.Drawing.Point(61, 123);
            this.checkBoxHealthyOption.Name = "checkBoxHealthyOption";
            this.checkBoxHealthyOption.Size = new System.Drawing.Size(91, 17);
            this.checkBoxHealthyOption.TabIndex = 3;
            this.checkBoxHealthyOption.Text = "Opcja zdrowa";
            this.checkBoxHealthyOption.UseVisualStyleBackColor = true;
            this.checkBoxHealthyOption.CheckedChanged += new System.EventHandler(this.checkBoxHealthyOption_CheckedChanged);
            // 
            // labelDescript2
            // 
            this.labelDescript2.AutoSize = true;
            this.labelDescript2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescript2.Location = new System.Drawing.Point(61, 147);
            this.labelDescript2.Name = "labelDescript2";
            this.labelDescript2.Size = new System.Drawing.Size(59, 20);
            this.labelDescript2.TabIndex = 4;
            this.labelDescript2.Text = "Koszt:";
            // 
            // labelKoszt
            // 
            this.labelKoszt.AutoSize = true;
            this.labelKoszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKoszt.Location = new System.Drawing.Point(126, 147);
            this.labelKoszt.Name = "labelKoszt";
            this.labelKoszt.Size = new System.Drawing.Size(65, 20);
            this.labelKoszt.TabIndex = 5;
            this.labelKoszt.Text = "##.## zł";
            // 
            // Form_DinnerPartyPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 210);
            this.Controls.Add(this.labelKoszt);
            this.Controls.Add(this.labelDescript2);
            this.Controls.Add(this.checkBoxHealthyOption);
            this.Controls.Add(this.checkBoxFancy);
            this.Controls.Add(this.numericUpDownIloscOsob);
            this.Controls.Add(this.labelDescript1);
            this.Name = "Form_DinnerPartyPlanner";
            this.Text = "DinnerPartyPlanner";
            this.Load += new System.EventHandler(this.Form_DinnerPartyPlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscOsob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescript1;
        private System.Windows.Forms.NumericUpDown numericUpDownIloscOsob;
        private System.Windows.Forms.CheckBox checkBoxFancy;
        private System.Windows.Forms.CheckBox checkBoxHealthyOption;
        private System.Windows.Forms.Label labelDescript2;
        private System.Windows.Forms.Label labelKoszt;
    }
}

