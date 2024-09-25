using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Auth.Domain.Users.Rules
{
    public class MustNotBeNullOrEmptyBusinessRule : IBusinessRule
    {
        private bool _isBroken;
        private string _message;

        public MustNotBeNullOrEmptyBusinessRule(string email)
        {
            _message = email;
            if (string.IsNullOrEmpty(_message))
            {
                _isBroken = true;
                _message = "Email was null or empty";
            }
            _isBroken = false;
            _message = "Checked";
        }


        public bool IsBroken => _isBroken;

        public string Message => _message;

    }
}
