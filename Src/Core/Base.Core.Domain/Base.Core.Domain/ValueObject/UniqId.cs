using Base.Core.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Base.Core.Domain.ValueObject.UniqId;

namespace Base.Core.Domain.ValueObject
{
    public class UniqId : BaseValueObject<UniqId>
    {

  
        public static UniqId FromString(string value) => new(value);
        public static UniqId FromGuid(Guid value) => new() { Value = value };

        public UniqId(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidValueObjectStateException("ValidationErrorIsRequire", nameof(UniqId));
            }
            if (Guid.TryParse(value, out Guid tempValue))
            {
                Value = tempValue;
            }
            else
            {
                throw new InvalidValueObjectStateException("ValidationErrorInvalidValue", nameof(UniqId));
            }
        }
        private UniqId()
        {

        }

        public Guid Value { get; private set; }

        public override string ToString()
        {
            return Value.ToString();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static explicit operator string(UniqId title) => title.Value.ToString();
        public static implicit operator UniqId(string value) => new(value);


        public static explicit operator Guid(UniqId title) => title.Value;
        public static implicit operator UniqId(Guid value) => new() { Value = value };

    }

}
