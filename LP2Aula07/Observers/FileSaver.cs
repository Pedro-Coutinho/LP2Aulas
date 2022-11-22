using System;
using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly string filename;
        public void Update(AbstractStringSubject sub)
        {
            File.AppendAllText(filename, sub.Item +"\n");
        }

        public FileSaver(string filename){
            this.filename = filename;
        }
    }
}