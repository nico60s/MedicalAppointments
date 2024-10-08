﻿

namespace MedicalAppointment.Shared.Domain
{
    public abstract class Entity<T> where T : ValueObject
    {
        public T Id { get; set; }
        protected Entity(T id) => Id = id;
        protected void CheckRule(IBusinessRule rule)
        {
            if (rule.IsBroken)
            {
                throw new BusinessRuleValidationException(rule);
            }
        }
    }
}
