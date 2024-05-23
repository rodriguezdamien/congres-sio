use master;
go
drop database if exists CongresDB;

drop login AppliGestCongres;
create login AppliGestCongres with password = 'MdpComplexe34';

CREATE DATABASE CongresDB;
go
use CongresDB;
go

create user AppliGestCongres for login AppliGestCongres;
go

CREATE TABLE SALLE(
   id INT identity,
   libelle VARCHAR(100),
   CONSTRAINT pk_salle PRIMARY KEY(id)
);


CREATE TABLE SESSION(
   id INT identity,
   theme VARCHAR(100),
   nomPresident VARCHAR(50),
   nbPlaces INT,
   salle VARCHAR(120),
   prix DECIMAL(15,2),
   dateSession DATE,
   estMatin BIT,
   idSalle int NOT NULL,
   CONSTRAINT pk_session PRIMARY KEY(id),
   CONSTRAINT fk_session_salle FOREIGN KEY(idSalle) REFERENCES SALLE(id)
);

CREATE TABLE ACTIVITE(
   id INT identity,
   nom VARCHAR(100),
   dateActivite DATE,
   nbPlaces INT,
   prix DECIMAL(15,2),
   estMatin BIT,
   CONSTRAINT pk_activite PRIMARY KEY(id)
);

CREATE TABLE LIGUE(
   id INT identity,
   nomLigue VARCHAR(200),
   adresse VARCHAR(200),
   cp CHAR(5),
   ville VARCHAR(50),
   CONSTRAINT pk_ligue PRIMARY KEY(id)
);

CREATE TABLE HEBERGEMENT(
   id INT identity,
   nom VARCHAR(50),
   adresse VARCHAR(200),
   cp CHAR(5),
   ville VARCHAR(40),
   tel CHAR(10),
   nbEtoiles CHAR(1),
   prix DECIMAL(15,2),
   CONSTRAINT pk_hebergement PRIMARY KEY(id)
);

CREATE TABLE CONGRESSISTE(
   id INT identity,
   nom VARCHAR(50),
   prenom VARCHAR(40),
   tel CHAR(10),
   adresse VARCHAR(200),
   cp CHAR(5),
   ville VARCHAR(50),
   accompte DECIMAL(15,2),
   idLigue INT NOT NULL,
   idHebergement INT,
   CONSTRAINT pk_congressiste PRIMARY KEY(id),
   CONSTRAINT fk_congressiste_ligue FOREIGN KEY(idLigue) REFERENCES LIGUE(id),
   CONSTRAINT fk_congressiste_hebergement FOREIGN KEY(idHebergement) REFERENCES HEBERGEMENT(id)
);

CREATE TABLE INSCRIRE(
   idSession INT,
   idCongressiste INT,
   CONSTRAINT pk_inscrire PRIMARY KEY(idSession, idCongressiste),
   CONSTRAINT fk_inscrire_session FOREIGN KEY(idSession) REFERENCES SESSION(id),
   CONSTRAINT fk_inscrire_congressiste FOREIGN KEY(idCongressiste) REFERENCES CONGRESSISTE(id)
);

CREATE TABLE PARTICIPER(
   idActivite INT,
   idCongressiste INT,
   CONSTRAINT pk_participer PRIMARY KEY(idCongressiste, idActivite),
   CONSTRAINT fk_participer_activite FOREIGN KEY(idActivite) REFERENCES ACTIVITE(id),
   CONSTRAINT fk_participer_congressiste FOREIGN KEY(idCongressiste) REFERENCES CONGRESSISTE(id)
);

-- Jeu d'essai pour la table SALLE
INSERT INTO SALLE (libelle) VALUES 
('B418'),
('Usain Bolt'),
('Nelson Mandela'),
('Roger Federer'),
('Hicham El Guerrouj'); 

