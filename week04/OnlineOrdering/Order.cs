using System;
using System.Collections.Generic;
 
public class Order
{
    private List<Product> _products;
    private Customer _customer;
 
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
 
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
 
    public double GetTotalCost()
    {
        double total = 0;
 
        foreach (Product product in _products)
        {
            total = total + product.GetTotalCost();
        }
 
        if (_customer.LivesInUSA())
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }
 
        return total;
    }
 
    public string GetPackingLabel()
    {
        string label = "";
 
        foreach (Product product in _products)
        {
            label = label + product.GetName() + " (" + product.GetProductId() + ")\n";
        }
 
        return label;
    }
 
    public string GetShippingLabel()
    {
        return _customer.GetName() + "\n" + _customer.GetAddress().GetFullAddress();
    }
}