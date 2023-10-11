using System.ComponentModel.DataAnnotations;

namespace AddrCRUD.Models
{
    public class Addr
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Building Name")]
        public string Building { get; set; }
        public string Level { get; set; }
        public string Room { get; set; }
        public string Carpark { get; set; }
        public string Lobby { get; set; }
        public string Pantry { get; set; }
        public string Type { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
    }
}
