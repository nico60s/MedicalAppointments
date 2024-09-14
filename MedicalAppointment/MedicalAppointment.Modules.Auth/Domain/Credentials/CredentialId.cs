using MedicalAppointment.Shared.Domain;
using System.Security.Cryptography;
using System.Text;

namespace MedicalAppointment.Modules.Auth.Domain.Credentials
{
    public class CredentialId : ValueObject
    {
        internal Guid Value { get; }
        private CredentialId(Guid value)
        {
            Value = Generate(value);
        }
        internal static CredentialId Create(Guid value) => new(value);
        private static Guid Generate(Guid value)
        {
            Guid result;
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(value.ToString()));
                result = new Guid(hash);
            }

            return result;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
