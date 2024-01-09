namespace DataTreeTest
{
    public class Tree
    {
        public static CategoryTree Build(List<CategoryEntity> data)
        {
            var tree = new CategoryTree()
            {
                Title = "Root"
            };
            var nodeDictionary = data.ToDictionary(node => node.Id, node => new CategoryTree
            {
                Id = node.Id,
                Title = node.Title,
                Children = new List<CategoryTree>()
            });

            foreach (var node in data)
            {
                if (nodeDictionary.TryGetValue(node.Id, out var treeNode))
                {
                    var parentNode = data.FirstOrDefault(n => n.Left < node.Left && n.Right > node.Right);
                    if (parentNode != null && nodeDictionary.TryGetValue(parentNode.Id, out var parentTreeNode))
                    {
                        parentTreeNode.Children.Add(treeNode);
                    }
                    else
                    {
                        tree.Children.Add(treeNode);
                    }
                }
            }

            return tree;
        }
    }
}
