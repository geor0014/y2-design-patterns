public class ChristMasDiscount : IDiscountable {
    public double getDiscount(IProduct product, int index) {
        bool isFirstProduct = index == 0;
        var discount = 0.0;
        discount = isFirstProduct ? 0.2 : 0.125;
        return 1 - discount;
    }
}