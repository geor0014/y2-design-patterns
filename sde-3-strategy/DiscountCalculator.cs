public class DiscountCalculator
{
    private Customer customer;
    private IDiscountable discount = new NoDiscount();

    public DiscountCalculator(Customer customer)
    {
        this.customer = customer;
    }

    public void setDiscount(IDiscountable discount)
    {
        this.discount = discount;
    }

    public double getDiscount(IProduct product, int index)
    {
        return discount.getDiscount(product, index);
    }

}