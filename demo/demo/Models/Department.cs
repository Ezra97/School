using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        public int InstructorID { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}