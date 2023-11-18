using Base.Core.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Domain.Person.ValueObject
{
    public record FirstName 
    {
        public string Value { get; init; }
        public FirstName()
        {
            if (string.IsNullOrEmpty(Value))
                throw new InvalidValueObjectStateException()
        }
    }
}
