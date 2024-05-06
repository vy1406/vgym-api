namespace Vgym.Server.Utilities.Responses
{
    public interface IResopnse
    {
        ErrorCodes ErrorCode { get; set; }
        string ErrorMessage { get; set; }
        string ErrorTitle { get; set; }
    }
}
