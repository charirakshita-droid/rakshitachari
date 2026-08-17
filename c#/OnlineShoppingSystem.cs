using System;

namespace OnlineShopping
{
    // ---------------------------
    // Abstraction
    // ---------------------------
    abstract class User
    {
        protected int id;
        protected string email;

        // Abstract method (no implementation)
        public abstract void Login();

        // Normal method
        public void Register()
        {
            Console.WriteLine("User Registered Successfully.");
        }
    }

    // ---------------------------
    // Inheritance
    // Customer inherits User
    // ---------------------------
    class Customer : User
    {
        // Encapsulation
        private string name;
        private long phoneNumber;

        // Property (Getter/Setter)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // Polymorphism (Method Overriding)
        public override void Login()
        {
            Console.WriteLine("Customer Logged In Successfully.");
        }
    }

    // ---------------------------
    // Another child class
    // ---------------------------
    class Admin : User
    {
        public override void Login()
        {
            Console.WriteLine("Admin Logged In Successfully.");
        }
    }

    // ---------------------------
    // Product Class
    // ---------------------------
    class Product
    {
        public int productId;
        public string productName;
        public double price;
        public string description;
        public int stock;

        public void DisplayProduct()
        {
            Console.WriteLine("Displaying Product Details...");
        }
    }

    // ---------------------------
    // Product Category
    // ---------------------------
    class ProductCategory
    {
        public int categoryId;
        public string categoryName;
    }

    // ---------------------------
    // Order Class
    // ---------------------------
    class Order
    {
        public int orderId;
        public string orderDate;
        public double amount;

        public void PlaceOrder()
        {
            Console.WriteLine("Order Placed Successfully.");
        }
    }

    // ---------------------------
    // Payment Class
    // ---------------------------
    class Payment
    {
        // Polymorphism (Method Overloading)

        public void MakePayment(double amount)
        {
            Console.WriteLine("Paid ₹" + amount + " using Default Method.");
        }

        public void MakePayment(double amount, string paymentMethod)
        {
            Console.WriteLine("Paid ₹" + amount + " using " + paymentMethod + ".");
        }
    }

    // ---------------------------
    // Wishlist
    // ---------------------------
    class Wishlist
    {
        public void AddProduct()
        {
            Console.WriteLine("Product Added to Wishlist.");
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Product Removed from Wishlist.");
        }
    }

    // ---------------------------
    // Search
    // ---------------------------
    class Search
    {
        public void SearchProduct(string keyword)
        {
            Console.WriteLine("Searching for: " + keyword);
        }
    }

    // ---------------------------
    // Offer
    // ---------------------------
    class Offer
    {
        public string coupon;
        public double discount;
    }

    // ---------------------------
    // Delivery
    // ---------------------------
    class Delivery
    {
        public int deliveryId;
        public string deliveryStatus;

        public void TrackOrder()
        {
            Console.WriteLine("Your Order is Out for Delivery.");
        }
    }

    // ---------------------------
    // Review
    // ---------------------------
    class Review
    {
        public int rating;
        public string feedback;
    }

    // ---------------------------
    // Profile
    // ---------------------------
    class Profile
    {
        public string address;
        public string username;

        public void UpdateProfile()
        {
            Console.WriteLine("Profile Updated Successfully.");
        }
    }

    // ---------------------------
    // Main Class
    // ---------------------------
    class OnlineShoppingSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== ONLINE SHOPPING SYSTEM ======\n");

            // Abstraction + Inheritance
            Customer customer = new Customer();
            customer.Register();
            customer.Login();

            // Encapsulation
            customer.Name = "Rakshita";
            customer.PhoneNumber = 9876543210L;

            Console.WriteLine("Customer Name : " + customer.Name);
            Console.WriteLine("Phone Number  : " + customer.PhoneNumber);

            Console.WriteLine();

            // Another inherited class
            Admin admin = new Admin();
            admin.Register();
            admin.Login();

            Console.WriteLine();

            // Product
            Product product = new Product();
            product.productName = "Laptop";
            product.price = 55000;

            product.DisplayProduct();

            Console.WriteLine("Product : " + product.productName);
            Console.WriteLine("Price   : ₹" + product.price);

            Console.WriteLine();

            // Order
            Order order = new Order();
            order.orderId = 101;
            order.orderDate = "06-Aug-2026";
            order.amount = 55000;

            order.PlaceOrder();

            Console.WriteLine();

            // Polymorphism (Method Overloading)
            Payment payment = new Payment();
            payment.MakePayment(55000);
            payment.MakePayment(55000, "UPI");

            Console.WriteLine();

            // Wishlist
            Wishlist wishlist = new Wishlist();
            wishlist.AddProduct();

            // Search
            Search search = new Search();
            search.SearchProduct("Laptop");

            // Delivery
            Delivery delivery = new Delivery();
            delivery.TrackOrder();

            // Profile
            Profile profile = new Profile();
            profile.UpdateProfile();

            Console.WriteLine("\nOnline Shopping System Executed Successfully.");
        }
    }
}
