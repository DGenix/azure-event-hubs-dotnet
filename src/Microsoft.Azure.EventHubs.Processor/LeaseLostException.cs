﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.EventHubs.Processor
{
    using System;

    /// <summary>
    /// Represents an exception that occurs when the service lease has been lost.
    /// </summary>
    public class LeaseLostException : Exception
    {
        internal LeaseLostException(string partitionId, Exception innerException)
            : base(innerException.Message, innerException)
        {
            if (partitionId == null)
            {
                throw new ArgumentNullException(nameof(partitionId));
            }

            this.PartitionId = partitionId;
        }

        /// <summary>
        /// Gets the partition ID where the exception occured.
        /// </summary>
        public string PartitionId { get; }
    }
}