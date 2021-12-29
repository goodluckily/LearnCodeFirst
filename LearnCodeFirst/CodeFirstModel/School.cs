using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstModel
{
    //[Table("school")]
    public class School
    {
        //[Column("id")]
        public int Id { get; set; }

        //[Column("sname")]
        public string? SName { get; set; }
        public string? SAddress { get; set; }
        public string? SEmail { get; set; }
        public DateTime? SCreateDate { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}
