using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apresentacao.Models
{
  [Table("vagas")]
  public class Vaga
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("vaga_id")]
    [Required]
    public int VagaId { get;set; }

    
    [Column("vaga", TypeName = "varchar")]
    [MaxLength(40)]
    [Required(ErrorMessage="O nome da vaga é obrigatório")]
     public string NomeVaga { get;set; }
    
    
    [Column("descricao_vaga", TypeName = "text")]
    [Required(ErrorMessage="O nome da profissão é obrigatório")]
     public string DescricaoVaga { get;set; }
  }
}