public class NoDiscount : IDiscountable {
    public double getDiscount(IProduct product, int index) {
        return 1;
    }
}