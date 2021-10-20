using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15HomeWork15Version6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arith 
            Console.Write("Установите первое число арифмитической прогрессии = ");
            int ap1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Установите шаг арифмитической прогрессии = ");
            int stepAP1 = Convert.ToInt32(Console.ReadLine());

            ArithProgession arith = new ArithProgession();
            arith.setStart(ap1);
            arith.setStep(stepAP1);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Следующее значение = " + arith.getNext());
            }
            Console.WriteLine("\nВыполняем сбросс к начальному значению.");
            arith.reset();

            Console.Write("\nЗаново установите первое число арифмитической прогрессии =");
            int ap2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Установите шаг арифмитической прогрессии = ");
            int stepAP2 = Convert.ToInt32(Console.ReadLine());
            arith.setStart(ap2);
            arith.setStep(stepAP2);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Следующее значение = " + arith.getNext());
            }
            #endregion
            #region Geom
            Console.Write("\nУстановите первое число геометрической прогрессии = ");
            int gp1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Установите шаг геометрической прогрессии = ");
            int stepGP1 = Convert.ToInt32(Console.ReadLine());
            GeomProgression geom = new GeomProgression();
            geom.setStart(gp1);
            geom.setStep(stepGP1);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее значение = " + geom.getNext());
            }
            Console.WriteLine("\nВыполняем сбросс к начальному значению.");
            geom.reset();
            Console.Write("\nЗаново установите первое число геометрической прогрессии = ");
            int gp2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Установите шаг геометрической прогрессии = ");
            int stepGP2 = Convert.ToInt32(Console.ReadLine());
            geom.setStep(stepGP2);
            geom.setStart(gp2);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее значение = " + geom.getNext());
            }
            #endregion
            Console.ReadLine();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgession : ISeries
    {
        int first;
        int second;
        public int Step { get; set; }

        public ArithProgession()
        {
            first = 0;
            second = 0;

        }
        public int getNext()
        {
            second += Step;
            return second;
        }
        public void reset()
        {
            second = first;
        }
        public void setStart(int x)
        {
            first = x;
            second = first;
        }
        public void setStep(int stepProgression)
        {
            Step = stepProgression;
        }

    }
    class GeomProgression : ISeries
    {
        private int first;
        private int second;
        public int Step { get; set; } // Не исключаю 0 и 1, так как это статические геометрические прогрессии
        public int First
        {
            set
            {
                if (value != 0)
                {
                    first = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Первый член геометрической последовательности не может быть равен 0 !");
                    Console.WriteLine("Принимаем по умолчанию первый член геометрической последовательности = 1");
                    first = 1;
                }
            }
            get
            {
                return first;
            }
        }
        public int Second
        {
            set
            {
                if (value != 0)
                {
                    second = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Первый член геометрической последовательности не может быть равен 0 !");
                    Console.WriteLine("Принимаем по умолчанию первый член геометрической последовательности = 1");
                    second = 1;
                }
            }
            get
            {
                return second;
            }
        }
        public GeomProgression()
        {
            first = 1;
            second = 1;
        }
        public int getNext()
        {
            second *= Step;
            return second;
        }
        public void reset()
        {
            second = first;
        }
        public void setStart(int x)
        {
            First = x;
            Second = First;
        }
        public void setStep(int stepProgression)
        {
            Step = stepProgression;
        }

    }

}
