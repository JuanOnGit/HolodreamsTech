using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Holodreams_Tech.Models
{
    public class AddMemberModel
    {

        public Member Member { get; set; }

        public System.DateTime Date { get; set; }

        public decimal AmountPaid { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }

    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required]
        [StringLength(100)]
        public string MemberName { get; set; }
    }

    public class MemberDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}
