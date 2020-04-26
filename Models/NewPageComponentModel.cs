using System.ComponentModel.DataAnnotations;

namespace LearningBlazorServer.Models
{
    public class NewPageComponentModel
    {
        [Required]
        [Range(0, 9999999, ErrorMessage ="Please select an ID")]
        public int Id { get; set; }

        [Required]
        [StringLength(999999999, MinimumLength = 1, ErrorMessage = "Please enter a value")]
        public string Value { get; set; }
    }
}
