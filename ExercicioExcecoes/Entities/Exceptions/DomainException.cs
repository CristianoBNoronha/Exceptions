using System;


namespace ExercicioExcecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensage) : base(mensage)
        {
        }
    }
}
