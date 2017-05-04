namespace Main
{
    partial class form_main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.main_tabs = new System.Windows.Forms.TabControl();
            this.tab_rules = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_params = new System.Windows.Forms.TabPage();
            this.btn_go = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clb_genre = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spinner_perso = new System.Windows.Forms.NumericUpDown();
            this.rb_perso = new System.Windows.Forms.RadioButton();
            this.rb_long = new System.Windows.Forms.RadioButton();
            this.rb_moyen = new System.Windows.Forms.RadioButton();
            this.rb_court = new System.Windows.Forms.RadioButton();
            this.l_p8 = new System.Windows.Forms.Label();
            this.l_p7 = new System.Windows.Forms.Label();
            this.tb_p8 = new System.Windows.Forms.TextBox();
            this.l_p6 = new System.Windows.Forms.Label();
            this.l_p5 = new System.Windows.Forms.Label();
            this.l_p4 = new System.Windows.Forms.Label();
            this.l_p3 = new System.Windows.Forms.Label();
            this.l_p2 = new System.Windows.Forms.Label();
            this.l_p1 = new System.Windows.Forms.Label();
            this.tb_p7 = new System.Windows.Forms.TextBox();
            this.tb_p6 = new System.Windows.Forms.TextBox();
            this.tb_p5 = new System.Windows.Forms.TextBox();
            this.tb_p4 = new System.Windows.Forms.TextBox();
            this.tb_p3 = new System.Windows.Forms.TextBox();
            this.tb_p2 = new System.Windows.Forms.TextBox();
            this.tb_p1 = new System.Windows.Forms.TextBox();
            this.tab_arbitre = new System.Windows.Forms.TabPage();
            this.btn_play = new System.Windows.Forms.Button();
            this.label_arbitre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_game = new System.Windows.Forms.TabPage();
            this.label_howmany = new System.Windows.Forms.Label();
            this.gb_round_winner = new System.Windows.Forms.GroupBox();
            this.tab_end = new System.Windows.Forms.TabPage();
            this.gb_vainqueur = new System.Windows.Forms.GroupBox();
            this.tab_hs = new System.Windows.Forms.TabPage();
            this.btn_rejouer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_perso_genre = new System.Windows.Forms.TextBox();
            this.main_tabs.SuspendLayout();
            this.tab_rules.SuspendLayout();
            this.tab_params.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner_perso)).BeginInit();
            this.tab_arbitre.SuspendLayout();
            this.tab_game.SuspendLayout();
            this.tab_end.SuspendLayout();
            this.gb_vainqueur.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tabs
            // 
            this.main_tabs.Controls.Add(this.tab_rules);
            this.main_tabs.Controls.Add(this.tab_params);
            this.main_tabs.Controls.Add(this.tab_arbitre);
            this.main_tabs.Controls.Add(this.tab_game);
            this.main_tabs.Controls.Add(this.tab_end);
            this.main_tabs.Controls.Add(this.tab_hs);
            this.main_tabs.Location = new System.Drawing.Point(12, 12);
            this.main_tabs.Name = "main_tabs";
            this.main_tabs.SelectedIndex = 0;
            this.main_tabs.Size = new System.Drawing.Size(1094, 603);
            this.main_tabs.TabIndex = 0;
            // 
            // tab_rules
            // 
            this.tab_rules.Controls.Add(this.label8);
            this.tab_rules.Controls.Add(this.label7);
            this.tab_rules.Controls.Add(this.label6);
            this.tab_rules.Controls.Add(this.label5);
            this.tab_rules.Controls.Add(this.label4);
            this.tab_rules.Controls.Add(this.label1);
            this.tab_rules.ForeColor = System.Drawing.Color.Black;
            this.tab_rules.Location = new System.Drawing.Point(4, 22);
            this.tab_rules.Name = "tab_rules";
            this.tab_rules.Padding = new System.Windows.Forms.Padding(3);
            this.tab_rules.Size = new System.Drawing.Size(1086, 577);
            this.tab_rules.TabIndex = 0;
            this.tab_rules.Text = "Règles";
            this.tab_rules.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(605, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "4. Jouer ! Celui qui trouve le plus de musique gagne la partie !";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(790, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "3. L\'arbitre de la partie est sélectionner aléatoirement, lui seul pourra voir l\'" +
    "écran !";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(587, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "2. Définir les genres de musique ainsi que la durée de jeu ...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "1. Commencer par entrer tous les joueurs !";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bienvenue dans BlindTest !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les règles sont simples ...";
            // 
            // tab_params
            // 
            this.tab_params.Controls.Add(this.btn_go);
            this.tab_params.Controls.Add(this.label2);
            this.tab_params.Controls.Add(this.groupBox2);
            this.tab_params.Controls.Add(this.groupBox1);
            this.tab_params.Controls.Add(this.l_p8);
            this.tab_params.Controls.Add(this.l_p7);
            this.tab_params.Controls.Add(this.tb_p8);
            this.tab_params.Controls.Add(this.l_p6);
            this.tab_params.Controls.Add(this.l_p5);
            this.tab_params.Controls.Add(this.l_p4);
            this.tab_params.Controls.Add(this.l_p3);
            this.tab_params.Controls.Add(this.l_p2);
            this.tab_params.Controls.Add(this.l_p1);
            this.tab_params.Controls.Add(this.tb_p7);
            this.tab_params.Controls.Add(this.tb_p6);
            this.tab_params.Controls.Add(this.tb_p5);
            this.tab_params.Controls.Add(this.tb_p4);
            this.tab_params.Controls.Add(this.tb_p3);
            this.tab_params.Controls.Add(this.tb_p2);
            this.tab_params.Controls.Add(this.tb_p1);
            this.tab_params.Location = new System.Drawing.Point(4, 22);
            this.tab_params.Name = "tab_params";
            this.tab_params.Padding = new System.Windows.Forms.Padding(3);
            this.tab_params.Size = new System.Drawing.Size(1086, 577);
            this.tab_params.TabIndex = 1;
            this.tab_params.Text = "Paramètres";
            this.tab_params.UseVisualStyleBackColor = true;
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(981, 527);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 23);
            this.btn_go.TabIndex = 21;
            this.btn_go.Text = "Musique !";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Liste des joueurs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_perso_genre);
            this.groupBox2.Controls.Add(this.clb_genre);
            this.groupBox2.Location = new System.Drawing.Point(483, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 301);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genres";
            // 
            // clb_genre
            // 
            this.clb_genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_genre.CheckOnClick = true;
            this.clb_genre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clb_genre.FormattingEnabled = true;
            this.clb_genre.Items.AddRange(new object[] {
            "Rock",
            "Rap",
            "Blues",
            "Jazz",
            "Anime",
            "Classical",
            "Comedy",
            "Dance (EDM)",
            "Holiday",
            "Instrumental",
            "Soundtrack",
            "World",
            "Vocal",
            "Reggae",
            "R&B",
            "Hip/Hop - Jazz",
            "Personnalisé"});
            this.clb_genre.Location = new System.Drawing.Point(15, 19);
            this.clb_genre.Name = "clb_genre";
            this.clb_genre.Size = new System.Drawing.Size(143, 270);
            this.clb_genre.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spinner_perso);
            this.groupBox1.Controls.Add(this.rb_perso);
            this.groupBox1.Controls.Add(this.rb_long);
            this.groupBox1.Controls.Add(this.rb_moyen);
            this.groupBox1.Controls.Add(this.rb_court);
            this.groupBox1.Location = new System.Drawing.Point(777, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 136);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Durée";
            // 
            // spinner_perso
            // 
            this.spinner_perso.Location = new System.Drawing.Point(171, 88);
            this.spinner_perso.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinner_perso.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinner_perso.Name = "spinner_perso";
            this.spinner_perso.Size = new System.Drawing.Size(40, 20);
            this.spinner_perso.TabIndex = 4;
            this.spinner_perso.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinner_perso.ValueChanged += new System.EventHandler(this.spinner_perso_ValueChanged);
            // 
            // rb_perso
            // 
            this.rb_perso.AutoSize = true;
            this.rb_perso.Location = new System.Drawing.Point(6, 88);
            this.rb_perso.Name = "rb_perso";
            this.rb_perso.Size = new System.Drawing.Size(158, 17);
            this.rb_perso.TabIndex = 3;
            this.rb_perso.TabStop = true;
            this.rb_perso.Text = "Personnalisé (5 min/50 max)";
            this.rb_perso.UseVisualStyleBackColor = true;
            this.rb_perso.CheckedChanged += new System.EventHandler(this.rb_perso_CheckedChanged);
            // 
            // rb_long
            // 
            this.rb_long.AutoSize = true;
            this.rb_long.Location = new System.Drawing.Point(6, 65);
            this.rb_long.Name = "rb_long";
            this.rb_long.Size = new System.Drawing.Size(117, 17);
            this.rb_long.TabIndex = 2;
            this.rb_long.TabStop = true;
            this.rb_long.Text = "Long (30 musiques)";
            this.rb_long.UseVisualStyleBackColor = true;
            this.rb_long.CheckedChanged += new System.EventHandler(this.rb_long_CheckedChanged);
            // 
            // rb_moyen
            // 
            this.rb_moyen.AutoSize = true;
            this.rb_moyen.Location = new System.Drawing.Point(6, 42);
            this.rb_moyen.Name = "rb_moyen";
            this.rb_moyen.Size = new System.Drawing.Size(125, 17);
            this.rb_moyen.TabIndex = 1;
            this.rb_moyen.TabStop = true;
            this.rb_moyen.Text = "Moyen (20 musiques)";
            this.rb_moyen.UseVisualStyleBackColor = true;
            this.rb_moyen.CheckedChanged += new System.EventHandler(this.rb_moyen_CheckedChanged);
            // 
            // rb_court
            // 
            this.rb_court.AutoSize = true;
            this.rb_court.Checked = true;
            this.rb_court.Location = new System.Drawing.Point(6, 19);
            this.rb_court.Name = "rb_court";
            this.rb_court.Size = new System.Drawing.Size(118, 17);
            this.rb_court.TabIndex = 0;
            this.rb_court.TabStop = true;
            this.rb_court.Text = "Court (10 musiques)";
            this.rb_court.UseVisualStyleBackColor = true;
            this.rb_court.CheckedChanged += new System.EventHandler(this.rb_court_CheckedChanged);
            // 
            // l_p8
            // 
            this.l_p8.AutoSize = true;
            this.l_p8.Location = new System.Drawing.Point(57, 410);
            this.l_p8.Name = "l_p8";
            this.l_p8.Size = new System.Drawing.Size(48, 13);
            this.l_p8.TabIndex = 16;
            this.l_p8.Text = "Joueur 8";
            // 
            // l_p7
            // 
            this.l_p7.AutoSize = true;
            this.l_p7.Location = new System.Drawing.Point(57, 372);
            this.l_p7.Name = "l_p7";
            this.l_p7.Size = new System.Drawing.Size(48, 13);
            this.l_p7.TabIndex = 15;
            this.l_p7.Text = "Joueur 7";
            // 
            // tb_p8
            // 
            this.tb_p8.Location = new System.Drawing.Point(122, 407);
            this.tb_p8.MaxLength = 20;
            this.tb_p8.Name = "tb_p8";
            this.tb_p8.Size = new System.Drawing.Size(279, 20);
            this.tb_p8.TabIndex = 14;
            // 
            // l_p6
            // 
            this.l_p6.AutoSize = true;
            this.l_p6.Location = new System.Drawing.Point(57, 337);
            this.l_p6.Name = "l_p6";
            this.l_p6.Size = new System.Drawing.Size(48, 13);
            this.l_p6.TabIndex = 13;
            this.l_p6.Text = "Joueur 6";
            // 
            // l_p5
            // 
            this.l_p5.AutoSize = true;
            this.l_p5.Location = new System.Drawing.Point(57, 299);
            this.l_p5.Name = "l_p5";
            this.l_p5.Size = new System.Drawing.Size(48, 13);
            this.l_p5.TabIndex = 12;
            this.l_p5.Text = "Joueur 5";
            // 
            // l_p4
            // 
            this.l_p4.AutoSize = true;
            this.l_p4.Location = new System.Drawing.Point(57, 260);
            this.l_p4.Name = "l_p4";
            this.l_p4.Size = new System.Drawing.Size(48, 13);
            this.l_p4.TabIndex = 11;
            this.l_p4.Text = "Joueur 4";
            // 
            // l_p3
            // 
            this.l_p3.AutoSize = true;
            this.l_p3.Location = new System.Drawing.Point(57, 223);
            this.l_p3.Name = "l_p3";
            this.l_p3.Size = new System.Drawing.Size(48, 13);
            this.l_p3.TabIndex = 10;
            this.l_p3.Text = "Joueur 3";
            // 
            // l_p2
            // 
            this.l_p2.AutoSize = true;
            this.l_p2.Location = new System.Drawing.Point(57, 184);
            this.l_p2.Name = "l_p2";
            this.l_p2.Size = new System.Drawing.Size(48, 13);
            this.l_p2.TabIndex = 9;
            this.l_p2.Text = "Joueur 2";
            // 
            // l_p1
            // 
            this.l_p1.AutoSize = true;
            this.l_p1.Location = new System.Drawing.Point(57, 147);
            this.l_p1.Name = "l_p1";
            this.l_p1.Size = new System.Drawing.Size(48, 13);
            this.l_p1.TabIndex = 8;
            this.l_p1.Text = "Joueur 1";
            // 
            // tb_p7
            // 
            this.tb_p7.Location = new System.Drawing.Point(122, 369);
            this.tb_p7.MaxLength = 20;
            this.tb_p7.Name = "tb_p7";
            this.tb_p7.Size = new System.Drawing.Size(279, 20);
            this.tb_p7.TabIndex = 6;
            // 
            // tb_p6
            // 
            this.tb_p6.Location = new System.Drawing.Point(122, 334);
            this.tb_p6.MaxLength = 20;
            this.tb_p6.Name = "tb_p6";
            this.tb_p6.Size = new System.Drawing.Size(279, 20);
            this.tb_p6.TabIndex = 5;
            // 
            // tb_p5
            // 
            this.tb_p5.Location = new System.Drawing.Point(122, 297);
            this.tb_p5.MaxLength = 20;
            this.tb_p5.Name = "tb_p5";
            this.tb_p5.Size = new System.Drawing.Size(279, 20);
            this.tb_p5.TabIndex = 4;
            // 
            // tb_p4
            // 
            this.tb_p4.Location = new System.Drawing.Point(122, 258);
            this.tb_p4.MaxLength = 20;
            this.tb_p4.Name = "tb_p4";
            this.tb_p4.Size = new System.Drawing.Size(279, 20);
            this.tb_p4.TabIndex = 3;
            // 
            // tb_p3
            // 
            this.tb_p3.Location = new System.Drawing.Point(122, 221);
            this.tb_p3.MaxLength = 20;
            this.tb_p3.Name = "tb_p3";
            this.tb_p3.Size = new System.Drawing.Size(279, 20);
            this.tb_p3.TabIndex = 2;
            // 
            // tb_p2
            // 
            this.tb_p2.Location = new System.Drawing.Point(122, 182);
            this.tb_p2.MaxLength = 20;
            this.tb_p2.Name = "tb_p2";
            this.tb_p2.Size = new System.Drawing.Size(279, 20);
            this.tb_p2.TabIndex = 1;
            // 
            // tb_p1
            // 
            this.tb_p1.Location = new System.Drawing.Point(122, 145);
            this.tb_p1.MaxLength = 20;
            this.tb_p1.Name = "tb_p1";
            this.tb_p1.Size = new System.Drawing.Size(279, 20);
            this.tb_p1.TabIndex = 0;
            // 
            // tab_arbitre
            // 
            this.tab_arbitre.Controls.Add(this.label9);
            this.tab_arbitre.Controls.Add(this.btn_play);
            this.tab_arbitre.Controls.Add(this.label_arbitre);
            this.tab_arbitre.Controls.Add(this.label3);
            this.tab_arbitre.Location = new System.Drawing.Point(4, 22);
            this.tab_arbitre.Name = "tab_arbitre";
            this.tab_arbitre.Padding = new System.Windows.Forms.Padding(3);
            this.tab_arbitre.Size = new System.Drawing.Size(1086, 577);
            this.tab_arbitre.TabIndex = 5;
            this.tab_arbitre.Text = "Arbitre";
            this.tab_arbitre.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(517, 514);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "C\'est parti !";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // label_arbitre
            // 
            this.label_arbitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_arbitre.AutoSize = true;
            this.label_arbitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_arbitre.Location = new System.Drawing.Point(453, 238);
            this.label_arbitre.Name = "label_arbitre";
            this.label_arbitre.Size = new System.Drawing.Size(221, 73);
            this.label_arbitre.TabIndex = 1;
            this.label_arbitre.Text = "Arbitre";
            this.label_arbitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(860, 73);
            this.label3.TabIndex = 0;
            this.label3.Text = "L\'arbitre de cette partie est ...";
            // 
            // tab_game
            // 
            this.tab_game.Controls.Add(this.label_howmany);
            this.tab_game.Controls.Add(this.gb_round_winner);
            this.tab_game.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab_game.Location = new System.Drawing.Point(4, 22);
            this.tab_game.Name = "tab_game";
            this.tab_game.Padding = new System.Windows.Forms.Padding(3);
            this.tab_game.Size = new System.Drawing.Size(1086, 577);
            this.tab_game.TabIndex = 2;
            this.tab_game.Text = "Jeu";
            this.tab_game.UseVisualStyleBackColor = true;
            // 
            // label_howmany
            // 
            this.label_howmany.AutoSize = true;
            this.label_howmany.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_howmany.Location = new System.Drawing.Point(1056, 3);
            this.label_howmany.Name = "label_howmany";
            this.label_howmany.Size = new System.Drawing.Size(24, 13);
            this.label_howmany.TabIndex = 1;
            this.label_howmany.Text = "0/0";
            // 
            // gb_round_winner
            // 
            this.gb_round_winner.Location = new System.Drawing.Point(241, 432);
            this.gb_round_winner.Name = "gb_round_winner";
            this.gb_round_winner.Size = new System.Drawing.Size(546, 100);
            this.gb_round_winner.TabIndex = 0;
            this.gb_round_winner.TabStop = false;
            this.gb_round_winner.Text = "Vainqueur de la manche";
            // 
            // tab_end
            // 
            this.tab_end.Controls.Add(this.gb_vainqueur);
            this.tab_end.Location = new System.Drawing.Point(4, 22);
            this.tab_end.Name = "tab_end";
            this.tab_end.Padding = new System.Windows.Forms.Padding(3);
            this.tab_end.Size = new System.Drawing.Size(1086, 577);
            this.tab_end.TabIndex = 3;
            this.tab_end.Text = "Fin";
            this.tab_end.UseVisualStyleBackColor = true;
            // 
            // gb_vainqueur
            // 
            this.gb_vainqueur.Controls.Add(this.btn_rejouer);
            this.gb_vainqueur.Location = new System.Drawing.Point(60, 32);
            this.gb_vainqueur.Name = "gb_vainqueur";
            this.gb_vainqueur.Size = new System.Drawing.Size(978, 521);
            this.gb_vainqueur.TabIndex = 0;
            this.gb_vainqueur.TabStop = false;
            this.gb_vainqueur.Text = "Vainqueur ...";
            // 
            // tab_hs
            // 
            this.tab_hs.Location = new System.Drawing.Point(4, 22);
            this.tab_hs.Name = "tab_hs";
            this.tab_hs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hs.Size = new System.Drawing.Size(1086, 577);
            this.tab_hs.TabIndex = 4;
            this.tab_hs.Text = "Highscore";
            this.tab_hs.UseVisualStyleBackColor = true;
            // 
            // btn_rejouer
            // 
            this.btn_rejouer.Location = new System.Drawing.Point(448, 460);
            this.btn_rejouer.Name = "btn_rejouer";
            this.btn_rejouer.Size = new System.Drawing.Size(75, 23);
            this.btn_rejouer.TabIndex = 0;
            this.btn_rejouer.Text = "Rejouer";
            this.btn_rejouer.UseVisualStyleBackColor = true;
            this.btn_rejouer.Click += new System.EventHandler(this.btn_rejouer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(720, 73);
            this.label9.TabIndex = 3;
            this.label9.Text = "Lui seul peut voir l\'écran";
            // 
            // tb_perso_genre
            // 
            this.tb_perso_genre.Location = new System.Drawing.Point(15, 275);
            this.tb_perso_genre.Name = "tb_perso_genre";
            this.tb_perso_genre.Size = new System.Drawing.Size(180, 20);
            this.tb_perso_genre.TabIndex = 18;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1118, 627);
            this.Controls.Add(this.main_tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BlindTest";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.main_tabs.ResumeLayout(false);
            this.tab_rules.ResumeLayout(false);
            this.tab_rules.PerformLayout();
            this.tab_params.ResumeLayout(false);
            this.tab_params.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner_perso)).EndInit();
            this.tab_arbitre.ResumeLayout(false);
            this.tab_arbitre.PerformLayout();
            this.tab_game.ResumeLayout(false);
            this.tab_game.PerformLayout();
            this.tab_end.ResumeLayout(false);
            this.gb_vainqueur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl main_tabs;
        private System.Windows.Forms.TabPage tab_rules;
        private System.Windows.Forms.TabPage tab_params;
        private System.Windows.Forms.TabPage tab_game;
        private System.Windows.Forms.TabPage tab_end;
        private System.Windows.Forms.TabPage tab_hs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clb_genre;
        private System.Windows.Forms.Label l_p8;
        private System.Windows.Forms.Label l_p7;
        private System.Windows.Forms.TextBox tb_p8;
        private System.Windows.Forms.Label l_p6;
        private System.Windows.Forms.Label l_p5;
        private System.Windows.Forms.Label l_p4;
        private System.Windows.Forms.Label l_p3;
        private System.Windows.Forms.Label l_p2;
        private System.Windows.Forms.Label l_p1;
        private System.Windows.Forms.TextBox tb_p7;
        private System.Windows.Forms.TextBox tb_p6;
        private System.Windows.Forms.TextBox tb_p5;
        private System.Windows.Forms.TextBox tb_p4;
        private System.Windows.Forms.TextBox tb_p3;
        private System.Windows.Forms.TextBox tb_p2;
        private System.Windows.Forms.TextBox tb_p1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_moyen;
        private System.Windows.Forms.RadioButton rb_court;
        private System.Windows.Forms.RadioButton rb_perso;
        private System.Windows.Forms.RadioButton rb_long;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.NumericUpDown spinner_perso;
        private System.Windows.Forms.TabPage tab_arbitre;
        private System.Windows.Forms.Label label_arbitre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_round_winner;
        private System.Windows.Forms.Label label_howmany;
        private System.Windows.Forms.GroupBox gb_vainqueur;
        private System.Windows.Forms.Button btn_rejouer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_perso_genre;
    }
}

