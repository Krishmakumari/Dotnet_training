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
//for binary serialization
using System.Runtime.Serialization.Formatters.Binary;
//for xml
using System.Xml.Serialization;
//for SOAP 
using System.Runtime.Serialization.Formatters.Soap;


namespace SerializationDemo
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtId.Text);
            emp1.Name = txtName.Text;
            emp1.Salary=Convert.ToInt32(txtSalary.Text);


            //binary serialization code below

            FileStream fs = new FileStream(@"D:\Dotnet\SerializationDemo\BinSerializable.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp1);

            foreach (Control item in this.Controls) //this is form. control is all ui elements
            {
                if(item.GetType()==typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
            MessageBox.Show("Record added....");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\Dotnet\SerializationDemo\BinSerializable.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();


            Employee emp1=(Employee)bf.Deserialize(fs);
            txtId.Text=emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();

            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtId.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);


            //xml serialization code below

            FileStream fs = new FileStream(@"D:\Dotnet\SerializationDemo\XmlSerializable.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp1);
            //ClearAllTextBoxes();

            fs.Close();
            MessageBox.Show("Record Added");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\Dotnet\SerializationDemo\XmlSerializable.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));

            Employee emp1 = (Employee)xs.Deserialize(fs);
            txtId.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();

            fs.Close();

        }

        /// <summary>
        /// Soap Serialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button5_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtId.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            FileStream fs = new FileStream(@"D:\Dotnet\SerializationDemo\SoapSerializable.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, emp1);

            //ClearAllTextBoxes();

            fs.Close();
            MessageBox.Show("Recoed Added");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\Dotnet\SerializationDemo\SoapSerializable.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter sf = new SoapFormatter();
            //sf.Serialize(fs, emp1);
            Employee emp1 = (Employee)sf.Deserialize(fs);
            txtId.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();

            fs.Close();
        }
    }
}
