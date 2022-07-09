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
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
                this.Size = new Size(557, 310);
            }

        }

        private void ChooseFiletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GeneratePDFbtn_Click(object sender, EventArgs e)
        {

            string jsonFile = File.ReadAllText(filename);
            JSONinput.Text = jsonFile;
            deserealize(JSONinput.Text);


        }

        private void deserealize(string JSONtoPDF)
        {
                var jsonn = JsonConvert.DeserializeObject<dynamic>(JSONtoPDF);
                var pdftxt = (jsonn.Name) + "\n" +  
                             (jsonn.Address) + "\n " +
                             (jsonn.ContactNumber) + "\n" + 
                             (jsonn.EmailAddress) + "\n" + " " + "\n " + 
                             ("OBJECTIVE:" + "\n" + jsonn.Objective) + "\n" + " " + "\n " + 
                             ("EDUCATION:" + "\n" + " "+ "\n"+ "College:")+ "\n" +
                             ("School: " + jsonn.Education[0].College[0].School) + "\n" +
                             ("School Address: " + jsonn.Education[0].College[1].SchoolAddress) + "\n" +
                             ("Course: " + jsonn.Education[0].College[2].Course) + "\n" +
                             ("Year: " + jsonn.Education[0].College[3].Year) + "\n" + "" + "\n" +
                             ("Senior High School:") + "\n" +
                             ("School: " + jsonn.Education[1].SeniorHighSchool[0].School) + "\n" +
                             ("School Address: " + jsonn.Education[1].SeniorHighSchool[1].SchoolAddress) + "\n" +
                             ("Strand: " + jsonn.Education[1].SeniorHighSchool[2].Strand) + "\n" +
                             ("Year: " + jsonn.Education[1].SeniorHighSchool[3].Year) + "\n" + "" + "\n" +
                             ("Junior High School:") + "\n" +
                             ("School: " + jsonn.Education[2].JuniorHighSchool[0].School) + "\n" +
                             ("School Address: " + jsonn.Education[2].JuniorHighSchool[1].SchoolAddress) + "\n" +
                             ("Special Program: " + jsonn.Education[2].JuniorHighSchool[2].SpecialProgram) + "\n" +
                             ("Year: " + jsonn.Education[2].JuniorHighSchool[3].Year) + "\n" + "" + "\n" +
                             ("Elementary:") + "\n" +
                             ("School: " + jsonn.Education[3].Elementary[0].School) + "\n" +
                             ("School Address: " + jsonn.Education[3].Elementary[1].SchoolAddress) + "\n" +
                             ("Special Program: " + jsonn.Education[3].Elementary[2].SpecialProgram) + "\n" +
                             ("Year: " + jsonn.Education[3].Elementary[3].Year) + "\n" + "" + "\n" +
                             ("ACHIEVEMENTS:") + "\n" +
                             (jsonn.Achievements[0]) + "\n" +
                             (jsonn.Achievements[1]) + "\n" +
                             (jsonn.Achievements[2]) + "\n" +
                             (jsonn.Achievements[3]) + "\n" +
                             (jsonn.Achievements[4]) + "\n" +
                             (jsonn.Achievements[5]) + "\n" + "" + "\n" +
                             ("SKILLS:") + "\n" +
                             (jsonn.Skills[0]) + "\n" +
                             (jsonn.Skills[1]) + "\n" +
                             (jsonn.Skills[2]) + "\n" +
                             (jsonn.Skills[3]) + "\n" +
                             (jsonn.Skills[4]) + "\n" 
                             ;

            Output.Text = pdftxt;

            using(SaveFileDialog pdff = new SaveFileDialog() {Filter = "PDF File|*.pdf", ValidateNames = true})
            {
                if (pdff.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document docss = new iTextSharp.text.Document(PageSize.LETTER.Rotate());
                    MessageBox.Show("Saved!");
                    try
                    {
                        PdfWriter.GetInstance(docss,new FileStream(pdff.FileName, FileMode.Create));
                        docss.Open();
                        docss.Add(new iTextSharp.text.Paragraph(Output.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Try Again!");
                    }
                    finally
                    {
                        docss.Close();
                    }
                }

            }

                
        }

        private void Downloadbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
