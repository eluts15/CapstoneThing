using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool AdminPrivilage = false; // Initially false, current admins can override this.
        public int PostID { get; set; }
        public virtual Post Post { get; set; }
    } 
}
