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
    public partial class Output : Form
    {
        Form mainform;

        public Output(Form frm)
        {
            InitializeComponent();
            mainform = frm;
        }

        void posUpdate()
        {
            while (true)
            {
                this.Location = new Point(mainform.Location.X + 15, mainform.Location.Y + 387);
                System.Threading.Thread.Sleep(1);
            }
        }

        private void Output_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => { posUpdate(); });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