-- Jeu d'essai pour la table SESSION
INSERT INTO SESSION (theme, nomPresident, nbPlaces, salle, prix, dateSession, estMatin, idSalle) VALUES 
('Session d''inauguration', 'Snow', 20, 'La Marignane', 50.00, '2024-06-03', 0, 1), -- 1
('Stratégies de coaching efficaces', 'Johnson', 10, 'Eiffel', 85.00, '2024-06-03', 1, 2), -- 2
('Alimentation et performance sportive', 'Smith', 11, 'Salle des Congrès', 80.00, '2024-06-04', 0, 1), -- 3
('Prévention des blessures chez les jeunes sportifs', 'Dubois', 12, 'Rivoli', 75.00, '2024-06-04', 1, 2), -- 4
('Evaluation psychologique du sportif', 'McKinney', 12, 'Léon Blum', 75.00, '2024-06-05', 0, 3), -- 5
('Gestion du stress chez les athlètes', 'Garcia', 14, 'Montmartre', 70.00, '2024-06-05', 1, 4), -- 6
('Nouvelles technologies dans le domaine sportif', 'Wang', 13, 'Palais des Congrès', 90.00, '2024-06-06',0, 5), -- 7
('Réhabilitation après blessure sportive', 'Chen', 12, 'Victor Hugo', 65.00, '2024-06-06', 1, 4), -- 8
('Pratiques sportives et usages de drogues', 'Costa Correia', 15, '50.00', 100.00, '2024-06-07', 0, 3), -- 9
('Impact du sommeil sur la performance sportive', 'Lee', 15, 'Louvre', 60.00, '2024-06-07', 1, 5); -- 10

-- Jeu d'essai pour la table HEBERGEMENT
INSERT INTO HEBERGEMENT (nom, adresse, cp, ville, tel, nbEtoiles, prix) VALUES 
('Novotel', '61 Quai de Grenelle', '75015', 'Paris', '0140582000', '2', 120.00),
('F1', '29 Rue du Dr Babinski', '75015', 'Paris', '0891705350', '1', 80.00),
('Hilton', '108 Rue Saint-Lazare', '75015', 'Paris', '0140084444', '3', 250.00),
('Bel Ami', '7-11 Rue Saint-Benoît', '75006', 'Paris', '0145458600', '2', 140.00),
('Petit Hôtel', '8 Rue Cambronne', '75015', 'Paris', '0145987654', '1', 70.00);

-- Jeu d'essai pour la table ACTIVITE
INSERT INTO ACTIVITE (nom, dateActivite, nbPlaces, prix, estMatin) VALUES 
('Natation', '2024-06-03', 7, 20.00, 0), -- 1
('Tennis', '2024-06-03', 8, 30.00, 1), -- 2
('Yoga', '2024-06-04', 8, 40.00, 0), -- 3
('Course à pied', '2024-06-04', 7, 25.00, 1), -- 4
('Cyclisme', '2024-06-05', 6, 30.00, 0), -- 5
('Musculation', '2024-06-05', 7, 25.00, 1), -- 6
('Randonnée', '2024-06-06', 8, 30.00, 0), --7
('Escalade', '2024-06-06', 5, 45.00, 1), -- 8
('Aquagym', '2024-06-07', 6, 35.00, 0);  -- 9

-- Jeu d'essai pour la table LIGUE
INSERT INTO LIGUE (nomLigue, adresse, cp, ville) VALUES 
('Ligue des Champions', '116 Bis Cr de Vincennes', '75012', 'Paris'),
('Ligue Lorraine de Tennis', '144 Rue La Fayette', '75010', 'Paris'),
('Ligue Hauts-de-France de Cyclisme', '8 Rue du Fbg Montmartre', '75009', 'Paris'),
('Ligue Rhône-Alpes de Randonnée', '12 Quai Maréchal Joffre', '69002', 'Lyon'),
('Ligue Côte d''Azur de Natation', '30 Boulevard des Anglais', '06000', 'Nice');

