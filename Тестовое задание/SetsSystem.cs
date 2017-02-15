using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    public class SetsSystem
    {
        private readonly List<List<int>> legion;

        public SetsSystem(params int[] values)
        {
            legion = new List<List<int>>();
            foreach (var item in values)
                Add(item);
        }

        private bool ContainsItem(int value)
        {
            return legion.Any(item => item.Contains(value));
        }

        public void Add(int value)
        {
            if (!ContainsItem(value))
                legion.Add(new List<int> { value });
        }

        public bool Union(int p, int q)
        {
            if (p == q) return false;
            if (!ContainsItem(p) || !ContainsItem(q)) return false;
            foreach (var item in legion)
            {
                if (item[0] == p && !item.Contains(q))
                {
                    item.Add(q);
                    continue;
                }
                if (item[0] == q && !item.Contains(p))
                    item.Add(p);
            }

            return true;
        }

        public bool Find(int p, int q)
        {
            if (p == q) return true;
            if (!ContainsItem(p) || !ContainsItem(q)) return false;

            return legion.Any(item => item[0] == p && item.Contains(q));
        }
    }
}
