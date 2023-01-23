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

namespace WindowsForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"E:\SkillMineDoc1";
            try
            {
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Directory already Exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory is Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"E:\SkillMineDoc1\Test1.txt";
            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("File already Exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File is Created.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string path = @"E:\SkillMineDoc1\Test1.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show("File  Deleted");
                }
                else
                {
                    MessageBox.Show("File Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtEmpId.Text));
                bw.Write(txtEmpName.Text);
                bw.Write(Convert.ToDouble(txtBasicSal.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to file..");
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
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpId.Text = br.ReadInt32().ToString();
                txtEmpName.Text = br.ReadString();
                txtBasicSal.Text = br.ReadDouble().ToString();
                
                br.Close();
                fs.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\SkillMineDoc2");
            try
            {
                if (di.Exists)
                {
                    MessageBox.Show("Directory already Exists");
                }
                else
                {
                    di.Create();
                    MessageBox.Show("Directory is Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCFile_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"E:\SkillMineDoc2\Test1.txt");
            try
            {
                if (fi.Exists)
                {
                    MessageBox.Show("File already Exists");
                }
                else
                {
                    fi.Create();
                    MessageBox.Show("File Created");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDFile_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"E:\SkillMineDoc2\Test1.txt");
            try
            {
                if (fi.Exists)
                {
                    fi.Delete();
                    MessageBox.Show("File  Deleted");
                }
                else
                {
                    MessageBox.Show("File Not Found");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
