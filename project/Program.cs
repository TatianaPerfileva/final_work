internal partial class Program
{
    private static void Main(string[] args)
    {
        void Zadacha()
        {
            // Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
            string[] a = {"year", "-56", "row", "dog", "9376", "friend", "you"};
            string[] b = new string[a.Length];
            Console.WriteLine("Исходный массив строк: ");
            PrintStringArray(a);
            Console.WriteLine();
            FindArrayOfUpToThreeCharacters(a, b);
            Console.WriteLine("Вывод нового массива строк до 3 символов: ");
            PrintStringArray(b);
        }
        Zadacha();

        void PrintStringArray(string[] numb)
        {
            for (int i = 0; i < numb.Length; i++) Console.Write($" {numb[i]} ");
        }

        void FindArrayOfUpToThreeCharacters(string[] numb, string[] numb2)
        {
           int count = 0;
           for (int i = 0; i < numb.Length; i++)
            {
                if (numb[i].Length <= 3)
                {
                    numb2[count] = numb[i];
                    count++;
                }    
            }
        }
    }
}

