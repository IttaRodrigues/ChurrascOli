using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChurrascOli.Models;

[Table("Tipo")]
public class Tipo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    public ICollection<Churrasco> Churrascos { get; set; }
}
