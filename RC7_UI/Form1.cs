using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Net;
using mshtml;

namespace RC7_UI
{
    public partial class mainForm : Form
    {
        string _themeDir = Application.StartupPath + "\\bin\\Themes\\";
        string _tempThemeDir = Application.StartupPath + "\\bin\\Themes\\temp\\";

        string binLocation = Application.StartupPath + "//bin";
        string defPath = Application.StartupPath + "//bin//def";

        public mainForm()
        {
            InitializeComponent();
        }

        void loadTheme()
        {
            try
            {
                //main form elements
                rightPanel.BackgroundImage = Image.FromFile(_tempThemeDir + "Hide_Side.bmp");
                this.BackgroundImage = Image.FromFile(_tempThemeDir + "MainUi.bmp");

                //side buttons
                saveButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Save_In.bmp");
                WButton.BackgroundImage = Image.FromFile(_tempThemeDir + "WordWrap_In.bmp");
                AButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Auto_In.bmp");
                downloadButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Google_Drive_In.bmp");
                roexploitButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Krystal_In.bmp");
                muteButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Wofly_In.bmp");

                //main gui buttons
                openButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
                executeButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
                clearButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load theme correctly.\r\nPlease make sure all files are in the temp directory or reinstall RC7.", "Theme Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        void showOutput()
        {
            Output outx = new Output(this);
            outx.Show();
        }

        void initToolTips()
        {
            ToolTip _saveTT = new ToolTip();
            _saveTT.ShowAlways = true;
            _saveTT.SetToolTip(saveButton, "Save");
            _saveTT.SetToolTip(WButton, "Wordwrap");
            _saveTT.SetToolTip(AButton, "Autorun");
            _saveTT.SetToolTip(downloadButton, "Download");
            _saveTT.SetToolTip(roexploitButton, "Ro-Xploit");
            _saveTT.SetToolTip(muteButton, "Mute");
        }

        void setDefPos()
        {
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = (rightmost.WorkingArea.Right + 10) - this.Width;
            this.Top = ((rightmost.WorkingArea.Bottom / 2) + 200) - this.Height;
        }

        void runJS(string js)
        {
            HtmlElement head = webBrowser1.Document.GetElementsByTagName("head")[0];
            HtmlElement script = webBrowser1.Document.CreateElement("script");
            IHTMLScriptElement element = (IHTMLScriptElement)script.DomElement;
            element.text = js;
            head.AppendChild(script);
        }

        void addIntel(string label, string kind, string detail, string insertText)
        {
            string label1 = @"""" + label + @"""";
            string kind1 = @"""" + kind + @"""";
            string detail1 = @"""" + detail + @"""";
            string insertText1 = @"""" + insertText + @"""";
            string built = "AddIntellisense(" + label1 + "," + kind1 + "," + detail1 + "," + insertText1 + ")";
            //MessageBox.Show(built);
            runJS(built);
        }

        void addGlobalF()
        {
            string[] lines = File.ReadAllLines(defPath + "//globalf.txt");
            foreach (string line in lines)
            {
                if (line.Contains(':'))
                {
                    addIntel(line, "Function", line, line.Substring(1));
                }
                else
                {
                    addIntel(line, "Function", line, line);
                }
            }
        }

        void addGlobalV()
        {
            foreach (string line in File.ReadLines(defPath + "//globalv.txt"))
            {
                addIntel(line, "Variable", line, line);
            }
        }

        void addGlobalNS()
        {
            foreach (string line in File.ReadLines(defPath + "//globalns.txt"))
            {
                addIntel(line, "Class", line, line);
            }
        }

        void addMath()
        {
            foreach (string line in File.ReadLines(defPath + "//classfunc.txt"))
            {
                addIntel(line, "Method", line, line);
            }
        }

        void addBase()
        {
            foreach (string line in File.ReadLines(defPath + "//base.txt"))
            {
                addIntel(line, "Keyword", line, line);
            }
        }

        void initScript()
        {
            runJS("SetTheme(\"Dark\")");
            runJS("SwitchFontSize(11)");
            addBase();
            addGlobalF();
            addGlobalV();
            addGlobalNS();
            addMath();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("file:///{0}\\bin\\Monaco.html", Directory.GetCurrentDirectory()));
            //messagebox to mainly fix browser bug
            MessageBox.Show("Welcome to RC7");
            initScript();
            initToolTips();
            setDefPos();
            loadTheme();           
        }

        //open
        private void openButton_MouseEnter(object sender, EventArgs e)
        {
            openButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Hover.bmp");
        }

        private void openButton_MouseLeave(object sender, EventArgs e)
        {
            openButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
        }

        //execute
        private void executeButton_MouseEnter(object sender, EventArgs e)
        {
            executeButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Hover.bmp");
        }

        private void executeButton_MouseLeave(object sender, EventArgs e)
        {
            executeButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
        }

        //clear
        private void clearButton_MouseEnter(object sender, EventArgs e)
        {
            clearButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Hover.bmp");
        }

        private void clearButton_MouseLeave(object sender, EventArgs e)
        {
            clearButton.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
        }

        private void showOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            bool open = false;

            foreach (Form frm in fc)
            {
                if (frm.Name == "Output")
                {
                    open = true;
                }
            }

            if (!open)
            {
                showOutput();
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //to stop application hanging in background
            Application.Exit();
            Environment.Exit(0);
        }

        private void scriptHubToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeRobloxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
