using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Storage.V1;
using System;
using System.IO;

namespace Escrever_tempo_dentro_do_arquivo_
{
    public class UploadFileSample
    {
        public void UploadFile(
            string bucketName = "your-unique-bucket-name",
            string localPath = "my-local-path/my-file-name",
            string objectName = "my-file-name")
        {
            var storage = StorageClient.Create();
            using var fileStream = File.OpenRead(localPath);
            storage.UploadObject(bucketName, objectName, null, fileStream);
            Console.WriteLine($"Uploaded {objectName}.");
        }
    }
}
