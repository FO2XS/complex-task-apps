--Очищение всех заполненных таблиц
TRUNCATE public.users_bet RESTART IDENTITY CASCADE;
TRUNCATE public.users RESTART IDENTITY CASCADE;
TRUNCATE public.possible_bets RESTART IDENTITY CASCADE;
TRUNCATE public.events RESTART IDENTITY CASCADE;
TRUNCATE public.type_of_bets RESTART IDENTITY CASCADE;
TRUNCATE public.sports RESTART IDENTITY CASCADE;

-- Заполнение таблиц данными
--for users 100

INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('laoreet@turpisnec.co.uk','16590824 0178','Faith','Kevyn','Bean','0352'),('sagittis.felis.Donec@Suspendisseac.co.uk','16250726 9187','Bradley','Dylan','Mcmahon','4002'),('ac@sedleo.edu','16730308 4458','Lucius','Upton','Harding','4308'),('sed@sitamet.com','16300216 2406','Amanda','Celeste','Battle','2422'),('ligula.Nullam@sedsapien.co.uk','16960805 3956','Bruno','Ryan','Oconnor','0180'),('torquent@vestibulumneque.com','16930717 9052','Rinah','Michelle','Snow','5073'),('ipsum@at.com','16091210 9345','Geraldine','Josiah','Cross','7697'),('montes@consequat.com','16910230 3345','Xaviera','Hedy','Wooten','5272'),('ante.blandit.viverra@nullaDonec.net','16310801 9161','Lucius','Idola','Nicholson','4644'),('lobortis@justoPraesentluctus.co.uk','16590818 9284','Marshall','Arden','Rice','3682');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('orci@Etiam.com','16720207 9864','Lunea','Linus','Scott','0758'),('Aliquam.erat@Pellentesquetincidunttempus.co.uk','16140612 4907','Hoyt','TaShya','Sharpe','5534'),('magna.Suspendisse@lacusQuisqueimperdiet.com','16581205 3634','Ayanna','Amery','Barry','3647'),('vel.convallis.in@enimgravidasit.com','16840306 9480','Imogene','Ursula','Campos','6831'),('ac.metus.vitae@faucibus.ca','16601218 4526','Octavius','Travis','Dejesus','5821'),('luctus.aliquet@erat.com','16460429 5040','Abra','Aspen','Stout','0068'),('Integer.in@Proin.net','16581205 9045','Laurel','Brett','Moore','6590'),('rhoncus.Proin.nisl@Maurisblandit.co.uk','16380304 9240','Gannon','Vance','House','3092'),('velit.Cras@facilisis.org','16610212 5223','Daryl','Tyrone','Thompson','1333'),('tristique@sapien.co.uk','16391118 0614','Ila','Halla','Fox','1239');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('luctus.ipsum.leo@mollis.com','16380506 7091','Quail','Ignatius','Wright','9989'),('nulla@Utsagittislobortis.net','16090109 6990','Marshall','Shafira','Finch','5806'),('Fusce.feugiat@dis.co.uk','16571216 3707','Coby','Ferdinand','Patterson','7181'),('vulputate.velit@sitamet.com','16170411 9120','Lunea','Adria','Wilkins','1350'),('a.sollicitudin@loremtristique.ca','16190810 0793','Jason','Unity','Valenzuela','8411'),('placerat@non.ca','16070607 7062','Maxine','Wesley','Coffey','4306'),('enim.Nunc@pellentesqueegetdictum.org','16781023 7227','Lee','Cyrus','Bush','4557'),('amet.consectetuer@felispurus.org','16301129 1840','Lynn','Noelle','Underwood','0521'),('Phasellus.vitae.mauris@Sedpharetra.com','16760809 3204','Cameran','Blaine','Glass','5317'),('sit@eratvolutpat.co.uk','16240415 9705','Leah','Wayne','Bates','8177');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('sem@consectetueradipiscing.edu','16101129 7163','Walter','Ariel','Hays','4701'),('tristique@egetmetuseu.net','16000610 4764','David','Plato','Francis','7539'),('et.euismod@mollis.ca','16470208 6879','Fiona','Willow','Dickerson','8566'),('morbi@et.com','16881117 9384','Melvin','Rylee','Ryan','4123'),('Vivamus.sit@nislNulla.net','16440203 2751','Aristotle','Rachel','Russo','1688'),('eros.nec@ametrisusDonec.edu','16920815 4691','Kathleen','Katelyn','Mitchell','6894'),('libero.Proin.mi@utnullaCras.net','16430607 6425','August','Hayden','Miles','2734'),('Nullam.nisl@tempuslorem.com','16211229 8589','Ethan','Joshua','Wagner','4348'),('consectetuer.adipiscing.elit@turpisIn.com','16310714 6072','Lynn','Zelda','Fowler','2840'),('massa.Integer@sapiencursus.org','16761008 0710','Olympia','Ulla','Montgomery','1804');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('amet@at.net','16610823 5430','Cain','Nigel','Marsh','4049'),('convallis.convallis@dolordolor.co.uk','16621115 0625','Shellie','Justine','Dudley','9494'),('tellus@utsemNulla.org','16561102 2608','Chancellor','Slade','Cooke','9530'),('enim.Nunc.ut@velitQuisque.net','16631215 3148','Evan','Summer','Quinn','7194'),('vulputate@Donecsollicitudin.net','16610123 6153','Odysseus','Chantale','Clark','8629'),('magnis@sagittislobortis.net','16160726 3272','Xandra','Aurora','Shepard','7604'),('ultricies.dignissim.lacus@mi.edu','16501222 4076','Zia','Ashely','Mccarthy','1097'),('Sed.molestie@miAliquam.edu','16900307 9176','Walker','Taylor','Richards','6444'),('mauris.erat.eget@Vestibulumaccumsan.org','16590829 8697','Sydnee','Paul','Romero','3312'),('Sed@quamCurabiturvel.net','16250124 7965','Gareth','Mikayla','Boyd','1287');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('Nunc.ut@purusMaecenas.edu','16340715 8595','Medge','Dai','Gentry','3577'),('ornare.lectus.justo@felisullamcorperviverra.edu','16531202 5223','Octavius','Yuri','Roy','3152'),('hendrerit@Quisqueac.co.uk','16320616 1261','Shannon','Teegan','Anthony','0440'),('fringilla.porttitor@tinciduntnunc.com','16951109 0293','John','Dustin','Townsend','1022'),('Curabitur@etmagnis.org','16001006 4293','Hayden','Stacey','Kerr','8556'),('gravida.non.sollicitudin@enim.org','16081022 7637','Guy','Cole','Steele','6804'),('mauris.Suspendisse@Pellentesque.ca','16561010 3433','Sydnee','Damon','Stewart','4756'),('turpis@loremtristiquealiquet.ca','16941022 8879','Tad','Alea','Mathews','7620'),('diam@anteVivamus.com','16350609 0723','Josiah','Merrill','Santos','3874'),('mauris.rhoncus@Nuncmaurissapien.com','16320618 7597','Rudyard','Dustin','Holloway','9293');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('vehicula@convallisantelectus.edu','16021006 3764','Skyler','Orla','Jordan','3166'),('gravida.sagittis@vitaesodales.co.uk','16950427 0498','Hedy','Maggie','Gay','2008'),('Morbi.vehicula@diam.co.uk','16031013 9043','Zahir','Wang','Blankenship','5623'),('semper.tellus@Phaselluselitpede.co.uk','16580230 4856','Hyatt','Naida','Medina','1773'),('nulla@elitsed.org','16250808 0781','Gay','Micah','Vega','0282'),('cursus.purus@Maurismolestie.com','16771021 7600','Constance','Yuri','Kelly','2609'),('lectus.a.sollicitudin@acmattisornare.net','16441120 3799','Breanna','Martina','Snyder','4290'),('parturient.montes.nascetur@utipsum.ca','16920416 0965','Rina','Mikayla','Wise','9491'),('at@nonenimcommodo.co.uk','16410829 9183','Molly','Bruce','Woodard','6210'),('commodo@pellentesqueeget.net','16211124 2141','Adara','Blake','Gonzales','4594');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('inceptos@convallis.org','16820222 5564','Adara','Nasim','Lloyd','1081'),('urna.justo.faucibus@vulputatelacus.edu','16540910 4030','Emerson','Lucas','Osborne','2016'),('nec.eleifend@ullamcorper.edu','16930209 9065','Rosalyn','Dominic','Wolf','8399'),('ipsum.Curabitur.consequat@metusfacilisis.edu','16631201 6832','Dillon','Hadassah','Hess','3965'),('Maecenas.mi@arcu.edu','16001221 6495','Kasimir','Iris','Taylor','1069'),('facilisi.Sed.neque@adipiscinglobortisrisus.co.uk','16530311 4911','Selma','Hanae','Wiley','0258'),('dolor.sit.amet@blanditviverra.com','16690410 4103','Georgia','Kendall','Simpson','9961'),('Vivamus.nibh@bibendum.org','16360919 5361','Aaron','Iola','Calhoun','8718'),('libero.Proin@loremtristique.org','16451227 3717','Alfonso','Kylynn','Torres','5454'),('dolor@nisiMaurisnulla.edu','16830730 6673','Wing','Cruz','Hinton','2462');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('Curae@tincidunt.ca','16101117 6011','Irene','Ciara','Holland','9841'),('dictum.magna.Ut@sedest.ca','16061116 7248','Bruce','Cally','Mckee','6096'),('lorem@enim.com','16711205 9204','Adam','Kimberley','Gilliam','7555'),('ultricies.dignissim@diamat.ca','16270614 9073','Xanthus','Lillian','Sharp','4506'),('eu.ultrices@nibh.org','16881213 6631','Harper','Evangeline','Mullins','4301'),('metus.In@nisidictumaugue.org','16960415 8049','Arsenio','Jessica','Luna','4986'),('ac.eleifend.vitae@non.com','16301005 1559','Olympia','Donna','Dunn','8851'),('felis.eget@scelerisquenequeNullam.edu','16891206 2752','Kibo','Rahim','Hebert','7455'),('Nullam@sitametluctus.edu','16971126 5976','Driscoll','Jerome','Clements','8235'),('urna@ipsumCurabiturconsequat.ca','16760725 3742','Hayden','Brenna','Mcgee','5993');
INSERT INTO "users" (email,password,nickname,name,surname,balance) VALUES ('et.ultrices@dolor.com','16330220 5772','Rana','Xander','Richmond','2944'),('Donec@Namporttitor.org','16160503 0129','Michael','Carolyn','Marks','2248'),('um@velitegetlaoreet.com','16710111 9340','Eve','Sylvester','Dyer','6829'),('pretium@ac.co.uk','16280806 1010','Leroy','Sandra','Sykes','0555'),('massa@scelerisquemollisPhasellus.co.uk','16220109 1580','Hayden','Omar','Webster','1405'),('et@variusultricesmauris.com','16720712 9557','Dominic','McKenzie','Acevedo','2213'),('Fusce.aliquet.magna@blandit.co.uk','16590404 9425','Chantale','Andrew','Morse','7474'),('sit@massaInteger.edu','16220117 5433','August','Yardley','Grant','7619'),('turpis.egestas.Fusce@fringillaest.ca','16590729 6858','Elizabeth','Vance','Chandler','6799'),('ut.mi@Praesenteunulla.ca','16681122 5561','Maya','Henry','Horne','9584');
-- for sports 2 rows
INSERT INTO public.sports(title) VALUES ('Counter Strike'), ('League of Legends');

