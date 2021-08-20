using System.ComponentModel.DataAnnotations;

namespace Altaliza.Application.Dtos
{
    public class CreateCharacterRequestDto
    {
        [Required(ErrorMessage = "O nome do personagem � obrigat�rio.")]
        [MinLength(0, ErrorMessage = "O nome do personagem n�o deve ser vazio.")]
        [MaxLength(50, ErrorMessage = "O nome do personagem deve ter no m�ximo 50 caracteres.")]
        public string Name { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "O valor da carteira n�o deve ser negativo.")]
        public float Wallet { get; set; }
    }
}
