using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAPI;
using LibAPI.Data;
namespace TestApp
{
    public class Abase
    {
        public virtual void HelloABase()
        {
            Console.WriteLine("the name of this class is {0}", this.ToString());
        }
    }
    public class BBase:Abase
    {
        public override void HelloABase()
        {
            Console.WriteLine("the name of this class is {0}", this.ToString());
        }
    }
    class Program
    {
        LibraryDBContext objContext = new LibraryDBContext();
        static void Main(string[] args)
        {
            Program objpro = new Program();

            foreach (MemberShipType _book in objpro.GetEmployees())
            {
                Console.WriteLine("{0} is the name of book", _book.MembershipTypeName);
            }
            
        }
        public List<MemberShipType> GetEmployees()
        {
            objContext.MemberShipTypes.Add(new MemberShipType() {MaxIssueDays=101,MembershipTypeName="10 dAY2S" });
            objContext.SaveChanges();
            return objContext.MemberShipTypes.ToList();
        }

    }
}
