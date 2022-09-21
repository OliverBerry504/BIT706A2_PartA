using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{
    public class FailedWithdrawalException : Exception
    {
        public FailedWithdrawalException()
        {

        }
        public FailedWithdrawalException(string message) : base(message)
        {

        }
    }
}
