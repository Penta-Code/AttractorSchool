using System.Text.Json;

namespace Exam3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectedOption = 0;
            int id = 0;

            ProductsInit prod = new();
            Menu menu = new();
            Options options = new();

            try
            {
                while (true)
                {
                    var prods = prod.GetProducts();
                    menu.ShowProducts(prods);
                    selectedOption = menu.ShowOptions(prods, out id);

                    OptionProcessing processing = new(prods, options, selectedOption, id);

                    processing.Options();
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Не предвиденная ошибка!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}