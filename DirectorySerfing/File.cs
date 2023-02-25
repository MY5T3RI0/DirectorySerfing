using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorySerfing
{
    [Table("Files")]
    public class File
    {
        public int FileId { get; set; }
        public DateTime CopyDate { get; set; }
        public string Name { get; set; }
        public string Extention { get; set; }
        public string BaseDir { get; set; }
        public long Size { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastChange { get; set; }
        public int Hash { get; set; }
        public ICollection<Directory> Directory { get; set; }

    }
}
