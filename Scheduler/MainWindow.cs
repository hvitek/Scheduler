using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
            makeConstructors();
            inicializeMethods();
        }
        Console console;
        Methods methods;
        public List<Method> methodList;

        public void makeConstructors()
        {
            console = new Console(this);
            methods = new Methods();
            methodList = new List<Method>();
        }

        private void inicializeMethods()
        {
            MethodInfo[] methodInfos = typeof(Methods).GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                listBoxDefFiles.Items.Add("Name: "+methodInfo.Name + " Type: " +methodInfo.ReturnType);

                Method method = new Method();
                method.methodName = methodInfo.Name;
                method.methodReturnType = methodInfo.ReturnType;
                method.methodReturnTypeCustomAttributes = methodInfo.ReturnTypeCustomAttributes;
                methodList.Add(method);

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            methods.execute();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            console.ConsoleWarning("stop");
        }
    }
}
