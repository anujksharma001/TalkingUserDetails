using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace First_MVC_Project.Models
{
    public class Category
    {
        [Key] //DataAnotations
        public int ID { get; set; }
        [Required] //DataAnotations
        public string Name { get; set; }
        //Custom Validations (Screenshot taken)
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }  
}
