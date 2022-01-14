﻿using Abp.Domain.Entities;
using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Domain.Aggregates.ExampleAggregate
{
    public class PersonPhone: Entity, IAggregateRoot
    {
        public int BusinessEntityID { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneNumberTypeID { get; set; }
        public string PhoneNumberType { get; set; }



        public ICollection<IEventData> DomainEvents => throw new NotImplementedException();
    }
}
