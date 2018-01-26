using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Console
    {
        MainWindow main;
        public Console(MainWindow mainWindow)
        {
            main = mainWindow;
        }


        /// <summary>
        /// Write line to console.
        /// </summary>
        /// <param name="text">Text to write</param>
        public void ConsoleWarning(string text)
        {
            Color color = Color.Red;
            ConsoleUtils.AppendText(main.richTextBoxState, text, color);
        }

        /// <summary>
        /// Write line to console.
        /// </summary>
        /// <param name="text">Text to write</param>
        public void ConsoleInfo(string text)
        {
            Color color = Color.ForestGreen;
            ConsoleUtils.AppendText(main.richTextBoxState, text, color);
        }


        /// <summary>
        /// Write line to console.
        /// </summary>
        /// <param name="text">Text to write</param>
        public void ConsoleNormal(string text)
        {
            Color color = Color.Black;
            ConsoleUtils.AppendText(main.richTextBoxState, text, color);
        }
    }
}
