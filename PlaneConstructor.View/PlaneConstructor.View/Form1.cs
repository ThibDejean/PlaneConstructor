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
            Subset poigneegaz = new Subset();

            poigneegaz = ConvertExcel();
           
            
            UpdateTreeView(poigneegaz);
           
            

            // TEST
            //L_DO.Text = poigneegaz.GetTheLongestDOSub().ToString();
            //L_cost.Text = poigneegaz.GetTotalCostSub().ToString();
            //L_Costpres.Text = poigneegaz.GetTotalHourSub().ToString();
        }


        public Subset ConvertExcel()
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
            return poigneegaz;
        }

        public void UpdateTreeView(Subset poigneegaz)
        {
            treeView1.BeginUpdate();
            int i = 0;

            foreach (Line li in poigneegaz.Nomenclature)
            {
                if (li.CompoCost == 0)
                {
                    treeView1.Nodes.Add(li.Designation);
                }
                if (li.CompoCost != 0)
                {
                    treeView1.Nodes[i].Nodes.Add(li.Designation);
                    i++;
                }
            }

            //treeView1.Nodes.Add("Parent");
            //treeView1.Nodes[0].Nodes.Add("Child 1");
            //treeView1.Nodes[0].Nodes.Add("Child 2");
            //treeView1.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            //treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            treeView1.EndUpdate();
          
        }
       
    }
}
