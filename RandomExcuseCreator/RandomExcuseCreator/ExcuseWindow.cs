using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RandomExcuseCreator
{
    // operacje wejścia/wyjścia - zapis do pliku
    using System.IO;


    public partial class ExcuseWindow : Form
    {
        // FIELDS 
        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        Random random = new Random();
        private string selectedFolder = "";

        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();

        // METHODS


        public ExcuseWindow()
        {
            InitializeComponent();
            currentExcuse.LastUsed = dateTimePickerLastUsed.Value;
        }

        // onLoad formularza
        private void ExcuseWindow_Load(object sender, EventArgs e)
        {
            ChangeButtonsBeforeChoseFolder();
        }

        // Ustawia możliwe do kliknięcia przyciski po załadowaniu formularza
        private void ChangeButtonsBeforeChoseFolder()
        {
            if (buttonSave.Enabled == true)
            {
                buttonSave.Enabled = false;
                buttonOpen.Enabled = false;
                buttonRandomExcuse.Enabled = false;
                textBoxFileDate.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
                buttonOpen.Enabled = true;
                buttonRandomExcuse.Enabled = true;
            }

        }


        // Zaktualizowanie pól formularza
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.textBoxDescription.Text = currentExcuse.Description;
                this.textBoxResults.Text = currentExcuse.Results;
                //this.dateTimePickerLastUsed = currentExcuse.LastUsed.ToString("yyyy-MM-dd");
                this.dateTimePickerLastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    textBoxFileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }
                this.Text = "Program do zarządzania wymówkami";
            }
            else
            {
                this.Text = "Program do zarządzania wymówkami*";
            }
            this.formChanged = changed;
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }



        // OBSŁUGA PRZYCISKOW
        private void buttonChoseFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog.SelectedPath;
                ChangeButtonsBeforeChoseFolder();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDescription.Text ) || String.IsNullOrEmpty(textBoxResults.Text))
            {
                MessageBox.Show("Określ wymówkę i rezultat", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog.InitialDirectory = selectedFolder;
            saveFileDialog.FileName = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.FileName = textBoxDescription.Text + ".txt";

            DialogResult result = saveFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse.SaveFile(saveFileDialog.FileName);
                UpdateForm(false);
            }
            
        }

        private void buttonRandomExcuse_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = textBoxDescription.Text;
            UpdateForm(true);
        }

        private void textBoxResults_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = textBoxResults.Text;
            UpdateForm(true);
        }

        private void dateTimePickerLastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dateTimePickerLastUsed.Value;
            UpdateForm(true);
        }

        //private void textBoxLastUsed_TextChanged(object sender, EventArgs e)
        //{
        //    DateTime tmpDate = DateTime.ParseExact(textBoxLastUsed.Text, "yyyy-MM-dd,fff", System.Globalization.CultureInfo.InvariantCulture);
        //    currentExcuse.LastUsed = tmpDate;
        //    UpdateForm(true);
        //}
    }




}
