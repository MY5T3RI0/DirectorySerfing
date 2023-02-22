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
        [Key]
        public string Name { get; set; }
        public string Extention { get; set; }
        public long Size { get; set; }
    }
}
