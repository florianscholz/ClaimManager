using System;
using System.Runtime.Serialization;

namespace ClaimManager.DataLayer.Repositories
{
    [Serializable]
    public class InactiveUserException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public InactiveUserException()
        {
        }

        public InactiveUserException(string message) : base(message)
        {
        }

        public InactiveUserException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InactiveUserException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}