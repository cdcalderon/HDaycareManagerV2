using System.ComponentModel.DataAnnotations;

namespace HDaycareManager.Models
{
    public class Status
    {
        [Required]
        public string ProviderId { get; set; }

        public int Id { get; set; }

        [Required]
        public string StatusName { get; set; }
    }
}