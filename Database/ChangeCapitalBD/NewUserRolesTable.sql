DROP TABLE public."AspNetUserRoles";

CREATE TABLE public."UserRoles"
(
    "UserId" text COLLATE pg_catalog."default" NOT NULL,
    "RoleId" text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "PK_UserRoles" PRIMARY KEY ("UserId", "RoleId"),
    CONSTRAINT "FK_UserRoles_Roles_RoleId" FOREIGN KEY ("RoleId")
        REFERENCES public."Roles" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT "FK_UserRoles_Users_UserId" FOREIGN KEY ("UserId")
        REFERENCES public."Users" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)

TABLESPACE pg_default;

ALTER TABLE public."UserRoles"
    OWNER to postgres;
-- Index: IX_AspNetUserRoles_RoleId

-- DROP INDEX public."IX_AspNetUserRoles_RoleId";

CREATE INDEX "IX_UserRoles_RoleId"
    ON public."UserRoles" USING btree
    ("RoleId" COLLATE pg_catalog."default" ASC NULLS LAST)
    TABLESPACE pg_default;