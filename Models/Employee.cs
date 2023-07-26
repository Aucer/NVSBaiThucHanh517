using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWeb.Models;
[Table("Employee")]
public class Employee
{
    [Key]
    public string EmpID { get; set; }
    public string EmpName { get; set; }
    public string Address { get; set; }
}