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
    public partial class ScriptEditor : Form
    {
        string binLocation = Application.StartupPath + "//bin";
        string defPath = Application.StartupPath + "//bin//def";
        string _comOUT = "RC7_SCRIPT";
        Communication com = new Communication();

        public ScriptEditor()
        {
            InitializeComponent();
            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            tt.SetToolTip(button1, "Execute Script");
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
            addBase();
            addGlobalF();
            addGlobalV();
            addGlobalNS();
            addMath();
        }

        private void ScriptEditor_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Format("file:///{0}\\bin\\MonacoEditor.html", Directory.GetCurrentDirectory()));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            initScript();
            timer1.Stop();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runJS("SetTheme(\"Dark\")");
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runJS("SetTheme(\"Light\")");
        }

        string getScript(WebBrowser bs)
        {
            return bs.Document.InvokeScript("GetText").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            com.sendPipeData(_comOUT, getScript(webBrowser1));
        }
    }
}
