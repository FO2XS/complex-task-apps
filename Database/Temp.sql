--
-- PostgreSQL database dump
--

-- Dumped from database version 13.1
-- Dumped by pg_dump version 13.2

-- Started on 2021-05-07 01:45:22

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
-- TOC entry 3059 (class 0 OID 27140)
-- Dependencies: 201
-- Data for Name: Users; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (2, 'Qwerty142@mail.ru', 'QWERTY142@MAIL.RU', 'Qwerty142@mail.ru', 'QWERTY142@MAIL.RU', false, 'AQAAAAEAACcQAAAAEDHbCJ6oSCD49zMn4TTn+7J2kMDP8ZA5QUiOCP+2Oqwox9Nc8anzYQHo7yeanJB0aA==', '2Y2CLMUH2GXJIDSW34FGJXFMOU5XRWBZ', 'd442e81e-3450-4c93-ae99-4aa37ed09a14', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (3, 'Test3@mail.ru', 'TEST3@MAIL.RU', 'Test3@mail.ru', 'TEST3@MAIL.RU', false, 'AQAAAAEAACcQAAAAENmUrQ7t83aWV9gpkQq95IwhfrBKwLkqwT18ocZU2m/pLuV49yuk412GPNTPuKgKQQ==', 'IVDX2BMIRGO42SKZUNJ6OMSHQAACUOGF', 'fcbab6c8-0a25-4ba8-a611-914f3519154d', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (4, 'Test4@mail.ru', 'TEST4@MAIL.RU', 'Test4@mail.ru', 'TEST4@MAIL.RU', false, 'AQAAAAEAACcQAAAAEIK1AKZHdSzADSMMIJwuY7fMA7MRCbEJ6eIeTF037B0E/s/V2zrh5FH7SbIcWhdMUA==', '5G43TV5UPE6YTH5WHVXO5RCDSQ74PLDA', '53fc3bce-3265-44c8-a8a4-225d555ca355', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (5, 'Test5@mail.ru', 'TEST5@MAIL.RU', 'Test5@mail.ru', 'TEST5@MAIL.RU', false, 'AQAAAAEAACcQAAAAEAu3J76b5MuaaKJtTIMltS4mZYARVIXf6ouxXon9Vr/JVzmnVSN6AKqiUXq/W/t/5A==', 'UTV6TQI7C6J6RRNRZVVLC7OGEGR6N3BY', '861fb555-e2a6-4380-baa7-68bf25a0649b', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (6, 'Test6@mail.ru', 'TEST6@MAIL.RU', 'Test6@mail.ru', 'TEST6@MAIL.RU', false, 'AQAAAAEAACcQAAAAEIOhiL+1yGolEH5ddgkaWdSSc6/n/P/y+UcvIUc8XKn50BtGMthsWI7IRI3xowG3TQ==', 'EHNV6UD46TBKUTHNK52M2CHJM72QCVFW', '37078a5d-73c9-487d-856d-dbf483c6a632', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (7, 'Test7@mail.ru', 'TEST7@MAIL.RU', 'Test7@mail.ru', 'TEST7@MAIL.RU', false, 'AQAAAAEAACcQAAAAEHXqm6qmWOFrSbEQHUKCKshArWo6eJeF5w1mnmCZd9zxmV7Zc6xEwNonnUHVf7yH7g==', '5GSCB46W35JF7J5QVZ5RTHPSK3UFTGPS', '87ddcc85-c24a-4507-98fc-26285269e5c2', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (8, 'Test8@mail.ru', 'TEST8@MAIL.RU', 'Test8@mail.ru', 'TEST8@MAIL.RU', false, 'AQAAAAEAACcQAAAAEFnWyUPeKYIAbG7pAjMxYAWrh7Z4HYXfoglBQ9cPRXMQXPWC9HVdVyVSKe/lDvn55g==', 'XTMZGFLTACSQU5XEM23APN3ZWBLQSXEX', '49f67c44-6dbc-4407-8767-26f3ea2a6e12', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (9, 'Test9@mail.ru', 'TEST9@MAIL.RU', 'Test9@mail.ru', 'TEST9@MAIL.RU', false, 'AQAAAAEAACcQAAAAEHKlHCeveNvH+pVh962BwAwZZ4Ru7v+DEx1UElioJPDm0MOxdfkkmzny4GPpLUgo4A==', 'VV43SXXKYS4EKTAW7RJLLGYVTGXHV3JI', 'cf49f052-2f86-45be-94d3-262071bc665b', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (10, 'Test10@mail.ru', 'TEST10@MAIL.RU', 'Test10@mail.ru', 'TEST10@MAIL.RU', false, 'AQAAAAEAACcQAAAAEPMCJ5FoOOvxWX0Yuqp9Vzzz7u3ROIeppKa/6oyoZkH2JTHAIR1TY/VEXTlhLuOSnA==', 'BYM3U4STUIHBBJPBEJRKDI6JJNL2HXIB', '8f051752-e10d-464f-aa9e-4c9ecf5fd1dd', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (11, 'Test11@mail.ru', 'TEST11@MAIL.RU', 'Test11@mail.ru', 'TEST11@MAIL.RU', false, 'AQAAAAEAACcQAAAAEDVRE4IpPJ2QD3XH/wgS5nVbLVd2B4KBZYd96BnwjPoQkYy+fsoz4fpl0T83hsOAjQ==', 'G7ISHX52HNUBVMXIDJSJNGFZFAE52WFG', 'f075ee09-70f4-49f6-9684-0760590061af', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (12, 'Test12@mail.ru', 'TEST12@MAIL.RU', 'Test12@mail.ru', 'TEST12@MAIL.RU', false, 'AQAAAAEAACcQAAAAEMiKxDo2neK3Fa+wHGdhGJ1krK+BdphaYdMcNFVuDcomNaIGgTwfq2HBLh/KtngKPg==', 'YTDFBI3BGIL34YLH3DXA2IXTKMOMDKO4', '9110fc0c-f428-45bb-be75-d452c5d0e45f', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (13, 'Test13@mail.ru', 'TEST13@MAIL.RU', 'Test13@mail.ru', 'TEST13@MAIL.RU', false, 'AQAAAAEAACcQAAAAEIMSBquQLtF+MXD1GPLyihWMyEvQRMo+Hmyc5XyCssRiY0mAgoyWfNdzk5gBBBmjCQ==', 'SKG44FGXBRIK6ACHUGOC7NIVVGZWRNUK', '5304d82b-8a54-4851-ae0f-e3852ea59bf4', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (14, 'Test15@mail.ru', 'TEST15@MAIL.RU', 'Test15@mail.ru', 'TEST15@MAIL.RU', false, 'AQAAAAEAACcQAAAAEEt1F1EiYeHtxyzsgQVuxE5dloAgar5p9v1mcI6glZLFry4f5vuKF96M0+uH8H8yqw==', 'AZU5IFTCSFJLCVDM6QUYWTUSJUT3T42F', '28b06c81-d370-4d4b-b81a-3ac836e71311', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (15, 'Test17@mail.ru', 'TEST17@MAIL.RU', 'Test17@mail.ru', 'TEST17@MAIL.RU', false, 'AQAAAAEAACcQAAAAEMEXQ5kgeGaaRs6VrzARJznNjD52ohpYT6+4Zp/3A7iPJM5tm9oLG90omIv8bQGoGg==', 'INXRUMHLPJRRAF6TE3ZLVVTU3QIAKNED', 'f9b3e9f0-340b-4a31-8b58-0e1248ef78df', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (1, 'Test2@mail.ru', 'TEST2@MAIL.RU', 'Test2@mail.ru', 'TEST2@MAIL.RU', false, 'AQAAAAEAACcQAAAAELVpsInqaiZoteWypxFlawBf7zkaugA0tUMaUxiWq0zYxexp0o2/oBIH3J717V5+2Q==', 'UMH6PYOHR2HVE6LQS2GMTGDJMQ3IZN6E', 'b7d37e5b-5383-478e-a5be-adeba34beb1b', NULL, false, false, NULL, true, 0, 'Максим', 'Киселев', 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (16, 'Test20@mail.ru', 'TEST20@MAIL.RU', 'Test20@mail.ru', 'TEST20@MAIL.RU', false, 'AQAAAAEAACcQAAAAEKx3sGnyH6iaaA0ZRojD+Ux2naM5T7TIcK/F4Bbh0eKsn8yUpzRiZm752sZitqE58A==', 'SOFIXUOKX5JKTWTSYA7EWI5VHHWTRHMV', 'e6d743bc-cd67-4011-97f8-5a0a3ab4053d', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (17, 'Test50@mail.ru', 'TEST50@MAIL.RU', 'Test50@mail.ru', 'TEST50@MAIL.RU', false, 'AQAAAAEAACcQAAAAEM0+UsGRAAnX0QmgMrI5LrQ4Yxs/S6IESj95gDohjfF/+GhnsVYTtRs23F0m9cpXDg==', 'IXTGHKLMPO4X6KMMNLVEBM2WYCFJVUWK', '33d76845-a832-4e21-9312-060855fd6bf1', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (18, 'Test100@mail.ru', 'TEST100@MAIL.RU', 'Test100@mail.ru', 'TEST100@MAIL.RU', false, 'AQAAAAEAACcQAAAAEO+H6EKdciiIDtaRjDb6oxvKB+IEoMs/vRKN0MB33pHiJnWURhXgB8K+ZMgJRvvZvg==', 'BDJKNQNVFI35DBGBSLJUOIPJFMN7C2WM', 'ece8a857-9fea-487b-a7b9-e594c7a378b7', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (19, 'Test18@mail.ru', 'TEST18@MAIL.RU', 'Test18@mail.ru', 'TEST18@MAIL.RU', false, 'AQAAAAEAACcQAAAAEE8OeXvGOr/gdnnq5AjM1+gVL68ogbz1m4Fj70/2wTH/DBQzxSxCu+VmrQfWoy5Zcw==', 'UJEXNNL42F6JJ4P5GWGSPQ6GKJXFA4RP', '1bae6702-cb58-4794-9ce8-1665a808da06', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (20, 'admin@mail.ru', 'ADMIN@MAIL.RU', 'admin@mail.ru', 'ADMIN@MAIL.RU', false, 'AQAAAAEAACcQAAAAEPjeru/lf0QQhKAh2LgpNtHgYIyug/GTgAihAGvTchtEhgbR1dKC/qzevN9SFnSO8A==', '4G45BRSNHBBWMLJH3QEYY34EXPT745FA', '543e9d5d-790f-4bb1-bd75-035f0aa911fb', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (21, 'test19@mail.ru', 'TEST19@MAIL.RU', 'test19@mail.ru', 'TEST19@MAIL.RU', false, 'AQAAAAEAACcQAAAAELzE5TS2vosgyZ5MQvCNPljVQEIjr9fXLt/MJrR+/BG7gCSzmGHFc8KNjJhsl+y8Yg==', 'B6QLZQ45H7ZZ6A5QOOCTMC2BTUOUUKXI', 'ec41a297-8d31-4785-a893-24f98b90f32a', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (22, 'test21@mail.ru', 'TEST21@MAIL.RU', 'test21@mail.ru', 'TEST21@MAIL.RU', false, 'AQAAAAEAACcQAAAAEKnME6nm+AMxdKYxzD60yU+Fu0iQxXB3vsXZpfNbVAj2RMvj3b5YEdnFn8h+qQZVzw==', 'KFMAMRTXFX5C37CBFSNEFYOT2ENK2I6M', '2223b9fb-1c94-48da-b0d3-974d7bb29e5d', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (23, 'test22@mail.ru', 'TEST22@MAIL.RU', 'test22@mail.ru', 'TEST22@MAIL.RU', false, 'AQAAAAEAACcQAAAAEO1AcqxXyTSrLydQKKuCJmfqx9qAG45YEAUfJx9KSyeiLns8abiMWg9vvXqbDEM0ZA==', 'VOH4HGMFDWKAB7SISG7IHKYQCVMMP3RN', '39f77694-6dbc-48b2-90f3-173fdcadf5bc', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (24, 'test23@mail.ru', 'TEST23@MAIL.RU', 'test23@mail.ru', 'TEST23@MAIL.RU', false, 'AQAAAAEAACcQAAAAEKGM1Kb0wM9KeJVPoGkAIlf0FuFPh+gTiA5MtoEBMBwQrIXoiFj/l9AHY+DI6nVV9A==', 'H7AH37ED5FQAXP7EOI3ZNET2PJWQ5Y3T', '589254af-3849-4199-985d-daa8a3f65660', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (25, 'test24@mail.ru', 'TEST24@MAIL.RU', 'test24@mail.ru', 'TEST24@MAIL.RU', false, 'AQAAAAEAACcQAAAAENEiz+NVF+ycboZz6hBeim7NrPuUpYfH43nmsez8rrpZq1TOjZsc1PuVVmmhTDs6gg==', '7SN4YQ7Z6XXK7DCCF4Y6YEB7LPH6AYRO', '35305447-9070-44f0-96e8-f0801ec2cf9f', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (26, 'test25@mail.ru', 'TEST25@MAIL.RU', 'test25@mail.ru', 'TEST25@MAIL.RU', false, 'AQAAAAEAACcQAAAAEMivzB9H8iIQCqS+AM1EfHXP85i4sySHWhHWWaA49UQ6Qj2rIBG4mQHQtvlNRR9aRg==', 'SE4QSM4YOVV2JNYLTWNFTSYFSKQDZ26P', '584fe1fb-2e38-4d5b-ad89-e8009004a5f6', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (27, 'test26@mail.ru', 'TEST26@MAIL.RU', 'test26@mail.ru', 'TEST26@MAIL.RU', false, 'AQAAAAEAACcQAAAAEK2FsTwkIbCHUl6gmi/B43KY1lWvArZJTeKBd5mL8DDt7sQqBojiP0p+D0KSA0SCtw==', 'CRJDO757BUIME57WRSZKAOYA6E5PHUWZ', '8f4958bb-4d62-447d-9d35-27d10d9a01bd', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (28, 'test27@mail.ru', 'TEST27@MAIL.RU', 'test27@mail.ru', 'TEST27@MAIL.RU', false, 'AQAAAAEAACcQAAAAEDf7FoTdWmHi99tV1n3igE5bYtyt321UcwxJ19JCeZBeYdHaJdZ5rChjG8Vg8lBR3Q==', 'KKPXNTXZAZ22B67DUT735QJ2TDK3UFHD', 'dbc2a5b8-40f7-47eb-97af-5407a58e6624', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (29, 'test28@mail.ru', 'TEST28@MAIL.RU', 'test28@mail.ru', 'TEST28@MAIL.RU', false, 'AQAAAAEAACcQAAAAEDHJnWlB0aRPVEMpoUlTyur73gE/jNhT1yYeykbrXk9DTkZEt4Nno0qWFXerg1KIFg==', 'ZINQLSKUP4UJ3Y2BM7W6JXO4NEUJVUXQ', '23df767c-e308-41f3-a645-3084f0dad9df', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (30, 'test29@mail.ru', 'TEST29@MAIL.RU', 'test29@mail.ru', 'TEST29@MAIL.RU', false, 'AQAAAAEAACcQAAAAEGN5nU87ar+i5fIi7ZFfg/AG8AnJQeFRCIwXHPvIHZdZHuHSkKlUhvXiPviUo6PG0A==', 'OTE564L4O4QAD35JFJXFYYWWJSOD2NI4', '32d11c97-d97c-4f66-96a0-6199c8ddb37e', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (31, 'test30@mail.ru', 'TEST30@MAIL.RU', 'test30@mail.ru', 'TEST30@MAIL.RU', false, 'AQAAAAEAACcQAAAAEDz+BXEcecPVUYS3UqDvJorqf6aiKp/36WpeFua1jRXNTjxzwWC1S76FNCAOTlcRfA==', 'ZMPSQ7QW6INJASWPLXD74ZN7WBU557WT', '96685582-1b23-4b92-bc5c-ba77e6a47e0d', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (32, 'test31@mail.ru', 'TEST31@MAIL.RU', 'test31@mail.ru', 'TEST31@MAIL.RU', false, 'AQAAAAEAACcQAAAAEAkVSA2XgXgH2skZb0eQdIi5+EY+U8m1RRNmpUzYuSxeqO5tlUK3lZFJYWA56iBqmQ==', 'BVBBP6C7WLJ2U2DVK7I5L6G7UNXI3GJO', 'dd9f2071-2f21-4fd4-8139-d8f775a9415b', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (33, 'test32@mail.ru', 'TEST32@MAIL.RU', 'test32@mail.ru', 'TEST32@MAIL.RU', false, 'AQAAAAEAACcQAAAAEKIfgjDKuwfPZ7QSIHxku7cKTGJHYWNXR1rSdi5XYVgjEXumVj+OOuLJnYUq9iqnVA==', 'I6W77RTGP7DKBV5S5KWYTFJ5ZZJV5NLL', '66e0c9bd-221d-464f-ad06-f732364d123c', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (34, 'test33@mail.ru', 'TEST33@MAIL.RU', 'test33@mail.ru', 'TEST33@MAIL.RU', false, 'AQAAAAEAACcQAAAAED+oaNMSsEkm6+3cx2/4lmni5cMsdDnmI+NA2YKa5DSBfn1M5RA6vXVj3GgBu9kEdg==', 'QFOMHAWOILSKEUKBIEPTTBO6P65IIKTG', '25d990a5-8eca-49d6-8306-33b5eedd51ea', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (35, 'test34@mail.ru', 'TEST34@MAIL.RU', 'test34@mail.ru', 'TEST34@MAIL.RU', false, 'AQAAAAEAACcQAAAAEEuTNeqPKloRPqQ+uKuM55UYZHX/7CKV4Jg57tvyLdWBv9dcLI9nZNZaLOmoI55SFQ==', 'BBGODN4QXIK6ARYJMPIQA7S5OBMIMICC', '2fa6f09c-3166-4140-9648-e9dbc4e915bb', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (36, 'test35@mail.ru', 'TEST35@MAIL.RU', 'test35@mail.ru', 'TEST35@MAIL.RU', false, 'AQAAAAEAACcQAAAAEDSv0q8NqT1btI3Q6BLkeQe5F8tFSDYdC6FL28/YaZ9C6Vvsg90WUPQZ82ZInzIvmQ==', 'Y3XTG5MLTJJQT3TSUTEOTBB7XIRXGDJU', 'f3be7ff3-41ad-4faf-a6e7-5912dd2f856a', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (37, 'test36@mail.ru', 'TEST36@MAIL.RU', 'test36@mail.ru', 'TEST36@MAIL.RU', false, 'AQAAAAEAACcQAAAAEMWVHID02+D+emTHhssy/2xkVfAfHqO6W0bSxfQjFlHS9aEClJPWDDAeCUTq3qqNdw==', 'YKWU3XH5QZA7XVTKDRAVS2H5YCDYMP25', '14d442e5-f9e2-4840-85d6-0cfeb28f6e39', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (38, 'test37@mail.ru', 'TEST37@MAIL.RU', 'test37@mail.ru', 'TEST37@MAIL.RU', false, 'AQAAAAEAACcQAAAAEHklpZl1Io9SB2cmcDlWjAdCzwBIEYs+oYOUHmqAGN3uKdTXzLqxHDFmbqAwNya8SQ==', 'YYQTUXDIGEWOBUE2233N3NHKEH25L6SC', 'dfcbeb91-00fb-4b43-9ee7-603e0cbdddc8', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (39, 'test38@mail.ru', 'TEST38@MAIL.RU', 'test38@mail.ru', 'TEST38@MAIL.RU', false, 'AQAAAAEAACcQAAAAEEH5C+iI3Lq8hbOSk8wjx+hblMVq9rh9K82O1O0tYF7FgqBS9UCa1PzUzoe4612xYg==', 'ODKKECUGLU464TYI3SL2JVVBYUIVLOL2', 'bd099391-d840-4e8c-9bdb-aadf52b5b7f7', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (40, 'test39@mail.ru', 'TEST39@MAIL.RU', 'test39@mail.ru', 'TEST39@MAIL.RU', false, 'AQAAAAEAACcQAAAAEC0h+hQpXcVDiaJcLGhk0s2woR2AZUL0hu54uK8umpkp/eA+p5+yV3OUc6GyGGGm1w==', 'GTRFGMY7RJIOOWLPNIBR7OFC22URMUYR', '89a95297-22a8-4a3e-b7df-454ff4d807c1', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (41, 'test40@mail.ru', 'TEST40@MAIL.RU', 'test40@mail.ru', 'TEST40@MAIL.RU', false, 'AQAAAAEAACcQAAAAED73/OLLVdtLi0eOf7D74Ag3QbNmTIUI71oYf6d9ZuvT3PcISZr/BC32Drz5BQhYEQ==', 'JCMR5W6PHE4BMUG2Q5CJEXHMZTFOB2PP', 'b74db428-f145-4622-8165-1d91342f83b5', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (42, 'test41@mail.ru', 'TEST41@MAIL.RU', 'test41@mail.ru', 'TEST41@MAIL.RU', false, 'AQAAAAEAACcQAAAAEFcVj/m84KGJPIlJvN2Iyj/VpxO3GP9hajHGvNeNggmBrY4PTcQuR0Fd/QSblznFkg==', 'URJUS5AJJWMDDGQTFA45V5BMHU2L5KCU', 'fa73db1a-8a49-4f40-94a2-f9b2eae7f0e5', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (43, 'test42@mail.ru', 'TEST42@MAIL.RU', 'test42@mail.ru', 'TEST42@MAIL.RU', false, 'AQAAAAEAACcQAAAAENyyMfuPG3+DeA8D8yeSBqmnuI0wdsAuOyB9b9By8Cu+zyR+w6IwviWRCWNdamUunQ==', 'ME7ILX7UEFHV7UUGF36OOZX4627L7KQW', 'cb5ec5d9-4498-4a76-8a20-8ea7df38eb2d', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (44, 'test43@mail.ru', 'TEST43@MAIL.RU', 'test43@mail.ru', 'TEST43@MAIL.RU', false, 'AQAAAAEAACcQAAAAEGwoFhnq6I/wR//YSooTCMvD4OivvenQ2hqJu7BZ/QyX8tWEd0XDZVjjXHj+xEnLKw==', 'FS27AYFVNZX22PCG72JOHBWCTUX65XK3', '1bbc4408-e6f2-4fd3-97ee-e1d02c10a6a0', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (45, 'test44@mail.ru', 'TEST44@MAIL.RU', 'test44@mail.ru', 'TEST44@MAIL.RU', false, 'AQAAAAEAACcQAAAAEEqwefRoIs6PSHdnAac6wt6AOQuJXMfjeclI0Y2w0YPVdoW27BG7G97F5BmSH7BMew==', 'MU2C25S4TLQJUJQD5SEAMTDE7YRKGFL3', '62bf123a-b419-47b3-8f61-b7730bdc429f', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (46, 'test45@mail.ru', 'TEST45@MAIL.RU', 'test45@mail.ru', 'TEST45@MAIL.RU', false, 'AQAAAAEAACcQAAAAEAdEN8PteJfAWpwiuQT2YEnbyCz2HPzr4S2J/tJMX1l8CiYep9uTYx0sDHtVZpiPjQ==', 'GBVYD5UKSHLO6NFTCZBS6KPZBP2PR6JZ', '4c89d29a-709b-4450-98f5-32c99760a7a5', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (47, 'test46@mail.ru', 'TEST46@MAIL.RU', 'test46@mail.ru', 'TEST46@MAIL.RU', false, 'AQAAAAEAACcQAAAAEE5pZUFjHVrEKyuqbY4hVLK3TF4h1q4Di724vjgjyFm8IVVvOkLemFyDINRoWDneJA==', '6UJXCWK3G3DW5KYL7PI6DD4QZDANOWEW', 'dd9042fa-6133-4125-abbf-6639e66f1a4a', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (48, 'test47@mail.ru', 'TEST47@MAIL.RU', 'test47@mail.ru', 'TEST47@MAIL.RU', false, 'AQAAAAEAACcQAAAAEGUTHghEjAnatgYgKz6xjlfmANi3XvJPQUDH5g8bAmLqAvWDiFrgP9D29zT1JWdVZg==', 'QZGZMREA57J5FSM4C43XCLLFYM7DIUQ4', 'ed52ecfa-6f36-4d91-bf54-9d542ee11318', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (49, 'test48@mail.ru', 'TEST48@MAIL.RU', 'test48@mail.ru', 'TEST48@MAIL.RU', false, 'AQAAAAEAACcQAAAAEPWposDfaBS5puFjyYmb4FpCqS/C6qBY+Mid1NVMHmgFt4IeAIQF377EKsCx9oNYPA==', 'XEJ2MZ7X6RWKFH5I34VEAI7PTB6YX6IG', '0ccaa4eb-3194-49af-9359-e927b69299a2', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);
INSERT INTO public."Users" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Name", "Surname", "Balance", "Avatar") VALUES (50, 'test49@mail.ru', 'TEST49@MAIL.RU', 'test49@mail.ru', 'TEST49@MAIL.RU', false, 'AQAAAAEAACcQAAAAEGxY1Ge7MFvJ43mCzrL+yYEGEPRbBLYxtUzVJKjhYIDThPNrGCKSD1pX0sMbhrB86g==', 'QFRDNZV35TLMHQYDHYABETC5XKVTV7XF', 'c643e0e6-6736-474f-84b5-f9bdaccf3a7f', NULL, false, false, NULL, true, 0, NULL, NULL, 0.00, NULL);


--
-- TOC entry 3065 (class 0 OID 0)
-- Dependencies: 200
-- Name: Users_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Users_Id_seq"', 50, true);


-- Completed on 2021-05-07 01:45:23

--
-- PostgreSQL database dump complete
--
