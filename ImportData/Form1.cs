using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client;

namespace ImportData
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = true;
            OFD.ShowDialog();
            OFD.Filter = "allfiles|*.xls";
            txtInput.Text = OFD.FileName;
            int count = 0;
            string[] FName;       

            foreach (string s in OFD.FileNames)
            {
                FName = s.Split('\\');
                System.IO.File.Copy(s, "C:\\file\\" + FName[FName.Length - 1]);
                count++;
            }

            //MessageBox.Show(Convert.ToString(count) + " File(s) copied");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = true;
            OFD.ShowDialog();
            OFD.Filter = "allfiles|*.xls";
            txtcsv.Text = OFD.FileName;
            int count = 0;
            string[] FName;

            foreach (string s in OFD.FileNames)
            {
                FName = s.Split('\\');
                System.IO.File.Copy(s, "C:\\file\\" + FName[FName.Length - 1]);
                count++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = true;
            OFD.ShowDialog();
            OFD.Filter = "allfiles|*.xls";
            txtReport.Text = OFD.FileName;
            int count = 0;
            string[] FName;

            foreach (string s in OFD.FileNames)
            {
                FName = s.Split('\\');
                System.IO.File.Copy(s, "C:\\file\\" + FName[FName.Length - 1]);
                count++;
            }
        }

        private void ImportData_Click(object sender, EventArgs e)
        {
            
        }
    }
}
