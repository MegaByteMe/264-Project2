/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 2
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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Project2
{
    [Serializable]
    public class CustDBase
    {
        private static CustDBase instance;

        private CustDBase() { }

        public static CustDBase Instance
        {
            get { if (instance == null) 
                    instance = new CustDBase();
                return instance;
                }
        }

        public List<Customer> KnownCust = new List<Customer>();

        public int Count
        {
            get { return this.KnownCust.Count; }
        }

        public void Add(Customer C)
        {
            //Check for existing Customer as in record edit or update
            if (this.KnownCust.Exists(item => (item.FName == C.FName && item.LName == C.LName)))
            {
                int loc = this.KnownCust.FindIndex(item => (item.FName == C.FName && item.LName == C.LName));

                this.KnownCust.RemoveAt(loc);
                this.KnownCust.Insert(loc, C);
            }
            else
            {
                C.Id = this.KnownCust.Count;
                this.KnownCust.Add(C);
            }

            this.Save();
        }

        public void Load()      //Load XML Object File
        {
            try
            {
                using (StreamReader sr = new StreamReader(Program.custpath))
                {
                    XmlSerializer c = new XmlSerializer(typeof(List<Customer>));
                    CustDBase.Instance.KnownCust = c.Deserialize(sr) as List<Customer>;
                    sr.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not find configuration file: " + Program.custpath + 
                                    "\nNew configuration file will be created.");
            }
        }

        public void Save()      //Save Objects to XML
        {
            var x = new XmlSerializer(KnownCust.GetType());
            using (var stream1 = new FileStream(Program.custpath, FileMode.Create))
            {
                x.Serialize(stream1, KnownCust);
                stream1.Flush();
                stream1.Close();
            }
            
        }
    }
}
