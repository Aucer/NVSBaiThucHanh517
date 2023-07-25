using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWeb.Models;
[Table("Students")]
public class Student
{
[Key]
public string StudentID { get; set; }
public string StudentName { get; set; }
}