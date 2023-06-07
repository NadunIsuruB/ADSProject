

using System.Security.Cryptography.X509Certificates;

namespace ADSCodes;

class Program
{
    public static void Main(string[] args)
    {
        Node root = new Node("root");
        Node a = new Node("left");
        Node b = new Node("right");
        Node c = new Node("left.left");
        Node d = new Node("left.right");
        Node e = new Node("right.left");
        Node f = new Node("right.right");
        Node g = new Node("left.left.left");
        Node h = new Node("left.left.right");


        root.left = a; 
        root.right = b;
        a.left = c;
        a.right = d;
        b.left = e;
        b.right = f;
        c.left = g;
        c.right = h;

        Console.WriteLine(string.Join(" ", BinaryTree.serialize(root).ToArray()));
        Console.WriteLine(string.Join(" ", BinaryTree.serialize(BinaryTree.deserialize(string.Join(" ", BinaryTree.serialize(root).ToArray()))).ToArray()));
    }
}