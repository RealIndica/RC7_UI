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
using System.IO.Pipes;

namespace RC7_UI
{
    public partial class Output : Form
    {
        Form mainform;
        string _comIN = "RC7_LOG";

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

        void sendClient(string text)
        {
            richTextBox1.AppendText("[");
            richTextBox1.AppendText("CLIENT", Color.Blue);
            richTextBox1.AppendText("] ");
            richTextBox1.AppendText(text);
            richTextBox1.AppendText(Environment.NewLine);
        }

        void pipeIn()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    var server = new NamedPipeServerStream(_comIN);
                    server.WaitForConnection();
                    StreamReader reader = new StreamReader(server);

                    var line = reader.ReadLine();
                    sendClient(line);
                    reader.Dispose();
                    server.Dispose();
                }

            });
        }

        private void Output_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Task.Factory.StartNew(() => { posUpdate(); });
            Task.Factory.StartNew(() => { pipeIn(); });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
