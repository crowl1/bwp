using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWP.Data
{
    public class Component
    {
        public int _ID { get; set; }
        public string _nameCustomer { get; set; }
        public List<string> _componentType = new List<string>() { "Процесор", "Метеринська плата", "Відеокарта", "Опереативна память" };
        public int _cost { get; set; }
        public Component(int ID, string NameCustomer, int Cost)
        {
            _ID = ID;
            _nameCustomer = NameCustomer;
            _cost = Cost;
        }
    }
}
