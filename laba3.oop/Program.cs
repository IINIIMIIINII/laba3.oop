using laba3.oop;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Random rand = new Random();

while (true) {
    Console.WriteLine("\n==============================");
    Console.WriteLine("1 - Створити одну прогресію");
    Console.WriteLine("2 - Створити 5 випадкових прогресій");
    Console.WriteLine("3 - Масив арифметичних прогресій");
    Console.WriteLine("4 - Масив геометричних прогресій");
    Console.WriteLine("0 - Вихід");
    Console.WriteLine("-----------------------------");
    Console.Write("Оберіть пункт: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    
    if (choice == 0) { break; }
    if (choice == 1) { 
        Console.Write("Введіть 0 - арифметична, 1 - геометрична: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть перший член a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть різницю/знаменник d: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть кількість членів n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        IParent obj;
        if (x == 0) { obj = new Child1(a, d, n); }
        else { obj = new Child2(a, d, n); }
        Console.WriteLine("\n" + obj.Info());
        Console.WriteLine($"n-й член = {obj.Metod1():F2}");
        Console.WriteLine($"Сума перших n членів = {obj.Metod2():F2}");
    }

    else if (choice == 2) {
        Console.WriteLine("\n---Випадкові прогресії---");
        for (int i = 0; i < 5; i++) {
            int x = rand.Next(0, 2);
            double a = rand.Next(1, 6);
            double d = rand.Next(2, 6);
            int n = rand.Next(2, 6);
            IParent obj;
            if (x == 0) { obj = new Child1(a, d, n); }
            else { obj = new Child2(a, d, n); }
            Console.WriteLine(obj.Info());
            Console.WriteLine($"n-й член = {obj.Metod1():F2}");
            Console.WriteLine($"Сума перших n членів = {obj.Metod2():F2}");
            Console.WriteLine();
        }
    }

    else if (choice == 3) {
        Console.Write("Введіть кількість арифметичних прогресій: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Child1[] arr = new Child1[size];
        for (int i = 0; i < size; i++) {
            Console.WriteLine($"\nПрогресія {i + 1}");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("d = ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            arr[i] = new Child1(a, d, n);
        }

        Console.WriteLine("\n----- До сортування -----");
        for (int i = 0; i < arr.Length; i++) {
            Console.WriteLine(
                arr[i].Info() +
                $" | n-й член = {arr[i].Metod1():F2}" +
                $" | сума = {arr[i].Metod2():F2}" );
        }
        Array.Sort(arr);
        Console.WriteLine("\n----- Після сортування за різницею -----");
        for (int i = 0; i < arr.Length; i++) {
            Console.WriteLine(
                arr[i].Info() +
                $" | n-й член = {arr[i].Metod1():F2}" +
                $" | сума = {arr[i].Metod2():F2}" );
        }
    }


    else if (choice == 4) {
        Console.Write("Введіть кількість геометричних прогресій: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Child2[] arr = new Child2[size];
        for (int i = 0; i < size; i++) {
            Console.WriteLine($"\nПрогресія {i + 1}");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("d = ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            arr[i] = new Child2(a, d, n);
        }
        Console.WriteLine("\n----- До сортування -----");
        for (int i = 0; i < arr.Length; i++) {
            Console.WriteLine(
                arr[i].Info() +
                $" | n-й член = {arr[i].Metod1():F2}" +
                $" | сума = {arr[i].Metod2():F2}" );
        }
        Array.Sort(arr);
        Console.WriteLine("\n----- Після сортування за сумою n членів -----");
        for (int i = 0; i < arr.Length; i++) {
            Console.WriteLine(
                arr[i].Info() +
                $" | n-й член = {arr[i].Metod1():F2}" +
                $" | сума = {arr[i].Metod2():F2}" );
        }
    }

    else { Console.WriteLine("Невірний пункт меню!"); }
}