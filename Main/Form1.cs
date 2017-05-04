using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
=======
using System.Diagnostics;
using E.Deezer;
using System.IO;
using System.Net;
using NAudio.Wave;
using System.Threading.Tasks;
using System.ComponentModel;
>>>>>>> origin/master

namespace Main
{
    public partial class form_main : Form
    {
        Params p = new Params();
        List<Player> players = new List<Player>();
        int nbr_music = 0;
        int actual = 0;
        List<String> songSelect = new List<string>();
        List<string> descriptions = new List<string>();
        List<string> covers = new List<string>();
        private BackgroundWorker _bw;
        private WaveOut player = new WaveOut(WaveCallbackInfo.FunctionCallback());

        public form_main()
        {
            InitializeComponent();
<<<<<<< HEAD
            ReadXml();
            showHighscores();
=======

            _bw = new BackgroundWorker();
            _bw.WorkerSupportsCancellation = true;
            _bw.DoWork += PlayMp3FromUrl;
>>>>>>> origin/master
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            main_tabs.TabPages.Remove(tab_game);
            main_tabs.TabPages.Remove(tab_end);
            main_tabs.TabPages.Remove(tab_arbitre);
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            List<string> tmp_joueurs = new List<string>();
            List<string> joueurs = new List<string>();
            List<string> genre = new List<string>();

            tmp_joueurs.Add(tb_p1.Text);
            tmp_joueurs.Add(tb_p2.Text);
            tmp_joueurs.Add(tb_p3.Text);
            tmp_joueurs.Add(tb_p4.Text);
            tmp_joueurs.Add(tb_p5.Text);
            tmp_joueurs.Add(tb_p6.Text);
            tmp_joueurs.Add(tb_p7.Text);
            tmp_joueurs.Add(tb_p8.Text);

            foreach(string txt in tmp_joueurs)
            {
                if(txt != "")
                {
                    joueurs.Add(txt);
                }
            }
            
            foreach (object itemChecked in clb_genre.CheckedItems)
            {
                if (clb_genre.GetItemChecked(16))
                {
                    genre.Add(tb_perso_genre.Text);
                }
                else
                {
                    genre.Add(itemChecked.ToString());
                }
            }

            if(joueurs.Count < 2 || genre.Count == 0)
            {
                MessageBox.Show("Entrez au moins un joueur et sélectionnez au moins un genre !");
            } else
            {
                p.Joueurs = joueurs;
                p.Genres = genre;
                nbr_music = p.Nbr_chansons-1;

                get_arbitre();
            }
        }

        private void game()
        {
            int x = 20;
            int y = 20;
            int i = 1;

            foreach(Player p in players)
            {
                if(p.Is_arbitre != 1)
                {
                    Button rb = new Button();
                    rb.Text = p.Pseudo;
                    rb.Location = new Point(x, y);
                    rb.Click += new System.EventHandler(this.winner_clickAsync);
                    y += 40;

                    gb_round_winner.Controls.Add(rb);
                    i++;

                    if (i % 2 == 1)
                    {
                        x += 130;
                        y = 20;
                    }
                }
            }
            label_howmany.Text = actual+1 + "/" + (nbr_music+1);
        }

<<<<<<< HEAD

        // DEBUT GESTION DES HIGHSCORES

        List<Player> listOfFame = new List<Player>();
        List<Player> listOfFame2 = new List<Player>();
        String debug = Path.GetDirectoryName(Application.ExecutablePath) + "\\HallOfFame.xml";

        public void ReadXml()
        {
            if (File.Exists(debug))
            {
                Console.WriteLine("If, file exists.");

                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));

