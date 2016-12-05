--
-- Contenu de la table `tbl_users`
--

INSERT INTO `tbl_users` (`email`, `password`, `nom_user`) VALUES
('psi@gmail.ch', '', 'psi'),
('john.doe@gmail.ch', '', 'john doe');





--
-- Contenu de la table `tbl_configuration`
--

INSERT INTO `tbl_configuration` (`points_victoire`, `sets_a_la_place_de_buts`, `aller_retour`, `duree_match`) VALUES
(3, 0, 15, 0),
(3, 1, 12, 0);



--
-- Contenu de la table `tbl_tournois`
--

INSERT INTO `tbl_tournois` (`nom_tournoi`, `date_debut`, `date_fin`, `numero_tbl_users`, `numero_tbl_configuration`) VALUES
('Villageois 2017', '2017-03-11 08:30:00', NULL, 1, 1),
('Tournoi romand 2017', '2017-05-20 09:00:00', '2017-05-21 16:00:00', 1, 1),
('six Pack beer', '2016-09-24 08:45:00', NULL, 2, 2);


--
-- Contenu de la table `tbl_terrains`
--

INSERT INTO `tbl_terrains` (`libelle`, `numero_tbl_tournois`) VALUES
('A', 1),
('B', 1),
('A', 2),
('B', 2),
('C', 2),
('A', 3),
('B', 3);

--
-- Contenu de la table `tbl_groupes`
--

INSERT INTO `tbl_groupes` (`libelle`, `numero_tbl_tournois`) VALUES
('A', 1),
('B', 1),
('A', 2),
('B', 2),
('A', 3),
('B', 3),
('C', 3),
('D', 3);




--
-- Contenu de la table `tbl_equipes`
--

INSERT INTO `tbl_equipes` (`nom_responsable`, `nom_equipe`, `prenom_resp`, `telephone`, `mobile`, `email_resp`, `numero_tbl_groupes`) VALUES
('Les poulets au curry', 'Doe', 'John', NULL, NULL, 'j.d@gmail.com', 1),
('Barbe-à-poils', 'Dupont', 'John', NULL, NULL, 'dupont@gmail.com', 1),
('Salt and pepper', 'Donald', '', NULL, NULL, 'Donaldd@gmail.com', 1),
('invicibles', 'Didier', 'John', NULL, NULL, 'didier@gmail.com', 1),
('Les verres pleins', 'Barras', 'Antoie', NULL, NULL, 'barras@gmail.com', 2),
('Barnabs', 'Venuti', 'Adrier', NULL, NULL, 'adrie @gmail.com', 2),
('Les glorius..', 'Ben Saucisson', 'Mo', NULL, NULL, 'Saucisson@gmail.com', 2),
('Les glorius le retour', 'Doe', 'John', NULL, NULL, 'Saucisson@gmail.com', 3),
('Bol de caf', 'Mina', 'Bill', NULL, NULL, 'mina@gmail.com', 3),
('Barbe-à-poils', 'Dupont', 'John', NULL, NULL, 'dupont@gmail.com', 4),
('Salt and pepper', 'Donald', '', NULL, NULL, 'Donaldd@gmail.com', 4),
('invicibles', 'Didier', 'John', NULL, NULL, 'didier@gmail.com', 4),
('Les verres pleins', 'Barras', 'Antoie', NULL, NULL, 'barras@gmail.com', 5),
('Barnabs', 'Venuti', 'Adrier', NULL, NULL, 'adrie @gmail.com', 5),
('Les glorius..', 'Ben Saucisson', 'Mo', NULL, NULL, 'Saucisson@gmail.com', 5),
('Les glorius le retour', 'Doe', 'John', NULL, NULL, 'Saucisson@gmail.com', 5),
('Bol de caf', 'Mina', 'Bill', NULL, NULL, 'mina@gmail.com', 5),
('Barbe-à-poils', 'Dupont', 'John', NULL, NULL, 'dupont@gmail.com', 6),
('Salt and pepper', 'Donald', '', NULL, NULL, 'Donaldd@gmail.com', 6),
('invicibles', 'Didier', 'John', NULL, NULL, 'didier@gmail.com', 6),
('Les verres vide', 'Malherbe', 'Antoine', NULL, NULL, 'barras@gmail.com', 7),
('Vieux mais encore...', 'Valdette', 'Adrien', NULL, NULL, 'valdette@gmail.com', 7),
('Stress under control', 'Paludy', 'Mickey', NULL, NULL, 'mickey@gmail.com', 7),
('Rouge et sang', 'Dorothy', 'Mariquis', NULL, NULL, 'marquis@gmail.com', 7),
('Surtout pour le pire', 'Jaccard', 'Jacques', NULL, NULL, 'jacky@gmail.com', 6),
('Dream team', 'Guigne', 'Maurice', NULL, NULL, 'guigne.maurice@gmail.com', 8),
('Insupportables', 'Bertriac', 'Jean', NULL, NULL, 'Bertriac@gmail.com', 8),
('Fondue chez moi', 'Patricks', 'Paul', NULL, NULL, 'Patricks@gmail.com', 8);




--
-- Contenu de la table `tbl_set_but`
--

INSERT INTO `tbl_set_but` (`nb_pts_du_set`, `numero_tbl_equipes`, `numero_tbl_matchs`) VALUES
(NULL, 1, 1),
(NULL, 1, 2),
(NULL, 1, 1),
(NULL, 1, 2),
(NULL, 1, 1),
(NULL, 1, 2),
(NULL, 2, 3),
(NULL, 1, 2),
(NULL, 2, 3),
(NULL, 7, 3),
(NULL, 2, 4),
(NULL, 7, 3),
(NULL, 5, 2),
(NULL, 7, 3),
(NULL, 5, 2),
(NULL, 8, 2),
(NULL, 5, 3),
(NULL, 8, 2),
(NULL, 5, 3),
(NULL, 8, 4),
(NULL, 5, 2),
(NULL, 9, 6),
(NULL, 6, 5),
(NULL, 9, 7),
(NULL, 7, 3),
(NULL, 9, 7),
(NULL, 7, 3),
(NULL, 9, 6);



--
-- Contenu de la table `tbl_matchs`
--

INSERT INTO `tbl_matchs` (`date_heure`, `numero_tbl_equipes`, `numero_tbl_equipes_1`, `numero_tbl_terrains`, `numero_tbl_equipes_2`) VALUES
('2017-03-11 09:00:00', NULL, 1, 2, 1),
('2017-03-11 09:00:00', NULL, 3, 4, 2),
('2017-03-11 09:15:00', NULL, 5, 6, 1),
('2017-03-11 09:30:00', NULL, 1, 4, 2),
('2017-03-11 09:45:00', NULL, 2, 3, 1),
('2017-03-11 09:45:00', NULL, 5, 7, 2),
('2017-03-11 10:00:00', NULL, 1, 3, 1),
('2017-03-11 10:15:00', NULL, 4, 2, 1),
('2017-03-11 10:15:00', NULL, 6, 7, 2);