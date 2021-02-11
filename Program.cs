using System;

namespace ConsoleApp15
{
    class ArrayHelper<T>
    {

        public static T Pop(ref T[] LastArr)
        {
            T lastarr = LastArr[LastArr.Length - 1];
            Array.Resize(ref LastArr, LastArr.Length - 1);
            return lastarr;
        }

        public static int Push(ref T[] pusharr, T PushArr)
        {
            Array.Resize(ref pusharr, pusharr.Length + 1);
            pusharr[pusharr.Length - 1] = PushArr;
            return pusharr.Length;
        }

        public static T Shift(ref T[] Shiftarr)
        {
            T array = Shiftarr[0];
            for (int i = 0; i < Shiftarr.Length - 1; i++)
            {
                Shiftarr[i] = Shiftarr[i + 1];
            }
            Array.Resize(ref Shiftarr, Shiftarr.Length - 1);
            return array;
        }

        public static int UnShift(ref T[] UNshiftArr, T UnSharr)
        {
            Array.Resize(ref UNshiftArr, UNshiftArr.Length + 1);
            for (int i = UNshiftArr.Length - 1; i >= 1; i--)
            {
                UNshiftArr[i] = UNshiftArr[i - 1];
            }
            UNshiftArr[0] = UnSharr;
            return UNshiftArr.Length - 1;
        }

