/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 2
 * Change: 1
 * Status: Complete
 * Notes:   https://msdn.microsoft.com/en-us/library/system.windows.forms.button.button(v=vs.110).aspx
 *          
 * Methods:
 *          
 * Dependencies:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Project2
{
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(instaSeat))]
    [System.Xml.Serialization.XmlInclude(typeof(Customer))]
    [System.Xml.Serialization.XmlInclude(typeof(Size))]
    [System.Xml.Serialization.XmlInclude(typeof(Point))]
    [System.Xml.Serialization.XmlInclude(typeof(Color))]
    public class instaSeat
    {
        public bool Reserve = false;
        public Color C = System.Windows.Forms.Button.DefaultBackColor;
        public Size S = new Size(45, 20);
        public Point P = new Point();
        public string DSP;
        public Customer rCust = new Customer();

        public instaSeat() 
        {

        }

        public instaSeat(instaSeat I)
        {
            this.Reserve = I.Reserve;
            this.C = I.C;
            this.S = I.S;
            this.P = I.P;
            this.DSP = I.DSP;
            this.rCust = I.rCust;
        }

    }
}