using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALYPSO
{
   public class print_informations
    {
        public int Totalprice {get; set; }
        public string SelectedDoctorName { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public int Totaldebt { get; set; }
       public int dr_last_payment { get; set; }
    }
}
