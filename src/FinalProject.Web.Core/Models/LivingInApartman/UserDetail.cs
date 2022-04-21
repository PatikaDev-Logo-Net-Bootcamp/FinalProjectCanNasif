using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.LivingInApartman
{
    
    internal class UserDetail
    { 
        public long Id { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string TC { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CarInformation { get; set; }

        public int ApartmentNo { get; set; }
    }
}
