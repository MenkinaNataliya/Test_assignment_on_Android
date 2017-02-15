using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    public class SetsSystemWithDictionary
    {
        private readonly Dictionary<int,List<int>> legion;

        public SetsSystemWithDictionary(params int[] values)
        {
            legion =new Dictionary<int, List<int>>();
            foreach (var item in values)
                Add(item);
        }

        private bool ContainsItem(int value)
        {
            return legion.ContainsKey(value );
        }

        public void Add(int value)
        {
            if (!ContainsItem(value))
                legion[value] = new List<int>();
        }

        public bool Union(int p, int q)
        {
            if (p == q) return false;
            if (!ContainsItem(p) || !ContainsItem(q)) return false;
            legion[p].Add(q);
            legion[q].Add(p);
            return true;
        }

        public bool Find(int p, int q)
        {
            if (p == q) return true;
            if (!ContainsItem(p) || !ContainsItem(q)) return false;
            return legion[p].Contains(q);
        }
    }
}
