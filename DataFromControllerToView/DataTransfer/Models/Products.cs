namespace DataTransfer.Models;
using System.Collections.Generic;
public class Products
{

    public string Pname { get; set; }
    public int Qtn { get; set; }


    public Products(string name, int qty)
    {
        this.Pname = name;
        this.Qtn = qty;
    }
// this method will transfer populated list to aaction method
    public static List<Products> GetProducts()
    {

        List<Products> list = new List<Products>();


        list.Add(new Products("Table", 12));
        list.Add(new Products("Chair", 15));
        list.Add(new Products("Computer", 14));
        list.Add(new Products("Laptop", 18));
        list.Add(new Products("SSD", 20));
        return list;
    }





}