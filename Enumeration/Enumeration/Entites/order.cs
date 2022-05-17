using System;
using Enumeration.Entites.Enums;

namespace Enumeration.Entites {
    class order {
        public int ID {get; set;}
        public DateTime Moment { get; set; }
        public Orderstatus Status { get; set; }

        public override string ToString() {
            return ID
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
