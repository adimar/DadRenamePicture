using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace DadRenamePicture
{
    class Logger : TextWriter
    {
      
        public delegate void AddLogEntry(string value);
        public AddLogEntry myDelegate;
        private Control logTextBox;

        public Logger(Control textbox)
        {
            this.logTextBox = textbox;
            myDelegate  = new AddLogEntry(AppendText);
        }

          public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }


       

        
        public void AppendText(string value)
        {
            this.logTextBox.Text += value;
        }
      


        public override void Write(string value)
        {
             if(this.logTextBox.InvokeRequired) {
                 this.logTextBox.Invoke(myDelegate, new Object[] { value });
            } else {
               this.logTextBox.Text += value;
            }
        }

        public override void Write(char value)
        {
            this.Write(new string(new char[]{value}));
        }


    }
}
