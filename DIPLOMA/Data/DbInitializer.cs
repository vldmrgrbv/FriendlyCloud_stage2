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

            // Look for any Clients.
            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var clients = new DirectoryClients[]
            {
            new DirectoryClients{FirstName="Александр",SecondName="Петров",Patronymic="Иванович",PassportSerial=0110,PassportNumber=111111,
                                AddressRegistration="г.Красноярск, ул.Ленинна, д.34/23, Индекс:412432",AddressResidential="г.Красноярск, ул.Ленинна, д.34/23, Индекс:412432",
                                TelephoneNumber="89823425634",Email="alexbge@mail.ru",DataAboutWorkPlace="Строитель, ООО\"Стройпласт\""}
            };
            foreach (DirectoryClients s in clients)
            {
                context.Clients.Add(s);
            }
            context.SaveChanges();
        }
    }
}
