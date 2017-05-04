using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Main.Model
{
    public partial class SerializeToXml : UserControl
    {
        BindingList<Player> l = new BindingList<Player>();
        Random rnd = new Random();

        String debug = Path.GetDirectoryName(Application.ExecutablePath) + "\\HallOfFame.xml";

        public SerializeToXml()
        {

            if (l.Count() == 0)
            {
                //label_xml.Text = "Aucune donnée présente ... Initialisation terminée.";
                String[] pseudos = { "Pseudo 1", "Pseudo 2", "Pseudo 3", "Pseudo 4", "Pseudo 5"};
                int[] idsTeam = { 1, 1, 1, 2, 2 };
                int[] scores = { 10, 20, 30, 40, 50 };
                int[] highscores = { 100, 200, 300, 400, 500 };

                for (int j = 0; j < 5; j++)
                {
                    Player p = new Player(pseudos[j], idsTeam[j], scores[j], highscores[j]);
                    l.Add(p);
                }
            }
          
            if (File.Exists(debug))
            {
                //label_xml.Text = "XML présent";

                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Player>));

                StreamReader reader = new StreamReader(debug);
                l = (BindingList<Player>)serializer.Deserialize(reader);
                reader.Close();

                //lv.DataSource = l;
            }
            else
            {
                //label_xml.Text = "XML non présent";
                String[] pseudos = { "Pseudo 1", "Pseudo 2", "Pseudo 3", "Pseudo 4", "Pseudo 5" };
                int[] idsTeam = { 1, 1, 1, 2, 2 };
                int[] scores = { 10, 20, 30, 40, 50 };
                int[] highscores = { 100, 200, 300, 400, 500 };

                for (int i = 0; i < 5; i++)
                {
                    Player p = new Player(pseudos[i], idsTeam[i], scores[i], highscores[i]);
                    l.Add(p);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 1)
            {
                string text = lv.GetItemText(lv.SelectedItem);
                label_detail.Text = text;

                String toChange = label_detail.Text;
                String[] exploded = toChange.Split(' ');

                tb_id.Text = exploded[0];
                tb_nom.Text = exploded[2].Replace(",", "");
                tb_prenom.Text = exploded[1];
                tb_age.Text = exploded[3];
            }
        }*/

        private void btnTest_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(BindingList<Player>));
            using (StreamWriter wr = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HallOfFame.xml")))
            {
                MessageBox.Show(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HallOfFame.xml"));
                xs.Serialize(wr, l);
            }
        }
    }
}
