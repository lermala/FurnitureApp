using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;

namespace FurnitureApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            var custFaker = new Faker<Customer>()
                .RuleFor(x => x.Name, x => x.Person.FullName)
                .RuleFor(x => x.Phone_number, x => x.Person.Phone)
                .RuleFor(x => x.Address, x => x.Address.FullAddress())
                ;

            
                
        }
    }
}
