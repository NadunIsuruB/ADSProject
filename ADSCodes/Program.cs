

using System.Security.Cryptography.X509Certificates;

namespace ADSCodes;

class Program
{
    public static void Main(string[] args)
    {
        Node root = new Node("root");
        Node a = new Node("a");
        Node b = new Node("b");
        Node c = new Node("c");
        Node d = new Node("d");

        root.left = a; 
        root.right = b;
        a.left = c;
        a.right = d;

        Console.WriteLine(string.Join(" ", SerializeBinaryTree(root).ToArray()));
    }

    public static List<string> SerializeBinaryTree(Node root)
    {
        if (root == null) return new List<string>();
        List<string> outputStr = new List<string>() { root.value };

        List<string> leftVal = new List<string>();
        List<string> rightVal = new List<string>();

        leftVal.AddRange(SerializeBinaryTree(root.left));
        rightVal.AddRange(SerializeBinaryTree(root.right));

        leftVal.AddRange(rightVal);
        outputStr.AddRange(leftVal);

        return outputStr;
    }
}

class Node
{
   public string value { get; set; }
   public Node left { get; set; }
   public Node right { get; set; }
    public Node(string val)
    {
        this.value = val;
    }

}

