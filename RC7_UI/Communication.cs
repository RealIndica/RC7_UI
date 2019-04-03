using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.IO.Pipes;

namespace RC7_UI
{
    public class Communication
    {
        public void sendPipeData(string PipeName, string Data)
        {
            try
            {
                NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(PipeName);
                namedPipeClientStream.Connect(2);

                using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
                {
                    string text = Data;
                    streamWriter.WriteLine(text);
                    streamWriter.Flush();
                    Thread.Sleep(3);
                }
                namedPipeClientStream.Dispose();
            }
            catch (Exception) { }
        }
    }
}
