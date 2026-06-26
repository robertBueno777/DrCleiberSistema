using System.ComponentModel.DataAnnotations;

namespace DrCleiberSistema.Models
{
    public class PacienteModel
    {
        public int IdPaciente { get; set; }

        [Required]
        public string? NomePaciente { get; set; }

        [Required]
        public string? IdadePaciente { get; set; }

        [Required]
        public string? MotivoConsulta { get; set; }

        [Required]
        public string? NumeroContato { get; set; }
    }
}
