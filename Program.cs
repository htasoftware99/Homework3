using ClassMetotDemo;

Customer customer1 = new Customer();
customer1.Id = 1;
customer1.Name = "Hasan";
customer1.Surname = "Aykaç";
customer1.City = "Ankara";

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.Name = "Mehmet";
customer2.Surname = "Buğra";
customer2.City = "Çorum";

CustomerManager customerManager =  new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Delete(customer1);
customerManager.Delete(customer2);

Customer[] customer = new Customer[] { customer1, customer2 };
customerManager.ListCustomer(customer);