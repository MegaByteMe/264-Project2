/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 0
 * Change: 2
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
using System.Windows.Forms;

namespace Project2
{
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Show))]
    [System.Xml.Serialization.XmlInclude(typeof(instaSeat))]
    [System.Xml.Serialization.XmlInclude(typeof(DateTime))]
    public class Show
    {
        public String name, description;
        public DateTime Date = new DateTime();
        public int Id;
        public double TikPrice;

        public List<instaSeat> Seats = new List<instaSeat>();

        public String ShowName
        {
            get { return name; }
            set { value = name; }
        }

        public String ShowDate
        {
            get { return Date.ToShortDateString(); }
        }

        public String NameDate
        {
            get { return (name + " " + Date.ToShortDateString() + " " + Date.ToShortTimeString()); }
        }

        public Show()
        {

        }

        public Show(Show S)
        {
            this.name = S.name;
            this.Seats = S.Seats;
            this.Id = S.Id;
            this.Date = S.Date;
            this.description = S.description;
            this.TikPrice = S.TikPrice;
        }

        public Show( string Name, string descrip, DateTime when, double price)
        {
            this.name = Name;
            this.description = descrip;
            this.Date = when;
            this.TikPrice = price;
        }
    }
}