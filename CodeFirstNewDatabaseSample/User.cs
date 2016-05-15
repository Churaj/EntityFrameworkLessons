using System.ComponentModel.DataAnnotations;

namespace CodeFirstNewDatabaseSample
{
    public class User
    {
        [Key]
        //[StringLength(50)] - min and max length
        [MaxLength(50)] // - max length
        [Required]
        public string Username { get; set; }
        public string DisplayName { get; set; }
    }
}