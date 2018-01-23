using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOPR_Indexovac_klient
{
    public class FileDocumentDao : IDocumentDao
    {
        private List<Document> _documents;

        public List<Document> Documents
        {
            get { return _documents; }
            //set { _documents = value; }
        }

        public FileDocumentDao(List<Document> documents)
        {
            this._documents = documents;
        }


        public void SaveDocuments(string directoryPath)
        {
            // _documents.ForEach(document => File.AppendAllText(directoryPath+document.name+".txt", document.content));
            _documents.ForEach(document =>
            {
                var streamWriter = new StreamWriter(directoryPath +"\\" +document.name);
                streamWriter.Write(document.content);
                streamWriter.Close();
            });
        }
        
    }
}
