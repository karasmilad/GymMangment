using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMnagment.DAL.Data.Models
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DurationDays { get; set; } 
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public ICollection<MemberShip> PlanMembers { get; set; } = default!;

    }
}
