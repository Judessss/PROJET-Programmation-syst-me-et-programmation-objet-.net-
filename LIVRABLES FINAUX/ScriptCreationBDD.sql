

-- Table Client
CREATE TABLE Client (
  id_client SERIAL PRIMARY KEY,
  nom_client VARCHAR(50)
);

-- Table TABLE  
CREATE TABLE "Table" (
  id_table SERIAL PRIMARY KEY,
  salle_restauration INT
);

-- Table Poste
CREATE TABLE Poste (
  id_poste SERIAL PRIMARY KEY,
  fonction VARCHAR(50)
);


-- Table Employé
CREATE TABLE Employe (
  id_employe SERIAL PRIMARY KEY,
  nom_employe VARCHAR(20),
  poste_employe INT,
  FOREIGN KEY (poste_employe) REFERENCES Poste(id_poste)
);

-- Table Materiel
CREATE TABLE Materiel (
  id_materiel SERIAL PRIMARY KEY,
  nom_materiel VARCHAR,
  quantite_materiel INT
);


-- Table Recette
CREATE TABLE Recette (
  id_recette SERIAL PRIMARY KEY,
  categorie VARCHAR,
  titre VARCHAR,
  nb_personnes INT,
  preparation VARCHAR,
  cuisson VARCHAR,
  repos VARCHAR,
  ingredient TEXT,
  recette TEXT,
  accompagnement VARCHAR,
  materiel INT,
  FOREIGN KEY (materiel) REFERENCES Materiel(id_materiel)
  
);

-- Table Nourriture
CREATE TABLE Nourriture (
  id_nourriture SERIAL PRIMARY KEY,
  nourriture INT,
  prix INT,
  cuisinier int,
  FOREIGN KEY (nourriture) REFERENCES Recette(id_recette),
  FOREIGN KEY (cuisinier) REFERENCES Employe(id_employe)
);

-- Table Commande
CREATE TABLE Commande (
  id_commande SERIAL PRIMARY KEY,
  client INT,
  nourriture INT,
  serveur INT,
  FOREIGN KEY (client) REFERENCES Client(id_client),
  FOREIGN KEY (nourriture) REFERENCES Nourriture(id_nourriture),
  FOREIGN KEY (serveur) REFERENCES Employe(id_employe)
);

