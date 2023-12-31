﻿using Base.Core.Domain;
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
        public FirstName(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidValueObjectStateException(Message.InvalidNulValue, Message.FirstName);
            if(value.Length > 25 || value.Length < 3)
                throw new InvalidValueObjectStateException(Message.InvalidNulValue , Message.FirstName , "3", "25");
        }
        Value = value;
    }
}
