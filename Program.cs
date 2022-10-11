using System;

namespace menu_sumar_opciones_con_funcion
{
    class Program
    {
        static void Main(string[] args)    {

             //suma, resta, division, multiplicacion con menu.

            int num1, num2,  opcionSel;
            

            Console.WriteLine("- - - - - - - - - - - - - -");
            Console.WriteLine("||  BIENVENIDO AL SISTEMA  ||");
            Console.WriteLine("- - - - - - - - - - - - - -");
        

            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar. . .  ");
            Console.ReadKey();
            Console.Clear();

           
             
                opcionSel= menu_opciones();  // FUNCION Menu de opciones.

                if(opcionSel !=0){
            
                Console.Clear();

                Console.WriteLine("Ingrese NUMERO 1: ");
                num1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese NUMERO 2: ");
                num2=Convert.ToInt32(Console.ReadLine());

                // opcion de casos, segun la opcion elegida.
                switch(opcionSel){
                    case 1: 
                    Console.Clear();   

                    sumarNumeros(num1,num2); // FUNCION SUMAR            

                    break;

                    case 2: // resta
                    Console.Clear();

                    restarNumeros(num1,num2);  // FUNCION RESTAR

                    break;

                    case 3: // no si el numero es 0, y cambiar opcion.
                    Console.Clear();
                    dividirNumeros(num1,num2); // FUNCION DIVIDIR
                   
                break;

                case 4:
                Console.Clear();
                multiplicarNumeros(num1,num2); // FUNCION MULTIPLICAR

                break;
               
                default:
                Console.WriteLine("No selecciono opcion valida.");
                break;

            }

            }

            Console.WriteLine("Finalizo el programa...");
        }

        //funciones de la operaciones

        static int menu_opciones(){
            int opcion;
            
        
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicar");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("Ingrese opcion: ");   
                opcion=Convert.ToInt32(Console.ReadLine());

                if(opcion !=1 && opcion !=2 && opcion !=3 && opcion !=4 && opcion !=0 ){
                    Console.Clear();
                    Console.WriteLine("Debe ingresar un numero valido.");
                }

            

            return opcion;

        }


        static float multiplicarNumeros(int num1, int num2){
            float resultado;
                            Console.WriteLine("MULTIPLICACION DE: " + num1 + " y " + num2);
                resultado = num1 * num2;
                Console.WriteLine("El resultado es : " + resultado);
            return resultado;    

        }

        static int sumarNumeros(int num1, int num2){
            int resultado;

                    Console.WriteLine("SUMA DE: " + num1 + " y " + num2);
                    resultado=num1 + num2;
                    Console.WriteLine("El resultado es : " + resultado);
            return resultado;
        }
        static float dividirNumeros(float num1, float num2){
            float  resultado;
            int opcionSel;
             if(num2 == 0){
                        Console.Clear();
                        Console.WriteLine("El numero 2 ingresado es: 0; la division por cero es indeterminado.");
                        Console.WriteLine("Presione una tecla para continuar. . .  ");
                        Console.ReadKey();
                        Console.Clear();    
                        Console.WriteLine("INGRESE OPCION: ");
                        Console.WriteLine(" ");
                        Console.WriteLine("1 - Cambiar valor del Divisor");
                        Console.WriteLine("0 - Continuar igual...  ");
                        opcionSel=Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                    if(opcionSel == 1){
                        Console.WriteLine("Ingrese NUMERO 2: ");
                        num2=Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }


                }
                Console.WriteLine("DIVISION DE: " + num1 + " y " + num2);
                resultado=((float)num1 / (float)num2);
                Console.WriteLine("El resultado es : " + resultado);
            return resultado;    


        }



        static int restarNumeros(int num1, int num2){
            int resultado;
                    Console.WriteLine("RESTA DE: " + num1 + " y " + num2);
                    resultado=num1-num2;
                    Console.WriteLine("El resultado es : " + resultado);
            return resultado;
        }

    }
}
