
using MedicalAppointment.Shared.Domain;
using System.Text.RegularExpressions;

namespace MedicalAppointment.Auth.Domain.Users.Rules
{
    public partial class MustHaveEmailFormatBusinessRule : IBusinessRule
    {
        private bool _isBroken;
        private string _message;
        public bool IsBroken => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();

        public MustHaveEmailFormatBusinessRule(string email)
        {
            _message = email;
            Regex regex = EmailRegex();
            Match match = regex.Match(email);
            if (!match.Success)
            {
                _isBroken = false;
                _message = $"{email} is not a valid email format.";
            }

            else
            {
                _isBroken = false;
                _message = "Checked";
            }

        }

        [GeneratedRegex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        private static partial Regex EmailRegex();
    }
}