-- for teams 22rows
INSERT INTO public.teams(title)
	VALUES ('Astralis'), ('T1'), ('Fnatic'), ('Natus Vincere'), ('Virtus.pro'), ('SK Gaming'),('Team Liquid'),('FaZe Clan'),('mousesports'),('Ninjas in Pyjamas');
INSERT INTO public.teams(title)
	VALUES ('Samsung Galaxy'),('Royal Never Give Up'),('Cloud9'),('G2 Esports'),('Invictus Gaming'),('Team Envy'),('G2 Esports'),('Gambit Esports'),('Team Vitality'),('EDward Gaming'),('MIBR'),('FPX Esports');

--for events 100 rows

INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (1,5,18,'03/10/2020'),(1,10,20,'02/03/2021'),(2,3,22,'27/11/2020'),(2,6,7,'11/12/2020'),(1,2,7,'09/07/2021'),(1,3,18,'30/09/2021'),(2,20,4,'07/03/2022'),(1,16,2,'28/09/2020'),(2,21,17,'25/10/2021'),(1,3,16,'03/12/2021');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (2,21,20,'15/08/2021'),(1,9,21,'29/03/2020'),(2,7,14,'27/02/2021'),(1,22,17,'18/03/2022'),(2,15,10,'30/04/2021'),(2,13,15,'29/10/2020'),(2,15,11,'14/11/2021'),(2,4,7,'03/12/2021'),(2,8,22,'07/06/2021'),(2,13,3,'01/03/2021');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (2,10,3,'06/05/2021'),(1,3,10,'26/02/2021'),(1,13,8,'05/07/2020'),(2,9,5,'14/10/2021'),(1,21,22,'09/08/2020'),(2,17,6,'13/03/2022'),(1,4,14,'23/08/2021'),(2,19,5,'08/04/2021'),(2,12,11,'22/08/2021'),(2,9,4,'07/01/2021');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (2,14,12,'14/12/2020'),(1,6,10,'02/07/2020'),(2,19,16,'24/09/2020'),(1,4,3,'29/07/2020'),(1,17,12,'03/01/2021'),(2,16,15,'23/08/2021'),(2,19,13,'25/01/2022'),(2,12,10,'14/08/2021'),(2,8,7,'02/04/2021'),(2,14,1,'14/05/2020');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (1,11,5,'19/08/2021'),(1,15,13,'05/12/2020'),(2,1,14,'26/04/2021'),(1,12,1,'06/05/2021'),(1,13,17,'25/09/2020'),(2,12,17,'25/10/2021'),(1,13,5,'03/12/2021'),(2,9,22,'13/10/2021'),(2,12,1,'30/07/2020'),(2,12,6,'27/02/2021');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (2,2,12,'24/05/2021'),(1,13,22,'11/02/2022'),(1,5,18,'22/09/2020'),(1,3,15,'25/06/2021'),(1,5,8,'28/02/2021'),(2,20,10,'18/02/2022'),(1,19,22,'31/05/2020'),(2,18,15,'16/12/2021'),(2,1,17,'24/06/2020'),(2,5,12,'18/09/2020');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (1,16,6,'11/06/2021'),(2,1,11,'09/08/2020'),(1,14,8,'04/06/2021'),(1,10,14,'27/11/2021'),(1,14,3,'23/03/2022'),(2,1,17,'04/02/2022'),(2,11,16,'27/09/2020'),(1,10,7,'26/04/2021'),(1,6,18,'12/12/2020'),(2,5,8,'14/04/2020');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (1,11,17,'19/05/2020'),(2,12,11,'24/06/2020'),(2,6,20,'05/11/2020'),(2,10,11,'15/07/2020'),(1,7,11,'12/03/2021'),(1,8,20,'09/08/2020'),(2,16,22,'08/03/2021'),(1,14,6,'09/05/2020'),(1,14,21,'08/01/2022'),(2,13,2,'23/08/2020');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (2,12,16,'12/09/2021'),(2,11,22,'20/01/2022'),(1,22,14,'10/04/2020'),(1,20,11,'22/10/2020'),(2,7,1,'05/10/2021'),(2,12,1,'15/07/2021'),(1,9,3,'22/11/2021'),(1,6,3,'28/06/2021'),(2,3,22,'30/04/2020'),(1,13,10,'12/10/2021');
INSERT INTO "events" (id_sport,id_team1,id_team2,start_date) VALUES (2,14,13,'27/11/2021'),(2,7,20,'19/10/2021'),(2,12,18,'16/12/2021'),(2,22,2,'13/02/2022'),(2,6,15,'27/09/2021'),(1,17,13,'14/07/2021'),(2,14,21,'06/12/2021'),(1,15,7,'01/12/2021'),(1,15,20,'09/10/2021'),(2,2,20,'26/07/2020');

