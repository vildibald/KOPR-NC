using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOPR_Indexovac_klient
{
    public interface IDocumentDao
    {

       void SaveDocuments(string directoryPath);
    }
}