-- Jeu d'essai pour la table CONGRESSISTE
INSERT INTO CONGRESSISTE (nom, prenom, tel, adresse, cp, ville, accompte, idLigue, idHebergement) VALUES 
('Gareau', 'Aurélie', '0781001230', '6 Rue Froment', '75011', 'Paris', 50.00, 1, 5),
('Plouffe', 'Laisné', '0652031245', '5 bis Rue André Dubois', '75019', 'Paris', 75.00, 2, 2),
('Napolitani', 'Fabrizio', '0612302510', '21 Rue des Grands Champs', '75020', 'Paris', 100.00, 3, 5),
('Dubois', 'Camille', '0678452130', '10 Avenue des Champs-Élysées', '75008', 'Paris', 60.00, 4, 2),
('Paoli', 'Toto', '0612457854', '15 Rue du Faubourg Saint-Honoré', '75008', 'Paris', 200.00, 5, 3),
('Smith', 'Emily', '0623104587', '18 Rue de Rivoli', '75001', 'Paris', 120.00, 1, 1),
('Leao', 'Rafael', '0678321098', '25 Rue de la République', '75002', 'Paris', 160.00, 2, 4),
('López', 'María', '0698745201', '30 Avenue des Champs-Élysées', '75008', 'Paris', 85.00, 3, 2),
('Chen', 'Dadi', '0658741230', '12 Rue de la Paix', '75002', 'Paris', 110.00, 3, 1),
('Kawasaki', 'Jan', '0612345879', '8 Avenue Montaigne', '75008', 'Paris', 105.00, 5, 4),
('Garcia', 'Luis', '0612345678', '1 Rue de la Gare', '75001', 'Paris', 190.00, 1, 3),
('Ramos', 'Sofia', '0623456789', '2 Rue de la Mairie', '75002', 'Paris', 105.00, 2, 1),
('Kim', 'Jung', '0634567890', '3 Rue des Champs', '75003', 'Paris', 170.00, 3, 3),
('Perez', 'Hernando', '0612345678', '10 Avenue de la Liberté', '75006', 'Paris', 120.00, 4, 4),
('Santos', 'Diego', '0645678901', '25 Rue de l''Avenir', '75009', 'Paris', 60.00, 5, 5),
('White', 'John', '0656789012', '30 Rue de la Paix', '75010', 'Paris', 110.00, 1, 4);


-- Jeu d'essai pour la table INSCRIRE
INSERT INTO INSCRIRE (idSession, idCongressiste) VALUES 
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 9),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15),
(1, 16),

(2, 1),
(2, 2),
(2, 6),
(2, 7),
(2, 8),
(2, 9),
(2, 10),
(2, 11),
(2, 12),
(2, 15),

(3, 1),
(3, 3),
(3, 4),
(3, 5),
(3, 6),
(3, 7),
(3, 9),
(3, 11),
(3, 16),

(4, 3),
(4, 4),
(4, 5),
(4, 8),
(4, 9),
(4, 10),
(4, 11),
(4, 13),
(4, 14),
(4, 15),

(5, 3),
(5, 4),
(5, 5),
(5, 6),
(5, 7),
(5, 8),
(5, 9),
(5, 10),
(5, 14),
(5, 15),
(5, 16),

(6, 1),
(6, 2),
(6, 3),
(6, 4),
(6, 5),
(6, 6),
(6, 7),
(6, 8),
(6, 9),
(6, 10),
(6, 11),
(6, 14),

(7, 1),
(7, 4),
(7, 5),
(7, 8),
(7, 9),
(7, 10),
(7, 12),
(7, 14),
(7, 15),
(7, 16),

(8, 2),
(8, 4),
(8, 5),
(8, 6),
(8, 7),
(8, 8),
(8, 11),
(8, 13),
(8, 15),
(8, 16),

(9, 1),
(9, 2),
(9, 3),
(9, 4),
(9, 5),
(9, 6),
(9, 7),
(9, 8),
(9, 10),
(9, 11),
(9, 13),
(9, 14),
(9, 16),

(10, 1),
(10, 2),
(10, 3),
(10, 4),
(10, 5),
(10, 6),
(10, 7),
(10, 8),
(10, 9),
(10, 10),
(10, 11),
(10, 12);

-- Jeu d'essai pour la table PARTICIPER
INSERT INTO PARTICIPER (idActivite, idCongressiste) VALUES 
(1, 3),
(1, 4),
(1, 5),
(1, 13),
(1, 14),
(1, 16),

