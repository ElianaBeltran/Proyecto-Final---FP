using System;

namespace Proyecto
{/// <summary>
/// Esta es la clase Principal del programa
/// </summary>
    class Program
    {
        /// <summary>
        /// Estas son Variables globales que usamos en todo el codigo
        /// </summary>
        static int i = 0, z = 0, m = 0, a = 0, b = 0, d = 0, f = 0, c = 0;
        static int[,] matrizA = new int[5, 5];
        static int[,] matrizB = new int[5, 5];
        static int[,] operacionResult = new int[5, 5];
        static Random aleatorio = new Random();
        static int[] Arreglo = new int[9];
        
        /// <summary>
        /// Este es el main, aqui se invocan los todos los metodos del programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declaración e inicialización de la variable utilizada para ingresar el número de opción del menú
            int OpcionMenu = 0;
            Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Magenta;
            // Se le pedirá al usuario que ingrese su nombre
            Console.WriteLine("Ingrese su nombre");
            string NombreUsuario = " ";
            Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
            NombreUsuario = Console.ReadLine();
            Console.WriteLine();

            //Menú principal: se ejecutará siempre y cuando el usuario no ingrese el numero 5
            while (OpcionMenu != 5)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
                Console.WriteLine("Bienvenid@ " + NombreUsuario);
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------------------------------ Menú Principal ------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------- Seleccione una de las siguientes opciones ----------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------- Opción 1: Secuencia de Números Fibonacci -----------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------- Opción 2: Palíndromas ------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------- Opción 3: Operaciones matemáticas de matrices: Suma y Resta ----------------------------------------------------------");
                Console.WriteLine("----------------------------------- Opción 4: Vector de 9 elementos --------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------- Opción 5: Salir del Programa -----------------------------------------------------------------------------------------");
                Console.WriteLine();