                StreamReader reader = new StreamReader(debug);
                listOfFame = (List<Player>)serializer.Deserialize(reader);
                reader.Close();
            }
            else
            {
                Console.WriteLine("Else, file !exists.");

                foreach(Player p in players)
                {
                    Player playeeer = new Player("0", 0, 0, 0);
                    listOfFame.Add(playeeer);
                }

                XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
                using (StreamWriter sw = new StreamWriter(debug))
                {
                    MessageBox.Show(debug);
                    xs.Serialize(sw, listOfFame);
                }
            }
        }

        private void determineHighscore()
        {
            foreach (Player plr in players)
            {
                if (plr.Score > plr.High_score)
                {
                    Player PlayersScores = new Player(plr.Pseudo, 0, plr.Id_team, plr.Score, plr.Score);
                    listOfFame2.Add(PlayersScores);
                }
                else
                {
                    Player PlayersScores = new Player(plr.Pseudo, 0, plr.Id_team, plr.Score, plr.High_score);
                    listOfFame2.Add(PlayersScores);
                }
                
                Console.WriteLine(plr.Pseudo + "\n");
                Console.WriteLine(plr.Id_team + "\n");
                Console.WriteLine(plr.Score + "\n");
                Console.WriteLine(plr.High_score + "\n");
                
            }
        }

        private void initiatingSerialization()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
            using (StreamWriter sw = new StreamWriter(debug))
            {
                MessageBox.Show(debug);
                xs.Serialize(sw, listOfFame2);
            }
        }

        private void showHighscores()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));

            StreamReader reader = new StreamReader(debug);

            listOfFame = (List<Player>)serializer.Deserialize(reader);
            reader.Close();

            int x = 20;
            int y = 20;
            
            foreach (Player plyr in listOfFame)
            {
                Label phs = new Label();
                phs.Text = plyr.Pseudo + " " + plyr.High_score;
                phs.Location = new Point(x, y);
                y += 40;

                tab_hs_highscores.Controls.Add(phs);
            }
        }
        // FIN GESTION DES HIGHSCORES

        private void winner_click(object sender, EventArgs e)
=======
        private void winner_clickAsync(object sender, EventArgs e)
>>>>>>> origin/master
        {
            Debug.WriteLine(actual);
            if (actual < nbr_music)
            {
<<<<<<< HEAD
                Player p = players.Find(x => x.Pseudo == (((Button)sender).Text));
                p.Score++;
                actual++;

                label_howmany.Text = actual + "/" + nbr_music;
=======
                if (_bw != null && _bw.IsBusy)
                {
                    Debug.WriteLine("Is Busy");
                    Debug.WriteLine("" + _bw.CancellationPending);
                    _bw.CancelAsync();
                    Debug.WriteLine("" + _bw.CancellationPending);
                    actual++;
                    Debug.WriteLine("Is Run");
                    btn_next_song.Visible = true;
                    gb_round_winner.Visible = false;
                    Player p = players.Find(x => x.Pseudo == (((Button)sender).Text));
                    p.Score++;
                }
                if (_bw != null && !_bw.CancellationPending)
                {
                    actual++;
                    Debug.WriteLine("Is Run");
                    btn_next_song.Visible = true;
                    gb_round_winner.Visible = false;
                    Player p = players.Find(x => x.Pseudo == (((Button)sender).Text));
                    p.Score++;
                }
>>>>>>> origin/master
            }
            else
            {
                _bw.CancelAsync();
                main_tabs.TabPages.Remove(tab_game);
                main_tabs.TabPages.Add(tab_end);

                int x = 20;
                int y = 20;
                foreach (Player p in players)
                {
                    if (p.Is_arbitre != 1)
                    {
                        Label rb = new Label();
                        rb.Text = p.Pseudo + " " + p.Score;
                        rb.Location = new Point(x, y);
                        y += 40;
                        gb_vainqueur.Controls.Add(rb);
                    }
                }
                
                determineHighscore();
                initiatingSerialization();
            }
        }

        private void btn_next_song_Click(object sender, EventArgs e)
        {
            description.Text = descriptions[actual];
            label_howmany.Text = actual + 1 + "/" + (nbr_music + 1);
            gb_round_winner.Visible = true;
            btn_next_song.Visible = false;
            _bw.RunWorkerAsync();
        }

        private void rb_court_CheckedChanged(object sender, EventArgs e)
        {
            p.Nbr_chansons = 10;
        }

        private void rb_moyen_CheckedChanged(object sender, EventArgs e)
        {
            p.Nbr_chansons = 20;
        }

        private void rb_long_CheckedChanged(object sender, EventArgs e)
        {
            p.Nbr_chansons = 30;
        }

        private void spinner_perso_ValueChanged(object sender, EventArgs e)
        {
            if (rb_perso.Checked)
            {
                p.Nbr_chansons = Int32.Parse(spinner_perso.Text) + 1;
            }
        }

        private void rb_perso_CheckedChanged(object sender, EventArgs e)
        {
            p.Nbr_chansons = Int32.Parse(spinner_perso.Text);
        }

        private void get_arbitre()
        {
            Random rnd = new Random();

            main_tabs.TabPages.Remove(tab_rules);
            main_tabs.TabPages.Remove(tab_params);
            main_tabs.TabPages.Remove(tab_hs);
            main_tabs.TabPages.Add(tab_arbitre);

            int r = rnd.Next(p.Joueurs.Count);
            label_arbitre.Text = (string)p.Joueurs[r];

            set_players(r);

        }

        private void set_players(int arbitre)
        {
            int i = 0;
            foreach(string pl in p.Joueurs)
            {
                if(i == arbitre)
                {
                    players.Add(new Player(pl, 1, 0, 0));
                } else
                {
                    players.Add(new Player(pl, 0, 0, 0));
                }
                i++;
            }
            players.Add(new Player("Personne", 0, 0, 0));
        }

        private async void btn_play_Click(object sender, EventArgs e)
        {
            main_tabs.TabPages.Remove(tab_arbitre);
            main_tabs.TabPages.Add(tab_game);

            game();
            List<String> songs = new List<string>();
            List<String> cov = new List<string>();
            List<String> des = new List<string>();
            var deezer = DeezerSession.CreateNew();
            foreach (var value in p.Genres)
            {
                Debug.WriteLine(value);
                var search = await deezer.Search.Playlists(value,1);
                foreach (var v in search)
                {
                    foreach (var s in await v.GetTracks())
                    {
                        if(s.Preview != "")
                        {
                            Debug.WriteLine(s.Title + "-" + s.Preview);
                            songs.Add(s.Preview);
                            des.Add(s.ArtistName + " - " + s.Title);
                            cov.Add("https://www.google.fr/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwinhKThoNbTAhVG7hoKHeHfDh0QjRwIBw&url=https%3A%2F%2Fwww.teepublic.com%2Ft-shirt%2F120734-pikachu-music&psig=AFQjCNGl7eNrncoE-OwaOz06f-M-Bc0KLg&ust=1493987882305435");
                            //songs.Add(s.Title + "-" + s.Preview);
                        }
                    }
                }
            }
            Shuffle(songs, cov, des, p.Nbr_chansons);
            Debug.WriteLine("SONGS DE LA PARTIE");
            foreach(var deb in songSelect)
            {
                Debug.WriteLine(deb.ToString());
            }
            description.Text = descriptions[actual];
            _bw.RunWorkerAsync();
        }

        private void Shuffle (List<string> list, List<string> listC, List<string> listD, int number)
        {
            int n = list.Count;
            Random rng = new Random();
            List<int> listR = new List<int>();
            while (number >0)
            {
                if (n > 1)
                {
                    int k = rng.Next(n);
                    if (!listR.Contains(k))
                    {
                        listR.Add(k);
                        Debug.WriteLine(k);
                        songSelect.Add(list[k]);
                        covers.Add(listC[k]);
                        descriptions.Add(listD[k]);
                        number--;
                    }
                }
            }
        }

        private void ll_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

