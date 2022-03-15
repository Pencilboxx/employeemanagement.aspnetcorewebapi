using System.ComponentModel.DataAnnotations;

namespace employeemanagement.aspnetcorewebapi.Model
{
    public class Employee
    {
        [Key]
        
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int salary { get; set; }
        public string designation { get; set; }



    }
}
