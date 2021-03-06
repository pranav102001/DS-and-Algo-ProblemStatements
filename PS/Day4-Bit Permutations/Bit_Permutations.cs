using System;
class S {
    static void f(char[] p, int d, int n, ref int s) {
        if (d >= n) {
            string r = new string(p);
            s += Convert.ToInt32(r, 2);
            return;
        }
        for (int i = d; i < n; i++) {
            bool c = true;
            for (int j = d; j < i; j++)
                if (p[j] == p[i]) c = false;
            if (c) {
                char t = p[d];
                p[d] = p[i];
                p[i] = t;
                f(p, d + 1, n, ref s);
                t = p[d];
                p[d] = p[i];
                p[i] = t;
            }
        }
    }
    static void Main() {
        int s, n, t = int.Parse(Console.ReadLine());
        while (t > 0) {
            n = int.Parse(Console.ReadLine());
            char[] c = Convert.ToString(n, 2).ToCharArray();
            s = 0;
            f(c, 0, c.Length, ref s);
            Console.WriteLine(s);
            t--;
        }
    }
}