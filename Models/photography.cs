
using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Summer22_Assignment .Models
{
    public class photography
    {
        public int ID { get; set; }
        public string Name{ get; set; } 

        [DataType(DataType.Date)]
        public DateTime Visited  { get; set; }
        public string Location{ get; set; }
        public string Type{ get; set; } 
    }
}