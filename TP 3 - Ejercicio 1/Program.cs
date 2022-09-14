using System;

namespace TP3_Ejercicio_1
{
    class Program
    {
        static void Main()

        {

            int op, mayor = 0, menor = 999, diamen = 0, diamay = 0;

            Console.WriteLine("\t Seleccione el mes del año 2022 para ver las temperaturas.");
            Console.WriteLine("1 - Enero");
            Console.WriteLine("2 - Febrero");
            Console.WriteLine("3 - Marzo");
            Console.WriteLine("4 - Abril");
            Console.WriteLine("5 - Mayo");
            Console.WriteLine("6 - Junio");
            Console.WriteLine("7 - Julio");
            Console.WriteLine("8 - Agosto");
            Console.WriteLine("9 - Septiembre");
            Console.WriteLine("10 - Octubre");
            Console.WriteLine("11 - Noviembre");
            Console.WriteLine("12 - Diciembre \n");

            op = Convert.ToInt32(Console.ReadLine());

            var seed = Environment.TickCount;
            var rand = new Random(seed);

            switch (op)
            {
                case 1:
                    int[] enero = new int[32];
                    int i;
                    for (i = 1; i < enero.Length; i++)
                    {
                        enero[i] = rand.Next(22, 34);
                        Console.WriteLine($"Dia {i} - Temp = {enero[i]}");

                        if (enero[i] > mayor)
                            {
                                mayor = enero[i];
                                diamay = i;
                            }
                        else
                            {
                                if (enero[i] < menor)
                                {
                                    menor = enero[i];
                                    diamen = i;
                                }
                            }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 2:
                    int[] febrero = new int[30];
                    for (i = 1; i < febrero.Length; i++)
                    {
                        febrero[i] = rand.Next(20, 33);
                        Console.WriteLine($"Dia {i} - Temp = {febrero[i]}");

                        if (febrero[i] > mayor)
                        {
                            mayor = febrero[i];
                            diamay = i;
                        }
                        else
                        {
                            if (febrero[i] < menor)
                            {
                                menor = febrero[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 3:
                    int[] marzo = new int[32];
                    for (i = 1; i < marzo.Length; i++)
                    {
                        marzo[i] = rand.Next(20, 31);
                        Console.WriteLine($"Dia {i} - Temp = {marzo[i]}");

                        if (marzo[i] > mayor)
                        {
                            mayor = marzo[i];
                            diamay = i;
                        }
                        else
                        {
                            if (marzo[i] < menor)
                            {
                                menor = marzo[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 4:
                    int[] abril = new int[31];
                    for (i = 1; i < abril.Length; i++)
                    {
                        abril[i] = rand.Next(17, 27);
                        Console.WriteLine($"Dia {i} - Temp = {abril[i]}");

                        if (abril[i] > mayor)
                        {
                            mayor = abril[i];
                            diamay = i;
                        }
                        else
                        {
                            if (abril[i] < menor)
                            {
                                menor = abril[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 5:
                    int[] mayo = new int[32];
                    for (i = 1; i < mayo.Length; i++)
                    {
                        mayo[i] = rand.Next(14, 24);
                        Console.WriteLine($"Dia {i} - Temp = {mayo[i]}");

                        if (mayo[i] > mayor)
                        {
                            mayor = mayo[i];
                            diamay = i;
                        }
                        else
                        {
                            if (mayo[i] < menor)
                            {
                                menor = mayo[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 6:
                    int[] junio = new int[31];
                    for (i = 1; i < junio.Length; i++)
                    {
                        junio[i] = rand.Next(12, 22);
                        Console.WriteLine($"Dia {i} - Temp = {junio[i]}");

                        if (junio[i] > mayor)
                        {
                            mayor = junio[i];
                            diamay = i;
                        }
                        else
                        {
                            if (junio[i] < menor)
                            {
                                menor = junio[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 7:
                    int[] julio = new int[32];
                    for (i = 1; i < julio.Length; i++)
                    {
                        julio[i] = rand.Next(11, 22);
                        Console.WriteLine($"Dia {i} - Temp = {julio[i]}");

                        if (julio[i] > mayor)
                        {
                            mayor = julio[i];
                            diamay = i;
                        }
                        else
                        {
                            if (julio[i] < menor)
                            {
                                menor = julio[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 8:
                    int[] agosto = new int[32];
                    for (i = 1; i < agosto.Length; i++)
                    {
                        agosto[i] = rand.Next(12, 24);
                        Console.WriteLine($"Dia {i} - Temp = {agosto[i]}");

                        if (agosto[i] > mayor)
                        {
                            mayor = agosto[i];
                            diamay = i;
                        }
                        else
                        {
                            if (agosto[i] < menor)
                            {
                                menor = agosto[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 9:
                    int[] septiembre = new int[31];
                    for (i = 1; i < septiembre.Length; i++)
                    {
                        septiembre[i] = rand.Next(14, 26);
                        Console.WriteLine($"Dia {i} - Temp = {septiembre[i]}");

                        if (septiembre[i] > mayor)
                        {
                            mayor = septiembre[i];
                            diamay = i;
                        }
                        else
                        {
                            if (septiembre[i] < menor)
                            {
                                menor = septiembre[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 10:
                    int[] octubre = new int[32];
                    for (i = 1; i < octubre.Length; i++)
                    {
                        octubre[i] = rand.Next(17, 28);
                        Console.WriteLine($"Dia {i} - Temp = {octubre[i]}");

                        if (octubre[i] > mayor)
                        {
                            mayor = octubre[i];
                            diamay = i;
                        }
                        else
                        {
                            if (octubre[i] < menor)
                            {
                                menor = octubre[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 11:
                    int[] noviembre = new int[31];
                    for (i = 1; i < noviembre.Length; i++)
                    {
                        noviembre[i] = rand.Next(19, 30);
                        Console.WriteLine($"Dia {i} - Temp = {noviembre[i]}");

                        if (noviembre[i] > mayor)
                        {
                            mayor = noviembre[i];
                            diamay = i;
                        }
                        else
                        {
                            if (noviembre[i] < menor)
                            {
                                menor = noviembre[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

                case 12:
                    int[] diciembre = new int[32];
                    for (i = 1; i < diciembre.Length; i++)
                    {
                        diciembre[i] = rand.Next(21, 32);
                        Console.WriteLine($"Dia {i} - Temp = {diciembre[i]}");

                        if (diciembre[i] > mayor)
                        {
                            mayor = diciembre[i];
                            diamay = i;
                        }
                        else
                        {
                            if (diciembre[i] < menor)
                            {
                                menor = diciembre[i];
                                diamen = i;
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"La mayor temperatura del mes es la del dia {diamay} - Temp: {mayor}");
                    Console.WriteLine($"La menor temperatura del mes es la del dia {diamen} - Temp: {menor}");

                    break;

            }

            //static extern int TempMayor(int[] array);
            //{
            //    int i, mayor = 0;
            //    int[] Array = new int[32];


            //    for (i = 0; i < Array.Length; i++)
            //        if (Array[i] > mayor)
            //        {
            //            mayor = Array[i];

            //        }
            //    Console.WriteLine($"La temperatura mayor es de:{mayor}");
            //}

        }
    }
}