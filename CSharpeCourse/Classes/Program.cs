namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Add(); 
            customerManager.Update();

            ProductManager productManager=new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer=new Customer(); 
            customer.City = "İstanbul"; // set
            customer.FirstName = "Kevser"; // set
            customer.Id = 44; // set
            customer.LastName = "Altunbey"; // set

            Customer customer2 = new Customer
            {
                Id = 3, City = "Malatya", LastName = "Altunbey", FirstName = "Kevs" // set
            };

            Console.WriteLine(customer2.FirstName);  // get

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}

