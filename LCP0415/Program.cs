// MIS 3013
// April 15, 2024
// Alexandra Camarena
// 113568154
using b;// because order is in the b folder
// list
Console.WriteLine("List");

// define an order
// namespace b
// the cs file name does not matter

Order or1;
or1 = new Order();
or1.ncogs = 1;
or1.ngears = 2; 
double s = or1.GetSubtotal();
string str1 = or1.GetOrderInfor();
Console.WriteLine(str1);

// order list
Order order1;
Order order2;
Order order3;
Order order4;

List<Order> orderlist;// warehouse, to store Order variables, List complex, Order list
orderlist = new List<Order>();// we build a warehouse we store the address on a card

orderlist.Add(or1);//two steps;
// 1. Create an order variable inside the order
// 2. orderList[0] = or1;

// list vs array: array fixed size warehouse. List: the size is flexible