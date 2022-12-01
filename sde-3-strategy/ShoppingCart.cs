public class ShoppingCart : List<IProduct>{
    public double TotalPrice (DiscountCalculator discountCalculator) {

        var total = 0.0;

        foreach (var product in this) {
            var index = this.IndexOf(product);

            double discount = discountCalculator.getDiscount(product, index);
            double price = product.getPrice() * discount;

            total += price;
        }
        return total;
    }

}