using System.ComponentModel;

namespace ExercicesEFCore.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [DisplayName("Titre")]
        public string Title { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Terminée")]
        public bool IsDone { get; set; }
    }
}
