using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTreeTest
{
    public class Populate
    {
        public static List<CategoryEntity> CategoryEntities()
        {
            return new List<CategoryEntity>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "A1",
                    Left = 1,
                    Right = 14,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "A11",
                    Left = 2,
                    Right = 7,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "A12",
                    Left = 3,
                    Right = 4,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "A13",
                    Left = 5,
                    Right = 6,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "B1",
                    Left = 8,
                    Right = 11,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "B11",
                    Left = 9,
                    Right = 10,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "C1",
                    Left = 12,
                    Right = 13,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "K1",
                    Left = 15,
                    Right = 18,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "K11",
                    Left = 16,
                    Right = 17,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Z",
                    Left = 19,
                    Right = 20,
                },
            };
        }
    }
}
