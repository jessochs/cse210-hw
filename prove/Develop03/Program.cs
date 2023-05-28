using System;

class Program
{
    static void Main(string[] args)
    {

        Reference r1 = new Reference("Proverbs", "3", "5", "6");
        

        Scripture s1 = new Scripture();

        bool Display()
        {
            
            Console.WriteLine(r1.GetReference());
            s1.DisplayScripture();

            Console.WriteLine("Press enter or quit to end");
            string input = Console.ReadLine();
            
        
            

            if (input == "quit")
            {
                return false;
            }
            if (s1.AllWordsHidden())
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }   

        while(Display())
            {
                Console.Clear();
                int counter = 0;
                while(counter < 3)
                {
                    if(s1.HideWord())
                    {
                        counter++;
                        if (s1.AllWordsHidden())
                            break;
                    }
                    
                    
                }
               
            }
        
        // create a display method
        //      call scripture.display
        //      prompt user
        //      get input
        //      return false if input == 'quit'
        //      call scripture.AllWordsHidden
        //      if true return false

        //      else return true


        // while(Display()) call the above display function
        //      call the scipture.hide word for three words at a time

    
    }
}