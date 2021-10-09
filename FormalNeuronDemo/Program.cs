using System;

namespace FormalNeuronDemo
{
    class Program
    {
        static int Main(string[] args)
        {
            Neuron neuron = new Neuron(LearnDate.X, LearnDate.Y);
            Console.WriteLine($"[{string.Join(",", neuron.W, 2)}] {neuron.C}");
            foreach (int[] test in LearnDate.Test)
                Console.WriteLine($"[{string.Join(",", test)} {test[3]} {neuron.calculate(test)}]");

            return 0;

            Console.ReadKey();
        }
    }
}
