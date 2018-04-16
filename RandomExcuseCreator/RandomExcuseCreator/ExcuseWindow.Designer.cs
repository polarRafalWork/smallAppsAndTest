namespace RandomExcuseCreator
{
    partial class ExcuseWindow
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
            this.labelExcuse = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelLastUsed = new System.Windows.Forms.Label();
            this.labelFileDate = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.textBoxFileDate = new System.Windows.Forms.TextBox();
            this.buttonChoseFolder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRandomExcuse = new System.Windows.Forms.Button();
            this.dateTimePickerLastUsed = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelExcuse
            // 
            this.labelExcuse.AutoSize = true;
            this.labelExcuse.Location = new System.Drawing.Point(121, 51);
            this.labelExcuse.Name = "labelExcuse";
            this.labelExcuse.Size = new System.Drawing.Size(60, 13);
            this.labelExcuse.TabIndex = 0;
            this.labelExcuse.Text = "Wymówka:";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(121, 72);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(42, 13);
            this.labelResults.TabIndex = 1;
            this.labelResults.Text = "Wyniki:";
            // 
            // labelLastUsed
            // 
            this.labelLastUsed.AutoSize = true;
            this.labelLastUsed.Location = new System.Drawing.Point(121, 94);
            this.labelLastUsed.Name = "labelLastUsed";
            this.labelLastUsed.Size = new System.Drawing.Size(77, 13);
            this.labelLastUsed.TabIndex = 2;
            this.labelLastUsed.Text = "Ostatnio użyte:";
            // 
            // labelFileDate
            // 
            this.labelFileDate.AutoSize = true;
            this.labelFileDate.Location = new System.Drawing.Point(121, 118);
            this.labelFileDate.Name = "labelFileDate";
            this.labelFileDate.Size = new System.Drawing.Size(58, 13);
            this.labelFileDate.TabIndex = 3;
            this.labelFileDate.Text = "Data pliku:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(212, 44);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(236, 20);
            this.textBoxDescription.TabIndex = 4;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(212, 70);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(236, 20);
            this.textBoxResults.TabIndex = 5;
            this.textBoxResults.TextChanged += new System.EventHandler(this.textBoxResults_TextChanged);
            // 
            // textBoxFileDate
            // 
            this.textBoxFileDate.Location = new System.Drawing.Point(212, 118);
            this.textBoxFileDate.Name = "textBoxFileDate";
            this.textBoxFileDate.Size = new System.Drawing.Size(236, 20);
            this.textBoxFileDate.TabIndex = 7;
            // 
            // buttonChoseFolder
            // 
            this.buttonChoseFolder.Location = new System.Drawing.Point(115, 153);
            this.buttonChoseFolder.Name = "buttonChoseFolder";
            this.buttonChoseFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonChoseFolder.TabIndex = 8;
            this.buttonChoseFolder.Text = "Folder";
            this.buttonChoseFolder.UseVisualStyleBackColor = true;
            this.buttonChoseFolder.Click += new System.EventHandler(this.buttonChoseFolder_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(196, 153);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(277, 153);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Otwórz";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonRandomExcuse
            // 
            this.buttonRandomExcuse.Location = new System.Drawing.Point(358, 153);
            this.buttonRandomExcuse.Name = "buttonRandomExcuse";
            this.buttonRandomExcuse.Size = new System.Drawing.Size(106, 23);
            this.buttonRandomExcuse.TabIndex = 11;
            this.buttonRandomExcuse.Text = "Losowa wymówka";
            this.buttonRandomExcuse.UseVisualStyleBackColor = true;
            this.buttonRandomExcuse.Click += new System.EventHandler(this.buttonRandomExcuse_Click);
            // 
            // dateTimePickerLastUsed
            // 
            this.dateTimePickerLastUsed.Location = new System.Drawing.Point(212, 94);
            this.dateTimePickerLastUsed.Name = "dateTimePickerLastUsed";
            this.dateTimePickerLastUsed.Size = new System.Drawing.Size(236, 20);
            this.dateTimePickerLastUsed.TabIndex = 12;
            this.dateTimePickerLastUsed.ValueChanged += new System.EventHandler(this.dateTimePickerLastUsed_ValueChanged);
            // 
            // ExcuseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 222);
            this.Controls.Add(this.dateTimePickerLastUsed);
            this.Controls.Add(this.buttonRandomExcuse);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonChoseFolder);
            this.Controls.Add(this.textBoxFileDate);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelFileDate);
            this.Controls.Add(this.labelLastUsed);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelExcuse);
            this.Name = "ExcuseWindow";
            this.Text = "ExcuseWindow";
            this.Load += new System.EventHandler(this.ExcuseWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExcuse;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelLastUsed;
        private System.Windows.Forms.Label labelFileDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.TextBox textBoxFileDate;
        private System.Windows.Forms.Button buttonChoseFolder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRandomExcuse;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastUsed;
    }
}