        public static T[] Slice(ref T[] arr, int? beginInd = null, int? endInd = null)
        {
            int ArrayLength = arr.Length;
            beginInd = beginInd ?? 0;
            endInd = endInd ?? ArrayLength;
            if (endInd < 0) endInd = ArrayLength + endInd;
            if (beginInd < 0) beginInd = endInd + beginInd;
            int arrnew = (endInd - beginInd > 0) ? (int)(endInd - beginInd) : 0;
            Console.WriteLine($"Дарозии нави Массив: {arrnew}");
            T[] ArrNew = new T[arrnew];
            for (int i = 0; i < arrnew; i++)
                ArrNew[i] = arr[i + (int)beginInd];
            return ArrNew;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            string[] Arrlaststr = new string[] { "Нозанин", "Нилуфар", "Фарзона", "Шукрона", "Мафтуна" };
            string ArrLastStr = ArrayHelper<string>.Pop(ref Arrlaststr);
            Console.WriteLine($"Охирон аломати Массив string: {ArrLastStr}");

            int[] Arrlastint = new int[] { 5, 555, 5555, 55555, 555555 };
            int ArrLastInt = ArrayHelper<int>.Pop(ref Arrlastint);
            Console.WriteLine($"Охирон аломати Массив int: {ArrLastInt}");

            double[] ArrLastdouble = new double[] {1.0, 5.55555, 7.2, 12.20007, 124.23};
            double ArrLastDouble = ArrayHelper<double>.Pop(ref ArrLastdouble);
            Console.WriteLine($"Охирон аломати Массив double: {ArrLastDouble}");

            decimal[] ArrLastdec = new decimal[] {14m, 21.5m, 45.64m, 72.5m, 85.52m};
            decimal ArrLastDec = ArrayHelper<decimal>.Pop(ref ArrLastdec);
            Console.WriteLine($"Охирон аломати Массив decimal: {ArrLastDec}");

            float[] ArrLastFloat = new float[] {15.32f, 588.25f, 518.21f, 1.5f, 51.025f};
            float ArrLastfloat = ArrayHelper<float>.Pop(ref ArrLastFloat);
            Console.WriteLine($"Охирон аломати Массив float: {ArrLastfloat}");


            Console.WriteLine();
            string[] Stringarr = new string[] {"Нозанин", "Нилуфар", "Фарзона", "Шукрона", "Мафтуна"};
            int StringArr = ArrayHelper<string>.Push(ref Stringarr, "Сонноз");
            Console.WriteLine($"МИКДОРИ АЛОМАТ ДАР МАССИВ String: {StringArr}");

            int[] Intarr = new int[] {6, 66, 666, 666666, 6666};
            int IntArr = ArrayHelper<int>.Push(ref Intarr, 1452);
            Console.WriteLine($"МИКДОРИ АЛОМАТ ДАР МАССИВ Int: {IntArr}");

            double[] Doublearr = new double[] {552.2, 48.2, 7.2, 1.2, 8455.2};
            double DoubleArr = ArrayHelper<double>.Push(ref Doublearr, 21.5);
            Console.WriteLine($"МИКДОРИ АЛОМАТ ДАР МАССИВ Double: {DoubleArr}");

            decimal[] Decimalarr = new decimal[] {7m, 551.23m, 5555.566m, 20.21m, 145587.224521552m};
            decimal DecimalArr = ArrayHelper<decimal>.Push(ref Decimalarr, 52.1331m);
            Console.WriteLine($"МИКДОРИ АЛОМАТ ДАР МАССИВ Decimal: {Decimalarr}");

            float[] Floatarr = new float[] {15.4f, 1.2f, 25.321f, 0.22525f, 7.4521f};
            float FloatArr = ArrayHelper<float>.Push(ref Floatarr, 8.552f);
            Console.WriteLine($"МИКДОРИ АЛОМАТ ДАР МАССИВ Float: {FloatArr}");


            Console.WriteLine();
            string[] StrArr = new string[] {"Нозанин", "Нилуфар", "Фарзона", "Шукрона", "Мафтуна"};
            Console.WriteLine($"Аломати аввалаи массив String: {ArrayHelper<string>.Shift(ref StrArr)}");

            int[] ArrInteger = new int[] {6, 66, 666, 666666, 6666};
            Console.WriteLine($"Аломати аввалаи массив Int: { ArrayHelper<int>.Shift(ref ArrInteger)}");
            
            double[] ArrDouble = new double[] {552.2, 48.2, 7.2, 1.2, 8455.2};
            Console.WriteLine($"Аломати аввалаи массив Double: {ArrayHelper<double>.Shift(ref ArrDouble)}");
            
            decimal[] ArrDecimal = new decimal[] {7m, 551.23m, 5555.566m, 20.21m, 145587.224521552m};
            Console.WriteLine($"Аломати аввалаи массив Decimal: {ArrayHelper<decimal>.Shift(ref ArrDecimal)}");
            
            float[] ArrFloat = new float[] {15.4f, 1.2f, 25.321f, 0.22525f, 7.4521f};
            Console.WriteLine($"Аломати аввалаи массив Float: {ArrayHelper<float>.Shift(ref ArrFloat)}");


            Console.WriteLine();
            string[] newstr = new string[] {"Нозанин", "Нилуфар", "Фарзона", "Шукрона", "Мафтуна"};
            int newstrArr = ArrayHelper<string>.UnShift(ref newstr, "Ноз");
            Console.WriteLine($"Аломати Нави Массив String: {newstrArr}");
            
            int[] newint = new int[] {6, 66, 666, 666666, 6666};
            int newintArr = ArrayHelper<int>.UnShift(ref newint, 1455);
            Console.WriteLine($"Аломати Нави Массив Int: {newintArr}");
            
            double[] newdbl = new double[] {552.2, 48.2, 7.2, 1.2, 8455.2};
            double newdblArr = ArrayHelper<double>.UnShift(ref newdbl, 0.554);
            Console.WriteLine($"Аломати Нави Массив Double {newdblArr}");
            
            decimal[] newdec = new decimal[] {7m, 551.23m, 5555.566m, 20.21m, 145587.224521552m};
            decimal newdecArr = ArrayHelper<decimal>.UnShift(ref newdec, 0.101m);
            Console.WriteLine($"Аломати Нави Массив Decimal: {newdecArr}");
            
            float[] newflt = new float[] {15.4f, 1.2f, 25.321f, 0.22525f, 7.4521f};
            float newfltArr = ArrayHelper<float>.UnShift(ref newflt, 245.4f);
            Console.WriteLine($"Аломати Нави Массив Float: {newfltArr}");


            Console.WriteLine();
            string[] Array = new string[] {"Нозанин", "Нилуфар", "Фарзона", "Шукрона", "Мафтуна"};
            int? begin_Index = null, end_index = null;
            Console.WriteLine("Агар хохед, ки Begin Index -ро ишора кунед 1 -ро дохил кунед!");
            Console.WriteLine("Агар нахохед, ки Begin Index -ро ишора кунед 2 -ро дохил кунед!");
            Console.Write("Ракамро дохил кунед: ");
            int inputnumber = int.Parse(Console.ReadLine());
            if (inputnumber == 1)
            {
                Console.Write("Begin Index = ");
                begin_Index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Агар хохед, ки End Index -ро ишора кунед 1 -ро дохил кунед!");
            Console.WriteLine("Агар хохед, ки End Index -ро ишора кунед 1 -ро дохил кунед!");
            Console.Write("Ракамро дохил кунед: ");
            inputnumber = int.Parse(Console.ReadLine());
            if (inputnumber == 1)
            {
                Console.Write("End Index = ");
                end_index = int.Parse(Console.ReadLine());
            }
            string[] NewArray = ArrayHelper<string>.Slice(ref Array, begin_Index, end_index);
            Console.Write("Mассив: ");
            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.Write($"{NewArray[i]} ");
            }
        }
    }
}