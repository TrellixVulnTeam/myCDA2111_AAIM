USE TP2_Franck;

CREATE TABLE avions(
	av TINYINT NOT NULL,
	marque VARCHAR(32)NOT NULL,
	avType VARCHAR(16)NOT NULL,
	capacite SMALLINT NOT NULL,
	localisation VARCHAR(16) NOT NULL,
		CONSTRAINT PK_Avions_av PRIMARY KEY (av)
);
CREATE TABLE pilotes(
	pil TINYINT NOT NULL,
	nom VARCHAR(16) NOT NULL,
	adresse VARCHAR(16) NOT NULL,
		CONSTRAINT PK_Pilotes_pil PRIMARY KEY (pil)
);

CREATE TABLE vols(
	vol VARCHAR(5) NOT NULL,
	avion TINYINT NOT NULL,
	pilote TINYINT NOT NULL,
	vd VARCHAR(16) NOT NULL,
	va VARCHAR(16) NOT NULL,
	hd TINYINT NOT NULL,
	ha TINYINT NOT NULL,
		CONSTRAINT PK_Vols_vol PRIMARY KEY (vol),	
		CONSTRAINT FK_Vols_avion FOREIGN KEY (avion) REFERENCES avions (av),
		CONSTRAINT FK_Vols_pilote FOREIGN KEY (pilote) REFERENCES pilotes (pil)
);