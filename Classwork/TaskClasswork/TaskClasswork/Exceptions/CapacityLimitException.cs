using System;
using System.Collections.Generic;
using System.Text;

namespace TaskClasswork.Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {
        }
    }
}
