using System;

class CoffeeMachine
{
    static void Main()
    {
        Console.WriteLine("กาแฟเครื่อง");
        Console.WriteLine("--------------");
        Console.WriteLine("1. กาแฟดำ");
        Console.WriteLine("2. มอคค่า");
        Console.WriteLine("3. ลาเต้");
        Console.WriteLine("4. ช็อกโกแลต");
        Console.WriteLine("--------------");

        Console.Write("กรุณาเลือกเมนู (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        ProcessMenuChoice(choice);
    }

    static void ProcessMenuChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                MakeCoffee("กาแฟดำ", 300, 20, 0, 0);
                break;
            case 2:
                MakeCoffee("มอคค่า", 300, 20, 10, 0);
                break;
            case 3:
                MakeCoffee("ลาเต้", 300, 20, 0, 10);
                break;
            case 4:
                MakeCoffee("ช็อกโกแลต", 300, 0, 20, 0);
                break;
            default:
                Console.WriteLine("รหัสไม่ถูกต้อง");
                break;
        }
    }

    static void MakeCoffee(string menu, int water, int coffee, int chocolate, int milk)
    {
        Console.WriteLine($"กำลังทำ {menu}");
        Console.WriteLine($"น้ำ: {water}g, กาแฟ: {coffee}g, ช็อกโกแลต: {chocolate}g, นม: {milk}g");
        Console.WriteLine($"{menu} เสร็จสิ้น!");
    }
}
