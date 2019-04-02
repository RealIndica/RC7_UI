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

        Image main;
        Image idle;
        Image side;
        Image hover;

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
            try
            {
                main = Image.FromFile(_tempThemeDir + "MainUi.bmp");
                idle = Image.FromFile(_tempThemeDir + "Button_Idle.bmp");
                side = Image.FromFile(_tempThemeDir + "Hide_Side.bmp");
                hover = Image.FromFile(_tempThemeDir + "Button_Hover.bmp");
            } catch (Exception)
            {
                MessageBox.Show("Unable to load theme correctly.\r\nPlease make sure all files are in the temp directory or reinstall RC7.", "Theme Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            Extensions.configReader cr = new Extensions.configReader(this);
            cr.readConfig();

            alphaBlendTextBox1.BorderStyle = BorderStyle.None;
            alphaBlendTextBox2.BorderStyle = BorderStyle.None;
            button1.FlatStyle = FlatStyle.Flat;

            /*Color invert = Color.FromArgb(alphaBlendTextBox1.ForeColor.ToArgb()^0xffffff);
            alphaBlendTextBox1.BackColor = invert;
            alphaBlendTextBox2.BackColor = invert;*/

            this.BackgroundImage = main;
            button1.BackgroundImage = idle;
            panel1.BackgroundImage = side;
            addRegkey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Login(alphaBlendTextBox1.Text, alphaBlendTextBox2.Text))
            {
                //good
                mainForm frm = new mainForm();
                frm.Show();

                //dispose of theme correctly
                this.BackgroundImage = null;
                foreach (Control c in this.Controls)
                {
                    c.BackgroundImage = null;
                }

                main.Dispose();
                idle.Dispose();
                side.Dispose();
                hover.Dispose();

                this.Hide();
            }
            else
            {
                //bad
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = hover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = idle;
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
