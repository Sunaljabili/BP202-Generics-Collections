using System;
using System.Collections.Generic;
using System.Text;

namespace TaskClasswork.Exceptions
{
    class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException(string message):base(message)
        {

        }
    }
}
