using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.WebApp.Models
{
    public class Medicine
    {
        public string Name { get; set; }
        public int Badge { get; set; }
        public int Init_Quantity { get; set; }
        public int Curr_Quantity { get; set; }
        public string Exp_Date { get; set; }
    }
}