--for type_of_bets 14 rows
INSERT INTO public.type_of_bets(title)
	VALUES ('Победитель'),('Победитель 1 карты'),('Победитель 2 карты'),('Победитель 3 карты'),('Победитель 4 карты'),('Победитель 5 карты'),('Тотал убийств'),('Длительность карты'),('Фора. Карта 1'),('Фора. Карта 2');
INSERT INTO public.type_of_bets(title)
	VALUES ('Чет/нечёт'),('Первое убийство'),('Фора по картам'),('Тотал по картам');
	
-- for possible_bets 200 rows

INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (47,4,'1.51','1.75',43,395,'true','false','false'),(89,1,'1.21','3.54',25,492,'false','false','false'),(49,6,'2.13','2.72',14,311,'true','false','false'),(35,4,'2.39','1.16',11,497,'true','false','false'),(10,6,'1.58','2.18',42,451,'false','false','false'),(62,10,'3.30','2.08',11,365,'false','false','false'),(14,11,'3.36','1.99',34,308,'true','false','false'),(30,14,'2.89','1.64',39,347,'true','false','false'),(89,12,'2.19','2.57',48,428,'false','false','false'),(87,5,'3.09','2.72',12,473,'true','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (41,5,'2.31','3.55',47,402,'false','false','false'),(52,5,'2.27','1.42',18,382,'true','false','false'),(10,13,'2.88','3.15',17,499,'true','false','false'),(93,10,'3.40','3.31',42,344,'false','false','false'),(44,8,'2.98','1.21',32,365,'false','false','false'),(16,11,'3.29','3.05',38,384,'false','false','false'),(93,3,'2.88','2.39',19,469,'false','false','false'),(96,9,'2.97','3.37',32,350,'true','false','false'),(83,1,'1.54','1.94',37,313,'false','false','false'),(44,11,'3.54','1.19',38,375,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (91,9,'2.58','2.50',43,472,'false','false','false'),(16,14,'3.46','2.13',40,321,'true','false','false'),(22,6,'1.08','1.78',36,353,'false','false','false'),(56,5,'2.21','1.73',28,407,'false','false','false'),(13,9,'1.92','2.12',42,303,'false','false','false'),(30,6,'2.50','1.96',22,477,'false','false','false'),(95,14,'2.41','1.58',28,427,'false','false','false'),(84,7,'3.32','2.89',50,422,'false','false','false'),(90,6,'2.56','3.32',10,401,'false','false','false'),(97,9,'1.40','3.02',50,366,'true','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (15,10,'1.06','3.35',43,310,'true','false','false'),(62,7,'2.16','3.29',15,320,'true','false','false'),(30,6,'1.70','1.35',48,359,'true','false','false'),(92,7,'2.33','1.51',42,495,'true','false','false'),(91,3,'2.05','2.47',27,401,'false','false','false'),(11,14,'3.36','2.92',44,356,'true','false','false'),(89,8,'2.11','2.65',31,376,'false','false','false'),(92,6,'1.15','2.71',29,441,'false','false','false'),(71,8,'3.52','1.07',15,322,'true','false','false'),(62,1,'3.39','1.59',44,429,'true','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (94,6,'2.29','1.06',17,406,'false','false','false'),(59,6,'1.97','3.30',17,384,'false','false','false'),(39,12,'1.34','1.84',40,500,'false','false','false'),(31,2,'2.54','3.56',38,327,'false','false','false'),(88,14,'1.31','2.10',21,496,'false','false','false'),(84,11,'2.63','2.95',23,468,'true','false','false'),(79,3,'3.27','1.87',15,445,'true','false','false'),(33,12,'2.99','1.41',13,382,'false','false','false'),(21,7,'1.97','3.46',37,440,'true','false','false'),(85,3,'1.50','3.13',30,367,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (88,12,'1.91','3.47',30,356,'true','false','false'),(11,4,'2.38','1.37',41,345,'false','false','false'),(93,14,'2.49','2.71',23,339,'false','false','false'),(53,4,'2.91','2.17',13,372,'true','false','false'),(85,10,'3.16','1.25',48,451,'false','false','false'),(88,5,'2.72','1.79',22,435,'true','false','false'),(51,4,'2.60','2.52',37,452,'false','false','false'),(63,5,'2.15','3.19',22,443,'true','false','false'),(69,14,'1.44','1.75',45,350,'false','false','false'),(93,9,'1.25','2.17',35,414,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (46,3,'2.99','1.23',15,396,'false','false','false'),(5,8,'2.07','1.79',36,390,'false','false','false'),(25,13,'3.52','1.48',26,303,'true','false','false'),(94,6,'3.02','3.06',28,456,'false','false','false'),(1,1,'3.20','2.47',34,349,'true','false','false'),(34,3,'1.91','1.76',47,495,'false','false','false'),(48,11,'3.38','2.22',45,365,'true','false','false'),(47,10,'2.89','1.50',18,455,'true','false','false'),(83,7,'1.46','2.00',16,341,'true','false','false'),(76,2,'3.46','3.08',48,499,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (38,8,'1.92','3.30',43,379,'true','false','false'),(75,2,'1.46','3.42',46,426,'false','false','false'),(66,1,'3.50','2.10',12,447,'false','false','false'),(20,11,'1.89','3.17',47,493,'true','false','false'),(32,5,'1.39','1.63',10,423,'true','false','false'),(21,12,'2.50','3.55',20,372,'true','false','false'),(20,13,'1.92','3.50',26,441,'true','false','false'),(33,14,'3.47','1.28',28,456,'true','false','false'),(84,8,'1.38','3.52',21,394,'true','false','false'),(2,6,'2.03','3.45',16,448,'true','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (20,11,'2.29','1.43',34,342,'false','false','false'),(38,10,'3.15','3.38',17,356,'true','false','false'),(34,2,'2.35','2.00',22,467,'true','false','false'),(44,11,'3.15','1.66',22,341,'true','false','false'),(43,8,'1.07','1.94',37,437,'true','false','false'),(93,4,'2.33','1.44',25,306,'false','false','false'),(40,11,'1.25','2.06',40,452,'false','false','false'),(77,9,'3.21','1.10',16,300,'false','false','false'),(30,14,'1.47','3.17',47,333,'true','false','false'),(98,10,'1.72','2.60',50,370,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (76,5,'2.63','2.15',26,344,'false','false','false'),(96,13,'2.93','2.07',11,420,'true','false','false'),(46,7,'2.29','3.18',14,395,'true','false','false'),(10,9,'3.54','1.95',14,391,'true','false','false'),(87,11,'3.40','3.53',38,367,'true','false','false'),(41,3,'1.79','2.70',27,418,'false','false','false'),(9,3,'2.12','1.57',18,309,'true','false','false'),(85,1,'2.75','1.24',24,416,'true','false','false'),(26,13,'1.67','2.68',18,420,'true','false','false'),(36,7,'1.84','3.27',32,345,'true','false','false');

INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (73,8,'1.74','2.93',15,419,'true','false','false'),(14,8,'1.78','2.05',36,433,'true','false','false'),(20,8,'3.05','2.69',34,347,'true','false','false'),(45,8,'1.48','3.50',33,387,'true','false','false'),(58,8,'3.52','1.38',45,397,'false','false','false'),(20,2,'2.53','1.90',45,491,'true','false','false'),(93,3,'2.32','1.63',28,327,'false','false','false'),(73,11,'2.89','1.65',38,304,'true','false','false'),(72,8,'2.59','1.17',10,400,'false','false','false'),(45,12,'1.88','3.06',23,305,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (48,7,'1.44','1.66',31,348,'true','false','false'),(83,8,'2.48','3.23',20,308,'false','false','false'),(13,5,'3.30','2.90',35,415,'false','false','false'),(40,1,'3.21','3.09',13,342,'true','false','false'),(41,8,'2.38','1.23',33,367,'false','false','false'),(37,5,'2.88','2.36',33,419,'false','false','false'),(28,6,'1.09','1.22',41,396,'false','false','false'),(7,9,'1.83','1.92',46,303,'false','false','false'),(82,6,'3.44','3.53',42,428,'false','false','false'),(16,14,'1.99','2.32',14,390,'true','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (31,8,'3.25','3.34',23,346,'true','false','false'),(91,13,'3.03','2.71',45,499,'false','false','false'),(99,11,'1.92','1.50',26,399,'true','false','false'),(80,14,'3.45','3.27',34,402,'true','false','false'),(57,5,'3.01','1.33',16,403,'true','false','false'),(99,6,'3.03','2.99',44,357,'true','false','false'),(13,1,'3.56','2.30',46,440,'false','false','false'),(10,4,'1.05','2.50',38,492,'true','false','false'),(9,14,'1.95','1.99',49,303,'false','false','false'),(11,9,'2.04','3.04',38,419,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (75,11,'2.07','2.79',49,356,'false','false','false'),(61,4,'1.28','2.70',41,357,'false','false','false'),(93,12,'1.09','1.94',34,482,'false','false','false'),(42,2,'2.19','1.30',49,339,'true','false','false'),(49,9,'3.24','2.76',25,440,'true','false','false'),(71,2,'2.89','1.38',39,473,'false','false','false'),(19,5,'2.33','3.13',21,472,'false','false','false'),(55,7,'2.15','2.40',26,493,'false','false','false'),(20,6,'1.32','2.58',39,397,'false','false','false'),(93,12,'1.31','2.09',41,477,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (1,9,'2.85','1.35',38,396,'false','false','false'),(81,3,'3.56','1.48',39,438,'true','false','false'),(4,5,'2.20','1.88',37,490,'true','false','false'),(42,13,'2.22','3.26',21,319,'true','false','false'),(58,6,'2.18','3.56',13,433,'true','false','false'),(19,3,'2.45','1.63',37,348,'false','false','false'),(17,4,'1.66','2.79',24,466,'false','false','false'),(51,1,'3.39','1.07',39,379,'true','false','false'),(63,1,'2.53','3.27',47,475,'false','false','false'),(51,10,'1.83','1.89',31,450,'true','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (65,12,'1.11','2.80',43,441,'true','false','false'),(35,7,'2.46','2.70',31,358,'false','false','false'),(53,10,'3.41','3.14',49,390,'true','false','false'),(13,5,'1.15','2.34',42,378,'true','false','false'),(72,5,'1.43','3.02',29,424,'true','false','false'),(5,5,'1.99','2.83',29,342,'false','false','false'),(86,1,'2.88','1.80',16,497,'false','false','false'),(80,2,'1.94','1.77',50,372,'true','false','false'),(82,1,'2.09','1.51',37,337,'true','false','false'),(47,2,'1.61','2.19',13,360,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (30,3,'3.03','1.13',14,362,'true','false','false'),(57,3,'1.87','1.95',22,350,'false','false','false'),(9,7,'2.36','3.56',24,438,'false','false','false'),(49,11,'2.68','2.99',22,473,'true','false','false'),(57,4,'2.75','2.12',19,342,'false','false','false'),(46,1,'1.37','1.88',27,372,'true','false','false'),(79,8,'3.15','2.28',10,348,'true','false','false'),(6,10,'1.73','1.51',15,300,'true','false','false'),(52,12,'3.20','1.26',29,390,'false','false','false'),(97,14,'2.49','3.38',12,305,'true','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (46,5,'2.63','2.90',29,421,'true','false','false'),(3,2,'1.74','2.37',11,433,'true','false','false'),(91,11,'1.54','2.51',25,441,'false','false','false'),(24,9,'1.85','3.03',37,455,'false','false','false'),(79,11,'2.56','1.06',17,373,'false','false','false'),(50,10,'2.43','2.85',16,412,'false','false','false'),(34,2,'2.48','2.80',20,484,'true','false','false'),(56,11,'1.35','1.90',35,460,'false','false','false'),(16,1,'2.22','1.47',32,320,'false','false','false'),(71,11,'1.77','1.31',10,470,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (30,10,'1.28','1.06',27,426,'true','false','false'),(24,9,'2.98','1.07',24,417,'false','false','false'),(37,3,'2.68','2.91',40,478,'false','false','false'),(90,7,'3.08','3.25',22,447,'true','false','false'),(7,14,'1.44','2.72',37,488,'true','false','false'),(9,12,'3.12','3.33',28,489,'false','false','false'),(5,3,'1.57','3.51',39,448,'false','false','false'),(72,14,'1.25','1.21',30,335,'true','false','false'),(97,10,'3.48','1.59',46,471,'false','false','false'),(60,8,'2.08','2.45',17,428,'false','false','false');
INSERT INTO "possible_bets" (id_event,id_tob,coef1,coef2,min,max,is_available,is_past,to_archive) VALUES (44,6,'2.15','2.70',16,339,'true','false','false'),(18,3,'3.01','1.15',21,353,'false','false','false'),(87,3,'1.11','1.27',10,437,'true','false','false'),(66,3,'1.68','3.16',16,441,'false','false','false'),(8,9,'1.27','3.53',20,400,'true','false','false'),(7,11,'2.33','2.70',19,362,'true','false','false'),(50,7,'2.03','1.91',43,421,'false','false','false'),(14,9,'1.15','2.15',21,306,'false','false','false'),(78,4,'3.05','2.76',34,458,'false','false','false'),(8,5,'3.40','1.46',34,454,'true','false','false');

-- for users_bet 200rows

INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (50,186,'2.11','2,55','false'),(79,197,'2.49','1,61','false'),(36,143,'1.76','1,87','false'),(17,57,'1.30','3,03','false'),(82,40,'1.18','4,74','false'),(23,36,'2.03','4,41','false'),(28,154,'1.94','1,23','false'),(72,153,'2.16','1,48','false'),(83,196,'1.57','2,23','false'),(64,182,'1.31','2,32','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (40,95,'1.69','2,80','false'),(96,30,'3.26','1,20','false'),(95,93,'1.81','1,35','false'),(38,33,'1.94','0,93','false'),(18,183,'3.42','2,31','false'),(69,28,'2.40','2,38','false'),(6,142,'2.53','2,34','false'),(40,186,'2.47','2,62','false'),(87,111,'3.52','2,90','false'),(4,40,'3.02','3,12','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (7,35,'2.50','0,63','false'),(21,11,'1.50','4,54','false'),(66,147,'2.51','1,48','false'),(86,61,'3.14','1,11','false'),(47,172,'3.46','2,49','false'),(8,49,'2.43','1,64','false'),(95,84,'2.39','2,63','false'),(19,17,'2.43','2,71','false'),(82,3,'2.67','1,05','false'),(7,25,'3.47','3,83','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (42,39,'3.00','4,95','false'),(52,172,'2.82','3,82','false'),(84,116,'2.20','0,77','false'),(20,48,'2.94','4,90','false'),(94,173,'1.06','4,08','false'),(67,138,'1.99','3,05','false'),(77,8,'1.58','2,85','false'),(56,49,'1.46','1,27','false'),(5,198,'2.27','1,29','false'),(35,84,'3.44','2,05','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (29,14,'3.17','4,70','false'),(100,111,'1.87','4,32','false'),(54,77,'1.23','2,22','false'),(23,118,'2.73','4,60','false'),(77,73,'1.20','2,95','false'),(63,145,'1.70','1,11','false'),(54,71,'2.37','2,02','false'),(66,33,'3.28','3,12','false'),(91,200,'1.49','3,83','false'),(12,111,'2.95','0,80','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (27,96,'1.62','1,65','false'),(98,13,'1.75','4,54','false'),(70,115,'1.88','3,43','false'),(93,108,'1.45','2,38','false'),(89,166,'2.43','2,01','false'),(43,70,'1.71','3,16','false'),(85,177,'3.43','1,20','false'),(40,92,'2.09','3,05','false'),(87,12,'1.06','4,31','false'),(67,196,'1.24','2,71','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (68,198,'1.33','2,51','false'),(66,5,'1.85','3,62','false'),(16,7,'2.53','4,40','false'),(55,124,'1.97','3,95','false'),(8,179,'3.32','3,65','false'),(98,156,'1.36','2,87','false'),(62,155,'2.94','2,16','false'),(57,183,'1.75','1,27','false'),(48,178,'2.18','2,11','false'),(29,30,'2.75','3,60','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (15,56,'3.50','0,84','false'),(41,105,'2.49','3,35','false'),(33,58,'2.62','4,33','false'),(99,151,'1.16','4,16','false'),(24,137,'2.89','1,09','false'),(59,160,'2.25','0,84','false'),(51,104,'2.55','3,56','false'),(7,195,'2.85','0,81','false'),(32,125,'1.29','3,57','false'),(50,132,'2.09','3,56','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (52,185,'1.92','1,95','false'),(17,35,'2.14','1,10','false'),(45,86,'2.74','2,07','false'),(74,91,'3.52','4,53','false'),(44,199,'2.27','2,16','false'),(84,57,'2.56','4,84','false'),(59,173,'3.10','3,85','false'),(51,47,'2.53','2,25','false'),(25,39,'1.73','3,89','false'),(11,198,'3.25','4,58','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (43,149,'3.52','4,43','false'),(66,55,'2.83','3,75','false'),(13,152,'3.48','1,89','false'),(36,102,'1.60','0,59','false'),(55,22,'1.51','2,55','false'),(61,141,'2.00','4,96','false'),(32,130,'2.43','4,61','false'),(72,92,'2.46','2,22','false'),(14,180,'1.42','1,76','false'),(48,132,'1.52','3,93','false');

INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (24,111,'1.18','4,87','false'),(55,180,'2.95','3,37','false'),(68,66,'3.34','4,16','false'),(78,156,'2.98','1,68','false'),(24,22,'3.17','1,41','false'),(61,47,'2.04','0,75','false'),(80,169,'2.62','0,99','false'),(11,76,'1.90','1,84','false'),(51,74,'3.29','1,95','false'),(21,143,'1.86','4,92','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (38,65,'3.41','2,55','false'),(95,163,'1.46','1,18','false'),(38,70,'2.40','1,99','false'),(100,188,'2.90','3,11','false'),(14,192,'2.72','3,04','false'),(85,123,'1.64','4,77','false'),(7,71,'1.16','2,92','false'),(74,126,'2.77','3,44','false'),(6,173,'2.60','4,43','false'),(92,93,'1.16','4,87','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (93,152,'1.28','4,58','false'),(15,100,'2.69','4,56','false'),(42,151,'2.55','4,19','false'),(56,16,'1.79','1,36','false'),(60,179,'1.21','4,28','false'),(27,24,'1.16','1,32','false'),(9,24,'2.73','0,80','false'),(12,4,'1.39','3,28','false'),(98,1,'3.36','4,21','false'),(8,170,'2.26','4,10','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (63,111,'3.42','1,33','false'),(7,190,'2.04','2,19','false'),(89,94,'2.62','3,43','false'),(10,155,'1.43','1,01','false'),(43,49,'2.23','4,57','false'),(8,54,'3.45','3,01','false'),(16,86,'2.55','2,94','false'),(82,61,'2.29','0,89','false'),(79,186,'2.49','4,19','false'),(51,14,'2.43','1,07','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (2,87,'2.18','1,16','false'),(31,26,'2.51','2,20','false'),(20,163,'1.98','4,35','false'),(23,198,'1.95','2,38','false'),(73,119,'1.65','0,81','false'),(3,3,'3.01','3,37','false'),(81,61,'2.24','4,24','false'),(56,61,'1.86','2,73','false'),(51,107,'1.49','2,25','false'),(37,58,'2.04','2,90','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (29,160,'1.65','1,22','false'),(93,161,'1.51','0,56','false'),(80,139,'2.24','2,82','false'),(67,187,'3.39','0,51','false'),(77,53,'1.47','2,21','false'),(28,138,'2.30','3,55','false'),(45,175,'2.50','1,85','false'),(73,55,'1.55','3,17','false'),(15,157,'2.05','3,00','false'),(61,22,'3.29','3,19','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (2,125,'2.41','2,98','false'),(99,189,'2.50','1,82','false'),(62,43,'2.81','4,27','false'),(83,1,'1.50','2,85','false'),(94,86,'1.61','0,60','false'),(86,192,'2.43','4,13','false'),(75,161,'1.43','1,22','false'),(82,120,'1.51','3,93','false'),(32,8,'3.36','4,17','false'),(57,21,'2.33','1,59','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (58,103,'1.60','3,71','false'),(10,157,'2.78','4,73','false'),(11,150,'1.32','2,33','false'),(44,200,'3.03','2,33','false'),(24,35,'1.49','4,35','false'),(16,6,'2.81','2,96','false'),(77,144,'1.90','4,21','false'),(4,72,'1.73','2,43','false'),(44,86,'2.85','3,52','false'),(2,168,'1.21','2,06','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (62,47,'2.01','1,33','false'),(87,189,'3.01','4,27','false'),(73,40,'1.43','4,00','false'),(98,25,'2.24','3,51','false'),(31,88,'1.25','4,30','false'),(34,173,'3.09','2,07','false'),(83,124,'1.63','4,05','false'),(88,106,'2.24','1,46','false'),(21,184,'1.72','1,82','false'),(66,197,'1.54','0,62','false');
INSERT INTO "users_bet" (id_user,id_pos_bet,coef,sum,to_archive) VALUES (41,96,'1.13','4,64','false'),(30,8,'2.04','0,85','false'),(88,102,'2.75','4,44','false'),(88,192,'1.21','1,70','false'),(94,81,'2.89','0,75','false'),(94,57,'2.05','4,37','false'),(92,121,'2.75','3,88','false'),(16,71,'2.12','4,07','false'),(89,167,'2.19','1,75','false'),(24,24,'1.84','1,88','false');
