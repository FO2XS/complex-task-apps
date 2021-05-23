--DROP DATABASE "BookMakers";

/*CREATE DATABASE "BookMakers" WITH OWNER = FOXXS ENCODING = 'UTF8' LC_COLLATE = 'Russian_Russia.1251' LC_CTYPE = 'Russian_Russia.1251' TABLESPACE = pg_default CONNECTION
LIMIT
    = -1;*/

DROP TABLE public."RoleClaims";
DROP TABLE public."UserRoles";
DROP TABLE public."UserTokens";
DROP TABLE public."UserLogins";
DROP TABLE public."UserClaims";
DROP TABLE public."UserBets";
DROP TABLE public."MoneyManagement";
DROP TABLE public."Users";
DROP TABLE public."Roles";
DROP TABLE public."Operators";
DROP TABLE public."PossibleBets";
DROP TABLE public."Events";
DROP TABLE public."TypeOfBets";
DROP TABLE public."Teams";
DROP TABLE public."Sports";
DROP TABLE public."Tournaments";


CREATE TABLE public."Users" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "UserName" character varying(256) COLLATE pg_catalog."default",
    "NormalizedUserName" character varying(256) COLLATE pg_catalog."default",
    "Email" character varying(256) COLLATE pg_catalog."default",
    "NormalizedEmail" character varying(256) COLLATE pg_catalog."default",
    "EmailConfirmed" boolean NOT NULL,
    "PasswordHash" text COLLATE pg_catalog."default",
    "SecurityStamp" text COLLATE pg_catalog."default",
    "ConcurrencyStamp" text COLLATE pg_catalog."default",
    "PhoneNumber" text COLLATE pg_catalog."default",
    "PhoneNumberConfirmed" boolean NOT NULL,
    "TwoFactorEnabled" boolean NOT NULL,
    "LockoutEnd" timestamp with time zone,
    "LockoutEnabled" boolean NOT NULL,
    "AccessFailedCount" integer NOT NULL,
    "Name" character varying(256) COLLATE pg_catalog."default",
    "Surname" character varying(256) COLLATE pg_catalog."default",
    "Balance" numeric(12,2),
    "Avatar" text COLLATE pg_catalog."default",
    CONSTRAINT "PK_Users" PRIMARY KEY ("Id")
) TABLESPACE pg_default;


CREATE INDEX "EmailIndex" ON public."Users" USING btree (
    "NormalizedEmail" COLLATE pg_catalog."default" ASC NULLS LAST
) TABLESPACE pg_default;

CREATE UNIQUE INDEX "UserNameIndex" ON public."Users" USING btree (
    "NormalizedUserName" COLLATE pg_catalog."default" ASC NULLS LAST
) TABLESPACE pg_default;

CREATE TABLE public."Roles" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "Name" character varying(256) COLLATE pg_catalog."default",
    "NormalizedName" character varying(256) COLLATE pg_catalog."default",
    "ConcurrencyStamp" text COLLATE pg_catalog."default",
    CONSTRAINT "PK_Roles" PRIMARY KEY ("Id")
) TABLESPACE pg_default;


CREATE UNIQUE INDEX "RoleNameIndex" ON public."Roles" USING btree (
    "NormalizedName" COLLATE pg_catalog."default" ASC NULLS LAST
) TABLESPACE pg_default;

CREATE TABLE public."RoleClaims" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "RoleId" integer NOT NULL,
    "ClaimType" text COLLATE pg_catalog."default",
    "ClaimValue" text COLLATE pg_catalog."default",
    CONSTRAINT "PK_RoleClaims" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_RoleClaims_Roles_RoleId" FOREIGN KEY ("RoleId") REFERENCES public."Roles" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE CASCADE
) TABLESPACE pg_default;


CREATE TABLE public."UserRoles" (
    "UserId" integer NOT NULL,
    "RoleId" integer NOT NULL,
    CONSTRAINT "PK_UserRoles" PRIMARY KEY ("UserId", "RoleId"),
    CONSTRAINT "FK_UserRoles_Roles_RoleId" FOREIGN KEY ("RoleId") REFERENCES public."Roles" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE CASCADE,
    CONSTRAINT "FK_UserRoles_Users_UserId" FOREIGN KEY ("UserId") REFERENCES public."Users" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE CASCADE
) TABLESPACE pg_default;


CREATE TABLE public."UserTokens" (
    "UserId" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "LoginProvider" character varying(128) COLLATE pg_catalog."default" NOT NULL,
    "Name" character varying(128) COLLATE pg_catalog."default" NOT NULL,
    "Value" text COLLATE pg_catalog."default",
    CONSTRAINT "PK_UserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name"),
    CONSTRAINT "FK_UserTokens_Users_UserId" FOREIGN KEY ("UserId") REFERENCES public."Users" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE CASCADE
) TABLESPACE pg_default;


CREATE TABLE public."UserLogins" (
    "LoginProvider" character varying(128) COLLATE pg_catalog."default" NOT NULL,
    "ProviderKey" character varying(128) COLLATE pg_catalog."default" NOT NULL,
    "ProviderDisplayName" text COLLATE pg_catalog."default",
    "UserId" integer NOT NULL,
    CONSTRAINT "PK_UserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey"),
    CONSTRAINT "FK_UserLogins_Users_UserId" FOREIGN KEY ("UserId") REFERENCES public."Users" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE CASCADE
) TABLESPACE pg_default;


