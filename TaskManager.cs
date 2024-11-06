namespace TaskList
{
    public class TaskManager
    {
       static List<Tasks> tasklist = new List<Tasks>();

        
        public static void Addtask()
        {
            Console.Clear();
            Console.WriteLine("De um numero a  sua tarefa");
            Console.Write("Numero: ");
            int numID = int.Parse(Console.ReadLine());

            if (tasklist.Any(u => u.Id.Equals(numID)))
            {
                Console.WriteLine("Uma tarefa com esse numero ja existe.");
                Console.WriteLine("Precione qualquer tecla para cintinuar...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("De um nome a sua tarefa");
            Console.Write("Nome: ");
            var name =Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Dedescreva a sua tarefa");
            Console.Write("Descrição: ");
            var descripton = Console.ReadLine();

            Console.WriteLine();
            Tasks newTask = new Tasks(numID , name, descripton);
            tasklist.Add(newTask);
            Console.WriteLine();
            Console.WriteLine(newTask);
            Console.WriteLine("Tarefa adicionada");
            Console.ReadKey();

         

        }
        public static void Sowtasks()
        {
            if (tasklist.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Tarefas");
                Console.WriteLine("============");
                Console.WriteLine();

                foreach (var task in tasklist)
                {
                    Console.WriteLine(task);
                    Console.WriteLine();
                    
                }
                Console.ReadKey();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Não exitem tarefas.");
                Console.ReadKey();
            }
        }

        public static void Taskstatus()
        {
            Console.Clear();

            Console.WriteLine("Starus da tarefa");
            Console.WriteLine("=================");
            
            
            if (tasklist.Count > 0)
            {
                foreach (var task in tasklist)
                {
                    Console.WriteLine(task);
                    Console.WriteLine();

                }
                Console.WriteLine("=================");
                Console.WriteLine("informe o numero da tarefa que deseja marcar como Concluida");
                var numdatarefa = int.Parse(Console.ReadLine());
                var tarefarefaencontrada = tasklist.FirstOrDefault(t => t.Id == numdatarefa);
                if (tarefarefaencontrada != null && tarefarefaencontrada.IsCompleted == false)
                {
                    tarefarefaencontrada.IsCompleted = true;
                    Console.WriteLine();
                    Console.WriteLine("Tarefa concluida!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Esta tarefa ja foi concluida");
                    Thread.Sleep(1500);
                    Taskstatus();
                }

                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não existem tarefas");
                Console.ReadKey();
            }

        }
        public static void EditTask()
        {

            foreach (var task in tasklist)
            {
                Console.WriteLine(task);
                Console.WriteLine();

            }
            Console.WriteLine("=================");
            Console.WriteLine("informe o numero da tarefa que deseja Editar");
            var numdatarefa = int.Parse(Console.ReadLine());
            var tarefarefaencontrada = tasklist.FirstOrDefault(t => t.Id == numdatarefa);
            if (tarefarefaencontrada != null )
            {

                Console.WriteLine($"De um novo nome a tarefa: {tarefarefaencontrada.Name} - Nome atual: {tarefarefaencontrada.Name}");
                Console.WriteLine();
                tarefarefaencontrada.Name = Console.ReadLine(); ;
                Console.WriteLine();
                Console.WriteLine("Nome modificado");

                Console.WriteLine();

                Console.WriteLine($"De uma nova Descrição a tarefa: {tarefarefaencontrada.Name} - Descrição atual: {tarefarefaencontrada.Description}");
                Console.WriteLine();
                tarefarefaencontrada.Description = Console.ReadLine(); 
                Console.WriteLine();
                Console.WriteLine("Descrição modificada");
                Console.WriteLine();
                
                Console.WriteLine("Tarefa alterada");
                Thread.Sleep(1000);




            }



        }
        public static void DeleteTask() 
        {
            foreach (var task in tasklist)
            {
                Console.WriteLine(task);
                Console.WriteLine();

            }
            Console.WriteLine("=================");
            Console.WriteLine("informe o numero da tarefa que deseja EXCLUIR");
            var numdatarefa = int.Parse(Console.ReadLine());
            var tarefarefaencontrada = tasklist.FirstOrDefault(t => t.Id == numdatarefa);
            if (tarefarefaencontrada != null)
            {

                Console.WriteLine($"Deseja excluir esta tarefa: {tarefarefaencontrada.Name} (s/n) ");
                char op = char.Parse(Console.ReadLine().ToLower());
                if (op == 's')
                {
                    Console.Clear();
                    tasklist.Remove(tarefarefaencontrada);
                    Console.WriteLine("Tarefa removida");
                    Console.ReadKey();
                }
                else if (op == 'n')
                {
                    Console.WriteLine("A tarefa foi mantida");
                    Thread.Sleep(1000);
                    Menu.Menuoption();
                    
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("entrada onvalida responda com (S ou N)");
                   Console.ReadKey(); 
                    DeleteTask();

                }





            }




        }


    }
}
