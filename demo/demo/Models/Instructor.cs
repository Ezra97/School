using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    public enum Title
    {
        Mister, Miss, Misses, Doctor, Professor
    }
    public class Instructor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstructorID { get; set; }
        public Title? InstructorTitle { get; set; }
        public string InstructorName { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}