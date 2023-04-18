using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaphangaPartOneApp
{
    internal class Program
    {
        static ArrayList lstIngredients = new ArrayList();
        static Ingredient objIngredient = new Ingredient();
        static Step[] arrStep;
        static Ingredient[] ArrIngredient;
        static Step objStep, objStep1, objStep3 = new Step();
        static ArrayList lstStep = new ArrayList();

        static string name;
        static int qty;
        static string unitOfMeasure;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("***====\n=====MPEBE RECIPE APP INGREDIENT CAPTURE FORM====\n***", Console.ForegroundColor);

            Console.ForegroundColor = ConsoleColor.White;
            //1a - NUMBER OF INGREDIENTS
            Console.Write("Enter Number of Ingredients : ");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());
            ArrIngredient = new Ingredient[numOfIngredients];

            //1b INGREDIENTS
            for (int i = 0; i < ArrIngredient.Length; i++)
            {
                Console.Write("\nEnter the name for ingredient " + (i + 1) + " : ");
               name = Console.ReadLine();

                Console.Write("Enter the quantity : ");
                qty = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the unit of measure : ");
                unitOfMeasure = Console.ReadLine();

                objIngredient= new Ingredient(name, qty,unitOfMeasure);
                //lstIngredients.Add(objIngredient);
                ArrIngredient[i] = objIngredient;
                Console.WriteLine(ArrIngredient[i].Name + " Successfully Saved: ");
            }

            //1c - NUMBER OF STEPS
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n=====CAPTURE STEPS=====");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter Number of Steps : ");
            int numOfSteps = Convert.ToInt32(Console.ReadLine());
            arrStep = new Step[numOfSteps];

            string desc;
            for (int i = 0; i < numOfSteps; i++)
            {
                Console.WriteLine("Enter Step " + (i + 1) + " Description : ");
                desc = Console.ReadLine();

                objStep = new Step(desc);
                arrStep[i] = objStep;

                //lstStep.Add(objStep);
                Console.WriteLine(arrStep[i].Description + " Successfully Saved: ");

            }

            //2 - DISPLAY FULL RECIPE
            int cntIng = 1;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("***\n=====MPEBE RECIPE APP REPORT====\n***", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;
           
                  
                //objIngredient = ArrIngredient[i];
                Console.WriteLine(1
                    + " -   " + ArrIngredient[0].Qty
                    + " " + ArrIngredient[0].UnitOfMeasure
                    + " of " + ArrIngredient[0].Name
                    );

            Console.WriteLine(2
                + " -   " + ArrIngredient[1].Qty
                + " " + ArrIngredient[1].UnitOfMeasure
                + " of " + ArrIngredient[1].Name
                );


            Console.WriteLine("===STEPS===");
          

            objStep = arrStep[0];
            Console.WriteLine("step " + (1));
            //objStep = arrStep[i];
            Console.WriteLine(arrStep[0].Description);
        

        objStep = arrStep[1];
                Console.WriteLine("step " + (2));
                //objStep = arrStep[i];
                Console.WriteLine(arrStep[1].Description);
            

    Console.ReadLine();
        }
    }
}
