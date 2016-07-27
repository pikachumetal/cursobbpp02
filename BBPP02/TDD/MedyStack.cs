using System.Collections.Generic;
using System.Linq;

namespace TDD
{
    public class MedyStack
    {
        public MedyStack()
        {
            Items = new List<string>();
        }

        public bool IsEmpty => !Items.Any();
        public int Count => Items.Count();

        private IList<string> Items { get; }

        public void Add(string item)
        {
            Items.Add(item);
        }

        public void Remove()
        {
            if (Items.Any())
            {
                Items.RemoveAt(Count-1);
            }
        }

        public string Top()
        {
            return Items.Any() ? Items[Count - 1] : null;
        }
    }
}