using System;

namespace Logic_Math
{
    public class LogicMath
    {

        public char connective;
        public char[] p;
        public char[] q;
        public char[] n;


        public void AND()
        {
            p = new char[] { 'T', 'T', 'F', 'F' };
            q = new char[] { 'T', 'F', 'T', 'F' };

            Console.WriteLine($"P  Q  P {connective} Q");
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"{p[i]}  {q[i]} {CheckAND(p[i],q[i])}");
            }
            
        }
        public void OR()
        {
            p = new char[] { 'T', 'T', 'F', 'F' };
            q = new char[] { 'T', 'F', 'T', 'F' };

            Console.WriteLine($"P  Q  P {connective} Q");
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"{p[i]}  {q[i]} {CheckOR(p[i],q[i])}");
            }

        }
        private bool CheckAND(char p, char q)
        {
            if(p == 'T' && q == 'T')
                return true;
            else
                return false;

        }
        private bool CheckOR(char p, char q)
        {
            if (p == 'T' || q == 'T')
                return true;
            else
                return false;
        }
        public void Negation()
        {
            n = new char[] { 'T', 'F' };

            Console.WriteLine($"N  {connective}N");

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"{p[i]}  {DoNegation(n[i])}");
            }
        }
        private char DoNegation(char n)
        {
            if (n == 'T')
                return 'F';
            else
                return 'T';
        }
    }
}
