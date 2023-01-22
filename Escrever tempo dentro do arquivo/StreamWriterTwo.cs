using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrever_tempo_dentro_do_arquivo_
{
    public class StreamWriterTwo
    {
        public string? dateTimeAsString { get; set; }
        public async Task ExampleAsync()
        {
            using StreamWriter file = new(@$"/home/gabrielgsdevbr/tf-tutorial/WriteLines2.txt");
            dateTimeAsString = DateTime.Now.ToString();
            await file.WriteLineAsync(dateTimeAsString);
        }
    }
}
