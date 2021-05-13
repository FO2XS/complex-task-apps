--
-- PostgreSQL database dump
--

-- Dumped from database version 13.1
-- Dumped by pg_dump version 13.2

-- Started on 2021-04-06 22:06:03

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 3025 (class 0 OID 16473)
-- Dependencies: 204
-- Data for Name: teams; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (3, 'Fnatic', NULL, NULL, NULL, 'https://i.ibb.co/N1rfFnx/fnatic.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (1, 'Astralis', NULL, NULL, NULL, 'https://i.ibb.co/QnVmfmt/Astralis-logo-svg.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (7, 'Team Liquid', NULL, NULL, NULL, 'https://i.ibb.co/3ck016t/Team-Liquid.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (8, 'FaZe Clan', NULL, NULL, NULL, 'https://i.ibb.co/FsTVhxC/Fazeclan.jpg');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (9, 'mousesports', NULL, NULL, NULL, 'https://i.ibb.co/4TCFQTw/Mouse-Sport.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (13, 'Cloud9', NULL, NULL, NULL, 'https://i.ibb.co/h2Qkf74/Cloud9.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (14, 'G2 Esports', NULL, NULL, NULL, 'https://i.ibb.co/YdMYsjN/G2-Esports-2020-Logo-1-884x1024.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (19, 'Team Vitality', NULL, NULL, NULL, 'https://i.ibb.co/8Mc8BwK/Team-Vitality.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (20, 'EDward Gaming', NULL, NULL, NULL, 'https://i.ibb.co/ypV8jsQ/Edward-Gaming.webp');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (5, 'Virtus.pro', NULL, NULL, NULL, 'https://i.ibb.co/26Q1XvW/Virtus-Pro.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (10, 'Ninjas in Pyjamas', NULL, NULL, NULL, 'https://i.ibb.co/HqSbQdX/NiP.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (18, 'Gambit Esports', NULL, NULL, NULL, 'https://i.ibb.co/WfsthSJ/Gambit-Esports.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (16, 'Team Envy', NULL, NULL, NULL, 'https://i.ibb.co/StQf2rL/Team-Envy.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (2, 'T1', NULL, NULL, NULL, 'https://i.ibb.co/G3Jdn6r/T1.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (21, 'MIBR', NULL, NULL, NULL, 'https://i.ibb.co/5hpws4G/Mibr.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (22, 'FPX Esports', NULL, NULL, NULL, 'https://i.ibb.co/5YcmDKS/FPX-Esports.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (6, 'SK Gaming', NULL, NULL, NULL, 'https://i.ibb.co/rtPQ5XD/SK-gaming.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (4, 'Natus Vincere', NULL, NULL, NULL, 'https://i.ibb.co/mRB6ybv/navy.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (17, 'Team Empire', NULL, NULL, NULL, 'https://i.ibb.co/drBJ0sh/EMpire.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (15, 'Invictus Gaming', NULL, NULL, NULL, 'https://i.ibb.co/mJxT6Z4/Invictus-gaming.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (11, 'Samsung Galaxy', NULL, NULL, NULL, 'https://i.ibb.co/GJW8h2h/Samsung-Galaxy.png');
INSERT INTO public.teams (id, title, raiting, percent_win, squadlist, logo) OVERRIDING SYSTEM VALUE VALUES (12, 'Royal Never Give Up', NULL, NULL, NULL, 'https://i.ibb.co/YNMwHdJ/RNGU.png');


--
-- TOC entry 3032 (class 0 OID 0)
-- Dependencies: 210
-- Name: teams_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.teams_id_seq', 1, false);


-- Completed on 2021-04-06 22:06:03

--
-- PostgreSQL database dump complete
--

