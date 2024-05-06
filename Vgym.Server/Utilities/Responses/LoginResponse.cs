namespace Vgym.Server.Utilities.Responses
{
    public class LoginResponse : IResopnse
    {
        public LoginResponse()
        {
            ErrorCode = ErrorCodes.NO_ERROR;
            ErrorMessage = null!;
            ErrorTitle = null!;
        }
        public ErrorCodes ErrorCode { get; set; }
        public string ErrorMessage { get; set; } 
        public string ErrorTitle { get; set; } 
    }
}
