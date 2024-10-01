


namespace MedicalAppointment.Shared.Domain
{
    public class ValueId : ValueObject
    {
        private readonly Guid _value;
        public Guid Value => _value;
        public ValueId(Guid value) : base(Guid.NewGuid())
        {
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _value;
        }
    }
}
