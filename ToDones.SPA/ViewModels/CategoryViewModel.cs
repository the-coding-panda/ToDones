using System.ComponentModel.DataAnnotations;
using ToDones.Data.Types;

namespace ToDones.SPA.ViewModels
{
    public class CategoryViewModel
    {
        public int UserId { get; set; }
        
        [Required(ErrorMessage ="Please enter a category name")]
        public string Name { get; set; }
        public CategoryColour Colour { get; set; }
    }
}
