using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWeb.Models;
[Table("Animal")]
public class Animal
{
    [Key]
    public string Name { get; set; }
    public string Address { get; set; }
    public string Eat { get; set; }
}