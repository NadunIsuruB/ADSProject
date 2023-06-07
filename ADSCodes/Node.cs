namespace ADSCodes;

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

