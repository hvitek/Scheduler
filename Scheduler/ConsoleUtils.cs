using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public static class ConsoleUtils
    {
        public static void AppendText(this RichTextBox box, string text, Color color, Font font)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionStart = 0;

            box.SelectionColor = color;
            box.SelectionFont = font;
            box.SelectedText = DateTime.Now.ToString()+" - "+text+"\n";
            box.SelectionColor = box.ForeColor;

            scrollDown(box);
        }

        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionStart = 0;

            box.SelectionColor = color;
            box.SelectedText = DateTime.Now.ToString() + " - " + text + "\n";
            box.SelectionColor = box.ForeColor;
            scrollDown(box);
        }

        public static void scrollDown(this RichTextBox box)
        {
            box.SelectionStart = 0;
            box.ScrollToCaret();
        }
    }
}
