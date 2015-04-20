using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaneConstructor.Business;

namespace PlaneConstructor.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertExcel test = new ConvertExcel();
            Subset poigneegaz = new Subset(); 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {               
                string excelPath = openFileDialog1.FileName;
                string CSVPath = excelPath;                
                CSVPath = CSVPath.Remove(CSVPath.Length - 4, 4) + "csv";
                test.ConvertExcelToCsv(excelPath, CSVPath, 1);
                poigneegaz = test.GetDataTableFromCsv(CSVPath);
            }          
        }
    }
}
