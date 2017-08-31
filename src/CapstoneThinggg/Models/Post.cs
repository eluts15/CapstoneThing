using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Forum.Models;

namespace Forum.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        [DataType(DataType.MultilineText)]
        public string MessageBody { get; set; }
        public virtual ApplicationUser User { get; set; }


    }
}
