using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class apartment
    {
        public int apartmentNo{ get; set; }
        public int ownerName { get; set; }
        public static int NoOfHousesbought { get; set; }
        public static string Address { get; set; }

        public apartment(int apartmentNo, string ownerName) {
            apartmentNo = apartmentNo;
            ownerName = ownerName;
            ++NoOfHousesbought;
        }

        public void Display()
        {
            Console.WriteLine("apartment no:" + apartmentNo + "OwnerName" + ownerName);
        }
        public static void DisplayAapartmentAddress()
        {
            Console.WriteLine($"Aapartment address: {Address}");
        }
        public static void DisplayTotalNoOfHousesBought() {
            Console.WriteLine($"Houses Bought:{NoOfHousesbought}");
            }
    }
}
