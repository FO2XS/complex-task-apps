DROP INDEX "RoleNameIndex";

CREATE TABLE public."Roles"
(
    "Id" text COLLATE pg_catalog."default" NOT NULL,
    "Name" character varying(256) COLLATE pg_catalog."default",
    "NormalizedName" character varying(256) COLLATE pg_catalog."default",
    "ConcurrencyStamp" text COLLATE pg_catalog."default",
    CONSTRAINT "PK_Roles" PRIMARY KEY ("Id")
)

TABLESPACE pg_default;

ALTER TABLE public."Roles"
    OWNER to postgres;
-- Index: RoleNameIndex

-- DROP INDEX public."RoleNameIndex";

CREATE UNIQUE INDEX "RoleNameIndex"
    ON public."Roles" USING btree
    ("NormalizedName" COLLATE pg_catalog."default" ASC NULLS LAST)
    TABLESPACE pg_default;