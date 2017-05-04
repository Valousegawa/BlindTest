using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.Model;
using System.IO;
using System.Xml.Serialization;

namespace Main
{
    public partial class UserControlRomain : UserControl
    {
        List<Player> listOfFame = new List<Player>();
        Random rnd = new Random();

        String debug = Path.GetDirectoryName(Application.ExecutablePath) + "\\HallOfFame.xml";

        public UserControlRomain()
        {
            InitializeComponent();
            InitXML();
            determineHighscore();
        }

        public void InitXML()
        {
            if (!File.Exists(debug))
            {
                Console.WriteLine("If, file !exists.");

                label_xml.Text = "XML présent";

                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));

                StreamReader reader = new StreamReader(debug);
                listOfFame = (List<Player>)serializer.Deserialize(reader);
                reader.Close();
            }
            else
            {
                //Console.WriteLine("Else, file !exists.");

                String[] pseudos = { "Pseudo 1", "Pseudo 2", "Pseudo 3", "Pseudo 4", "Pseudo 5" };
                int[] idsTeam = { 1, 1, 1, 2, 2 };
                int[] scores = { 150, 20, 350, 40, 560 };
                int[] highscores = { 100, 200, 300, 400, 500 };


                for (int i = 0; i < 5; i++)
                {
                    Player Players = new Player(pseudos[i], idsTeam[i], scores[i], highscores[i]);
                    //Players.infosPlayer();
                    listOfFame.Add(Players);
                }
            }
        }

        private void determineHighscore()
        {

            //Console.WriteLine("Start Get Highscore\n");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
            StreamReader reader = new StreamReader(debug);

            listOfFame = (List<Player>)serializer.Deserialize(reader);
            reader.Close();

            foreach (Player plr in listOfFame)
            {
                //Console.Write(
                //plr.pseudo + "\t" +
                //plr.idTeam + "\t" +
                //plr.score + "\t" +
                //plr.highscore + "\t" +
                //plr.isArbitre + "\n");

                //Console.WriteLine("Joueur : " + plr.pseudo + ", Highscore AVANT modification : " + plr.highscore);

                //Console.WriteLine("Score : " + (plr.score).GetType());
                //Console.WriteLine("HighScore : " + (plr.highscore).GetType());

                //Console.WriteLine(plr.score > plr.highscore);

                if (plr.Score > plr.High_score)
                {
                    plr.High_score = plr.Score;
                    //Console.WriteLine("Entrée de boucle if\n");
                }

                //Console.WriteLine("Joueur : " + plr.pseudo + ", Highscore APRES modification : " + plr.highscore);
            }
            //Console.WriteLine("\n");
            //Console.WriteLine("End Get Highscore\n");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
            using (StreamWriter wr = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HallOfFame.xml")))
            {
                MessageBox.Show(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HallOfFame.xml"));
                xs.Serialize(wr, listOfFame);
            }
        }
    }
}
