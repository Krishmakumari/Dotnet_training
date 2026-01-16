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

namespace WinReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            Assembly assemblyObj = Assembly.LoadFrom(FileName);


            //Assemby is logical unit of deployment
            Type[] myType = assemblyObj.GetTypes();
            this.ReflectAll(myType[0]);

        }

        public  void ReflectAll(Type typeObj)
        {
            //getting all methods
            MethodInfo[] methodList = typeObj.GetMethods();

            //getting all properties
            PropertyInfo[] propList = typeObj.GetProperties();

            //Load All Properties
            foreach (var item in propList)
            {
                //listbox1 is of instance type and invoking directly in static gives error
                listBox1.Items.Add(item.Name);
            }

            //Load All Methods
            foreach (var item in methodList)
            {
                //listbox1 is of instance type and invoking directly in static gives error
                listBox2.Items.Add(item.Name);
            }

        }
    }
}
