namespace MedicalAppointment.Shared.Domain
{
    public interface IDomainEvent
    {
        public Guid Id { get; }
        public DateTime OccurredOn { get; }
    }
}
