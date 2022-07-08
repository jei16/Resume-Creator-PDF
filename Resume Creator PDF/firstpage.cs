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
using Newtonsoft;

namespace Resume_Creator_PDF
{
    
    public partial class firstpage : Form
    {
        string filename;
        public firstpage()
        {
            InitializeComponent();
        }

        private void firstpage_Load(object sender, EventArgs e)
        {

        }

        private void ChooseFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "|*.json";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = file.FileName;
                ChooseFiletxt.Text = filename;
                GeneratePDFbtn.Visible = true;
            }

        }

        private void ChooseFiletxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GeneratePDFbtn_Click(object sender, EventArgs e)
        {
           
           
            
        }
    }
}
