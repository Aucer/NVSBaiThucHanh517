using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWeb.Models;
public class Person
{
    [Key]
    public string ID { get; set; }
    public string Fullname { get; set; }
    public string Address { get; set; }
    public DateTime Birthday { get; set; }
}