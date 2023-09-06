using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_CRUD.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }

        public string ContactNo { get; set; }
        public string EmailId { get; set; }

        public int DepId { get; set; }

        [NotMapped]
        public string DepartmentName { get; set; }



    }
}
