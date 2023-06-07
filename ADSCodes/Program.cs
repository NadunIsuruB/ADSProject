

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


        root.left = a; 
        root.right = b;
        a.left = c;
        a.right = d;
        b.left = e;
        b.right = f;

        Console.WriteLine(string.Join(" ", SerializeBinaryTree(root).ToArray()));
        Console.WriteLine(string.Join(" ", SerializeBinaryTree(DeSerializeBinaryTree(string.Join(" ", SerializeBinaryTree(root).ToArray()))).ToArray()));

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

    public static Node DeSerializeBinaryTree(String serializeBinaryTree)
    {
        List<string> treeData = serializeBinaryTree.Split(' ').ToList(); //root left left.left left.right right
        List<Node> nodes = new List<Node>() { new Node("root") };
        int currentDepth = 0;
        Boolean isLeftDone = false;
        for (int i = 0; i < treeData.Count; i++)
        {
            
            if (i == 0) continue;
            int depth = treeData[i].Split('.').Length;
            if(currentDepth <depth)
            {
                nodes.Add(new Node(treeData[i]));
                nodes[nodes.Count - 2].left = nodes[nodes.Count - 1];
                currentDepth++;
            }
            else if( currentDepth == depth) 
            {
                nodes.Add(new Node(treeData[i]));
                nodes[nodes.Count - 3].right = nodes[nodes.Count - 1];
            }
            else
            {
                currentDepth = depth - 1;
                i--;
            }
        }

        return nodes[0];
    }
}