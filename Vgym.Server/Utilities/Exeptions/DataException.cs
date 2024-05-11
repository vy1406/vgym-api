namespace Vgym.Server.Utilities.Exeptions
{
    public class DataException : Exception
    {
        public DataException(string message = null, Exception inner = null) : base(message, inner) { }

    }

    public class EntityNotFoundException : DataException
    {
        public EntityNotFoundException(string message = null, Exception inner = null) : base(message, inner) { }

    }

    public class DuplicateEntityException : DataException
    {
        public DuplicateEntityException(string message = null, Exception inner = null) : base(message, inner) { }

    }

    public class InvalidEntityException : DataException
    {
        public InvalidEntityException(string message = null, Exception inner = null) : base(message, inner) { }

    }
}
