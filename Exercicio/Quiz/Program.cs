using quiz;

BinaryTree<QuizItem> tree = GetTree();
BinaryTreeNode<QuizItem> node = tree.Root;
while (node != null)
{
    if (node.Left != null || node.Right != null)
    {
        Console.Write(node.Data.Text);
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y:
                WriteAnswer(" Yes");
                node = node.Left;
                break;
            case ConsoleKey.N:
                WriteAnswer(" No");
                node = node.Right;
                break;
        }
    }
    else
    {
        WriteAnswer(node.Data.Text);
        node = null;
    }
}

static BinaryTree<QuizItem> GetTree()
{
    BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
    tree.Root = new BinaryTreeNode<QuizItem>()
    {
        Data = new QuizItem("Do you prefer tropical destinations?"),
        Children = new List<TreeNode<QuizItem>>()
    {
        new BinaryTreeNode<QuizItem>()
        {
            Data = new QuizItem("Would you like to visit an island?"),
            Children = new List<TreeNode<QuizItem>>()
            {
                new BinaryTreeNode<QuizItem>()
                {
                    Data = new QuizItem("Visit Bali, Indonesia!")
                },
                new BinaryTreeNode<QuizItem>()
                {
                    Data = new QuizItem("Try the Maldives!")
                }
            }
            },
            new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Do you enjoy cultural and historical sites?"),
                Children = new List<TreeNode<QuizItem>>()
                {
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("Explore Rome, Italy!")
                    },
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("Discover Cairo, Egypt!")
                    }
                }
            }
        }
    };
    tree.Count = 9;
    return tree;
}

static void WriteAnswer(string text)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.Gray;
}
