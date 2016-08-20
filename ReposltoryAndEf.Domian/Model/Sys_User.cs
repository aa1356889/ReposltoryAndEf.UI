using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposltoryAndEf.Domian
{
    public class Sys_User
    {

        public int ID { get; set; }

        [MaxLength(50)]
        public string NAME { get; set; }
        [MaxLength(50)]
        public string ACCOUNT { get; set; }
        [MaxLength(1000)]
        public string PASSWORD { get; set; }

        public bool ISCANLOGIN { get; set; }

        public int? SHOWORDER1 { get; set; }

        public int? SHOWORDER2 { get; set; }
        [MaxLength(50)]
        public string PINYIN1 { get; set; }
        [StringLength(50)]
        public string PINYIN2 { get; set; }
        [Column(TypeName = "ntext")]
        public string FACE_IMG { get; set; }

        [StringLength(36)]
        public string LEVELS { get; set; }

        [StringLength(36)]
        public string DPTID { get; set; }
        [StringLength(36)]
        public string CREATEPER { get; set; }

        public DateTime? CREATEDATE { get; set; }

      
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATEDATE { get; set; }

       
    }
}
