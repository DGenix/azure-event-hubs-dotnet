// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.EventHubs.Processor
{
    using System;
    using System.Threading.Tasks;

    /// <inheritdoc cref="EventProcessorHost"/>
    public interface IEventProcessorHost
    {
        /// <inheritdoc cref="EventProcessorHost"/>
        string ConsumerGroupName { get; }

        /// <inheritdoc cref="EventProcessorHost"/>
        Uri EndpointAddress { get; }

        /// <inheritdoc cref="EventProcessorHost"/>
        string EventHubPath { get; }

        /// <inheritdoc cref="EventProcessorHost"/>
        string HostName { get; }

        /// <inheritdoc cref="EventProcessorHost"/>
        TimeSpan OperationTimeout { get; }

        /// <inheritdoc cref="EventProcessorHost"/>
        PartitionManagerOptions PartitionManagerOptions { get; set; }

        /// <inheritdoc cref="EventProcessorHost"/>
        TransportType TransportType { get; }

        /// <inheritdoc cref="EventProcessorHost"/>
        Task DeleteLeasesAsync();

        /// <inheritdoc cref="EventProcessorHost"/>
        Task RegisterEventProcessorAsync<T>() where T : IEventProcessor, new();

        /// <inheritdoc cref="EventProcessorHost"/>
        Task RegisterEventProcessorAsync<T>(EventProcessorOptions processorOptions) where T : IEventProcessor, new();

        /// <inheritdoc cref="EventProcessorHost"/>
        Task RegisterEventProcessorFactoryAsync(IEventProcessorFactory factory);

        /// <inheritdoc cref="EventProcessorHost"/>
        Task RegisterEventProcessorFactoryAsync(IEventProcessorFactory factory, EventProcessorOptions processorOptions);

        /// <inheritdoc cref="EventProcessorHost"/>
        Task UnregisterEventProcessorAsync();
    }
}