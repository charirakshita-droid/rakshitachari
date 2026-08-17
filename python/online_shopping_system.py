from abc import ABC, abstractmethod


# ---------------------------
# Abstraction
# ---------------------------
class User(ABC):
    def __init__(self):
        self._id = None
        self._email = None

    @abstractmethod
    def login(self):
        pass

    def register(self):
        print("User Registered Successfully.")


# ---------------------------
# Inheritance
# Customer inherits User
# ---------------------------
class Customer(User):
    def __init__(self):
        super().__init__()
        # Encapsulation
        self.__name = None
        self.__phone_number = None

    # Getter
    def get_name(self):
        return self.__name

    # Setter
    def set_name(self, name):
        self.__name = name

    # Getter
    def get_phone_number(self):
        return self.__phone_number

    # Setter
    def set_phone_number(self, phone_number):
        self.__phone_number = phone_number

    # Polymorphism (Method Overriding)
    def login(self):
        print("Customer Logged In Successfully.")


# ---------------------------
# Another child class
# ---------------------------
class Admin(User):
    def login(self):
        print("Admin Logged In Successfully.")


# ---------------------------
# Product Class
# ---------------------------
class Product:
    def __init__(self):
        self.product_id = None
        self.product_name = None
        self.price = None
        self.description = None
        self.stock = None

    def display_product(self):
        print("Displaying Product Details...")


# ---------------------------
# Product Category
# ---------------------------
class ProductCategory:
    def __init__(self):
        self.category_id = None
        self.category_name = None


# ---------------------------
# Order Class
# ---------------------------
class Order:
    def __init__(self):
        self.order_id = None
        self.order_date = None
        self.amount = None

    def place_order(self):
        print("Order Placed Successfully.")


# ---------------------------
# Payment Class
# ---------------------------
class Payment:
    # Polymorphism (Method Overloading, simulated via default args)
    def make_payment(self, amount, payment_method=None):
        if payment_method is None:
            print(f"Paid ₹{amount} using Default Method.")
        else:
            print(f"Paid ₹{amount} using {payment_method}.")


# ---------------------------
# Wishlist
# ---------------------------
class Wishlist:
    def add_product(self):
        print("Product Added to Wishlist.")

    def remove_product(self):
        print("Product Removed from Wishlist.")


# ---------------------------
# Search
# ---------------------------
class Search:
    def search_product(self, keyword):
        print(f"Searching for: {keyword}")


# ---------------------------
# Offer
# ---------------------------
class Offer:
    def __init__(self):
        self.coupon = None
        self.discount = None


# ---------------------------
# Delivery
# ---------------------------
class Delivery:
    def __init__(self):
        self.delivery_id = None
        self.delivery_status = None

    def track_order(self):
        print("Your Order is Out for Delivery.")


# ---------------------------
# Review
# ---------------------------
class Review:
    def __init__(self):
        self.rating = None
        self.feedback = None


# ---------------------------
# Profile
# ---------------------------
class Profile:
    def __init__(self):
        self.address = None
        self.username = None

    def update_profile(self):
        print("Profile Updated Successfully.")


# ---------------------------
# Main
# ---------------------------
def main():
    print("====== ONLINE SHOPPING SYSTEM ======\n")

    # Abstraction + Inheritance
    customer = Customer()
    customer.register()
    customer.login()

    # Encapsulation
    customer.set_name("Rakshita")
    customer.set_phone_number(9876543210)

    print(f"Customer Name : {customer.get_name()}")
    print(f"Phone Number  : {customer.get_phone_number()}")

    print()

    # Another inherited class
    admin = Admin()
    admin.register()
    admin.login()

    print()

    # Product
    product = Product()
    product.product_name = "Laptop"
    product.price = 55000

    product.display_product()

    print(f"Product : {product.product_name}")
    print(f"Price   : ₹{product.price}")

    print()

    # Order
    order = Order()
    order.order_id = 101
    order.order_date = "06-Aug-2026"
    order.amount = 55000

    order.place_order()

    print()

    # Polymorphism (Method Overloading)
    payment = Payment()
    payment.make_payment(55000)
    payment.make_payment(55000, "UPI")

    print()

    # Wishlist
    wishlist = Wishlist()
    wishlist.add_product()

    # Search
    search = Search()
    search.search_product("Laptop")

    # Delivery
    delivery = Delivery()
    delivery.track_order()

    # Profile
    profile = Profile()
    profile.update_profile()

    print("\nOnline Shopping System Executed Successfully.")


if __name__ == "__main__":
    main()
