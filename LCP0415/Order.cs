namespace b // folder b
{
    public class Order
    {// use it outside this {}
       public int ncogs;// private vs public 80/each
       public int ngears;// 200/each
       public double subtotal;

       public double GetSubtotal()
        {
            double s = 80 * ncogs + 200 * ngears;
            subtotal = s;
            return s;
        }

        public string GetOrderInfor()
        {
            return $"N cogs: {ncogs}, N gears: {ngears}, Subtotal: {subtotal:C2}";
        }
    }
}