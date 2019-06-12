using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIPLOMA.Models
{
    public class DirectoryClients
    {
        public int DirectoryClientsID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public int PassportSerial { get; set; }
        public int PassportNumber { get; set; }
        public string AddressRegistration { get; set; }
        public string AddressResidential { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string DataAboutWorkPlace { get; set; }
    }
}
