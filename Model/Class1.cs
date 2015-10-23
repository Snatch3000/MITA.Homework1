using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CatColor
    {
        public string HealthColor { get; set; }
        public string SickColor { get; set; }
    }

    public class Cat 
    {
        private string _name;
        private readonly string _age;
        private int _health;
        CatColor cet = new CatColor();
        
        public Cat(string age)
        {
            _age = age;
            _health = 5;
            cet.HealthColor = "white";
            cet.SickColor = "green";
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                    _name = value;
            }
        }

        public string Age
        {
            get { return _age; }
        }

        public string Color
        {
            get
            {
                
                if (_health==5)
                return cet.HealthColor;
                else
                {
                    return cet.SickColor;
                }
            }
            set
            {
                
                if (_health == 5)
                    cet.HealthColor = value;
                else
                {
                    cet.SickColor = value;
              }
            }

        }

        public void Feed()
        {
            if (_health!=5)
            _health = _health + 1;
        }

        public void Punish()
        {
            if (_health != 0)
                _health = _health - 1;
        }

        public string CurrentColor
        {
            get { return Color; }
            set { Color = value; }
        }
        }
}
