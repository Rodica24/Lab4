using System;

namespace VScode{

    class Cleaners: Personal{
       private Client client;

       public Cleaners(string name, string status): base(name, status){
            setValues(name, status);
        }

       public void cleanRoom(){
            Random rnd = new Random();
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("There are this number of dirty rooms:");
                int a=rnd.Next(3);
                Console.WriteLine(a);//returns random integers < 10
                if (a == 0) 
                {
                    Console.WriteLine("The cleaner gets congrats");
                    break;
                }
                else 
                {
                    Console.WriteLine("The cleaner now has a lower salary("); 
                }
                }


        }
        
        }}