using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.Prototype
{
    public class Sheep : ICloneable
    {
        protected string _name;
        protected string _category;

        public Sheep(string name, string category = "Mountain Sheep")
        {
            _name = name;
            _category = category;
        }

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Category 
        {
            get { return _category; }
            set { _category = value; }
        }

        public object Clone()
        {
            return new Sheep(_name, _category);
        }
    }
}
