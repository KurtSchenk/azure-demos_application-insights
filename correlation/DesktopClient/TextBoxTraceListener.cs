using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DesktopClient
{
    public class TextBoxTraceListener : TraceListener
    {
        private TextBox _target;
        private StringSendDelegate _invokeWrite;

        public TextBoxTraceListener(TextBox target)
        {
            _target = target;
            _invokeWrite = new StringSendDelegate(SendString);
        }

        public override void Write(string message)
        {
            _target.Invoke(_invokeWrite, new object[] { message });
        }

        public override void WriteLine(string message)
        {
            StackTrace trace = new StackTrace();
            StackFrame[] stackFrames = trace.GetFrames();
            if (Array.Exists(stackFrames, element => element.GetMethod().DeclaringType.Name.ToUpper().Equals("TRACE")))
            {
                _target.Invoke(_invokeWrite, new object[]  { message + Environment.NewLine });
            }
            if (Array.Exists(stackFrames, element => element.GetMethod().DeclaringType.Name.ToUpper().Equals("DEBUG")))
            {
                //do nothing
            }
        }

        private delegate void StringSendDelegate(string message);
        private void SendString(string message)
        {
            // No need to lock text box as this function will only 
            // ever be executed from the UI thread
            _target.Text += message;
        }
    }
}
