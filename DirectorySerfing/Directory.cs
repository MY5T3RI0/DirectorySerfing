using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorySerfing
{
    [Table("Directories")]
    public class Directory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("File")]
        public int FileId { get; set; }
        public string Name { get; set; }
        public File File { get; set; }
    }
}
