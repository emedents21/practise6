using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise6
{
    public class LinearCong
    {
        private long _seed;
        private const long a = 25214903917;
        private const long c = 11;
        private readonly long m = (long)Math.Pow(2, 48);

        public LinearCong(long seed)
        {
            _seed = seed;
        }

        public double NextDouble()
        {
            _seed = (a * _seed + c) % m;
            return (double)_seed / m;
        }
    }
}
