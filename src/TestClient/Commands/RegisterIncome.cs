﻿using System;
using Evento;

namespace TestClient.Commands
{
    public class RegisterIncome : Command
    {
        public Guid CorrelationId { get; }
        public decimal Value { get; }
        public string Description { get; }

        public RegisterIncome(Guid correlationId, decimal value, string description)
        {
            CorrelationId = correlationId;
            Value = value;
            Description = description;
        }
    }
}
