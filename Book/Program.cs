using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Book
{

    class book
    {
        int id;
        string name;
        string type;
        DateTime createdOn;
       // bool isDeleted;
        int price;
        static int count = 0;
        string category;

        // static constractor
        static book()
        {
            Console.WriteLine("This is first book");
            count = 0;
        }

        // deafult constractor
        public book() 
        {
            count++;
        }

        //Parameterized constructors
        public book(int id,String name="unnown")
        {
            this.id = id;
            this.name = name;
            createdOn = DateTime.Now;
            count++;
        }
        public book(int id, String name = "unnown",string type = "default",int price=0,string category = "no categoty")
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.price = price;
            this.category = category;
            createdOn = DateTime.Now;
            count++;
        }
        public int howMenyBookBuy() { return count; }
        //public bool is_Deleted() { return isDeleted; }

        public void getDataBook()
        {
            Console.WriteLine($"{id} - {name} - {type} - {createdOn} - {price}");          
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book(15, "rich dad", "money", 50, "improvment");
            book b2 = new book(55, "fgh", "money", 50, "improvment");
            b1.getDataBook();
            b2.getDataBook();

            Console.WriteLine(b1.howMenyBookBuy());


        }







    }
}