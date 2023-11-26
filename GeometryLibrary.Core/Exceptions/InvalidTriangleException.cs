namespace GeometryLibrary.Core.Exceptions;

internal class InvalidTriangleException : Exception
{

    public InvalidTriangleException() : base("Incorrect triangle edges are set.")
    {
        
    }
}