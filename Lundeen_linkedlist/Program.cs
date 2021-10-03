using System;

namespace Lundeen_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList links = new LinkedList();
            bool Exit = false;
            string Choice;
            char Cases;
            while (!Exit)
            {
                Choice = "";
                while (Choice == "")
                {
                    Choice = Input(
                    "1. Show Head       \n" +
                    "2. Add Item        \n" +
                    "3. Remove Item     \n" +
                    "4. Search for Item \n" +
                    "5. Print           \n" +
                    "6. Exit            \n"
                    );
                }
                Cases = Choice[0];
                switch (Cases)
                {
                    default:
                        break;

                    case '1': // Show Head
                        Node First = links.getFirst();
                        if(First != null)
                        {
                            Clear();
                            Print(First.Data);
                            Wait();
                        } else
                        {
                            Clear();
                            Print("Head Node does not exist.");
                            Wait();
                        }
                        break;

                    case '2': // Add Item
                        string NodeContent = "";

                        while (NodeContent == "")
                        { NodeContent = Input("Enter Node Contents:"); }
                        Node newNode = new Node(NodeContent);

                        if (links.getFirst() == null)
                        { 
                            links.addFirst(newNode); 
                        } else
                        {
                            links.Add(newNode);
                        }

                        break;

                    case '3': // Remove Item, no confirmation might need changed
                        if(links.getFirst() != null)
                        {
                            string searchString = "";

                            while (searchString == "")
                            { searchString = Input("Enter Node data to search: "); }
                            links.Remove(searchString);
                            break;
                        }else
                        {
                            Clear();
                            Print("There are no Nodes.");
                            Wait();
                        }
                        break;

                    case '4': // Search for Item
                        if (links.getFirst() != null)
                        {
                            string search = "";
                            Node result;
                            while (search == "")
                            { search = Input("Enter Node data to search: "); }

                            result = links.Contains(search);
                            if (result != null)
                            {
                                Clear();
                                Print("Node Contains: " + result.Data);
                                Wait();
                            }
                            break;
                        }
                        else
                        {
                            Clear();
                            Print("There are no Nodes.");
                            Wait();
                        }
                        break;

                    case '5': // Print
                        Clear();
                        links.PrintAllNodes();
                        break;

                    case '6': // Exit
                        Exit = true;
                        break;

                }
            }
                
        }
        

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static string Input(string helperMessage)
        { 
            string input = null;

            Clear();
            Print(helperMessage);
            input = Console.ReadLine();
            

            return input;
        }
        public static void Wait()
        {
            Console.ReadLine();
        }
        public static void Clear()
        {
            Console.Clear();
        }

    }
}
