using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class Airplane : TransBase
    {
        public override int Speed => 2000;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var trans = new TransportationService();
            trans.CalculateTimeSpent(new Train(), 60);
            trans.CalculateTimeSpent(new Airplane(), 2000);
        }
    }

    internal class Train : TransBase
    {
        public override int Speed => 60;
    }

    internal abstract class TransBase
    {
        public abstract int Speed { get; }
    }

    internal class TransportationService
    {
        public decimal CalculateTimeSpent<T>(T t1, int distance) where T : TransBase
        {
            return distance / t1.Speed;
        }
    }
}