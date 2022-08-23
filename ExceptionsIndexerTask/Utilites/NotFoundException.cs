using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsIndexerTask.Utilites
{
    class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
