DROP DATABASE IF EXISTS CongresDB;

CREATE DATABASE CongresDB;

use CongresDB;
go

create login AppliGestCongres with password = 'MdpComplexe34';
GO

create user AppliGestCongres for login AppliGestCongres;
go

DROP TABLE IF EXISTS SESSION;
CREATE TABLE SESSION(
   id INT,
   theme VARCHAR(100),
   nomPresident VARCHAR(50),
   nbPlace INT,
   salle VARCHAR(120),
   prix DECIMAL(15,2),
   dateSession DATE,
   estMatin BIT,
   CONSTRAINT pk_session PRIMARY KEY(id)
);

DROP TABLE IF EXISTS HEBERGEMENT;
CREATE TABLE HEBERGEMENT(
   id INT,
   nom VARCHAR(50),
   adresse VARCHAR(200),
   cp CHAR(5),
   ville VARCHAR(40),
   tel CHAR(10),
   nbEtoiles CHAR(1),
   prix DECIMAL(15,2),
   CONSTRAINT pk_hebergement PRIMARY KEY(id)
);

DROP TABLE IF EXISTS ACTIVITE;
CREATE TABLE ACTIVITE(
   id INT,
   nom VARCHAR(100),
   dateActivite DATE,
   nbPlace INT,
   prix DECIMAL(15,2),
   estMatin BIT,
   CONSTRAINT pk_activite PRIMARY KEY(id)
);

DROP TABLE IF EXISTS LIGUE;
CREATE TABLE LIGUE(
   id INT,
   nomLigue VARCHAR(200),
   adresse VARCHAR(200),
   cp CHAR(5),
   ville VARCHAR(50),
   CONSTRAINT pk_ligue PRIMARY KEY(id)
);

DROP TABLE IF EXISTS CONGRESSISTE;
CREATE TABLE CONGRESSISTE(
   id INT,
   nom VARCHAR(50),
   prenom VARCHAR(40),
   tel CHAR(10),
   adresse VARCHAR(200),
   cp CHAR(5),
   ville VARCHAR(50),
   accompte DECIMAL(15,2),
   idLigue INT NOT NULL,
   idHebergement INT NOT NULL,
   CONSTRAINT pk_congressiste PRIMARY KEY(id),
   CONSTRAINT fk_congressiste_ligue FOREIGN KEY(idLigue) REFERENCES LIGUE(id),
   CONSTRAINT fk_congressiste_hebergement FOREIGN KEY(idHebergement) REFERENCES HEBERGEMENT(id)
);

DROP TABLE IF EXISTS INSCRIRE;
CREATE TABLE INSCRIRE(
   idSession INT,
   idCongressiste INT,
   CONSTRAINT pk_inscrire PRIMARY KEY(idSession, idCongressiste),
   CONSTRAINT fk_inscrire_session FOREIGN KEY(idSession) REFERENCES SESSION(id),
   CONSTRAINT fk_inscrire_congressiste FOREIGN KEY(idCongressiste) REFERENCES CONGRESSISTE(id)
);

DROP TABLE IF EXISTS PARTICIPER;
CREATE TABLE PARTICIPER(
   idCongressiste INT,
   idActivite INT,
   CONSTRAINT pk_participer PRIMARY KEY(idCongressiste, idActivite),
   CONSTRAINT fk_participer_congressiste FOREIGN KEY(idCongressiste) REFERENCES CONGRESSISTE(id),
   CONSTRAINT fk_participer_activite FOREIGN KEY(idActivite) REFERENCES ACTIVITE(id)
);

-- Jeu d'essai pour la table SESSION
INSERT INTO SESSION (id, theme, nomPresident, nbPlace, salle, prix, dateSession, estMatin) VALUES 
(1, 'Session d''inauguration', 'Snow', 30, 'La Marignane', 50.00, '2024-06-03', 1),
(2, 'Evaluation psychologique du sportif', 'McKinney', 40, 'Léon Blum', 75.00, '2024-06-05', 0),
(3, 'Pratiques sportives et usages de drogues', 'Costa Correia', 20, '50.00', 100.00, '2024-06-07', 1);