CREATE TABLE public."UserClaims" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "UserId" integer NOT NULL,
    "ClaimType" text COLLATE pg_catalog."default",
    "ClaimValue" text COLLATE pg_catalog."default",
    CONSTRAINT "PK_UserClaims" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_UserClaims_Users_UserId" FOREIGN KEY ("UserId") REFERENCES public."Users" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE CASCADE
) TABLESPACE pg_default;


CREATE TABLE public."Operators" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "Title" character varying(50) COLLATE pg_catalog."default" NOT NULL,
    "Details" text COLLATE pg_catalog."default",
    CONSTRAINT pk_operators PRIMARY KEY ("Id")
) TABLESPACE pg_default;


CREATE TABLE public."Sports" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "Title" character varying(50) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_users PRIMARY KEY ("Id")
) TABLESPACE pg_default;


CREATE TABLE public."Teams" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "IdSport" integer NOT NULL,
    "Title" character varying(50) COLLATE pg_catalog."default" NOT NULL,
    "Raiting" integer,
    "PercentWin" real,
    "SquadList" text COLLATE pg_catalog."default",
    "Logo" text COLLATE pg_catalog."default",
    CONSTRAINT pk_teams PRIMARY KEY ("Id"),
    CONSTRAINT fk_teams_sports_idsport FOREIGN KEY ("IdSport")
        REFERENCES public."Sports" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
) TABLESPACE pg_default;

CREATE TABLE public."Tournaments"
(
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "Title" text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "Tournaments_pkey" PRIMARY KEY ("Id")
) TABLESPACE pg_default;

CREATE TABLE public."TypeOfBets" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "Title" character varying(50) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_typeofbets PRIMARY KEY ("Id")
) TABLESPACE pg_default;


CREATE TABLE public."Events" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "IdSport" integer NOT NULL,
    "IdTournament" integer,
    "IdTeam1" integer NOT NULL,
    "IdTeam2" integer NOT NULL,
    "StartDate" timestamp with time zone NOT NULL,
    "IdWin" integer,
    "IdLose" integer,
    "IsAvailable" boolean NOT NULL,
    "IsPast" boolean NOT NULL,
    "ToArchive" boolean NOT NULL,
    CONSTRAINT PK_Events PRIMARY KEY ("Id"),
    CONSTRAINT FK_Events_Sports_IdSport FOREIGN KEY ("IdSport") REFERENCES public."Sports" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID,
    CONSTRAINT FK_Events_Teams_IdTeam1 FOREIGN KEY ("IdTeam1") REFERENCES public."Teams" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID,
    CONSTRAINT FK_Events_Teams_IdTeam2 FOREIGN KEY ("IdTeam2") REFERENCES public."Teams" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID,
    CONSTRAINT fk_events_tournaments_idtournaments FOREIGN KEY ("IdTournaments") REFERENCES public."Tournaments" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID
) TABLESPACE pg_default;


CREATE TABLE public."PossibleBets" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "IdEvent" integer NOT NULL,
    "IdTob" integer NOT NULL,
    "Coef1" real NOT NULL,
    "Coef2" real NOT NULL,
    "Min" numeric(12,2) NOT NULL,
    "Max" numeric(12,2) NOT NULL,
    "Margin" real,
    "IsAvalaible" boolean NOT NULL,
    "IsPast" boolean NOT NULL,
    "ToArchive" boolean NOT NULL,
    "Winner" boolean,
    CONSTRAINT PK_PossibleBets PRIMARY KEY ("Id"),
    CONSTRAINT FK_PossibleBets_Events_IdEvent FOREIGN KEY ("IdEvent") REFERENCES public."Events" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID,
    CONSTRAINT FK_PossibleBets_TypeOfBets_IdTob FOREIGN KEY ("IdTob") REFERENCES public."TypeOfBets" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID
) TABLESPACE pg_default;


CREATE TABLE public."UserBets" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "IdUser" integer NOT NULL,
    "IdPosBet" integer NOT NULL,
    "Side" boolean NOT NULL,
    "Coef" real NOT NULL,
    "Sum" numeric(12,2) NOT NULL,
    "Victory" bit(2),
    "Prize" numeric(12,2),
    "ToArchive" boolean NOT NULL,
    CONSTRAINT PK_UserBets PRIMARY KEY ("Id"),
    CONSTRAINT FK_UserBets_PossibleBets_IdPosBet FOREIGN KEY ("IdPosBet") REFERENCES public."PossibleBets" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID,
    CONSTRAINT FK_UserBets_Users_IdUser FOREIGN KEY ("IdUser") REFERENCES public."Users" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID
) TABLESPACE pg_default;


CREATE TABLE public."MoneyManagement" (
    "Id" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY (
        INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1
    ),
    "IdUser" integer NOT NULL,
    "IdOperator" integer NOT NULL,
    "TakeOrAdd" boolean NOT NULL,
    "Sum" numeric(12,2) NOT NULL,
    "Date" timestamp with time zone NOT NULL,
    "Details" text COLLATE pg_catalog."default",
    CONSTRAINT PK_MoneyManagement PRIMARY KEY ("Id"),
    CONSTRAINT FK_MoneyManagement_Operators_IdOperator FOREIGN KEY ("IdOperator") REFERENCES public."Operators" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID,
    CONSTRAINT FK_MoneyManagement_Users_IdUser FOREIGN KEY ("IdUser") REFERENCES public."Users" ("Id") MATCH SIMPLE ON UPDATE NO ACTION ON DELETE NO ACTION NOT VALID
) TABLESPACE pg_default;