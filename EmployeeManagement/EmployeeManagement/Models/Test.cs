using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeManagement.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        public string Description { get; set; }

        [ForeignKey("Employee")]
        public int EployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
