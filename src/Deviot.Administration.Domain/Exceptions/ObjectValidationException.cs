﻿namespace Deviot.Administration.Domain.Exceptions
{
    public class ObjectValidationException : Exception
    {
        public ObjectValidationException()
        {

        }

        public ObjectValidationException(string message): base(message)
        {

        }

        public ObjectValidationException(string message, Exception inner): base(message, inner)
        {

        }
    }
}
