using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalNeuronDemo
{
    struct LearnDate
    {
        static int[][] x = //обучаемый вектор
        {
            new int[] {0,0,0,0},
            new int[] {0,0,0,1},
            new int[] {1,1,1,1},//была ошибка
            new int[] {1,1,1,0},
            new int[] {1,1,1,1},
        };

        static int[] y = { 0, 1, 1, 0, 1 }; //желаемое значение

        static int[][] test =
        {
            new int[] {0,0,0,0},
            new int[] {0,0,0,1},
            new int[] {0,1,0,1},
            new int[] {0,1,1,0},
            new int[] {1,1,1,0},
            new int[] {1,1,1,1}
        };

        public static int[][] X
        {
            get => x;
        }

        public static int[] Y
        {
            get => y;
        }

        public static int[][] Test
        {
            get => test;
        }
    }
}
