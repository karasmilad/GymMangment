using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMnagment.DAL.Data.Models
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }
        #region Relationships
        public HelthRecord HelthRecord { get; set; } = default!;
        public ICollection<MemberShip> MemberShips { get; set; } = default!;
        public ICollection<Booking> MemberSessions { get; set; } = default!;

        #endregion

    }
}
