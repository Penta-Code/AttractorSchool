using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3.Exceptions
{
    internal class WrongProductStateException : Exception
    {
        public WrongProductStateException() : base("Попытка привести к состоянию, которое сейчас не допустимо!") { }

        public WrongProductStateException(string state, string wrongState) : base($"Попытка привести к состоянию {wrongState}, которое не допустимо из состояния {state}!") { }

        public WrongProductStateException(string message) : base(message) { }

        public WrongProductStateException(string message, Exception innerException) : base(message, innerException) { }
    }
}