                Console.WriteLine("Opción: ");
                OpcionMenu = Int32.Parse(Console.ReadLine());
                switch (OpcionMenu)
                {   // Invocará el procediemiento de la secuencia Fibonacci
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Secuencia de Números Fibonacci");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Fibonacci();
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    // Ejecutará el procedimiento palíndroma: imprimirá un mensaje diciendo si una palabra es palíndroma o no
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Palíndromas");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Palindromo();
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    // Este procedimiento invoca varios procedimientos para llevar a cabo la suma y resta de matrices
                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Operaciones matemáticas de matrices: Suma y Resta");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        ImpresionMatrices();
                        SumaDeMatrices();
                        Console.WriteLine();
                        RestaDeMatrices();
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    // Presenta un vector de 9 elementos, al azar, donde el usuario ingresará un número y dirá si 
                    // se encuentra o no en el arreglo, y si esta, señalará su posición
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vector de 9 elementos");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Vector();
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    // Esto indica fin del programa
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Fin del Programa");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    // En caso de que el usuario ingrese una opción no válida, desplegará un mensaje
                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Opción no encontrada, debe elegir una de las opciones presentadas en el menú principal.");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        break;


                } 
            }
        }

                /// <summary>
                /// Este  se van imprimir las matrices 5x5
                /// </summary>

                public static void ImpresionMatrices()
        {

            Console.WriteLine("Matriz A");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            // Generación de matriz A
            for (f = 0; f < 5; f++)
            {
                for (c = 0; c < 5; c++)
                {
                    matrizA[f, c] = aleatorio.Next(1, 100);
                }
            }
            // Impresión de matriz A
            for (f = 0; f < 5; f++)
            {
                for (c = 0; c < 5; c++)
                {
                    if (matrizA[f, c] > m)
                    {   m = matrizA[f, c];
                        i = f;
                        z = c;
                    }
                    Console.Write(matrizA[f, c].ToString() + " ");
                }
                Console.WriteLine();
            }
            // Generación de matriz B
            Console.WriteLine("Matriz B");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            for (f = 0; f < 5; f++)
                for (c = 0; c < 5; c++)
                {
                    matrizB[f, c] = aleatorio.Next(1, 100);
                }
            // Impresión de matriz B
            for (f = 0; f < 5; f++)
            {
                for (c = 0; c < 5; c++)
                {
                    if (matrizB[f, c] > a)
                    {
                        a = matrizB[f, c];
                        b = f;
                        d = c;
                    }

                    Console.Write(matrizB[f, c].ToString() + " ");
                }

                Console.WriteLine();

            }

            Console.ReadKey();

        }

        /// <summary>
        /// En este se realizar la suma de matrices 5x5
        /// </summary>
        public static void SumaDeMatrices()
        {   
            // Procedimiento de suma de matrices A y B
            for (c = 0; c < 5; c++)
            {
                for (f = 0; f < 5; f++)
                {
                    operacionResult[f, c] = matrizA[f, c] + matrizB[f, c];

                }
            }
            // Impresión del resultado de la suma de matrices
            Console.WriteLine("La suma de la MatrizA y MatrizB es :");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
   
            for (f = 0; f < 4; f++)
            {
                Console.Write("\n");
                for (c = 0; c < 4; c++)
                {
                    Console.Write(operacionResult[f, c] + "  ");
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// En este se realizará la resta de matrices
        /// </summary>
        public static void RestaDeMatrices()
        {   // Procedimiento de resta de matrices A y B
            for (c = 0; c < 5; c++)
            {
                for (f = 0; f < 5; f++)
                {
                    operacionResult[f, c] = matrizA[f, c] - matrizB[f, c];
                }
            }

            // Impresión del resultado de la resta de matrices
            Console.WriteLine("La resta de la MatrizA y MatrizB es :");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");

            for (f = 0; f < 4; f++)
            {
                Console.Write("\n");
                for (c = 0; c < 4; c++)
                {
                    Console.Write(operacionResult[f, c] + "  ");
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Este es el metodo que realiza la operacion de las palabras palindromo
        /// </summary>
        public static void Palindromo()
        {   // El usuario ingresará una palabra cualquiera en minúsculas; y se verificará si es palíndroma o no
            string str = string.Empty;
            Console.WriteLine("Introduzca una palabra en minúsculas");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            string s = Console.ReadLine();
            int i = s.Length;
            for (int j = i - 1; j >= 0; j--)
            {
                str = str + s[j];
            }
            if (str == s)
            {
                Console.WriteLine(s + " Es palindroma");
            }
            else
            {
                Console.WriteLine(s + " No es palindroma");
            }
            // Se imprimirá la palabra al revés
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("La palabra en el orden contrario es: ");
            Console.WriteLine(str);

        }
        /// <summary>
        /// En este se realizará la secuencia de números fibonacci
        /// </summary>
        public static void Fibonacci()
        {   
            // Declaración de variables a utilizar
            int limite, a, b, h, auxiliar;
            Console.WriteLine("Introduzca la secuencia de números de Fibonacci que desea mostrar");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");

            // El usuario ingresará el número de secuencia que desea mostrar y luego se ejecutará este procedimiento
            limite = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (h = 0; h < limite; h++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.Write(a + " ");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// En este se presentará un arreglo de 9 elementos, el usuario digitará un número que desee buscar en el arreglo 
        /// </summary>
        public static void Vector()
        {   
            // Declaración de variables
            int t, c;

            // Generación del vector
            for (int o = 0; o <= 8; o++)
            {
                Arreglo[o] = aleatorio.Next(1, 100);
            }

            for (int k = 0; k < 8; k++)
            {
                for (int f = 0; f < 8 - k; f++)
                {
                    if (Arreglo[f] > Arreglo[f + 1])
                    {
                        int aux;
                        aux = Arreglo[f];
                        Arreglo[f] = Arreglo[f + 1];
                        Arreglo[f + 1] = aux;

                    }
                }
            }
            // Impresión del vector ordenadamente
            Console.WriteLine("Ordenados ascendentemente");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (t = 0; t <= 8; t++)
            {

                c = t;
                Console.Write(Arreglo[c]+ " ");

            }
            Console.WriteLine();

            // Señalará la posición del número dentro del vector
            Console.WriteLine("Digite el número que desea buscar");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            int l = Convert.ToInt32(Console.ReadLine());

            for (int numero = 0; numero <= 8; numero++)
            {
                if (Arreglo[numero] == l)

                {
                    Console.WriteLine("Se encontró el número " + l+  " en la posición "+"{" + numero+"}");
                }


            }

        }

    }
}
