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
        public Console console;
        public Methods methods;
        public List<MethodModel> methodList;
        public FileReader defFileReader;

        public void makeConstructors()
        {
            console = new Console(this);
            methods = new Methods();
            methodList = new List<MethodModel>();
            
        }

        private void inicializeMethods()
        {
            MethodInfo[] methodInfos = typeof(Methods).GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                listBoxDefFiles.Items.Add("Name: "+methodInfo.Name + " Type: " +methodInfo.ReturnType);

                MethodModel method = new MethodModel();
                method.methodName = methodInfo.Name;
                method.methodReturnType = methodInfo.ReturnType;
                method.methodReturnTypeCustomAttributes = methodInfo.ReturnTypeCustomAttributes;
                methodList.Add(method);

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            console.ConsoleInfo("*********************************************************************** start ***********************************************************************");
            defFileReader = new FileReader(this);
            //
            DefFileReader fr = new DefFileReader();
            //Methods methods = new Methods();
            //methods.execute();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            console.ConsoleInfo("*********************************************************************** stop ***********************************************************************");
        }
    }
}
