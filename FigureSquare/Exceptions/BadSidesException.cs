namespace FigureArea.Exceptions
{
    public class BadSidesException : Exception
    {
        public BadSidesException() : base() { }
        public BadSidesException(string entity) : base($"Figure \"{entity}\" has incorrect sides.") { }
    }
}
