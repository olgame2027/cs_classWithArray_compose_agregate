using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace cs_classWithArray_compose_agregate
{
    internal class Vector
    {
        public string Title { get; set; }
        public int[] Array { get; set; }

        public Vector() { }

        public Vector(string title, int[] array) {
            Title = title;
            Array = array;
        }

        public int SumPositive() {
            int sum = 0;
            foreach (int a in Array) { if (a > 0) sum += a; }
            
            return sum;
        }

        public int[] GetPosiveElements() {
            int n = 0;
            foreach (int a in Array) { if (a > 0) n++; }
            int[] result = new int[n];
            int i = 0;
            foreach (int a in Array) {
                if (a > 0) { result[i] = a; n++; }

            }
            return result;
        }

        public override bool Equals(object? obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string? ToString() {
            return base.ToString();
        }
 
        
    }
}
