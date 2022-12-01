Checkout cashier = new Checkout(SalesAction.None);

// two custoemers enter the shop
Customer customer1 = new Customer(CustomerType.REGULAR, "John");
Customer customer2 = new Customer(CustomerType.NEW, "Mary");

// They make purchases 
customer1.purchase(new TeddyBear());
customer2.purchase(new TVScreen());

// go to checkout
cashier.nextCustomer(customer1);
cashier.nextCustomer(customer2);
