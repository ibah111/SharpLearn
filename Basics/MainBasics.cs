using System.Net;

namespace Basics;

class Basic
{
    public static void ScanUri(string uriVariable)
    {
        Uri uri = new(uriVariable);
        Console.WriteLine("{");
        Console.WriteLine($"AbsolutePath: {uri.AbsolutePath}");
        Console.WriteLine($"AbsoluteUri: {uri.AbsoluteUri}");
        Console.WriteLine($"Fragment: {uri.Fragment}");
        Console.WriteLine($"Host: {uri.Host}");
        Console.WriteLine($"IsAbsoluteUri: {uri.IsAbsoluteUri}");
        Console.WriteLine($"IsDefaultPort: {uri.IsDefaultPort}");
        Console.WriteLine($"IsFile: {uri.IsFile}");
        Console.WriteLine($"IsLoopback: {uri.IsLoopback}");
        Console.WriteLine($"OriginalString: {uri.OriginalString}");
        Console.WriteLine($"PathAndQuery: {uri.PathAndQuery}");
        Console.WriteLine($"Port: {uri.Port}");
        Console.WriteLine($"Query: {uri.Query}");
        Console.WriteLine($"Scheme: {uri.Scheme}");
        Console.WriteLine($"Segments: {string.Join(", ", uri.Segments)}");
        Console.WriteLine($"UserInfo: {uri.UserInfo}");
        Console.Write("}");

    }
}