using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstWeb.Models;
[Table("Animals")]
public class Animals
{
    [Key]
    public string AnimalsName { get; set; }
    public string Address { get; set; }
    public string Age { get; set; }
}