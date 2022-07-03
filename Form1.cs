using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace ClickToCopy
{
    public partial class Form1 : Form
    {
        void CreateDirectory(string UserFolder,string AppData, string AppDataFolder, string FileCharList)
        {
            Directory.CreateDirectory(UserFolder + AppData + AppDataFolder);

            if (UserFolder + AppData + AppDataFolder + FileCharList != null)
            {

                using (StreamWriter sw = new StreamWriter(UserFolder + AppData + AppDataFolder + FileCharList))
                {
                    sw.WriteLine
(@"‽
²
³
÷
±
≥
≤");
                }
            }
        }

        string UserFolderFun()
        {
            string UserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return UserFolder;
        }

        string PathMidToEndFun()
        {
            string PathMidToEnd = @"\AppData\Local\ClickToCopy\Character List.txt";
            return PathMidToEnd;
        }

        void GenerateButtons()
        {
            string UserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string PathMidToEnd = @"\AppData\Local\ClickToCopy\Character List.txt";
            var LineCount = File.ReadLines(UserFolder + @"\AppData\Local\ClickToCopy\Character List.txt").Count(); //Gets the amount of lines in the file which is used to generate the correct amount of buttons
            int LineCountInt = Convert.ToInt32(LineCount); //Converts the number of lines to a usable format (int)


            int x = 39;
            int y = 56;
            using (StreamReader rs = new StreamReader(UserFolder + PathMidToEnd))
            {
                for (int i = 0; i < LineCountInt; i++)
                {
                    Button button = new Button(); //Creates new button object
                    //button.Name = "Button1";
                    button.Location = new Point(x, y);
                    button.Size = new Size(30, 30);
                    button.Text = rs.ReadLine();
                    button.Font = new Font("Segoe UI", 12);
                    button.Name = "NewButton";
                    this.Controls.Add(button);
                    button.Click += new EventHandler(button_Click);
                    void button_Click(object sender, EventArgs e)
                    {
                        Clipboard.SetText(button.Text);
                    }
                    y = y + 36;
                }
            }
            
        }

        public Form1()
        {
            InitializeComponent();

            //A the paths and file names for the files the app will use.
            string UserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); //Gets C:\Users\[USER]
            string AppData = @"\AppData\Local"; //AppData folder
            string AppDataFolder = @"\ClickToCopy"; //The folder in the Local folder 
            string FileCharList = @"\Character List.txt"; //The character list file
            string FileIni = @"\config.ini"; //The config file
            string FullPathCharList = @"C:\Users\lucky\AppData\Local\ClickToCopy\Character List.txt";

            if (!Directory.Exists(UserFolder + AppData + AppDataFolder))
            {
                CreateDirectory(UserFolder, AppData, AppDataFolder, FileCharList);
            }

            GenerateButtons(); 
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuItemFile_Click(object sender, EventArgs e)
        {

        }

        private void editCharacterFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", UserFolderFun() + PathMidToEndFun());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateButtons();
        }
    }
}