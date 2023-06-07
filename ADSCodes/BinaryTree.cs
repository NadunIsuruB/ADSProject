namespace ADSCodes;

public class BinaryTree
{
    public static List<string> serialize(Node root)
    {
        if (root == null) return new List<string>();
        List<string> outputStr = new List<string>() { root.value };

        List<string> leftVal = new List<string>();
        List<string> rightVal = new List<string>();

        leftVal.AddRange(serialize(root.left));
        rightVal.AddRange(serialize(root.right));

        leftVal.AddRange(rightVal);
        outputStr.AddRange(leftVal);

        return outputStr;
    }

    public static Node deserialize(String serializeBinaryTree)
    {
        List<string> treeData = serializeBinaryTree.Split(' ').ToList(); //root left left.left left.right right
        List<Node> nodes = new List<Node>() { new Node("root") };
        int currentDepth = 0;

        for (int i = 0; i < treeData.Count; i++)
        {

            if (i == 0) continue;
            int depth = treeData[i].Split('.').Length;
            if (currentDepth < depth)
            {
                nodes.Add(new Node(treeData[i]));
                nodes[nodes.Count - 2].left = nodes[nodes.Count - 1];
                currentDepth++;
            }
            else if (currentDepth == depth)
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