<<<<<<< HEAD
        private void btn_play_music_Click(object sender, EventArgs e)
        {

        }

        private void tab_hs_highscores_Enter(object sender, EventArgs e)
        {

=======
        private void PlayMp3FromUrl(object sender, DoWorkEventArgs e)
        {
            using (Stream ms = new MemoryStream())
            {
                using (Stream stream = WebRequest.Create(this.songSelect[this.actual])
                    .GetResponse().GetResponseStream())
                {
                    byte[] buffer = new byte[32768];
                    int read;
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                }

                ms.Position = 0;
                using (WaveStream blockAlignedStream =
                    new BlockAlignReductionStream(
                        WaveFormatConversionStream.CreatePcmStream(
                            new Mp3FileReader(ms))))
                {
                        player.Init(blockAlignedStream);
                        player.Play();
                        while (player.PlaybackState == PlaybackState.Playing)
                        {
                            if (_bw.CancellationPending)
                            {
                                e.Cancel = true;
                                return;
                            }
                            System.Threading.Thread.Sleep(100);
                        }

                }
                ms.Close();
            }

        }

        private void btn_rejouer_Click(object sender, EventArgs e)
        {
            main_tabs.TabPages.Remove(tab_game);
            main_tabs.TabPages.Remove(tab_end);

            main_tabs.TabPages.Add(tab_rules);
            main_tabs.TabPages.Add(tab_params);
            main_tabs.TabPages.Add(tab_hs);

            songSelect = new List<string>();
            descriptions = new List<string>();
            covers = new List<string>();

            nbr_music = 0;
            actual = 0;
            players = new List<Player>();
            p = new Params();
>>>>>>> origin/master
        }
    }
}
