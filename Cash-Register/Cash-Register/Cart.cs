using System;
namespace Cash_Register
{
    public class Cart : iItem
    {
        float asp = 0;
        float bananas = 0;
        float cake = 0;
        float eggs = 0;
        float pasta = 0;
        float potatoes = 0;
        float soup = 0;

        public float price { get; set; }
        public Cart()
        {
            asp = .97f;
            bananas = 1.07f;
            cake = 3.88f;
            eggs = 1.89f;
            pasta = 3.29f;
            potatoes = 1.67f;
            soup = 2.99f;
        }
    }
}
