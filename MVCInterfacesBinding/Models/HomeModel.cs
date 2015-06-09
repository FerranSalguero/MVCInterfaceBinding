using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInterfaceBinding.Models
{
    public class HomeModel
    {
        public List<IItem> ItemList { get; set; }
    }

    public interface IItem
    {
        string Name { get; set; }
        int Value { get; set; }

        string GetAllProps();
    }

    public class Item1 : IItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public int OtherValue { get; set; }


        public string GetAllProps()
        {
            return string.Format("{0}-{1}-{2}", Name, Value, OtherValue);
        }
    }

    public class Item2 : IItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public string OtherName { get; set; }

        public string GetAllProps()
        {
            return string.Format("{0}-{1}-{2}", Name, Value, OtherName);
        }
    }
}