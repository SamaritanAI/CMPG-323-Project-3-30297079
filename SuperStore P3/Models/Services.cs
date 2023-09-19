using System;

namespace EcoPower_Logistics.Models
{
    public partial class Services
    {
        public Guid ServiceID { get; set;}
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }

        private DateTime createdDate;

        public DateTime GetCreatedDate()
        {
            return createdDate;
        }

        public void SetCreatedDate(DateTime value)
        {
            createdDate = value;
        }
    }
}
