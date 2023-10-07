using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH01.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string? MenuName { get; set; }
        public bool? IsActive { get; set; }
        public string? Controllername { get; set; }
        public string? ActionName { get; set; }
        public int Levels { get; set; }
        public int ParentID { get; set; }
        public string? Link { get; set; }
        public int MenuOder { get; set; }   

    }
}
