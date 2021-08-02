using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TExample
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
    }
}