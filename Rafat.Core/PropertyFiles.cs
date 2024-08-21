using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafat.Core
{
    public class PropertyFile
    {

        public int PropertyFileId { get; set; }
     
        public int PropertyId { get; set; }
        
        public string FilePath { get; set; }

        public string FileName { get; set; }

        public string FileType { get; set; }

        public byte [] FileData { get; set; }

        public virtual Property Property { get; set; }




    }
}
