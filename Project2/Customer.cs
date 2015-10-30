/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 2
 * Change: 3
 * Status: Complete
 * Notes:
 *          
 * Methods:
 *          
 * Dependencies:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    [Serializable]
    public class Customer
    {
        public string FName, LName, Street, City, State, CardType, Zip, Phone, CardNum, CVV, ExpMon, ExpYear;
        public int Id;

        public string CombName
        {
            get { return FName + " " + LName; }
        }

        public Customer()
        {

        }

        public Customer(Customer C)
        {
            this.Id = C.Id;
            this.FName = C.FName;
            this.LName = C.LName;
            this.Street = C.Street;
            this.City = C.City;
            this.State = C.State;
            this.Zip = C.Zip;
            this.Phone = C.Phone;
            this.CardNum = C.CardNum;
            this.CVV = C.CVV;
            this.ExpMon = C.ExpMon;
            this.ExpYear = C.ExpYear;
            this.CardType = C.CardType;
        }

        public Customer(String FirstN, String LastN, int Ident)
        {
            this.FName = FirstN;
            this.LName = LastN;
            this.Id = Ident;
        }

        public Customer(String FirstN, String LastN, String StreetA, String CityA, String StateA,
                        String ZipA, String tele, String CardNum, String CVV, String CardExpMon, 
                        String CardExpYear, String CType)
        {
            this.FName = FirstN;
            this.LName = LastN;
            this.Street = StreetA;
            this.City = CityA;
            this.State = StateA;
            this.Zip = ZipA;
            this.Phone = tele;
            this.CardNum = CardNum;
            this.CVV = CVV;
            this.ExpMon = CardExpMon;
            this.ExpYear = CardExpYear;
            this.CardType = CType;
        }

        public Customer(String FirstN, String LastN, String StreetA, String CityA, String StateA,
                        String ZipA, String tele)
        {
            this.FName = FirstN;
            this.LName = LastN;
            this.Street = StreetA;
            this.City = CityA;
            this.State = StateA;
            this.Zip = ZipA;
            this.Phone = tele;
        }

        public void AddPayment( String Type, String CardNumber, String CVVcode, 
                                String ExpiresMon, String ExpiresY )
        {
            this.CardType = Type;
            this.CardNum = CardNumber;
            this.CVV = CVVcode;
            this.ExpMon = ExpiresMon;
            this.ExpYear = ExpiresY;
        }
    }
}