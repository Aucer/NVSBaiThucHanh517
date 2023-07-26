using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWeb.Models;
public class Student
{
    [Key]
    public string StudentID { get; set; }
    public string MVS { get; set; }
    public string Age { get; set; }
    public string FacultyID { get; set; }
    [ForeignKey("FacultyID")]
    public Faculty? Faculty { get; set; }
}