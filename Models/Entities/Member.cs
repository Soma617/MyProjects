using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interview1.Models.Entities
{
    public class Member
    {
        [Key]
        public string MemberId { get; set; }

        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
        //資料表Member對資料表Order是一對多
    }
}
