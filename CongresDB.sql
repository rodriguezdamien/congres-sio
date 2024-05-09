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
   id INT identity,
   theme VARCHAR(100),
   nomPresident VARCHAR(50),
   nbPlace INT,
   salle VARCHAR(120),
   prix DECIMAL(15,2),
   dateSession DATE,
   estMatin BIT,
   CONSTRAINT pk_session PRIMARY KEY(id)
);

DROP TABLE IF EXISTS ACTIVITE;
CREATE TABLE ACTIVITE(
   id INT identity,
   nom VARCHAR(100),
   dateActivite DATE,
   nbPlace INT,
   prix DECIMAL(15,2),
   estMatin BIT,
   CONSTRAINT pk_activite PRIMARY KEY(id)
);

DROP TABLE IF EXISTS LIGUE;
CREATE TABLE LIGUE(
   id INT identity,
   nomLigue VARCHAR(200),
   adresse VARCHAR(200),
   cp CHAR(5),
   ville VARCHAR(50),
   CONSTRAINT pk_ligue PRIMARY KEY(id)
);

DROP TABLE IF EXISTS HEBERGEMENT;
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

DROP TABLE IF EXISTS CONGRESSISTE;
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
   idActivite INT,
   idCongressiste INT,
   CONSTRAINT pk_participer PRIMARY KEY(idCongressiste, idActivite),
   CONSTRAINT fk_participer_activite FOREIGN KEY(idActivite) REFERENCES ACTIVITE(id),
   CONSTRAINT fk_participer_congressiste FOREIGN KEY(idCongressiste) REFERENCES CONGRESSISTE(id)
);

-- Jeu d'essai pour la table SESSION
INSERT INTO SESSION (theme, nomPresident, nbPlace, salle, prix, dateSession, estMatin) VALUES 
('Session d''inauguration', 'Snow', 10, 'La Marignane', 50.00, '2024-06-03', 0),
('Stratégies de coaching efficaces', 'Johnson', 8, 'Eiffel', 85.00, '2024-06-03', 1),
('Alimentation et performance sportive', 'Smith', 10, 'Salle des Congrès', 80.00, '2024-06-04', 0),
('Prévention des blessures chez les jeunes sportifs', 'Dubois', 6, 'Rivoli', 75.00, '2024-06-04', 1),
('Evaluation psychologique du sportif', 'McKinney', 8, 'Léon Blum', 75.00, '2024-06-05', 0),
('Gestion du stress chez les athlètes', 'Garcia', 7, 'Montmartre', 70.00, '2024-06-05', 1),
('Nouvelles technologies dans le domaine sportif', 'Wang', 8, 'Palais des Congrès', 90.00, '2024-06-06', 0),
('Réhabilitation après blessure sportive', 'Chen', 10, 'Victor Hugo', 65.00, '2024-06-06', 1),
('Pratiques sportives et usages de drogues', 'Costa Correia', 9, '50.00', 100.00, '2024-06-07', 0),
('Impact du sommeil sur la performance sportive', 'Lee', 10, 'Louvre', 60.00, '2024-06-07', 1);

-- Jeu d'essai pour la table HEBERGEMENT
INSERT INTO HEBERGEMENT (nom, adresse, cp, ville, tel, nbEtoiles, prix) VALUES 
('Hôtel Novotel', '61 Quai de Grenelle', '75015', 'Paris', '0140582000', '2', 120.00),
('Hôtel F1', '29 Rue du Dr Babinski', '75015', 'Paris', '0891705350', '1', 80.00),
('Hôtel Hilton', '108 Rue Saint-Lazare', '75015', 'Paris', '0140084444', '3', 250.00),
('Hôtel Montalembert', '3 Rue de Montalembert', '75007', 'Paris', '0147322000', '2', 160.00),
('Hôtel Bel Ami', '7-11 Rue Saint-Benoît', '75006', 'Paris', '0145458600', '2', 140.00),
('Hôtel Petit Hôtel', '8 Rue Cambronne', '75015', 'Paris', '0145987654', '1', 70.00),
('Hôtel Auberge de la Ville', '5 Rue de la Paix', '75015', 'Paris', '0145678910', '1', 78.00),
('Hôtel des Grands Boulevards', '17 Boulevard Poissonnière', '75002', 'Paris', '0144558998', '2', 190.00),
('Hôtel Napoleon Paris', '40 Avenue de Friedland', '75008', 'Paris', '0145623435', '3', 300.00),
('Hôtel de Crillon', '10 Place de la Concorde', '75008', 'Paris', '0144470000', '3', 350.00);

