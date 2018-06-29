using System;

namespace DevJobsCE.Domain.Entities
{
    public class Company
    {
        protected Company() { }

        public Company(string name, DateTime insertionDate)
        {
            SetProperties(name, insertionDate);
        }

        public Guid CompanyId { get; set; }

        public string Name { get; set; }

        public DateTime InsertionDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        private void SetProperties(string name, DateTime insertionDate)
        {
            Name = name;
            InsertionDate = insertionDate;
        }
    }
}