-- Jeu d'essai pour la table HEBERGEMENT
INSERT INTO HEBERGEMENT (id, nom, adresse, cp, ville, tel, nbEtoiles, prix) VALUES 
(1, 'Novotel', '61 Quai de Grenelle', '75015', 'Paris', '0140582000', '2', 80.00),
(2, 'F1', '29 Rue du Dr Babinski', '75015', 'Paris', '0891705350', '1', 120.00),
(3, 'Hilton', '108 Rue Saint-Lazare', '75015', 'Paris', '0140084444', '3', 150.00);

-- Jeu d'essai pour la table ACTIVITE
INSERT INTO ACTIVITE (id, nom, dateActivite, nbPlace, prix, estMatin) VALUES 
(1, 'Natation', '2024-06-03', 15, 20.00, 0),
(2, 'Tennis', '2024-06-05', 20, 30.00, 1),
(3, 'Yoga', '2024-06-07', 40, 40.00, 0);

-- Jeu d'essai pour la table LIGUE
INSERT INTO LIGUE (id, nomLigue, adresse, cp, ville) VALUES 
(1, 'Ligue des Champions', '116 Bis Cr de Vincennes', '75012', 'Paris'),
(2, 'Ligue Lorraine de Tennis', '144 Rue La Fayette', '75010', 'Paris'),
(3, 'Ligue Occitanie de Tennis', '5 Avenue Suzanne Lenglen', '31130', ' Balma');

-- Jeu d'essai pour la table CONGRESSISTE
INSERT INTO CONGRESSISTE (id, nom, prenom, tel, adresse, cp, ville, accompte, idLigue, idHebergement) VALUES 
(1, 'Gareau', 'Aurélie', '0781001230', '6 Rue Froment', '75011', 'Paris', 50.00, 1, 1),
(2, 'Plouffe', 'Laisné', '0652031245', '5 bis Rue André Dubois', '75019', 'Paris', 75.00, 2, 2),
(3, 'Karlsen', 'Fabrizio Napolitani', '0612302510', '21 Rue des Grands Champs', '75020', 'Paris', 100.00, 3, 3);

-- Jeu d'essai pour la table INSCRIRE
INSERT INTO INSCRIRE (idSession, idCongressiste) VALUES 
(1, 1),
(2, 2),
(3, 3);

-- Jeu d'essai pour la table PARTICIPER
INSERT INTO PARTICIPER (idCongressiste, idActivite) VALUES 
(1, 1),
(2, 2),
(3, 3);

GO

-- Procédure stockée qui renvoie le nombre de place disponible pour un idSession donné
drop procedure if exists dbo.nbPlaceDispoSession;
go
CREATE PROCEDURE nbPlaceDispoSession
@idS INT
AS
   declare @nbPlacePrise INT
   select @nbPlacePrise=count(*) from INSCRIRE where idSession = @idS
   select SUM(nbPlace - @nbPlacePrise) as nbPlaceDispo from SESSION where id = @idS



-- Procédure stockée qui renvoie le nombre de place disponible pour un idActivite donné
drop procedure if exists dbo.nbPlaceDispoActivite;
go
CREATE PROCEDURE nbPlaceDispoActivite
@idA INT
AS
   declare @nbPlaceReserver INT
   select @nbPlaceReserver = count(*)  from PARTICIPER where idActivite = @idA
   select SUM(nbPlace - @nbPlaceReserver) as nbPlaceDispo from ACTIVITE where id = @idA

-- Procédure stockée qui renvoie le montant totale à régler pour un congressiste donné
DROP PROCEDURE IF EXISTS dbo.montantTotal
GO
CREATE PROCEDURE montantTotal 
    @idC INT
AS
    DECLARE @accompte DECIMAL(15,2)
    DECLARE @montantT DECIMAL(15,2)

    SELECT @montantT = prix FROM HEBERGEMENT WHERE id = (SELECT idHebergement FROM CONGRESSISTE WHERE id = @idC)
    SELECT @montantT = @montantT + ISNULL(SUM(prix), 0) FROM ACTIVITE WHERE id IN (SELECT idActivite FROM PARTICIPER WHERE idCongressiste = @idC)
    SELECT SUM(@montantT - accompte) as montantTotal FROM CONGRESSISTE WHERE id = @idC