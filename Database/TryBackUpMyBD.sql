--
-- PostgreSQL database dump
--

-- Dumped from database version 13.1
-- Dumped by pg_dump version 13.2

-- Started on 2021-04-19 14:20:44

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

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 203 (class 1259 OID 16468)
-- Name: events; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.events (
    id integer NOT NULL,
    id_sport integer NOT NULL,
    id_team1 integer NOT NULL,
    id_team2 integer NOT NULL,
    start_date date,
    id_win integer,
    id_lose integer,
    is_past boolean,
    to_archive boolean
);


ALTER TABLE public.events OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16516)
-- Name: events_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.events ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.events_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 206 (class 1259 OID 16486)
-- Name: money_management; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.money_management (
    id integer NOT NULL,
    id_user integer NOT NULL,
    id_oper integer NOT NULL,
    take_or_add boolean NOT NULL,
    sum money NOT NULL,
    date date NOT NULL,
    details text
);


ALTER TABLE public.money_management OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 16514)
-- Name: money_management_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.money_management ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.money_management_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 207 (class 1259 OID 16494)
-- Name: operators; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.operators (
    id integer NOT NULL,
    title character varying(50) NOT NULL,
    details text
);


ALTER TABLE public.operators OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 16512)
-- Name: operators_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.operators ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.operators_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 202 (class 1259 OID 16463)
-- Name: possible_bets; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.possible_bets (
    id integer NOT NULL,
    id_event integer NOT NULL,
    id_tob integer NOT NULL,
    coef1 real NOT NULL,
    coef2 real NOT NULL,
    min money NOT NULL,
    max money,
    is_available boolean NOT NULL,
    margin real,
    is_past boolean NOT NULL,
    to_archive boolean NOT NULL,
    winner boolean
);


ALTER TABLE public.possible_bets OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 16510)
-- Name: possible_bets_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.possible_bets ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.possible_bets_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 205 (class 1259 OID 16481)
-- Name: sports; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sports (
    id integer NOT NULL,
    title character varying(50) NOT NULL
);


ALTER TABLE public.sports OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 16508)
-- Name: sports_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.sports ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.sports_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 204 (class 1259 OID 16473)
-- Name: teams; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.teams (
    id integer NOT NULL,
    title character varying(50) NOT NULL,
    raiting integer,
    percent_win real,
    squadlist text,
    logo text
);


ALTER TABLE public.teams OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 16506)
-- Name: teams_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.teams ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.teams_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 216 (class 1259 OID 16558)
-- Name: type_of_bets; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.type_of_bets (
    id integer NOT NULL,
    title character varying(50) NOT NULL
);


ALTER TABLE public.type_of_bets OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16569)
-- Name: type_of_bets_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.type_of_bets ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.type_of_bets_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 200 (class 1259 OID 16450)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id integer NOT NULL,
    email character varying(50) NOT NULL,
    password text NOT NULL,
    nickname character varying(50),
    name character varying(50) NOT NULL,
    surname character varying(50) NOT NULL,
    balance money NOT NULL
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 201 (class 1259 OID 16458)
-- Name: users_bet; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users_bet (
    id integer NOT NULL,
    id_user integer NOT NULL,
    id_pos_bet integer NOT NULL,
    coef real NOT NULL,
    sum money NOT NULL,
    victory bit(2),
    prize money,
    to_archive boolean
);


ALTER TABLE public.users_bet OWNER TO postgres;

--
-- TOC entry 209 (class 1259 OID 16504)
-- Name: users_bet_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.users_bet ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.users_bet_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 208 (class 1259 OID 16502)
-- Name: users_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.users ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.users_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 2909 (class 2606 OID 16472)
-- Name: events events_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.events
    ADD CONSTRAINT events_pkey PRIMARY KEY (id);


--
-- TOC entry 2915 (class 2606 OID 16493)
-- Name: money_management money_management_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.money_management
    ADD CONSTRAINT money_management_pkey PRIMARY KEY (id);


--
-- TOC entry 2917 (class 2606 OID 16501)
-- Name: operators operators_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.operators
    ADD CONSTRAINT operators_pkey PRIMARY KEY (id);


--
-- TOC entry 2907 (class 2606 OID 16467)
-- Name: possible_bets possible_bets_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.possible_bets
    ADD CONSTRAINT possible_bets_pkey PRIMARY KEY (id);


--
-- TOC entry 2913 (class 2606 OID 16485)
-- Name: sports sports_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sports
    ADD CONSTRAINT sports_pkey PRIMARY KEY (id);


--
-- TOC entry 2911 (class 2606 OID 16480)
-- Name: teams teams_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.teams
    ADD CONSTRAINT teams_pkey PRIMARY KEY (id);


--
-- TOC entry 2919 (class 2606 OID 16562)
-- Name: type_of_bets type_of_bets_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.type_of_bets
    ADD CONSTRAINT type_of_bets_pkey PRIMARY KEY (id);


--
-- TOC entry 2905 (class 2606 OID 16462)
-- Name: users_bet users_bet_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users_bet
    ADD CONSTRAINT users_bet_pkey PRIMARY KEY (id);


--
-- TOC entry 2903 (class 2606 OID 16457)
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);


--
-- TOC entry 2922 (class 2606 OID 16528)
-- Name: possible_bets event_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.possible_bets
    ADD CONSTRAINT event_fkey FOREIGN KEY (id_event) REFERENCES public.events(id) NOT VALID;


--
-- TOC entry 2928 (class 2606 OID 16553)
-- Name: money_management oper_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.money_management
    ADD CONSTRAINT oper_fkey FOREIGN KEY (id_oper) REFERENCES public.operators(id) NOT VALID;


--
-- TOC entry 2921 (class 2606 OID 16523)
-- Name: users_bet posbet_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users_bet
    ADD CONSTRAINT posbet_fkey FOREIGN KEY (id_pos_bet) REFERENCES public.possible_bets(id) NOT VALID;


--
-- TOC entry 2926 (class 2606 OID 16543)
-- Name: events sport_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.events
    ADD CONSTRAINT sport_fkey FOREIGN KEY (id_sport) REFERENCES public.sports(id) NOT VALID;


--
-- TOC entry 2924 (class 2606 OID 16533)
-- Name: events team1_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.events
    ADD CONSTRAINT team1_fkey FOREIGN KEY (id_team1) REFERENCES public.teams(id) NOT VALID;


--
-- TOC entry 2925 (class 2606 OID 16538)
-- Name: events team2_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.events
    ADD CONSTRAINT team2_fkey FOREIGN KEY (id_team2) REFERENCES public.teams(id) NOT VALID;


--
-- TOC entry 2923 (class 2606 OID 16563)
-- Name: possible_bets tob_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.possible_bets
    ADD CONSTRAINT tob_fkey FOREIGN KEY (id_tob) REFERENCES public.type_of_bets(id) NOT VALID;


--
-- TOC entry 2920 (class 2606 OID 16518)
-- Name: users_bet users_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users_bet
    ADD CONSTRAINT users_fkey FOREIGN KEY (id_user) REFERENCES public.users(id) NOT VALID;


--
-- TOC entry 2927 (class 2606 OID 16548)
-- Name: money_management users_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.money_management
    ADD CONSTRAINT users_fkey FOREIGN KEY (id_user) REFERENCES public.users(id) NOT VALID;


-- Completed on 2021-04-19 14:20:45

--
-- PostgreSQL database dump complete
--

