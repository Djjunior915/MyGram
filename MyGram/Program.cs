using System;

using MyGram.MyClasses;


namespace MyGram
{
    class Program
    {
        static void Main()
        {
            Posts post = new Posts();
            post.PostId = 1;
            post.Post = "This is a post";

            Console.WriteLine("The value if my first property is: " + post.PostId);
            Console.WriteLine("The value if my second property is: " + post.Post);

        }

    }
}
