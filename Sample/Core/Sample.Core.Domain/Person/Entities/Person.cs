using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Domain.Person.Entities
{
    public class Person : AggregateRoot<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
