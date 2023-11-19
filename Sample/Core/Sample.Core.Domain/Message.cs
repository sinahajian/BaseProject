using Sample.Core.Domain.Person.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Core.Domain
{
    public class Message
    {
        public static string InvalidNulValue = "The Value {0} Is Null ";
        public static string InvalidValueSiza = "The Value {0} Must Beetween {1} and {2} ";
        public static string FirstName =nameof(FirstName);
        public static string LastName =nameof(LastName);

    }
}
