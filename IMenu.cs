using System;

namespace c{

    interface IMenu{

        Dictionary<string, int> createMain();
        Dictionary<string, int> createDrink();
        
        void dispMain();
        void dispDrink();
    }
}