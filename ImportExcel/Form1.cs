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
using ExcelDataReader;

//C:\Users\Piotr\source\repos\ImportExcel

namespace ImportExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet result;

        private void Button1_Click(object sender, EventArgs e)
        {
            var fdlg = new OpenFileDialog
            {
                Title = "Open a file",
                InitialDirectory = ".",
                //Filter = "all files(*.*)|*.*|all files(*.)|*.*",
                Filter = "Excel Workbook|*.xlsx",
                ValidateNames=true,
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;
                var fs = File.Open(fdlg.FileName, FileMode.Open, FileAccess.Read);
                var readerX = ExcelReaderFactory.CreateReader(fs).Name;
                IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);
                
                result = reader.AsDataSet();

            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = result;
            dataGridView1.DataMember = "Sheet1";

        }
    }
}
