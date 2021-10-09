using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalNeuronDemo
{
    class Neuron
    {
        private double a = 0.02;
        private double b = -0.4;
        private double[] w = { 0, 0, 0, 0 };
        private int c = 0;

        public double[] W
        {
            get => w;
        }

        public int C
        {
            get => c;
        }

        public Neuron(int[][] X, int[] Y) 
        {
            while (learn(X, Y))
                if (c++ > 10000) break;
        }

        bool learn(int[][] X, int[] Y)
        {
            double[] w_ = new double[w.Length];
            Array.Copy(w, w_, w.Length);
            int i = 0;
            foreach(int[] x in X)
            {
                int y = Y[i++];
                for (int j = 0; j < x.Length; j++)
                    w[j] += a * (y - calculate(x)) * x[j];
            }

            return !Enumerable.SequenceEqual(w_, w);
        }

        public int calculate(int[] x)
        {
            double s = b;
            for (int i = 0; i < w.Length; i++)
                s += w[i] * x[i];

            return (s > 0) ? 1 : 0;
        }
    }
}
