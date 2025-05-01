namespace LabWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Play play = new();
                play.GuessLetter();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ошибка чтения файла! Файл не найден или содержимое отсутствует.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка ввода!\nБыло введено число, пробел, знаки пунктуации или прочие символы! Введите любые буквы английского алфавита: A - Z");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода!\nВведите любые буквы английского алфавита: A - Z");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка! Дополнительная информация ниже:\nError message:{ex.Message}\nError message:{ex.StackTrace}");
            }
        }
    }
}