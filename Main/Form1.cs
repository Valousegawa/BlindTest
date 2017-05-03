using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Main
{
    public partial class form_main : Form
    {

        Params p = new Params();
        List<Player> players = new List<Player>();
        int nbr_music = 0;
        int actual = 1;

        public form_main()
        {
            InitializeComponent();
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            main_tabs.TabPages.Remove(tab_game);
            main_tabs.TabPages.Remove(tab_end);
            main_tabs.TabPages.Remove(tab_arbitre);

            ll_login.Links.Add(12, 6, "https://accounts.spotify.com/fr-FR/login");
            ll_login.Links.Add(60, 13, "https://www.spotify.com/fr/download/windows/");
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
                genre.Add(itemChecked.ToString());
            }

            if(joueurs.Count == 0 || genre.Count == 0)
            {
                MessageBox.Show("Entrez au moins un joueur et sélectionner au moins un genre !");
            } else
            {
                p.Joueurs = joueurs;
                p.Genres = genre;
                nbr_music = p.Nbr_chansons;

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
                    rb.Click += new System.EventHandler(this.winner_click);
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
            label_howmany.Text = actual + "/" + nbr_music;
        }

        private void winner_click(object sender, EventArgs e)
        {
            if(actual <= nbr_music)
            {
                Player p = players.Find(x => x.Pseudo == (((Button)sender).Text));
                p.Score++;
                actual++;

                label_howmany.Text = actual + "/" + nbr_music;
            } else
            {
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
            }
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

        private void btn_play_Click(object sender, EventArgs e)
        {
            main_tabs.TabPages.Remove(tab_arbitre);
            main_tabs.TabPages.Add(tab_game);

            game();
        }

        private void ll_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void btn_play_music_Click(object sender, EventArgs e)
        {

        }
    }
}
