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
using System.Diagnostics;
using System.Net;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace RC7_UI
{
    public partial class Login : Form
    {
        string _tempThemeDir = Application.StartupPath + "\\bin\\Themes\\temp\\";

        public Login()
        {
            InitializeComponent();
        }

        bool _Login(string user, string pass)
        {
            return true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(_tempThemeDir + "MainUi.bmp");
            button1.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
            //rightPanel.BackgroundImage = Image.FromFile(_tempThemeDir + "Hide_Side.bmp");
            addRegkey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Login(alphaBlendTextBox1.Text, alphaBlendTextBox2.Text))
            {
                //good
                mainForm frm = new mainForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                //bad
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Hover.bmp");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
        }

        void addRegkey()
        {
            string key = "Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION";

            if (Registry.GetValue("HKEY_CURRENT_USER\\" + key, System.AppDomain.CurrentDomain.FriendlyName, null) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + key, System.AppDomain.CurrentDomain.FriendlyName, 11001, RegistryValueKind.DWord);
                DialogResult dialogResult = MessageBox.Show("Added registry entries, the application will now restart.", "RC7 First Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
