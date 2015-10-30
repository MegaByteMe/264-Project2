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
using System.Drawing;

namespace Project2
{
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(VenObj))]
    [System.Xml.Serialization.XmlInclude(typeof(Show))]
    [System.Xml.Serialization.XmlInclude(typeof(instaSeat))]
    public class VenDBase
    {
        private static VenDBase instance;

        private VenDBase() { }

        public static VenDBase Instance
        {
            get {
                if (instance == null) instance = new VenDBase();
                return instance;
            }
        }

        public List<VenObj> KnownVen = new List<VenObj>();

        public int Count
        {
            get { return this.KnownVen.Count; }
        }

        public void Add(VenObj V)
        {
            //Check for existing record edit or update
            if (this.KnownVen.Exists(item => (item.venname == V.venname)))
            {
                int loc = this.KnownVen.FindIndex(item => (item.venname == V.venname));

                this.KnownVen.RemoveAt(loc);
                this.KnownVen.Insert(loc, V);
            }
            else
            {
                V.id = this.KnownVen.Count;
                this.KnownVen.Add(V);
            }

            this.Save();
        }

        public void Load()      //Load XML Object File
        {
            try
            {
                using (StreamReader sl = new StreamReader(Program.venpath))
                {
                    XmlSerializer v = new XmlSerializer(typeof(List<VenObj>));
                    VenDBase.Instance.KnownVen = v.Deserialize(sl) as List<VenObj>;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not find configuration file: " + Program.venpath +
                                    "\nNew configuration file will be created.");
            }
        }

        public void Save()
        {
            XmlSerializer w = new XmlSerializer(typeof(List<VenObj>));
            using (var stream2 = new FileStream(Program.venpath, FileMode.Create))
            {
                w.Serialize(stream2, KnownVen);
                stream2.Flush();
                stream2.Close();
            }
        }

        //Debug Routine
        public void demoload()
        {
            VenObj demo = new VenObj();
            demo.id = KnownVen.Count;
            demo.venname = "Cavern On The Green";

            int seat = 0, row = 0;

            for (int i = 50; i < 550; i += 30)      //X
            {
                for (int j = 25; j < 500; j += 50)   //Y
                {
                    instaSeat a = new instaSeat();
                    a.DSP = seat.ToString() + ", " + row.ToString();
                    a.P = new Point(j,i);

                    demo.SeatLayout.Add(a);
                    seat++;
                }
                seat = 0;
                row++;
            }
            instaSeat stage = new instaSeat();
            stage.DSP = "Stage";
            stage.S = new Size(100, 50);
            stage.P = new Point(225, 600);

            demo.SeatLayout.Add(stage);

            this.KnownVen.Add(demo);
        }

        public void demoload1()
        {
            VenObj demo = new VenObj();
            demo.id = KnownVen.Count;
            demo.venname = "The Place That Shall Not Be Named";

            int seat = 0, row = 0;

            for (int i = 50; i < 550; i += 60)      //X
            {
                for (int j = 25; j < 500; j += 100)   //Y
                {
                    instaSeat a = new instaSeat();
                    a.DSP = seat.ToString() + ", " + row.ToString();
                    a.P = new Point(j, i);
                    demo.SeatLayout.Add(a);
                    seat++;
                }
                seat = 0;
                row++;
            }
            instaSeat stage = new instaSeat();
            stage.DSP = "Stage";
            stage.S = new Size(100, 50);
            stage.P = new Point(225, 600);

            demo.SeatLayout.Add(stage);

            this.KnownVen.Add(demo);
        }

    }
}