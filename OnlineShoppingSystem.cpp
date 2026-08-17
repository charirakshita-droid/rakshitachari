#include <iostream>
#include <string>
using namespace std;

// ---------------------------
// Abstraction
// ---------------------------
class User {
protected:
    int id;
    string email;

public:
    virtual ~User() {}

    // Pure virtual method (abstract)
    virtual void login() = 0;

    // Normal method
    void registerUser() {
        cout << "User Registered Successfully." << endl;
    }
};

// ---------------------------
// Inheritance
// Customer inherits User
// ---------------------------
class Customer : public User {
private:
    // Encapsulation
    string name;
    long long phoneNumber;

public:
    // Getter
    string getName() {
        return name;
    }

    // Setter
    void setName(string name) {
        this->name = name;
    }

    // Getter
    long long getPhoneNumber() {
        return phoneNumber;
    }

    // Setter
    void setPhoneNumber(long long phoneNumber) {
        this->phoneNumber = phoneNumber;
    }

    // Polymorphism (Method Overriding)
    void login() override {
        cout << "Customer Logged In Successfully." << endl;
    }
};

// ---------------------------
// Another child class
// ---------------------------
class Admin : public User {
public:
    void login() override {
        cout << "Admin Logged In Successfully." << endl;
    }
};

// ---------------------------
// Product Class
// ---------------------------
class Product {
public:
    int productId;
    string productName;
    double price;
    string description;
    int stock;

    void displayProduct() {
        cout << "Displaying Product Details..." << endl;
    }
};

// ---------------------------
// Product Category
// ---------------------------
class ProductCategory {
public:
    int categoryId;
    string categoryName;
};

// ---------------------------
// Order Class
// ---------------------------
class Order {
public:
    int orderId;
    string orderDate;
    double amount;

    void placeOrder() {
        cout << "Order Placed Successfully." << endl;
    }
};

// ---------------------------
// Payment Class
// ---------------------------
class Payment {
public:
    // Polymorphism (Method Overloading)

    void makePayment(double amount) {
        cout << "Paid Rs " << amount << " using Default Method." << endl;
    }

    void makePayment(double amount, string paymentMethod) {
        cout << "Paid Rs " << amount << " using " << paymentMethod << "." << endl;
    }
};

// ---------------------------
// Wishlist
// ---------------------------
class Wishlist {
public:
    void addProduct() {
        cout << "Product Added to Wishlist." << endl;
    }

    void removeProduct() {
        cout << "Product Removed from Wishlist." << endl;
    }
};

// ---------------------------
// Search
// ---------------------------
class Search {
public:
    void searchProduct(string keyword) {
        cout << "Searching for: " << keyword << endl;
    }
};

// ---------------------------
// Offer
// ---------------------------
class Offer {
public:
    string coupon;
    double discount;
};

// ---------------------------
// Delivery
// ---------------------------
class Delivery {
public:
    int deliveryId;
    string deliveryStatus;

    void trackOrder() {
        cout << "Your Order is Out for Delivery." << endl;
    }
};

// ---------------------------
// Review
// ---------------------------
class Review {
public:
    int rating;
    string feedback;
};

// ---------------------------
// Profile
// ---------------------------
class Profile {
public:
    string address;
    string username;

    void updateProfile() {
        cout << "Profile Updated Successfully." << endl;
    }
};

// ---------------------------
// Main
// ---------------------------
int main() {
    cout << "====== ONLINE SHOPPING SYSTEM ======\n" << endl;

    // Abstraction + Inheritance
    Customer customer;
    customer.registerUser();
    customer.login();

    // Encapsulation
    customer.setName("Rakshita");
    customer.setPhoneNumber(9876543210LL);

    cout << "Customer Name : " << customer.getName() << endl;
    cout << "Phone Number  : " << customer.getPhoneNumber() << endl;

    cout << endl;

    // Another inherited class
    Admin admin;
    admin.registerUser();
    admin.login();

    cout << endl;

    // Product
    Product product;
    product.productName = "Laptop";
    product.price = 55000;

    product.displayProduct();

    cout << "Product : " << product.productName << endl;
    cout << "Price   : Rs " << product.price << endl;

    cout << endl;

    // Order
    Order order;
    order.orderId = 101;
    order.orderDate = "06-Aug-2026";
    order.amount = 55000;

    order.placeOrder();

    cout << endl;

    // Polymorphism (Method Overloading)
    Payment payment;
    payment.makePayment(55000);
    payment.makePayment(55000, "UPI");

    cout << endl;

    // Wishlist
    Wishlist wishlist;
    wishlist.addProduct();

    // Search
    Search search;
    search.searchProduct("Laptop");

    // Delivery
    Delivery delivery;
    delivery.trackOrder();

    // Profile
    Profile profile;
    profile.updateProfile();

    cout << "\nOnline Shopping System Executed Successfully." << endl;

    return 0;
}
