namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            char restart;
            do
            {
                try
                {

                    Console.WriteLine("Введите номер задания");
                    string TaskNumber = Console.ReadLine();
                    switch (TaskNumber)
                    {
                        case "1":
                            Console.WriteLine("Выбран вариант: Треугольник \nВведите значение треугольника ");
                            Triangle triangle = new Triangle();
                            triangle.SiteA = Convert.ToInt32(Console.ReadLine());
                            triangle.SiteB = Convert.ToInt32(Console.ReadLine());
                            triangle.SiteC = Convert.ToInt32(Console.ReadLine());
                            bool result = triangle.Check();
                            if (result)
                            {
                                Console.WriteLine("Треугольник существует");
                                Console.WriteLine("Периметр треугольника = " + triangle.PerimeterCalculation());
                                Console.WriteLine(triangle.AreaTriangle());
                            }
                            else
                            {
                                Console.WriteLine("Треугольника не существует!");
                                break;
                            }
                            break;

                        case "2":
                            Console.WriteLine("Выбран вариант: Пирамида \nВведите длину основания (треугольника)");
                            Pyramid pyramid = new Pyramid();
                            pyramid.SiteA = Convert.ToInt32(Console.ReadLine());
                            pyramid.SiteB = Convert.ToInt32(Console.ReadLine());
                            pyramid.SiteC = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите высоту");
                            pyramid.Height = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Площадь пирамды = " + pyramid.AreaTriangle());
                            break;

                        case "3":
                            Console.WriteLine("Выбран вариант: Треугольная призма \nВведите длину основания (треугольника)");
                            Triangularprism triangularprism = new Triangularprism();
                            triangularprism.SiteA = Convert.ToInt32(Console.ReadLine());
                            triangularprism.SiteB = Convert.ToInt32(Console.ReadLine());
                            triangularprism.SiteC = Convert.ToInt32(Console.ReadLine());
                            triangularprism.Height = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Площадь пирамды = " + triangularprism.AreaTrianglePrism());
                            break;

                        default:
                            Console.WriteLine("Введите число от 1 до 3");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите число");
                }
                    Thread.Sleep(1000);
                    Console.WriteLine("\n" + "Повторить? y/n");
                    restart = Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                }
            while (restart == 'y') ;

            }
    }
    }
