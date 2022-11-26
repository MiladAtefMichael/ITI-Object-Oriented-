using System;
namespace Lab3
{
    class Program
    {
        #region Functions of Task 01
        public static int[] FillArray(int _length)
        {
            int[] result = new int[_length];
            for(int i = 0; i < _length; i++)
            {
                Console.Write($"enter value of Arr [{i}] = ");
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        public static void DisplayArray(int[] _arr)
        {
            
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine($" value of Arr [{i}] = {_arr[i]}");
            }
           
        }
        public static int SumArr(int[] _arr)
        {
            int sum =0;
            for (int i = 0; i < _arr.Length; i++)
            {
                sum+= _arr[i];
            }
            return sum;
        }
        public static void GetEven(int[] _arr)
        {
            int evenCounter = 0;
            for (int i=0;i< _arr.Length;i++)
            {
                
                if (_arr[i] % 2 == 0)
                {
                    evenCounter++;
                }

            }
            Console.Write("even numbers : ");
            int[] result = new int[evenCounter];
            for (int i = 0; i < _arr.Length; i++)
            {

                if (_arr[i] % 2 == 0)
                {
                    Console.Write($"{_arr[i]} ");
                }

            }
            Console.WriteLine();

        }
        public static void GetOdd(int[] _arr)
        {
            int oddCounter = 0;
            for (int i = 0; i < _arr.Length; i++)
            {

                if (_arr[i] % 2 != 0)
                {
                    oddCounter++;
                }

            }
            Console.Write("odd numbers : ");
            int[] result = new int[oddCounter];
            for (int i = 0; i < _arr.Length; i++)
            {

                if (_arr[i] % 2 != 0)
                {
                    Console.Write($"{_arr[i]} ");
                }

            }
            Console.WriteLine();
        }  
        public static int GetMax (int[] _arr)
        {
            int max = 0;
            for (int i=0;i< _arr.Length;i++) 
            { 
                for(int j = i+1; j < _arr.Length; j++)
                {
                    if (_arr[i] > _arr[j] && _arr[i]>max) 
                    { 
                        max = _arr[i];
                    }

                }
            }
            return max;
        }
        public static int GetMin(int[] _arr)
        {
            int min = _arr[0];
            for (int i = 0; i < _arr.Length; i++)
            {
                for (int j = i+1; j < _arr.Length; j++)
                {
                    if (_arr[i] < _arr[j] && _arr[i] < min)
                    {
                        min = _arr[i];
                    }

                }
            }
            return min;
        }
        public static int GetAvg(int[] _arr)
        {
             return SumArr(_arr) / _arr.Length;

        }
        #endregion
        #region Functions of Task 02
        public static int[,] FillTwoDimArray(int _rowNumber,int _columnNumber)
        {
           int[,] _arr = new int[_rowNumber,_columnNumber];
            for (int i = 0; i < _rowNumber; i++)
            {
                for(int j=0;i<_columnNumber; j++)
                {
                    Console.Write($"enter Arr [{i},{j}] = ");
                    _arr[i,j]=int.Parse(Console.ReadLine()); 
                }
            }
            return _arr;

        }
        public static void DisplayTwoDimArray(int[,] _arr)
        {
            
            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                for (int j = 0; i < _arr.GetLength(1); j++)
                {
                    Console.Write($"enter Arr [{i},{j}] = {_arr[i,j]} ");
                    _arr[i,j] =int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine();    
            }
           
        }
        public static void DisplayTwoDimRowSumation(int[,] _arr)
        {

            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                int RowSumation = 0;
                for (int j = 0; i < _arr.GetLength(1); j++)
                {
                    RowSumation += _arr[i,j];

                }
                Console.WriteLine($"Row Sumation of Row {i} : {RowSumation}");
            }

        }
        public static void DisplayTwoDimColAvg(int[,] _arr)
        {

            for (int i = 0; i < _arr.GetLength(1); i++)
            {
                int ColumnSumation = 0;
                for (int j = 0; i < _arr.GetLength(0); j++)
                {
                    ColumnSumation += _arr[j,i];

                }
                Console.WriteLine($"Column Avrage of Column  {i} : {ColumnSumation/_arr.GetLength(1)}");
            }

        }
        public static int[] ConcatArr (int[] _arr1, int[] _arr2)
        {
            int[] _arr=new int[_arr1.Length+_arr2.Length];   
            int j = 0;
            for (int i=0;i< _arr1.Length;i++)
            {
                _arr[i] = _arr1[i];  
            }
            for (int i = _arr1.Length; i < _arr2.Length; i++)
            {
                _arr[i] = _arr1[j];
                j++;
            }
            return _arr;

        }
        #endregion
        #region Task07
        public static bool CheckUnique(int[] _arr)
        {
            bool unique = true;
            for (int i=0;i<_arr.Length;i++)
            {
                for(int j=i;j<_arr.Length-1;j++)
                {
                    if (_arr[i] == _arr[j]) unique= false;
                }
            }
            return unique;
        }
        #endregion
        #region Task08
        public static int GetPower(int _base,int _power)
        {
            int power = 1;
            for (int i=0; i< _power ; i++)
            {
                power*= _base;
            }
            return power;
        }
        #endregion
        #region Task09
        public static bool checkPrime(int _number)
        {
            bool isPrime=true;
            if(_number==0||_number==1) { isPrime=false; }
            for(int i=1;i< _number;i++)
            { 
                if (_number%i==0) { isPrime = false; }
            }
            return isPrime;
        }
        #endregion
      
