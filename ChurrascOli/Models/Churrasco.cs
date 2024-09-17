using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChurrascOli.Models;

[Table("Churrasco")]
public class Churrasco
{
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }

[Required]
[StringLength(30)]
public string Nome { get; set; }

[StringLength(1000)]
public int Descricao  { get; set; }

[StringLength(200)]
public int Imagem { get; set; }


public int TipoId { get; set; }
[ForeignKey("TipoId")]
public Churrasco Churrascos { get;set; }

public ICollection<Churrasco> Churrascos { get; set; }

}
