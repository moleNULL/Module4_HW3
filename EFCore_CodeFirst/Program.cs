/*
                                                      Задача

              Необхідно створити Базу Даних, використовуючи Code First підхід на основі фізичної моделі даних

Критерії:
    ● Конфігурація сутностей має бути в окремих файлах
    ● Рядок підключення має бути в json файлі config.
    ● Повинні бути явно прописані обмеження сутності. Встановлено коректно Primary Key та Foreign Key.

 */

namespace EFCore_CodeFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter.Run();

            Console.Write("\nPress any key to continue . . .");
            Console.ReadLine();
        }
    }
}