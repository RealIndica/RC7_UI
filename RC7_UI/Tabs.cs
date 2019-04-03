using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC7_UI
{
    public partial class Tabs : Form
    {
        Form mainform;
        public Tabs(Form frm)
        {
            InitializeComponent();
            mainform = frm;
        }

        void posUpdate()
        {
            while (true)
            {
                this.Location = new Point(mainform.Location.X - this.Size.Width, mainform.Location.Y + 55);
                System.Threading.Thread.Sleep(1);
            }
        }

        private void Tabs_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => { posUpdate(); });
        }
    }
}
