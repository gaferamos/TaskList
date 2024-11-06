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
           
                

                switch (valor)
                {
                    case 0: System.Environment.Exit(0); break;

                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("ADICIONAR TAREFAS");
                            Thread.Sleep(1000);
                            
                            TaskManager.Addtask();
                           

                        }; 
                    break;

                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("MOSTRAR TAREFAS");
                        Thread.Sleep(1000);

                        TaskManager.Sowtasks();

                        

                    }
                    break;

                    case 3: 
                        {
                            Console.Clear();
                            Console.WriteLine("EDITAR TAREFAS");
                            Thread.Sleep(1000);
                            TaskManager.EditTask();
                        }
                    break;

                    case 4: 
                        {
                            Console.Clear();
                            Console.WriteLine("CONCLUIR TAREFAS");
                            Thread.Sleep(1000);

                            TaskManager.Taskstatus();
                        }
                    break;

                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("EXCLUIR TAREFAS");
                            Thread.Sleep(1000);
                            TaskManager.DeleteTask();
                           
                        }
                    break;
                }
            
        }
    }

}
