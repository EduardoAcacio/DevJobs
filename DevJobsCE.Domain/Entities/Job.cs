using DevJobsCE.Domain.Exceptions;
using System;

namespace DevJobsCE.Domain.Entities
{
    public class Job
    {
        protected Job() { }

        public Job(string name, DateTime insertionDate, DateTime expireDate, bool active, Guid companyId)
        {
            SetProperties(name, insertionDate, expireDate, active, companyId);
            Validate(name, insertionDate, expireDate, active, companyId);
        }

        public Guid JobId { get; set; }

        public string Name { get; set; }

        public DateTime InsertionDate{ get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public bool IsPaid { get; set; }

        public bool Active { get; set; }

        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; }

        private void SetProperties(string name, DateTime insertionDate, DateTime expireDate, bool active, Guid companyId)
        {
            Name = name;
            InsertionDate = insertionDate;
            ExpireDate = expireDate;
            Active = active;
            CompanyId = companyId;
        }

        public void Activate()
        {
            Active = true;
            ExpireDate = DateTime.Now.AddDays(5);
        }

        public void Inactivate()
        {
            Active = false;
        }
    }
}
