﻿using System;

namespace AzureResourceManager.Core.Exceptions
{
    public abstract class BusinessRuleException : Exception
    {
        public BusinessRuleException()
        {
        }

        public BusinessRuleException(string message) : base(message)
        {
        }

        public BusinessRuleException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
