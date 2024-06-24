using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class salesdetailes
    {
        public int salesno;
        public int productionno;
        public float price;
        public DateTime dateofsale;
        public int  qty;
        public float totalamount;

        public salesdetailes(int salesno, int productionno, float price, DateTime dateofsale, int qty)
        {
            this.salesno = salesno;
            this.productionno = productionno;
            this.price = price;
            this.dateofsale = dateofsale;
            this.qty = qty;
            //this.totalamount = totalamount;
            this.sales();
        }

        public  void sales()
        {
            totalamount = qty * price;
            

        }
        public void showdata()
        {
            Console.WriteLine($"salesno:  {salesno}, productionno:  {productionno}, price:  {price},  dateofsale:  {dateofsale}, qty:  {qty}, totalamount:  {totalamount}  ");
        }


        
    }
    class testsalesdata
    {
        public static void Main()
        {
            salesdetailes sale = new salesdetailes(401, 1, 1000, DateTime.Now,4);
            sale.showdata();

            Console.Read();
        }
    }
}
