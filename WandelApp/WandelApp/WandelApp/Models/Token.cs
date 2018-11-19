using System;
using System.Collections.Generic;
using System.Text;

namespace WandelApp.Models
{
    public class Token
    {
        public int id { get; set; }
        public string accesToken { get; set; }
        public string errorDescription { get; set; }
        public DateTime expireDate { get; set; }

        public Token()
        {
            
        }
    }
}
