using System.ComponentModel.DataAnnotations;

namespace TechChallenge;

public class Aluno
{
    [Required (ErrorMessage = "O CAMPO É OBRIGATÓRIO")]
    public int Id { get; set; }
    [StringLength(100, ErrorMessage = "O NOME DEVE TER ENTRE 3 E 167 CARACTERES")]
    public string Nome { get; set; }
    [EmailAddress (ErrorMessage = "NÃO É UM E-MAIL VÁLIDO")]
    [Required (ErrorMessage = "UM E-MAIL DEVE SER UTILIZADO")]
    public string Email { get; set; }
    [Required (ErrorMessage = "UM TELEFONE DEVE SER UTILIZADO")]
    [Phone (ErrorMessage = "NÃO É UM NÚMERO VÁLIDO")]
    public string Telefone { get; set; }
    [Required (ErrorMessage = "A DATA DE NASCIMENTO É OBRIGATÓRIA")]
    public DateOnly DataNascimento { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;
    public bool Ativo { get; set; } = true;
}
