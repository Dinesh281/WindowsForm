using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsForm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\Employee.dat", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp.Id = Convert.ToInt32(txtEmpId.Text);
                emp.Name = txtEmpName.Text;
                emp.Salary = Convert.ToInt32(txtBasicSal.Text);
                binaryFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee added to the File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\Employee.dat", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                txtEmpId.Text = emp.Id.ToString();
                txtEmpName.Text = emp.Name;
                txtBasicSal.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                SoapFormatter soapFormatter = new SoapFormatter();
                emp.Id = Convert.ToInt32(txtEmpId.Text);
                emp.Name = txtEmpName.Text;
                emp.Salary = Convert.ToInt32(txtBasicSal.Text);
                soapFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee added to the File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                SoapFormatter soapFormatter = new SoapFormatter();
                emp = (Employee)soapFormatter.Deserialize(fs);
                txtEmpId.Text = emp.Id.ToString();
                txtEmpName.Text = emp.Name;
                txtBasicSal.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\EmployeeXML.xml", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp.Id = Convert.ToInt32(txtEmpId.Text);
                emp.Name = txtEmpName.Text;
                emp.Salary = Convert.ToInt32(txtBasicSal.Text);
                xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee added to the File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\EmployeeXML.xml", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                txtEmpId.Text = emp.Id.ToString();
                txtEmpName.Text = emp.Name;
                txtBasicSal.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtBasicSal.Clear();
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                SoapFormatter soapFormatter = new SoapFormatter();
                emp.Id = Convert.ToInt32(txtEmpId.Text);
                emp.Name = txtEmpName.Text;
                emp.Salary = Convert.ToInt32(txtBasicSal.Text);
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Employee added to the File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\EmployeeJSON.json", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();

                emp = (Employee)JsonSerializer.Deserialize<Employee>(fs);
                txtEmpId.Text = emp.Id.ToString();
                txtEmpName.Text = emp.Name;
                txtBasicSal.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
