using Helpers;
namespace _10a_menu;

class Program
{
    public enum enSeason { Winter, Spring, Summer, Fall }
    public class csAppData
    {
        public csNecklace Necklace { get; set; }
        public csPearl Pearl { get; set; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("10a_menu");

        var AppData = new csAppData
        {
            Necklace = new csNecklace("Martins necklace"),
            Pearl = new csPearl()
        };
            
        do
        {
            ShowMenu();

            int _menuSel;
            if (!GetMenuSelection(out _menuSel))
            {
                break;
            }

            //Only if menu item selected
            ProcessMenuSelection(_menuSel, AppData);

        } while (true);

        Console.WriteLine("Thank you!");
    }

    private static void ProcessMenuSelection(int _menuSel, csAppData _appData)
    {
        var rnd = new csSeedGenerator();

        switch (_menuSel)
        {
            case 1:
                int _intAnswer;
                if (csConsoleInput.TryReadInt32("Enter an integer", -1, 101, out _intAnswer))
                {
                    Console.WriteLine($"You entered {_intAnswer}");
                }
                break;

            case 2:
                string _strAnswer = null;
                if (csConsoleInput.TryReadString("Enter a string", out _strAnswer))
                {
                    Console.WriteLine($"You entered {_strAnswer}");
                }
                break;

            case 3:
                DateTime _dtAnswer = default;
                if (csConsoleInput.TryReadDateTime("Enter a date and time", out _dtAnswer))
                {
                    Console.WriteLine($"You entered {_dtAnswer}");
                }
                break;

            case 4:
                enSeason _enAnswer = default;
                if (csConsoleInput.TryReadEnum<enSeason>("Enter a Season", out _enAnswer))
                {
                    Console.WriteLine($"You entered {_enAnswer}");
                }
                break;

            case 5:
                enSeason _enAnswer1 = default;
                string _strAnswer1 = null;
                DateTime _dtAnswer1 = default;
                if (csConsoleInput.TryReadString("Enter first input (string)", out _strAnswer1) &&
                    csConsoleInput.TryReadEnum<enSeason>("Enter second input (Season)", out _enAnswer1) &&
                    csConsoleInput.TryReadDateTime("Enter a date and time", out _dtAnswer1))
                {
                    Console.WriteLine($"You entered {_enAnswer1}");
                    Console.WriteLine($"You entered {_strAnswer1}");
                    Console.WriteLine($"You entered {_dtAnswer1}");
                }
                break;

            case 6:

                //Create a random Pearl
                _appData.Pearl = new csPearl(rnd);
                Console.WriteLine(_appData.Pearl.ToString());

                break;

            case 7:

                //Add the random pearl to a Necklace
                _appData.Necklace.ListOfPearls.Add(_appData.Pearl);
                Console.WriteLine(_appData.Necklace.ToString());

                break;

        }
    }

    private static bool GetMenuSelection(out int menuSelection)
    {
        bool _continue;
        if (!csConsoleInput.TryReadInt32("Enter your selection", 1, 7, out menuSelection))
        {
            _continue = false;
        }
        else
        {
            _continue = true;
        }

        return _continue;
    }

    private static void ShowMenu()
    {
        Console.WriteLine("\n\nMenu:");
        Console.WriteLine("1 - Enter an integer");
        Console.WriteLine("2 - Enter a string");
        Console.WriteLine("3 - Enter a date and time");
        Console.WriteLine("4 - Enter an enum");
        Console.WriteLine("5 - Enter multiple input");
        Console.WriteLine("6 - Create a random Pearl");
        Console.WriteLine("7 - Add a random Pearl to a Necklace");
        Console.WriteLine("Q - Quit program");
    }
}

