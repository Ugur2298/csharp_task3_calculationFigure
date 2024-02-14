using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Text;

namespace csharp_third_task_Geometrical_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            int requirementOfMenu = 0;
            GetMenuInfo(ref requirementOfMenu);

        }

        public static void GetMenuInfo(ref int requirementOfMenu)
        {
            bool isFlag = true;

            do
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1.Calculation Perimeter Of Figure");
                Console.WriteLine("2.Calculation Area of Figure");
                Console.WriteLine("3. Exit");
                requirementOfMenu = int.Parse(Console.ReadLine());
              
               
                    if (requirementOfMenu == 1) { 
                       bool isContinue = true;
                    do
                        {

                        SubMenuRequirement();
                        Console.WriteLine("Please choose an option (Figure):");
                        int chooseFigure = int.Parse(Console.ReadLine());
                        if (chooseFigure == 1)
                        {
                            ChooseFigure(1);
                            Console.WriteLine("Please choose parameters of square:  1-Perimeter");
                            int chooseAnOption = int.Parse(Console.ReadLine());
                            if (chooseAnOption == 1)
                            {
                                Console.Write("Please enter square side: ");
                                int sideLength = int.Parse(Console.ReadLine());
                                CalculatePerimeterOfSquare(ref sideLength);
                            }

                        }

                        else if (chooseFigure == 2)
                        {
                            ChooseFigure(2);
                            Console.WriteLine("Please choose parameters of circle:  1-Perimeter ");
                            int chooseAnOption = int.Parse(Console.ReadLine());
                            if (chooseAnOption == 1)
                            {
                                Console.Write("Please enter circle side: ");
                                double radius = double.Parse(Console.ReadLine());
                                CalculatePerimeterOfCircle(ref radius);
                            }

                        }
                        else if (chooseFigure == 3)
                        {
                            ChooseFigure(3);
                            Console.WriteLine("Please choose parameters of rectangle:  1-Perimeter ");
                            int chooseAnOption = int.Parse(Console.ReadLine());
                            if (chooseAnOption == 1)
                            {
                                Console.WriteLine("Please enter rectangle side: ");
                                Console.Write("Enter width of rectangle: ");
                                int widthLength = int.Parse(Console.ReadLine());
                                Console.Write("Enter height of rectangle: ");
                                int heightLength = int.Parse(Console.ReadLine());
                                CalculatePerimeterOfRectangle(ref widthLength, ref heightLength);
                            }

                        }
                        else if (chooseFigure == 4)
                        {
                            ChooseFigure(4);
                            Console.WriteLine("Please choose parameters of triangle:  1-Perimeter ");
                            int chooseAnOption = int.Parse(Console.ReadLine());
                            if (chooseAnOption == 1)
                            {
                                Console.WriteLine("Please enter triangle side: ");
                                Console.Write("Enter first side of triangle: ");
                                int firstSide = int.Parse(Console.ReadLine());
                                Console.Write("Enter second side of triangle: ");
                                int secondSide = int.Parse(Console.ReadLine());
                                Console.Write("Enter third side of triangle: ");
                                int thirdSide = int.Parse(Console.ReadLine());

                                CalculatePerimeterOfTriangle(ref firstSide, ref secondSide, ref thirdSide);
                            }

                        }
                        else if (chooseFigure == 5)
                        {
                            isContinue = false;
                        }

                    }

                    while (isContinue) ;
                }
                else if (requirementOfMenu == 2)
                {
                    bool isContinue = true;
                    do
                    {

                   
                    SubMenuRequirement();
                    Console.WriteLine("Please choose an option (Figure):");
                    int chooseFigure = int.Parse(Console.ReadLine());
                    if (chooseFigure == 1)
                    {
                        ChooseFigure(1);
                        Console.WriteLine("Please choose area of square:  2-Area:");
                        int chooseAnOption = int.Parse(Console.ReadLine());
                        if (chooseAnOption == 2)
                        {
                            Console.Write("Please enter square side: ");
                            int sideLength = int.Parse(Console.ReadLine());
                            CalculateAreaOfSquare(ref sideLength);
                        }

                    }

                    else if (chooseFigure == 2)
                    {
                        ChooseFigure(2);
                        Console.WriteLine("Please choose parameters of circle: 2-Area:");
                        int chooseAnOption = int.Parse(Console.ReadLine());
                        if (chooseAnOption == 2)
                        {
                            Console.Write("Please enter circle side: ");
                            double radius = double.Parse(Console.ReadLine());
                            CalculateAreaOfCircle(ref radius);
                        }

                    }
                    else if (chooseFigure == 3)
                    {
                        ChooseFigure(3);
                        Console.WriteLine("Please choose parameters of rectangle: 2-Area:");
                        int chooseAnOption = int.Parse(Console.ReadLine());
                        if (chooseAnOption == 2)
                        {
                            Console.WriteLine("Please enter rectangle side: ");
                            Console.Write("Enter width of rectangle: ");
                            int widthLength = int.Parse(Console.ReadLine());
                            Console.Write("Enter height of rectangle: ");
                            int heightLength = int.Parse(Console.ReadLine());
                            CalculateAreaOfRectangle(ref widthLength, ref heightLength);
                        }

                    }
                    else if (chooseFigure == 4)
                    {
                        ChooseFigure(4);
                        Console.WriteLine("Please choose parameters of triangle: 2-Area:");
                        int chooseAnOption = int.Parse(Console.ReadLine());
                        if (chooseAnOption == 2)
                        {
                            Console.WriteLine("Please enter triangle side: ");
                            Console.Write("Enter first side of triangle: ");
                            int firstSide = int.Parse(Console.ReadLine());
                            Console.Write("Enter second side of triangle: ");
                            int secondSide = int.Parse(Console.ReadLine());
                            Console.Write("Enter third side of triangle: ");
                            int thirdSide = int.Parse(Console.ReadLine());

                            CalculateAreaOfTriangle(ref firstSide, ref secondSide, ref thirdSide);
                        }

                    }
                    else if (chooseFigure == 5)
                    {
                            isContinue = false;
                    }
                    } while (isContinue);

                }
                else if (requirementOfMenu == 3)
                {
                    Console.Write("Do you want to exit program: (Y-yes/N-no) ");
                    char c = char.Parse(Console.ReadLine());
                    if (char.ToLower(c) == 'y')
                    {
                        isFlag = false;
                    }
                  
                }
           } while (isFlag);

        }


        public static int CalculatePerimeterOfSquare(ref int sideLength)
        {
            int result = 4 * sideLength;
            Console.Write("Perimeters of Square: " + result);
            return result;
        }

        public static int CalculateAreaOfSquare(ref int sideLength)
        {
            int result = sideLength * sideLength;
            Console.Write("Area of Square: " + result);
            return result;
        }

        public static double CalculatePerimeterOfCircle(ref double radius)
        {
            double result = 2*Math.PI * radius;
            Console.Write("Perimeter of Circle: " + result);
            return result;
        }

        public static double CalculateAreaOfCircle(ref double radius)
        {
            double result = Math.PI * radius*radius;
            Console.Write("Area of Circle: " + result);
            return result;
        }

        public static int CalculatePerimeterOfRectangle(ref int witdhlength,ref int heightLength)
        {
            int result = 2*(witdhlength+heightLength);
            Console.Write("Perimeters of Rectangle: " + result);
            return result;
        }

        public static int CalculateAreaOfRectangle(ref int witdhlength,  ref int heightLength)
        {
            int result = witdhlength * heightLength;
            Console.Write("Area of Rectangle: " + result);
            return result;
        }

        public static int CalculatePerimeterOfTriangle(ref int firstSide, ref int secondSide, ref int thirdSide)
        {
            int result = firstSide+secondSide+thirdSide;
            Console.Write("Perimeters of Triangle: " + result);
            return result;
        }

        public static int CalculateAreaOfTriangle(ref int firstSide, ref int secondSide, ref int thirdSide)
        {
            int result = firstSide * secondSide * thirdSide;
            Console.Write("Area of Triangle: " + result);
            return result;
        }

        public static void SubMenuRequirement()
        {
            StringBuilder menuPageRequirement = new StringBuilder();
            menuPageRequirement.AppendLine("\n1.Square");
            menuPageRequirement.AppendLine("2.Circle");
            menuPageRequirement.AppendLine("3.Rectangle");
            menuPageRequirement.AppendLine("4.Triangle");
            menuPageRequirement.AppendLine("5.Main Menu");
            Console.WriteLine(menuPageRequirement);
        }

        public static void ChooseFigure( int figure) 
        {
            if (figure==1)
            {
                Console.WriteLine("Square");
            }
            else if (figure==2) 
            {
                Console.WriteLine("Circle");
            }
            else if(figure==3) 
            {
                Console.WriteLine("Rectangle");
            }
            else if (figure==4)
            {
                Console.WriteLine("Triangle");
            }
           
        }
    }
    }


