using Base.Core.Domain.Entities;
using Sample.Core.Domain.Person.Event;
using Sample.Core.Domain.Person.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Domain.Person.Entities
{
    public class Person : AggregateRoot
    {
        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public Person(FirstName firstName , LastName lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AddEvent(new PersonCreated(UniqId.Value, firstName.Value, lastName.Value));
        }
    }
}
