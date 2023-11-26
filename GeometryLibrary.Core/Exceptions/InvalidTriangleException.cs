namespace GeometryLibrary.Core.Exceptions;

public class InvalidTriangleException : Exception
{

    public InvalidTriangleException() : base("Incorrect triangle edges are set.")
    {
        
    }
}