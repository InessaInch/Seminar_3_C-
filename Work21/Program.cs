/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int getNumberFromUser(string message)
            {
                int result = 0;
                Console.WriteLine(message);
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }

            double GetDistance (double xa, double ya, double ca, double xb, double yb, double cb)
            {
               double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((cb-ca), 2) );
               return distance;
            }
            int xa = getNumberFromUser("Введите координату X первой точки:");
            int ya = getNumberFromUser("Введите координату Y первой точки:");
            int ca = getNumberFromUser("Введите координату Z первой точки:");
            int xb = getNumberFromUser("Введите координату X второй точки:");
            int yb = getNumberFromUser("Введите координату Y второй точки:");
            int cb = getNumberFromUser("Введите координату Z второй точки:");

            double distance = GetDistance(xa, ya, ca, xb, yb, cb);
            Console.WriteLine($"Расстояние между точками равно {distance} ");