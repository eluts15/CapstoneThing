using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{
    [Table("Forum")]
    public class Forum
    {
        public virtual ICollection<Post> Posts { get; set; }
    }
}
