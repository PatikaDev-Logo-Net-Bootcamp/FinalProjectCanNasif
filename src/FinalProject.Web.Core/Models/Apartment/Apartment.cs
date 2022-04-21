using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.Apartment
{
    internal class Apartment
    {
        public long Id { get; set; }   
        public string BlockNo { get; set; }

        public string ApartmentStatus   { get; set; }

        public string ApartmentType { get; set; }

        public int ApartmentFloor { get; set; }

        public int ApartmentNo { get; set; }

        public  int OwnerOfApartmentNoId  { get; set; }

    }
}