(2, 2),
(2, 8),
(2, 10),
(2, 12),
(2, 13),
(2, 14),
(2, 15),

(3, 1),
(3, 2),
(3, 6),
(3, 7),
(3, 12),
(3, 16),

(4, 1),
(4, 2),
(4, 11),
(4, 12),
(4, 13),

(5, 12),
(5, 13),
(5, 15),
(5, 16),

(6, 2),
(6, 3),
(6, 6),
(6, 7),
(6, 11),
(6, 13),

(7, 1),
(7, 3),
(7, 9),
(7, 10),
(7, 12),
(7, 14),

(8, 9),
(8, 12),
(8, 15),

(9, 13),
(9, 14),
(9, 15),
(9, 16);

GO

-- Procédure stockée qui renvoie le nombre de place disponible pour un idSession donné
drop procedure if exists nbPlacesDispoSession;
go
CREATE PROCEDURE nbPlacesDispoSession
@idS INT
AS
   declare @nbPlacesPrise INT
   select @nbPlacesPrise=count(*) from INSCRIRE where idSession = @idS
   select SUM(nbPlaces - @nbPlacesPrise) as nbPlacesDispo from SESSION where id = @idS



-- Procédure stockée qui renvoie le nombre de place disponible pour un idActivite donné
drop procedure if exists nbPlacesDispoActivite;
go
CREATE PROCEDURE nbPlacesDispoActivite
@idA INT
AS
   declare @nbPlacesReservees INT
   select @nbPlacesReservees = count(*)  from PARTICIPER where idActivite = @idA
   select SUM(nbPlaces - @nbPlacesReservees) as nbPlacesDispo from ACTIVITE where id = @idA

-- Procédure stockée qui renvoie le montant totale à régler pour un congressiste donné
DROP PROCEDURE IF EXISTS montantTotal
GO
CREATE PROCEDURE montantTotal 
    @idC INT
AS
    DECLARE @accompte DECIMAL(15,2)
    DECLARE @montantT DECIMAL(15,2)

    SELECT @montantT = prix FROM HEBERGEMENT WHERE id = (SELECT idHebergement FROM CONGRESSISTE WHERE id = @idC)
    SELECT @montantT = @montantT + ISNULL(SUM(prix), 0) FROM ACTIVITE WHERE id IN (SELECT idActivite FROM PARTICIPER WHERE idCongressiste = @idC)
    SELECT SUM(@montantT - accompte) as montantTotal FROM CONGRESSISTE WHERE id = @idC

GO
CREATE OR ALTER TRIGGER TD_Session ON SESSION
INSTEAD OF DELETE
AS
BEGIN
	DELETE FROM INSCRIRE WHERE idSession IN (SELECT id FROM deleted)
	DELETE FROM SESSION WHERE id IN (SELECT id FROM deleted)
END

GO
CREATE OR ALTER TRIGGER TD_Activite ON ACTIVITE
INSTEAD OF DELETE
AS
BEGIN
	DELETE FROM PARTICIPER WHERE idActivite IN (SELECT id FROM deleted)
	DELETE FROM ACTIVITE WHERE id IN (SELECT id FROM deleted)
END

GO
CREATE OR ALTER TRIGGER TI_Participer ON PARTICIPER
AFTER INSERT
AS
BEGIN
IF((select count(idCongressiste) from PARTICIPER where idActivite IN (select idActivite from inserted) group by idActivite) > (select nbPlaces from ACTIVITE where id in (select idActivite from inserted)))
throw 50001, 'Il n''y a plus de place disponible pour cette activité.',0
END

GO
CREATE OR ALTER TRIGGER TI_Inscrire ON INSCRIRE
AFTER INSERT
AS
BEGIN
IF((select count(idCongressiste) from INSCRIRE where idSession IN (select idSession from inserted)) > (select nbPlaces from SESSION where id in (select idSession from inserted)))
throw 50002, 'Il n''y a plus de place disponible pour cette session.',0
END

Select * From SALLE
Select * From SESSION

