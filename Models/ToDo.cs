using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExercicesEFCore.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [DisplayName("Titre")]
        [Required(ErrorMessage = "Le titre est obligatoire")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        public string Title { get; set; }

        [DisplayName("Description")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La description est obligatoire")]
        public string Description { get; set; }

        [DisplayName("Terminée")]
        [Required]
        public bool IsDone { get; set; }
    }
}