        #region Task11
        public static int GetFactorial(int _number)
        {
            int fac = 1;
            for(int i = _number; i > 1; i--)
            {
                fac*= _number;
            }
            return fac;
        }
        #endregion

        public static void Main()
        {
            #region Task 01
            Console.Write("Enter The size of Array :");
            int ArrayLength=int.Parse(Console.ReadLine());
            int[] arr=new int[ArrayLength];
            arr = FillArray(ArrayLength);
            DisplayArray(arr);
            Console.WriteLine($" Array Sum = {SumArr(arr)}");
            GetEven(arr);
            GetOdd(arr);
            Console.WriteLine($" Maxiumam Value of Array = {GetMax(arr)}");
            Console.WriteLine($" Minumam value of Array  = {GetMin(arr)}");
            Console.WriteLine($" Average  value of Array  = {GetAvg(arr)}");

            #endregion
            #region Task03
            int menuKey = 0;
            int ArrayRowNumber = 0;
            int ArrayColumnNumber = 0;
            do
            {
                Console.WriteLine("select your operation : ");
                Console.WriteLine("1 : Enter Dimension  ");
                Console.WriteLine("2 : fill array ");
                Console.WriteLine("3 : Display Array ");
                Console.WriteLine("4 : Diplay Row Sumation ");
                Console.WriteLine("5 : Diplay Columns Average ");
                Console.WriteLine("6 : Exit ");
            
                menuKey=int.Parse(Console.ReadLine());
                if (menuKey == 1)
                {
                    Console.WriteLine("enter the number of Rows : ");
                    ArrayRowNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the number of Columns : ");
                    ArrayColumnNumber = int.Parse(Console.ReadLine());
                }


                int[,] arr_2D = new int[ArrayRowNumber, ArrayColumnNumber];

                if (menuKey == 2)
                {

                   arr_2D = FillTwoDimArray(ArrayRowNumber, ArrayColumnNumber);

                }
                else if (menuKey == 3)
                {
                    DisplayTwoDimArray(arr_2D);
                }
                else if (menuKey == 4)
                {
                    DisplayTwoDimRowSumation(arr_2D);
                }
                else if (menuKey == 5)
                {
                    DisplayTwoDimColAvg(arr_2D);
                }



            } while(menuKey!=6);
            #endregion
            #region Task05
            int[] arr_1 = new int[] { 1,5,8};
            int[] arr_2 = new int[] { 9, 13, 10,20 };
            DisplayArray(ConcatArr(arr_1, arr_2));
            #endregion
            #region Task06
            int[] NewArr = new int[] { 2,5,2,7,7,5,2};
            for(int i=0;i<NewArr.Length-1;i++)
            {
                int swapIem = 0;
                for (int j=i;i<NewArr.Length-1;j++)
                {
                    if (NewArr[i] == NewArr[j] && i != j + 1)
                    {
                        swapIem = NewArr[i + 1];
                        NewArr[i + 1] = NewArr[j];
                        NewArr[j] = swapIem;
                    }
                }              
            }
            int counter = 0;

            for (int i = 0; i < NewArr.Length-1; i++)
            {
                if (NewArr[i] == NewArr[i+1]) 
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"number of item {NewArr[i]} : {counter}");
                    counter = 0;
                }
            }
            #endregion
            #region Task07
            int[] uniqueArr=new int[] {2,8,9,10};
            if (CheckUnique(uniqueArr) == true)
            {
                Console.WriteLine("this Arr have unique items ");
            }
            else 
            {
                Console.WriteLine("this Arr have not unique items ");
            }
            DisplayArray(uniqueArr);
            #endregion
            #region Task08
            Console.WriteLine(GetPower(2,3));
            #endregion
            #region Task09
            Console.WriteLine(checkPrime(200));
            #endregion
            #region Task10
            int number = 100;
            if (number > 1 && number < 100)
            {
                if (checkPrime(number) == true)
                {
                    Console.WriteLine("this number is prime");
                }
                else
                {
                    Console.WriteLine("this number is not prime");
                }
            }
            else
            { Console.WriteLine("this number is out of range"); }
            #endregion
            #region Task11
            Console.WriteLine(GetFactorial(20));
            #endregion




        }
    }
}
