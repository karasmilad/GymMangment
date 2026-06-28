using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMnagment.DAL.Data.Models
{
    public class HelthRecord : BaseEntity
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string? Note { get; set; }
        public string BloodType { get; set; } = default!;

        #region Relationships
        public Member Member { get; set; } = default!;
        public int MemberId { get; set; }
        #endregion
    }
}
