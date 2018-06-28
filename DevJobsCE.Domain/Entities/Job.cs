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

        public void Validate(string name, DateTime insertionDate, DateTime expireDate, bool active, Guid companyId)
        {
            DomainException.When(!(id > 0), "ProjectId is invalid");
            DomainException.When(String.IsNullOrEmpty(name), "Name is invalid");
            DomainException.When(!(cost > 0), "Cost is invalid");
            DomainException.When(createDate == null, "Create Date is null");
            DomainException.When(!(CompanyId > 0), "CompanyId is invalid");
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
