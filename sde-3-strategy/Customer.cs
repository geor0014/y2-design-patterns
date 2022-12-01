public class Customer {
    private CustomerType type;
    private ShoppingCart cart;
    private string name;

    public Customer(CustomerType type,  string name) {
        this.type = type;
        this.name = name;
        this.cart = new ShoppingCart();
    }

    public string getName() {
        return name;
    }

    public ShoppingCart getCart() {
        return cart;
    }

    public void purchase (IProduct product) {
        this.cart.Add(product);
    }

    public Boolean isRegular() {
        return this.type == CustomerType.REGULAR;
    }
}