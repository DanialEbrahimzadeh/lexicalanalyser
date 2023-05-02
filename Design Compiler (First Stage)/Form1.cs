using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Design_Compiler__First_Stage_
{
    public partial class Form1 : Form
    {
        PrivateFontCollection Private_Fonts = new PrivateFontCollection();
        private string Source_File_Path;
        private string Source_File_Name;
        private string Result_Files_Saved_Path;
        private string SymbTable_Path;
        private string Phase1_Path;
        private string Error_Path;

        public Form1()
        {
            InitializeComponent();

            Preparation_Theme();
        }

        private void Preparation_Theme()
        {
            try
            {
                Private_Fonts.AddFontFile("..\\..\\fonts\\segoeui.ttf");
                Private_Fonts.AddFontFile("..\\..\\fonts\\segoeuil.ttf");

                OpenSourceLabel.Font = new Font(Private_Fonts.Families[0], 18, FontStyle.Regular);
                OpenSourceMessageLabel.Font = new Font(Private_Fonts.Families[1], 16, FontStyle.Regular);
                OpenSourceStartButton.Font = new Font(Private_Fonts.Families[1], 18, FontStyle.Regular);
                OpenSourceBrowseButton.Font = new Font(Private_Fonts.Families[1], 18, FontStyle.Regular);
                OpenSourcePathLabel.Font = new Font(Private_Fonts.Families[1], 12, FontStyle.Regular);

                ResultFileLabel.Font = new Font(Private_Fonts.Families[0], 18, FontStyle.Regular);
                ResultFilesMessageLabel.Font = new Font(Private_Fonts.Families[1], 16, FontStyle.Regular);
                ResultFilesSourceButton.Font = new Font(Private_Fonts.Families[1], 18, FontStyle.Regular);
                ResultFilesSymbleTableButton.Font = new Font(Private_Fonts.Families[1], 18, FontStyle.Regular);
                ResultFilesPhase1Button.Font = new Font(Private_Fonts.Families[1], 18, FontStyle.Regular);
                ResultFilesErrorsButton.Font = new Font(Private_Fonts.Families[1], 18, FontStyle.Regular);

                OpenSourceLabel.ForeColor = Color.DarkCyan;
                OpenSourceMessageLabel.ForeColor = Color.White;
                OpenSourcePathLabel.ForeColor = Color.Gold;

                ResultFileLabel.ForeColor = Color.DarkCyan;

                this.BackgroundImage = Image.FromFile("..\\..\\images\\back2.png");
                ExitButton.Image = Image.FromFile("..\\..\\images\\exit.png");
                RestartButton.Image = Image.FromFile("..\\..\\images\\restart.png");
                MinimizeButton.Image = Image.FromFile("..\\..\\images\\minimize.png");
                LogoPictureBox.Image = Image.FromFile("..\\..\\images\\firstlogo1.png");

                ScannerPanel.Enabled = false;
                SemanticButton.Enabled = false;
                ScannerButton_Click(null, EventArgs.Empty);

                OpenSourceStartButton.Enabled = false;
                //ResultFilesPanel.Enabled = false;
            }
            catch { }
        }


        #region Mouse Hover and Leave Events

        private void OpenSourceBrowseButton_MouseHover(object sender, EventArgs e)
        {
            OpenSourceBrowseButton.ForeColor = Color.DarkCyan;
        }

        private void OpenSourceBrowseButton_MouseLeave(object sender, EventArgs e)
        {
            OpenSourceBrowseButton.ForeColor = Color.White;
        }

        private void OpenSourceStartButton_MouseHover(object sender, EventArgs e)
        {
            OpenSourceStartButton.ForeColor = Color.DarkCyan;
        }

        private void OpenSourceStartButton_MouseLeave(object sender, EventArgs e)
        {
            OpenSourceStartButton.ForeColor = Color.White;
        }

        private void ResultFilesErrorsButton_MouseHover(object sender, EventArgs e)
        {
            ResultFilesErrorsButton.ForeColor = Color.DarkCyan;
        }

        private void ResultFilesErrorsButton_MouseLeave(object sender, EventArgs e)
        {
            ResultFilesErrorsButton.ForeColor = Color.White;
        }

        private void ResultFilesPhase1Button_MouseHover(object sender, EventArgs e)
        {
            ResultFilesPhase1Button.ForeColor = Color.DarkCyan;
        }

        private void ResultFilesPhase1Button_MouseLeave(object sender, EventArgs e)
        {
            ResultFilesPhase1Button.ForeColor = Color.White;
        }

        private void ResultFilesSymbleTableButton_MouseHover(object sender, EventArgs e)
        {
            ResultFilesSymbleTableButton.ForeColor = Color.DarkCyan;
        }

        private void ResultFilesSymbleTableButton_MouseLeave(object sender, EventArgs e)
        {
            ResultFilesSymbleTableButton.ForeColor = Color.White;
        }

        private void ResultFilesSourceButton_MouseHover(object sender, EventArgs e)
        {
            ResultFilesSourceButton.ForeColor = Color.DarkCyan;
        }

        private void ResultFilesSourceButton_MouseLeave(object sender, EventArgs e)
        {
            ResultFilesSourceButton.ForeColor = Color.White;
        }

        private void SemanticButton_MouseHover(object sender, EventArgs e)
        {
            if (SemanticButton.ForeColor != Color.Gold)
                SemanticButton.ForeColor = Color.DarkCyan;
        }

        private void SemanticButton_MouseLeave(object sender, EventArgs e)
        {
            if (SemanticButton.ForeColor != Color.Gold)
                SemanticButton.ForeColor = Color.White;
        }

        private void ScannerButton_MouseHover(object sender, EventArgs e)
        {
            if (ScannerButton.ForeColor != Color.Gold)
                ScannerButton.ForeColor = Color.DarkCyan;
        }

        private void ScannerButton_MouseLeave(object sender, EventArgs e)
        {
            if (ScannerButton.ForeColor != Color.Gold)
                ScannerButton.ForeColor = Color.White;
        }

        #endregion

        #region Buttons Click Events
       
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Restart_Project();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void ScannerButton_Click(object sender, EventArgs e)
        {
            SemanticButton.ForeColor = Color.White;
            ScannerButton.ForeColor = Color.Gold;

            //ScannerPanel.Enabled = true;
            //SemanticPanel.Enabled = true;
        }

        private void SemanticButton_Click(object sender, EventArgs e)
        {
            SemanticButton.ForeColor = Color.Gold;
            ScannerButton.ForeColor = Color.White;

            ScannerPanel.Visible = false;
            //SemanticPanel.Enabled = false;
        }


        private void OpenSourceBrowseButton_Click(object sender, EventArgs e)
        {
            Source_File_Path = "";
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.Filter = "Text Files (.txt)|*.txt";
            myOpenFileDialog.FileName = "";
            myOpenFileDialog.Title = "Open Source File";
                                    
            DialogResult OpenFileDialogResult = myOpenFileDialog.ShowDialog();

            if (OpenFileDialogResult == DialogResult.OK)
            {
                OpenSourcePathLabel.Text = myOpenFileDialog.FileName;
                Source_File_Path = myOpenFileDialog.FileName;
                Source_File_Name = System.IO.Path.GetFileNameWithoutExtension(myOpenFileDialog.FileName);               
                OpenSourceStartButton.Enabled = true;
            }
        }

        private void OpenSourceStartButton_Click(object sender, EventArgs e)
        {
            try
            {
                create_folder();

                lexical_analyzer L = new lexical_analyzer();
                token_class T = new token_class();
                phase_table_class P = new phase_table_class();
                symble_table_class S = new symble_table_class();
                error_class E = new error_class();

                L.create_list(Source_File_Path);

                while (L.count < L.file_list.Count())
                {
                    T = L.get_next_token();
                    if (T.type != "error")
                        P.add_phase_table(T);
                    else
                        E.add_error(T);
                    if (T.type == "id" && !S.search_symble_table(T.token))
                        S.add_symble_table(T.token);                        
                }

                S.write_to_file(SymbTable_Path);
                P.write_to_file(Phase1_Path);
                E.write_to_file(Error_Path);
                
                ScannerPanel.Enabled = true;
                ResultFilesErrorRichTextBox.Visible = true;
                ResultFilesPhase1RichTextBox.Visible = true;
                ResultFilesSorceRichTextBox.Visible = true;
                ResultFilesSymbleTableRichTextBox.Visible = true;

                Preparation_RichTextBoxes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ResultFilesSymbleTableButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", SymbTable_Path);            
        }

        private void ResultFilesPhase1Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", Phase1_Path);
        }

        private void ResultFilesErrorsButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", Error_Path);
        }

        private void ResultFilesSourceButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", Source_File_Path);
        }

        #endregion

        #region Functions

        private void Restart_Project()
        {
            try
            {
                OpenSourceStartButton.Enabled = false;
                OpenSourcePathLabel.Text = "";
                ResultFilesErrorRichTextBox.Clear();
                ResultFilesPhase1RichTextBox.Clear();
                ResultFilesSorceRichTextBox.Clear();
                ResultFilesSymbleTableRichTextBox.Clear();
                ResultFilesErrorRichTextBox.Visible = false;
                ResultFilesPhase1RichTextBox.Visible = false;
                ResultFilesSorceRichTextBox.Visible = false;
                ResultFilesSymbleTableRichTextBox.Visible = false;
                ScannerPanel.Enabled = false;
            }
            catch { }
        }

        private void create_folder()
        {
            try
            {
                Result_Files_Saved_Path = System.Environment.CurrentDirectory + "\\" + Source_File_Name;
                Result_Files_Saved_Path += "(" + DateTime.Today.ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH-mm-ss") + ")";

                if (!File.Exists(Result_Files_Saved_Path))
                    Directory.CreateDirectory(Result_Files_Saved_Path);

                SymbTable_Path = Result_Files_Saved_Path + "\\SymbTable.txt";
                Phase1_Path = Result_Files_Saved_Path + "\\Phase1.txt";
                Error_Path = Result_Files_Saved_Path + "\\lerr.txt";
            }
            catch { }
        }

        private void Preparation_RichTextBoxes()
        {
            try
            {                
                ResultFilesSorceRichTextBox.LoadFile(Source_File_Path, RichTextBoxStreamType.PlainText);
                ResultFilesSymbleTableRichTextBox.LoadFile(SymbTable_Path, RichTextBoxStreamType.PlainText);
                ResultFilesPhase1RichTextBox.LoadFile(Phase1_Path, RichTextBoxStreamType.PlainText);
                ResultFilesErrorRichTextBox.LoadFile(Error_Path, RichTextBoxStreamType.PlainText);
            }
            catch { }
        }

        #endregion

        
        

       
       
    }
}
