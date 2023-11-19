using Base.Core.Domain.Exceptions;
using Base.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Domain.Person.ValueObject
{
    public class LastName
    {
        public string Value { get; init; }
        public LastName(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidValueObjectStateException(Message.InvalidNulValue, Message.FirstName);
            if (value.Length > 25 || value.Length < 3)
                throw new InvalidValueObjectStateException(Message.InvalidNulValue, Message.LastName, "3", "25");
            Value = value;

        }
    }
}
