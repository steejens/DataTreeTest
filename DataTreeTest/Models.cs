using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTreeTest
{
    public class CategoryEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public int Left { get; set; }
        public int Right { get; set; }

    }
    public class CategoryTree
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;

        public ICollection<CategoryTree> Children { get; set; } = new List<CategoryTree>();

    }
}
