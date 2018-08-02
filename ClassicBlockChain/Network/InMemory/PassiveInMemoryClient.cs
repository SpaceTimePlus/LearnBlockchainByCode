﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace UChainDB.Example.Chain.Network.InMemory
{
    public class PassiveInMemoryClient : InMemoryClientBase
    {
        public PassiveInMemoryClient(InMemoryClientServerCenter center, ActiveInMemoryClient client) : base(center)
        {
            this.opposite = client;
            this.opposite.opposite = this;
            this.BaseAddress = client.TargetAddress;
            this.TargetAddress = client.BaseAddress;
        }

        public override Task ConnectAsync(string connectionString, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }
    }
}