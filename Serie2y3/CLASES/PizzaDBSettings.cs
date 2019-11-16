using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serie2y3.CLASES
{
    public class PizzaDBSettings : IPizzaDBSettings
    {
        public string PizzasCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPizzaDBSettings
    {
        string PizzasCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