-- Jeu d'essai pour la table ACTIVITE
INSERT INTO ACTIVITE (nom, dateActivite, nbPlace, prix, estMatin) VALUES 
('Natation', '2024-06-03', 5, 20.00, 0),
('Tennis', '2024-06-03', 6, 30.00, 1),
('Yoga', '2024-06-04', 4, 40.00, 0),
('Course à pied', '2024-06-04', 6, 25.00, 1),
('Cyclisme', '2024-06-05', 7, 30.00, 0),
('Musculation', '2024-06-05', 5, 25.00, 1),
('Randonnée', '2024-06-06', 7, 30.00, 0),
('Escalade', '2024-06-06', 6, 45.00, 1),
('Aquagym', '2024-06-07', 5, 35.00, 0),
('Course d''orientation', '2024-06-07', 8, 30.00, 1);

-- Jeu d'essai pour la table LIGUE
INSERT INTO LIGUE (nomLigue, adresse, cp, ville) VALUES 
('Ligue des Champions', '116 Bis Cr de Vincennes', '75012', 'Paris'),
('Ligue Lorraine de Tennis', '144 Rue La Fayette', '75010', 'Paris'),
('Ligue Occitanie de Tennis', '5 Avenue Suzanne Lenglen', '31130', ' Balma'),
('Ligue Parisienne de Football', '10 Rue Cambrai', '75019', 'Paris'),
('Ligue Bretonne de Natation', '25 Rue de la Tour d''Auvergne', '35000', 'Rennes'),
('Ligue Hauts-de-France de Cyclisme', '8 Rue du Fbg Montmartre', '75009', 'Paris'),
('Ligue Rhône-Alpes de Randonnée', '12 Quai Maréchal Joffre', '69002', 'Lyon'),
('Ligue Alsacienne de Football', '15 Rue de la Première Armée', '67000', 'Strasbourg'),
('Ligue Bourgogne-Franche-Comté de Musculation', '1 Avenue du Stade', '21000', 'Dijon'),
('Ligue Côte d''Azur de Natation', '30 Boulevard des Anglais', '06000', 'Nice');

-- Jeu d'essai pour la table CONGRESSISTE
INSERT INTO CONGRESSISTE (nom, prenom, tel, adresse, cp, ville, accompte, idLigue, idHebergement) VALUES 
('Gareau', 'Aurélie', '0781001230', '6 Rue Froment', '75011', 'Paris', 50.00, 1, 1),
('Plouffe', 'Laisné', '0652031245', '5 bis Rue André Dubois', '75019', 'Paris', 75.00, 2, 2),
('Napolitani', 'Fabrizio', '0612302510', '21 Rue des Grands Champs', '75020', 'Paris', 100.00, 3, 3),
('Dubois', 'Camille', '0678452130', '10 Avenue des Champs-Élysées', '75008', 'Paris', 60.00, 4, 4),
('Paoli', 'Toto', '0612457854', '15 Rue du Faubourg Saint-Honoré', '75008', 'Paris', 200.00, 5, 5),
('Smith', 'Emily', '0623104587', '18 Rue de Rivoli', '75001', 'Paris', 120.00, 6, 6),
('Leao', 'Rafael', '0678321098', '25 Rue de la République', '75002', 'Paris', 160.00, 7, 7),
('López', 'María', '0698745201', '30 Avenue des Champs-Élysées', '75008', 'Paris', 85.00, 1, 1),
('Chen', 'Dadi', '0658741230', '12 Rue de la Paix', '75002', 'Paris', 110.00, 2, 2),
('Kawasaki', 'Jan', '0612345879', '8 Avenue Montaigne', '75008', 'Paris', 105.00, 3, 3);

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

(2, 1),
(2, 2),
(2, 6),
(2, 7),
(2, 9),
(2, 10),

(3, 1),
(3, 3),
(3, 4),
(3, 5),
(3, 6),
(3, 7),
(3, 9),

(4, 3),
(4, 4),
(4, 5),
(4, 6),
(4, 8),
(4, 10),

(5, 3),
(5, 4),
(5, 5),
(5, 6),
(5, 7),
(5, 8),
(5, 9),
(5, 10),

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

(7, 1),
(7, 2),
(7, 3),
(7, 4),
(7, 5),

(8, 1),
(8, 2),
(8, 3),
(8, 4),
(8, 5),
(8, 6),
(8, 7),
(8, 8),

(9, 1),
(9, 2),
(9, 3),
(9, 4),
(9, 5),
(9, 6),
(9, 7),

(10, 1),
(10, 2),
(10, 3),
(10, 4),
(10, 5),
(10, 6),
(10, 7),
(10, 8),
(10, 9),
(10, 10);

-- Jeu d'essai pour la table PARTICIPER
INSERT INTO PARTICIPER (idActivite, idCongressiste) VALUES 
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

(2, 3),
(2, 4),
(2, 5),
(2, 8),

(3, 2),
(3, 8),
(3, 10),

(4, 1),
(4, 2),
(4, 5),
(4, 6),
(4, 7),
(4, 9),

(5, 1),
(5, 2),

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

(7, 6),
(7, 7),
(7, 8),
(7, 9),
(7, 10),

(8, 9),
(8, 10),

(9, 8),
(9, 9),
(9, 10);

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