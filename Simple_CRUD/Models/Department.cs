using System.ComponentModel.DataAnnotations;

namespace Simple_CRUD.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string DepName { get; set; }
    }
}
