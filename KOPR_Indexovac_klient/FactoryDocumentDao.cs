using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOPR_Indexovac_klient
{
    public static class FactoryDocumentDao
    {
        public static IDocumentDao GetDocumentDao(List<Document> documents)
        {
            return new FileDocumentDao(documents);
        }
    }
}
