using System;
using System.Diagnostics;

namespace TaskList
{
    public class Menu
    {
        public static void Menuoption()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE TAREFAS");
            Console.WriteLine("===================");
            Console.WriteLine();
            Console.WriteLine("1 - ADICIONAR TAREFAS");
            Console.WriteLine("2 - VER TAREFAS");
            Console.WriteLine("3 - EDITAR TAREFAS");
            Console.WriteLine("4 - MARCAR COMO CONCLUIDO");
            Console.WriteLine("5 - EXCLUIR TAREFA");
            Console.WriteLine("0 - SAIR");
          

            if (short.TryParse(Console.ReadLine(), out short value))
            {
                Optinhendler(value);
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente.");
                Console.ReadKey();
                Menuoption(); 
            }


        }


        public static void Optinhendler( short valor ) 
        { 
           
                TaskManager tskm = new TaskManager();

                switch (valor)
                {
                    case 0: System.Environment.Exit(0); break;

                    case 1:
                        {
                            Console.WriteLine("ADICIONAR TAREFAS");
                            Thread.Sleep(1000);
                            
                            tskm.Addtask();
                            Menuoption();

                        }; 
                    break;

                    case 2:
                    {

                      tskm.Sowtasks();
                        

                    }
                    break;

                    case 3: 
                        {
                            Console.WriteLine("1 - ADICIONAR TAREFAS");
                        }
                    break;

                    case 4: 
                        {
                            Console.WriteLine("1 - ADICIONAR TAREFAS");
                        }
                    break;

                    case 5:
                        {
                            Console.WriteLine("1 - ADICIONAR TAREFAS");
                        }
                    break;
                }
            
        }
    }

}
