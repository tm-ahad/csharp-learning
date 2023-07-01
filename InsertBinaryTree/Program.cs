using System.Security.Cryptography.X509Certificates;

public class BinaryTree
{
    public int? value;
    public BinaryTree? left = null;
    public BinaryTree? right = null;


    public BinaryTree(int? value, BinaryTree? left, BinaryTree? right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
}

public class InverseBinaryTree
{

    static void Print(BinaryTree? tree)
    {
        tree = tree == null ? new BinaryTree(null, null, null) : tree;

        string enc(BinaryTree? tree)
        {
            if (tree == null) return string.Empty;
            else
            {
                return $"" +
                $"{tree.value}" +
                $" -----> {enc(tree.left)}\n|\n|\n|" +
                $"{enc(tree.right)}\n\n";
            }
        }

        Console.WriteLine(enc(tree));
    }

    static BinaryTree? InverseTree(BinaryTree? tree)
    {
        if (tree == null) { return null; }
        else
        {
            BinaryTree? tmp = tree.right;

            tree.right = tree.left;
            tree.left = tmp;

            InverseTree(tree.left);
            InverseTree(tree.right);

            return tree;
        }

    }

    static void Main()
    {
        BinaryTree? tree = new BinaryTree(
            1, new BinaryTree(2,
                new BinaryTree(3, null, null),
                new BinaryTree(4, null, null)
            ),
            new BinaryTree(5,
                new BinaryTree(6, null, null),
                new BinaryTree(7, null, null)
            )
        );

        BinaryTree? inversed_tree = InverseTree(tree);

        Print(inversed_tree);
    }
}
