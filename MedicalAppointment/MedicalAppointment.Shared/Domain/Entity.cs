

namespace MedicalAppointment.Shared.Domain
{
    public abstract class Entity<T> where T : ValueObject
    {
        protected T Id { get; set; }
        public abstract IReadOnlyCollection<IIntegrationEvent> Events { get; }
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
