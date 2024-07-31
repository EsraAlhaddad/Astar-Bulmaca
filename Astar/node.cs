internal class Node
{
    public int[,] State { get; }
    public int G { get; }
    public int H { get; }
    public int F => G + H;
    public Node Parent { get; }

    public Node(int[,] state, int g, int h, Node parent)
    {
        State = state;
        G = g;
        H = h;
        Parent = parent;
    }
}