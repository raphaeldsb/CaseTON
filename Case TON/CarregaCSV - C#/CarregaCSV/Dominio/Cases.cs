using System;
using System.Collections.Generic;
using System.Text;

namespace CarregaCSV.Dominio
{
    public class Cases
    {
        public int id { get; set; }

        public string accountId { get; set; }

        public string dateRef { get; set; }

        public int channelId { get; set; }

        public int waitingTime { get; set; }

        public string missed { get; set; }

        public string feedback { get; set; }

        public string category_1 { get; set; }

        public string category_2 { get; set; }
        
        public string category_3 { get; set; }
    }
}
