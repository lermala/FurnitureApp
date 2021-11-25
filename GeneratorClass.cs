using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace FurnitureApp
{
    // сделать генерацию и отображение данных в каждой таблице.
    // удаление / изменение не надо. Только ввод количества и генерацию.
    // сделать форсу для ввода данных (messagebox with txtBox)
    // 2 запроса для БД (через сервер)

    class GeneratorClass
    {
        public static List<Customer> GenerateCustomers(int countOfGenerated)
        {
            Faker<Customer> generatorCustomer = GenerateCustomerFaker();
            List<Customer> customers = generatorCustomer.Generate(countOfGenerated);
            customers.ForEach(value => Console.WriteLine(value)); // FIXME

            return customers;
        }

        public static List<Manufacturer> GenerateManufacturers(int countOfGenerated)
        {
            Faker<Manufacturer> generatorManufacturer = GenerateManufacturerFaker();
            List<Manufacturer> manufacturers = generatorManufacturer.Generate(countOfGenerated);
            manufacturers.ForEach(value => Console.WriteLine(value)); //FIXME

            return manufacturers;
        }

        public static List<Model> GenerateModels(int countOfGenerated)
        {
            Faker<Model> generatorModel = GenerateModelFaker();
            List<Model> models = generatorModel.Generate(countOfGenerated);
            models.ForEach(value => Console.WriteLine(value)); //FIXME

            return models;
        }

        private static Faker<Customer> GenerateCustomerFaker()
        {
            // создаём объект класса Faker, указывая что необходимо
            // использовать русскую локализацию
            return new Faker<Customer>("ru")
                // задаём правилa генерации
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Phone_number, f => f.Person.Phone)
                .RuleFor(x => x.Address, f => f.Address.FullAddress())
                ;
        }

        private static Faker<Manufacturer> GenerateManufacturerFaker()
        {
            return new Faker<Manufacturer>("ru")
                // задаём правилa генерации
                //.RuleFor(x => x.Name, f => f.Lorem.Word())                
                .RuleFor(x => x.Name, f => f.Company.CompanyName()) // FIXME +ИП ООО ПАО ОАО                
                .RuleFor(x => x.OGRN, f => f.Random.Long(1000000000000, 9999999999999).ToString()) //FIXME
                ;
            
            // сгенерировать 13-знач число -> toString -> shuffle
            // ...
        }

        private static Faker<Model> GenerateModelFaker()
        {
            return new Faker<Model>("ru")                
                .RuleFor(x => x.ID_model, f => f.Random.String2(1, 8))              //FIXME 
                .RuleFor(x => x.Name, f => f.Commerce.ProductName())               
                .RuleFor(x => x.Description, f => f.Commerce.ProductDescription())
                .RuleFor(x => x.Manufacturer, f => f.Random.Long(1000000000000, 9999999999999).ToString()) //FIXME
                .RuleFor(x => x.Cost, f => Convert.ToDouble(f.Commerce.Price()))
                ;
        }


    }
}
