using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APi_PublicPeMinutes.Dtos
{
    public class MinutesDto
    {
        public string Organization_Name { get; set; }
        
    }
    public class Teachers
    {
        public string TeacherName { get; set; }
        public string BadgeNumber { get; set; }
    }
    public class Minute
    {
        public int? Minutes { get; set; }
        public string InstructionTime{ get; set; }
    }
}