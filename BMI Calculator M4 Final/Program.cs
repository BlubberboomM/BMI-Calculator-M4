using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator_Final_M4
{
    class Program
    //********************************************************************************************************************************************************************
    //Title: BMI Calculator
    //Application Type: NET Framework Console
    //Description: Application designed to calculate users Body Mass Index score and interpret their health based on the results and provide info to better their health.
    //Author: Max Mackin
    //Date Created: 4/10/21
    //Last Modified: 4/18/21
    //********************************************************************************************************************************************************************
    {
        static void Main(string[] args)
        {

            SetTheme();
            DisplayOpeningScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DisplayOpeningScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\tBMI Calculator");
            Console.WriteLine();
            Console.WriteLine("\tWelcome to the BMI calculator! This is an application designed by Max Mackin to calculate your Body Mass Index.");
            Console.WriteLine("\tIt will interpret your score and provide information to better your health if you so choose.");

            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tThank you for using the BMI Calculator!");
            Console.WriteLine("\tI hope you enjoyed using this application!");

            DisplayContinuePrompt();
        }
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        static void DisplayMenuScreen()
        {
            Console.CursorVisible = false;

            bool QuitApplication = false;
            string MenuChoice;

            do
            {
                DisplayScreenHeader("\tMain Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) BMI Calculator");
                Console.WriteLine("\tb) Health Resources");
                Console.WriteLine("\tc) Instructions");
                Console.WriteLine("\td) Quit Application");
                Console.Write("\tPlease Enter menu Choice:");
                MenuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (MenuChoice)
                {
                    case "a":
                        DisplayBMICalculator();
                        break;

                    case "b":
                        DisplayHealthResources();
                        break;

                    case "c":
                        DisplayInstructions();
                        break;

                    case "d":
                        QuitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a corresponding letter to choose a menu");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!QuitApplication);
        }

        static void DisplayBMICalculator()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\tEnter weight (lbs) = ");
            double Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("\tEnter height (in) = ");
            double Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("\tEnter age (years) = ");
            double Age = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine($"\tWeight = {Weight} lbs");
            Console.WriteLine($"\tHeight = {Height} inches");
            Console.WriteLine($"\tAge = {Age} years");

            double BMI = ((Weight / Height) / Height) * 703;
            double BMR = 66 + (6.23 * Weight) + (12.7 * Height) - (6.8 * Age);


            if (BMI < 18.5)
            {
                Console.WriteLine();
                Console.WriteLine($"\tYour calculated BMI is {BMI.ToString("N3")}");
                Console.WriteLine($"\tYour calculated BMR is {BMR.ToString("N3")}");
                Console.WriteLine();
                Console.WriteLine($"\tA BMI of {BMI.ToString("N3")} means you are underweight for your measurments.");
                Console.WriteLine($"\tYour BMR ({BMR.ToString("N3")}) is how many calories you burn a day in resting.");
                Console.WriteLine($"\tIf you wish to maintain current weight you must eat {(BMR * 1.375).ToString("N3")} calories daily");
                Console.WriteLine($"\tConsuming 500 calories above or below {(BMR * 1.375).ToString("N3")} daily will increase or decrease weight by 1lb per week.");
            }
            if (BMI > 18.5 && BMI < 24.9)
            {
                Console.WriteLine();
                Console.WriteLine($"\tYour calculated BMI is {BMI.ToString("N3")}");
                Console.WriteLine($"\tYour calculated BMR is {BMR.ToString("N3")}");
                Console.WriteLine();
                Console.WriteLine($"\tA BMI of {BMI.ToString("N3")} means you are normal and healthy for your measurments.");
                Console.WriteLine($"\tYour BMR ({BMR.ToString("N3")}) is how many calories you burn a day in resting.");
                Console.WriteLine($"\tIf you wish to maintain current weight you must eat {(BMR * 1.375).ToString("N3")} calories daily");
                Console.WriteLine($"\tConsuming 500 calories above or below {(BMR * 1.375).ToString("N3")} daily will increase or decrease weight by 1lb per week.");
            }
            if (BMI > 24.9 && BMI < 29.9)
            {
                Console.WriteLine();
                Console.WriteLine($"\tYour calculated BMI is {BMI.ToString("N3")}");
                Console.WriteLine($"\tYour calculated BMR is {BMR.ToString("N3")}");
                Console.WriteLine();
                Console.WriteLine($"\tA BMI of {BMI.ToString("N3")} means you are overweight for your measurments.");
                Console.WriteLine($"\tYour BMR ({BMR.ToString("N3")}) is how many calories you burn a day in resting.");
                Console.WriteLine($"\tIf you wish to maintain current weight you must eat {(BMR * 1.375).ToString("N3")} calories daily");
                Console.WriteLine($"\tConsuming 500 calories above or below {(BMR * 1.375).ToString("N3")} daily will increase or decrease weight by 1lb per week.");
            }
            if (BMI > 29.9 && BMI < 39.9)
            {
                Console.WriteLine();
                Console.WriteLine($"\tYour calculated BMI is {BMI.ToString("N3")}");
                Console.WriteLine($"\tYour calculated BMR is {BMR.ToString("N3")}");
                Console.WriteLine();
                Console.WriteLine($"\tA BMI of {BMI.ToString("N3")} means you are obese for your measurments.");
                Console.WriteLine($"\tYour BMR ({BMR.ToString("N3")}) is how many calories you burn a day in resting.");
                Console.WriteLine($"\tIf you wish to maintain current weight you must eat {(BMR * 1.375).ToString("N3")} calories daily");
                Console.WriteLine($"\tConsuming 500 calories above or below {(BMR * 1.375).ToString("N3")} daily will increase or decrease weight by 1lb per week.");
            }
            if (BMI > 39.9)
            {
                Console.WriteLine();
                Console.WriteLine($"\tYour calculated BMI is {BMI.ToString("N3")}");
                Console.WriteLine($"\tYour calculated BMR is {BMR.ToString("N3")}");
                Console.WriteLine();
                Console.WriteLine($"\tA BMI of {BMI.ToString("N3")} means you are very obese for your measurments.");
                Console.WriteLine($"\tYour BMR ({BMR.ToString("N3")}) is how many calories you burn a day in resting.");
                Console.WriteLine($"\tIf you wish to maintain current weight you must eat {(BMR * 1.375).ToString("N3")} calories daily");
                Console.WriteLine($"\tConsuming 500 calories above or below {(BMR * 1.375).ToString("N3")} daily will increase or decrease weight by 1lb per week.");
            }

            DisplayContinuePrompt();

        }

        static void DisplayHealthResources()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tHere is a list of resources for the formulas used in calculation for this program.");
            Console.WriteLine();
            Console.WriteLine("\tBMI formula = https://www.cdc.gov/nccdphp/dnpao/growthcharts/training/bmiage/page5_2.html");
            Console.WriteLine("\tBMR formula = https://www.medicinenet.com/what_is_the_formula_to_calculate_bmr/article.htm");
            Console.WriteLine();
            Console.WriteLine("\t\tHere is a list of resources to help those looking to adjust their weight and be healthy.");
            Console.WriteLine();
            Console.WriteLine("\tCalories to gain weight = https://www.bmi-calculator.net/bmr-calculator/harris-benedict-equation/calorie-intake-to-gain-weight.php");
            Console.WriteLine("\tCalories to lose weight = https://www.bmi-calculator.net/bmr-calculator/harris-benedict-equation/calorie-intake-to-lose-weight.php");
            Console.WriteLine("\tTips to staying healthy = http://stopcancerfund.org/pz-diet-habits-behaviors/eating-habits-that-improve-health-and-lower-body-mass-index/");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        static void DisplayInstructions()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\tThe BMI calculator will prompt you for your weight (pounds) and height (inches).");
            Console.WriteLine("\tEnter both values as accruately as you can to calculate BMI score.");
            Console.WriteLine("\tProgram will interpret score and tell if you're healthy.");
            Console.WriteLine("\tIt will then inform you of your BMR and how many calories to consume to change or maintain weight.");
            Console.WriteLine("\tThe resources page will provide sites to help better health, and sources for calculation formulas.");
            Console.WriteLine();
            Console.WriteLine("\tBMI = Body Mass Index, score derived from weight and height to evaulate overall health.");
            Console.WriteLine("\tBMR = Base Metabolic Rate, rate at which you burn calories daily in resting.");
            DisplayContinuePrompt();
        }
    }
}
