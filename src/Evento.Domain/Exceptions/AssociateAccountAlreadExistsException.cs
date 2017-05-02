﻿using System;

namespace Evento.Domain.Exceptions
{
    public class AssociateAccountAlreadExistsException : Exception
    {
        public Guid Id { get; }

        public AssociateAccountAlreadExistsException(Guid id)
        {
            Id = id;
        }
    }
}
