using Firebase.Auth.Requests;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firebase.Auth.Requests
{
    public class SendEmailVerificationRequest

    {
        public const string EmailVerificationType = "VERIFY_EMAIL";

        public SendEmailVerificationRequest()
        {
            this.RequestType = EmailVerificationType;
        }

        public string Email { get; set; }

        public string RequestType { get; set; }
    }

    public class SendEmailVerificationResponse
    {
        public string Email { get; set; }
    }

    /// <summary>
    /// (re-)sends Email verification mail
    /// </summary>
    public class SendEmailVerification : FirebaseRequestBase<object, object>
    {
        public SendEmailVerification(FirebaseAuthConfig config) : base(config)
        {
        }
        protected override string UrlFormat => Endpoints.GoogleGetConfirmationCodeUrl;

    }
}