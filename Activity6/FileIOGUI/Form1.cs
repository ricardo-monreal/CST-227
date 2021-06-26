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
//using DocumentFormat.OpenXml.Bibliography;
using FileIO;


namespace FileIOGUI
{
    public partial class Form1 : Form
    {
        //Person myPeople = new Person();
        List<Person> people = new List<Person>();
        BindingSource peopleBindingSource = new BindingSource();
        Person myPerson = new Person();


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Person p = new Person(textBox_firstName.Text, textBox_lastName.Text, textBox_url.Text);
            //MessageBox.Show(person.ToString());
            //StreamWriter sw = new StreamWriter(Application.StartupPath + "\\people\\" + people.Count());
            people.Add(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
