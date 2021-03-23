using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLCRUD.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlenname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

    }
}
