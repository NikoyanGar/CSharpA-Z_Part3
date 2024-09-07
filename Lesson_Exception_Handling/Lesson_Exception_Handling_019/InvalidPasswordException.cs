
namespace Lesson_Exception_Handling_019
{
    [Serializable]
    internal class InvalidPasswordException : Exception
    {
        public InvalidPasswordException()
        {
        }

        public InvalidPasswordException(string? message) : base(message)
        {
        }

        public InvalidPasswordException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}