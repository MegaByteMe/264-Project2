/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 1
 * Change: 0
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
    [System.Xml.Serialization.XmlInclude(typeof(VenObj))]
    [System.Xml.Serialization.XmlInclude(typeof(instaSeat))]
    [System.Xml.Serialization.XmlInclude(typeof(Show))]
    public class VenObj
    {
        public List<instaSeat> SeatLayout = new List<instaSeat>();
        public List<Show> AShows = new List<Show>();

        public String venname;
        public int id;

        public String VenueName 
        {
            get { return venname; }
            set { value = venname; }
        }

        public VenObj()
        {

        }

        public VenObj(VenObj V)
        {
            this.SeatLayout = V.SeatLayout;
            this.AShows = V.AShows;
            this.venname = V.venname;
            this.id = V.id;
        }

        public void AddShow(Show S)
        {
            S.Seats = SeatLayout;
            AShows.Add(S);
        }
    }
}