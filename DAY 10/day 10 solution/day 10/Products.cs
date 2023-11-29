using System.Runtime.Intrinsics.X86;

namespace day_10
{
     internal class Products
     {
        public static int cnt;
        public string Name;
        public string description;
        public double price;
        public int CounInStack;
        public bool HasDiscount;
        
        
        public  Products( string Name , string description , double price , int CountInStack , bool HasDiscount)
        {
            this.Name = Name;
            this.description = description;
            this.price = price;
            this.CounInStack = CountInStack;
            this.HasDiscount = HasDiscount;

    static void DeatailsProducts()
    {

    }
        }

     }


    
}
