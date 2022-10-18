using System;

namespace VScode{
    
    class Program{

        static void Main(){
            Hotel hotel = new Hotel();
            Menu menu = new Menu();
            Orders orders = new Orders();
            Chief chief = new Chief("Luidji", "Chief");
            Cleaners cleaners = new Cleaners("Galea", "Cleaner");
            Administrator administrator = new Administrator("Mihai", "Administrator");
            Client client = new Client();

        
    
            hotel.setValues("Grand", "Chisinau");
            hotel.printValues();
            administrator.speak();

            Rooms rooms = new Rooms();
            rooms.GenerateRoom();
            rooms.RoomQuality(0, client);

            Facility facility = new Facility();
            facility.displayFacility();

          
            menu.displayMain();
            menu.displayDrink();

            chief.speak();
            orders.orderMain();
            orders.orderDrink();
            

        
            chief.prepare(orders);
            Console.WriteLine();
            cleaners.speak();
            cleaners.cleanRoom();
            administrator.grade(client, cleaners); 
            Console.WriteLine();
            

           
        }

    } 

}