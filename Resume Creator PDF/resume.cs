using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_Creator_PDF
{
    [Serializable]
    public class resume
    {

        public class Rootobject 
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string ContactNumber { get; set; }
            public string EmailAddress { get; set; }
            public string Objective { get; set; }
            public Education[] Education { get; set; }
            public string[] Achievements { get; set; }
            public string[] Skills { get; set; }
        }

        public class Education
        {
            public College[] College { get; internal set; }
            public SeniorHighSchool[] SeniorHighSchool { get; set; }
            public JuniorHighSchool[] JuniorHighSchool { get; set; }
            public Elementary[] Elementary { get; set; }
        }

        public class College
        {
            public string School { get; internal set; }
            public string SchoolAddress { get; set; }
            public string Course { get; set; }
            public string Year { get; set; }
        }

        public class SeniorHighSchool
        {
            public string School { get; set; }
            public string SchoolAddress { get; set; }
            public string Strand { get; set; }
            public string Year { get; set; }
        }

        public class JuniorHighSchool
        {
            public string School { get; set; }
            public string SchoolAddress { get; set; }
            public bool SpecialProgram { get; set; }
            public string Year { get; set; }
        }

        public class Elementary
        {
            public string School { get; set; }
            public string SchoolAddress { get; set; }
            public bool SpecialProgram { get; set; }
            public string Year { get; set; }
        }


    }





}
