public class RegularCustomerDiscount : IDiscountable {
    public double getDiscount(IProduct product, int index) {
        return 0.85;
    }
}