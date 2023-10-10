using Helpers;
namespace _10_error_handling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Error handling");
        try
        {
             ProcessUserInput();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Pls contact our service center, you have a virus in your computer");
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Thank you and goodbye");
        }

        //macOs only
        Console.ReadKey();
    }
    private static void ProcessUserInput()
    {
        bool _continue = true;
        do
        {
            Console.WriteLine("\n\nDon't Press Button 5 or 7!");
            int buttonToPress;
            if (!csConsoleInput.TryReadInt32("Which button do you want to press?", 1, 10, out buttonToPress))
            {
                _continue = false;
                break;
            }

            try
            {
                PressTheButton(buttonToPress);
                Console.WriteLine($"Button {buttonToPress} was pressed successfully");
            }
            catch (InsufficientMemoryException ex)
            {
                Console.WriteLine($"{ex.Message} - Why cant you listen!!");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} - But it is alright my friend!");
            }
            finally
            {
                Console.WriteLine("Code here will always be executed!");
            }
        } while (_continue);
    }

    static void PressTheButton(int buttonNr)
    {
        if (buttonNr == 5)
            throw new Exception("KaBoom!!");

        if (buttonNr == 7)
            throw new InsufficientMemoryException("You hopless guy!");

        Console.WriteLine($"You pressed button {buttonNr}");
    }
}

