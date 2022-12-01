public class Checkout
{
    private SalesAction salesAction;

    public Checkout(SalesAction salesAction)
    {
        this.salesAction = salesAction;
    }

    public void nextCustomer(Customer customer)
    {
        DiscountCalculator discountCalculator = new DiscountCalculator(customer);

        //init checkout 
        if (salesAction == SalesAction.Christmas)
        {
            // discountCalculator = new DiscountCalculator(customer, new ChristMasDiscount());
            discountCalculator.setDiscount(new ChristMasDiscount());

        }
        else if (salesAction == SalesAction.BlackFriday)
        {
            // discountCalculator = new DiscountCalculator(customer, new BlackFridayDiscount());
            discountCalculator.setDiscount(new BlackFridayDiscount());
        }
        else if (customer.isRegular())
        {
            // discountCalculator = new DiscountCalculator(customer, new RegularCustomerDiscount());
            discountCalculator.setDiscount(new RegularCustomerDiscount());
        }


        // welcome customer 
        string welcome = "Welcome " + customer.getName() + "!";

        // perform checkout
        ShoppingCart cart = customer.getCart();

        var amountToPay = cart.TotalPrice(discountCalculator);
        // tell the customer what he owns and what his discount is
        string checkout = "You own " + amountToPay + "";
        Console.WriteLine(checkout);
    }
}