using Base.Core.Domain.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Domain.Person.Event
{
    public record PersonCreated : IDomainEvent
    {
        
        public Guid BusinessId { get; }
        public string FirstName { get; }
        public string LastName { get;  }
        public PersonCreated(Guid businessId , string firstName , string lastName)
        {
            BusinessId = businessId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
