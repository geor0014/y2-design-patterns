public class BlackFridayDiscount : IDiscountable {
    public double getDiscount(IProduct product, int index) {
        return 0.5;
    }
}