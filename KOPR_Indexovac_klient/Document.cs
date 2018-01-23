using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOPR_Indexovac_klient
{
    public class Document
    {
        public string name {get; set;}
        public string content {get; set;}
        
       

        public Document()
        {

        }

        public Document(string name, string content)
        {
            this.name = name;
            this.content = content;
        }

        public Document(string name)
        {
            this.name = name;
        }
    }
}
