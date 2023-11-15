using Base.Core.Domain.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Core.Domain.Entities
{
    public interface IAggregateRoot
    {
        void ClearEvents();
        IEnumerable<IDomainEvent> GetEvents();
    }
}
