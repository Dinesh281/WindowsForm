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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsForm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStdId.Clear();
            txtStdName.Clear();
            txtPercentage.Clear();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\Student.dat", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                std.StdId = Convert.ToInt32(txtStdId.Text);
                std.StdName = txtStdName.Text;
                std.Percentage = Convert.ToDouble(txtPercentage.Text);
                binaryFormatter.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Student added to the File");
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
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\Student.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Student std = new Student();
                std = (Student)binaryFormatter.Deserialize(fs);
                txtStdId.Text = std.StdId.ToString();
                txtStdName.Text = std.StdName;
                txtPercentage.Text = std.Percentage.ToString();
                fs.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\StudentXML.xml", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                std.StdId = Convert.ToInt32(txtStdId.Text);
                std.StdName = txtStdName.Text;
                std.Percentage = Convert.ToDouble(txtPercentage.Text);
                xmlSerializer.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Student File Created");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\StudentXML.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student std = new Student();
                std = (Student)xmlSerializer.Deserialize(fs);
                txtStdId.Text = std.StdId.ToString();
                txtStdName.Text = std.StdName;
                txtPercentage.Text = std.Percentage.ToString();
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
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\StudentSOAP.soap", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                SoapFormatter soapFormatter = new SoapFormatter();
                std.StdId = Convert.ToInt32(txtStdId.Text);
                std.StdName = txtStdName.Text;
                std.Percentage = Convert.ToDouble(txtPercentage.Text);
                soapFormatter.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Student added to the File");
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
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\StudentSOAP.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Student std = new Student();
                std = (Student)soapFormatter.Deserialize(fs);
                txtStdId.Text = std.StdId.ToString();
                txtStdName.Text = std.StdName;
                txtPercentage.Text = std.Percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\StudentJSON.json", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                
                std.StdId = Convert.ToInt32(txtStdId.Text);
                std.StdName = txtStdName.Text;
                std.Percentage = Convert.ToDouble(txtPercentage.Text);
                JsonSerializer.Serialize<Student>(fs,std);
                fs.Close();
                MessageBox.Show("Student added to the File");
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
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\StudentJSON.json", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                std = (Student)JsonSerializer.Deserialize<Student>(fs);
                txtStdId.Text = std.StdId.ToString();
                txtStdName.Text = std.StdName;
                txtPercentage.Text = std.Percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
