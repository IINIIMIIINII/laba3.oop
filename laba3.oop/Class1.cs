using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.oop
{
    public interface IParent {
        string Info();
        double Metod1();
        double Metod2();
    }

    // Арифметична прогресія
    public class Child1 : IParent, IComparable<Child1> {
        public double a;
        public double d;
        public int n;
        public Child1(double a, double d, int n) {
            this.a = a;
            this.d = d;
            this.n = n;
        }
        public string Info() { return $"Арифметична: перший член={a} різниця={d} n={n}"; }

        // n-й член
        public double Metod1() { return a + (n - 1) * d; }
        // сума перших n членів
        public double Metod2() { return n * (2 * a + (n - 1) * d) / 2; }
        // Сортування за різницею
        public int CompareTo(Child1 other) { return d.CompareTo(other.d); }
    }



    // Геометрична прогресія
    public class Child2 : IParent, IComparable<Child2>
    {
        public double a;
        public double d;
        public int n;
        public Child2(double a, double d, int n) {
            this.a = a;
            this.d = d;
            this.n = n;
        }
        public string Info() { return $"Геометрична: перший член={a} знаменник={d} n={n}"; }

        // n-й член
        public double Metod1() { return a * Math.Pow(d, n - 1); }
        // сума перших n членів
        public double Metod2() {
            if (d == 1) { return a * n; }
            return a * (Math.Pow(d, n) - 1) / (d - 1);
        }
        // Сортування за сумою n членів
        public int CompareTo(Child2 other) { return Metod2().CompareTo(other.Metod2()); }
    }
}
