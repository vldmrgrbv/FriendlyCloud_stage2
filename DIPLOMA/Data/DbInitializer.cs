using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIPLOMA.Models;

namespace DIPLOMA.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext_2 context)
        {
            context.Database.EnsureCreated();

            // Look for any Services.
            if (context.Services.Any())
            {
                return;   // DB has been seeded
            }

            var services = new DirectoryServices[]
            {
            new DirectoryServices{Service="Администратор"},
            new DirectoryServices{Service="Уборщик"}
            };
            foreach (DirectoryServices s in services)
            {
                context.Services.Add(s);
            }
            context.SaveChanges();


            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new DirectoryEmployees[]
            {
            new DirectoryEmployees{FirstName="Георгий",SecondName="Васильев",Patronymic="Петрович",PassportSerial="0110",PassportNumber="213432",
                                AddressRegistration="г.Красноярск, ул.Пушкина, д.12/1, Индекс:454324",AddressResidential="г.Красноярск, ул.Пушкина, д.12/1, Индекс:454324",
                                MaritalStatus = true, TelephoneNumber="89732114323", Education="КГУ(ФИТ), бакалавр", Email ="georgvas@mail.ru",
                                DirectoryServicesID = services.Single( i => i.Service == "Администратор").DirectoryServicesID, EmployeeDate=Convert.ToDateTime("01.02.2019")},
            new DirectoryEmployees{FirstName="Екатерина",SecondName="Рудова",Patronymic="Романовна",PassportSerial="0110",PassportNumber="122143",
                                AddressRegistration="г.Красноярск, ул.Георгиева, д.1/21, Индекс:124359",AddressResidential="г.Красноярск, ул.Георгиева, д.1/21, Индекс:124359",
                                MaritalStatus = true, TelephoneNumber="89863456743", Education="КГУ(ХБФ), бакалавр", Email ="ekaterrud@mail.ru",
                                DirectoryServicesID = services.Single( i => i.Service == "Уборщик").DirectoryServicesID, EmployeeDate=Convert.ToDateTime("01.02.2019")}
            };
            foreach (DirectoryEmployees s in employees)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();


            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var clients = new DirectoryClients[]
            {
            new DirectoryClients{FirstName="Александр",SecondName="Петров",Patronymic="Иванович",PassportSerial="0110",PassportNumber="111111",
                                AddressRegistration="г.Красноярск, ул.Ленинна, д.34/23, Индекс:412432",AddressResidential="г.Красноярск, ул.Ленинна, д.34/23, Индекс:412432",
                                TelephoneNumber="89823425634",Email="alexbge@mail.ru",DataAboutWorkPlace="Строитель, ООО\"Стройпласт\"",ClientDate=Convert.ToDateTime("12.05.2019")}
            };
            foreach (DirectoryClients s in clients)
            {
                context.Clients.Add(s);
            }
            context.SaveChanges();
        }
    }
}
