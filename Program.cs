namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GIT FLOW");

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Lista sin ordenar:");
            PrintArray(arr);

            BubbleSort(arr);

            Console.WriteLine("Lista ordenada:");
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] arr, int a)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
