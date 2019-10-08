﻿using Azure.Storage.Blobs.PerfStress.Core;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Storage.Blobs.PerfStress
{
    public class UploadTest : ParallelTransferTest<ParallelTransferOptionsOptions>
    {
        public UploadTest(string id, ParallelTransferOptionsOptions options) : base(id, options)
        {
            try
            {
                BlobClient.Delete();
            }
            catch (StorageRequestFailedException)
            {
            }
        }

        public override void Run(CancellationToken cancellationToken)
        {
            BlobClient.Upload(RandomStream, parallelTransferOptions: ParallelTransferOptions, cancellationToken: cancellationToken);
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            await BlobClient.UploadAsync(RandomStream, parallelTransferOptions: ParallelTransferOptions, cancellationToken: cancellationToken);
        }

        public override void Dispose()
        {
            try
            {
                BlobClient.Delete();
            }
            catch (StorageRequestFailedException)
            {
            }
            base.Dispose();
        }
    }
}
