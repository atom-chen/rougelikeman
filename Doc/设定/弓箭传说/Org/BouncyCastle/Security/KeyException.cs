﻿namespace Org.BouncyCastle.Security
{
    using System;

    [Serializable]
    public class KeyException : GeneralSecurityException
    {
        public KeyException()
        {
        }

        public KeyException(string message) : base(message)
        {
        }

        public KeyException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}

