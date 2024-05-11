using Vgym.Server.Utilities.Enums;

namespace Vgym.Server.Utilities.Responses
{
    public class Response : IResopnse
    {
        public Response()
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
