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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Project2
{
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Show))]
    [System.Xml.Serialization.XmlInclude(typeof(DateTime))]
    public class ShowDBase
    {
        private static ShowDBase instance;

        private ShowDBase() { }

        public static ShowDBase Instance
        {
            get
            {
                if (instance == null) instance = new ShowDBase();
                return instance;
            }
        }

        public List<Show> KnownShows = new List<Show>();

        public int Count
        {
            get { return this.KnownShows.Count; }
        }

        public void Add(Show S)
        {
            //Check for existing record edit or update
            if (this.KnownShows.Exists(item => (item.name == S.name && item.Date == S.Date)))
            {
                int loc = this.KnownShows.FindIndex(item => (item.name == S.name && item.Date == S.Date));

                this.KnownShows.RemoveAt(loc);
                this.KnownShows.Insert(loc, S);
            }
            else
            {
                S.Id = this.KnownShows.Count;
                this.KnownShows.Add(S);
            }

            this.Save();
        }

        public void Load()      //Load XML Object File
        {
            try
            {
                using (StreamReader sm = new StreamReader(Program.showpath))
                {
                    XmlSerializer s = new XmlSerializer(typeof(List<Show>));
                    ShowDBase.Instance.KnownShows = s.Deserialize(sm) as List<Show>;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not find configuration file: " + Program.showpath +
                                    "\nNew configuration file will be created.");
            }
        }

        public void Save()
        {
            XmlSerializer z = new XmlSerializer(KnownShows.GetType());
            using (var stream3 = new FileStream(Program.showpath, FileMode.Create))
            {
                z.Serialize(stream3, KnownShows);
                stream3.Flush();
                stream3.Close();
            }
        }
    }
}