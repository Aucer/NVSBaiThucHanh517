using System.ComponentModel.DataAnnotations;

namespace FirstWeb.Models;
public class Person
{
    [Key]
    public string ID { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
}