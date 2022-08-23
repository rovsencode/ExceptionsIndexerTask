using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsIndexerTask.Utilites
{
    class NotAvaliableException:Exception
    {
        public NotAvaliableException(string message):base( message)
        {

        }

    }
}
