public class DiscountCalculator {
    private Customer customer;
    private IDiscountable discount;

    public DiscountCalculator(Customer customer, IDiscountable discount) {
        this.customer = customer;
        this.discount = discount;
    }

    public double getDiscount(IProduct product, int index){
        return discount.getDiscount(product, index);
    }

}