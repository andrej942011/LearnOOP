using System;

namespace FormalNeuronDemo
{
    class Program
    {
        static int Main(string[] args)
        {
            //перевод четных и не четных двоичных чисел

            Neuron neuron = new Neuron(LearnDate.X, LearnDate.Y);
            Console.WriteLine($"[{string.Join(", ", neuron.W)}] {neuron.C}");
            foreach (int[] test in LearnDate.Test)
                Console.WriteLine($"[{string.Join(", ", test)} {test[3]} {neuron.calculate(test)}]");

            return 0;

            Console.ReadKey();
        }
    }
}
