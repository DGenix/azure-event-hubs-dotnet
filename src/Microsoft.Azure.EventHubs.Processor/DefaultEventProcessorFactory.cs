// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Azure.EventHubs.Processor
{
    class DefaultEventProcessorFactory<TEventProcessor> : IEventProcessorFactory
        where TEventProcessor : IEventProcessor, new()
    {
        readonly Lazy<TEventProcessor> instance;

        public DefaultEventProcessorFactory()
        {
            this.instance = new Lazy<TEventProcessor>(() => new TEventProcessor());
        }

        public DefaultEventProcessorFactory(TEventProcessor instance)
        {
            this.instance = new Lazy<TEventProcessor>(() => instance);
        }

        public IEventProcessor CreateEventProcessor(PartitionContext context)
        {
            return this.instance.Value;
        }
    }
}