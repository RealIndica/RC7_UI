using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Net;
using mshtml;

namespace RC7_UI
{
    public class Extensions
    {
        public class configReader
        {
            string _tempThemeDir = Application.StartupPath + "\\bin\\Themes\\temp\\";

            Form _form;
            public configReader(Form frm)
            {
                _form = frm;
            }

            public void readConfig()
            {
                try
                {
                    string[] lines = File.ReadAllLines(_tempThemeDir + "Config.txt");
                    foreach (string xline in lines)
                    {
                        string line = xline;
                        line = line.Replace(";", "");
                        string[] obj = line.Split(':');
                        switch (obj[0])
                        {
                            case "FontColor":
                                int R = Convert.ToInt32(obj[1].Split(',')[0]);
                                int G = Convert.ToInt32(obj[1].Split(',')[1]);
                                int B = Convert.ToInt32(obj[1].Split(',')[2]);
                                foreach (Control c in _form.Controls)
                                {
                                    if (c.Name != "ToolBar")
                                    {
                                        c.ForeColor = Color.FromArgb(R, G, B);
                                    }
                                }
                                break;
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Config load error"); }
            }
        }

        public class ScriptIDE
        {
            Control parent;
            WebBrowser curBrows;
            string binLocation = Application.StartupPath + "//bin";
            string defPath = Application.StartupPath + "//bin//def";

            public ScriptIDE(Control targ)
            {
                parent = targ;
            }

            void runJS(string js, WebBrowser bs)
            {
                HtmlElement head = bs.Document.GetElementsByTagName("head")[0];
                HtmlElement script = bs.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)script.DomElement;
                element.text = js;
                head.AppendChild(script);
            }

            void addIntel(string label, string kind, string detail, string insertText, WebBrowser bs)
            {
                string label1 = @"""" + label + @"""";
                string kind1 = @"""" + kind + @"""";
                string detail1 = @"""" + detail + @"""";
                string insertText1 = @"""" + insertText + @"""";
                string built = "AddIntellisense(" + label1 + "," + kind1 + "," + detail1 + "," + insertText1 + ")";
                //MessageBox.Show(built);
                runJS(built, bs);
            }

            void addGlobalF(WebBrowser bs)
            {
                string[] lines = File.ReadAllLines(defPath + "//globalf.txt");
                foreach (string line in lines)
                {
                    if (line.Contains(':'))
                    {
                        addIntel(line, "Function", line, line.Substring(1), bs);
                    }
                    else
                    {
                        addIntel(line, "Function", line, line, bs);
                    }
                }
            }

            void addGlobalV(WebBrowser bs)
            {
                foreach (string line in File.ReadLines(defPath + "//globalv.txt"))
                {
                    addIntel(line, "Variable", line, line, bs);
                }
            }

            void addGlobalNS(WebBrowser bs)
            {
                foreach (string line in File.ReadLines(defPath + "//globalns.txt"))
                {
                    addIntel(line, "Class", line, line, bs);
                }
            }

            void addMath(WebBrowser bs)
            {
                foreach (string line in File.ReadLines(defPath + "//classfunc.txt"))
                {
                    addIntel(line, "Method", line, line, bs);
                }
            }

            void addBase(WebBrowser bs)
            {
                foreach (string line in File.ReadLines(defPath + "//base.txt"))
                {
                    addIntel(line, "Keyword", line, line, bs);
                }
            }

            void initScript()
            {
                WebBrowser bs = curBrows;
                runJS("SwitchFontSize(11)", bs);
                addBase(bs);
                addGlobalF(bs);
                addGlobalV(bs);
                addGlobalNS(bs);
                addMath(bs);
            }

            Timer curtm;

            void tmTick(object sender, EventArgs e)
            {
                initScript();
                curtm.Stop();
            }

            void timerhandle(object sender, EventArgs e)
            {
                Timer tm = new Timer();
                tm.Interval = 10;
                tm.Tick += tmTick;
                curtm = tm;
                curtm.Start();
            }

            public void makeIDE()
            {
                WebBrowser browser = new WebBrowser();
                browser.ScriptErrorsSuppressed = true;
                browser.IsWebBrowserContextMenuEnabled = false;
                browser.Navigate(string.Format("file:///{0}\\bin\\Monaco.html", Directory.GetCurrentDirectory()));
                browser.Parent = parent;
                browser.Dock = DockStyle.Fill;
                curBrows = browser;
                browser.Navigated += timerhandle;
            }
        }
    }
}
