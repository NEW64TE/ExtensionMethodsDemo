using System;

namespace ExtensionMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a very very very very very very very very very very long blogpost...";
            var shortenPost = post.Shorten(5);

            Console.WriteLine(shortenPost);
        }
    }
}
