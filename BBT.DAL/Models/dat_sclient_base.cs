using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBT.DAL.Models
{
    [TableName("dat_sclient_base")]
    [ExplicitColumns]
    public class dat_sclient_base : DefaultConnectionDB.Record<dat_sclient_base>
    {
        [Column]
        public string c_num { get; set; }

        [Column]
        public string c_uid { get; set; }

        [Column]
        public string c_pass { get; set; }

        [Column]
        public string c_name { get; set; }

        [Column]
        public DateTime c_createtime { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [Column]
        public string c_mt { get; set; }

        [Column]
        public string c_addr { get; set; }
    }
}
