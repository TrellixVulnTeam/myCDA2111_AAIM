USE SALARIE;
--USE MASTER

-- 1.	Donner nom, EMPMETIER, num�ro et salaire de tous les employ�s, puis seulement des employ�s du d�partement 10

-- selectionne les attribut suivant � afficher : EMPNO, EMPNOM, EMPMETIER, EMPSAL depuis la table EMPlOYE
SELECT EMPNO, EMPNOM, EMPMETIER, EMPSAL 
FROM EMPlOYE;

-- selectionne les m�mes attributs uniquement pour les employ� du d�partement 10 (DPTNO = 10)
SELECT EMPNO, EMPNOM, EMPMETIER, EMPSAL 
FROM EMPlOYE WHERE EMPLOYE.DPTNO = 10;


-- 2.	Donner nom, EMPMETIER et salaire des employ�s de type MANAGER dont le salaire est sup�rieur � 2800
SELECT EMPNOM, EMPMETIER, EMPSAL 
FROM EMPlOYE 
WHERE EMPMETIER = 'MANAGER' AND EMPSAL > 2800;

-- "WHERE EMPMETIER = 'MANAGER'" : condition pour selectionner les managers
-- "AND" : pour ajouter une deuxi�me condition
-- "EMPSAL > 2800" : pour la condition du salaire minimal 


-- 3.	Donner la liste des MANAGER n'appartenant pas au d�partement 30
SELECT EMPNOM, EMPMETIER, EMPLOYE.DPTNO 
FROM EMPlOYE 
WHERE EMPMETIER = 'MANAGER' AND EMPLOYE.DPTNO <> 30.

-- 4.	Liste des employ�s de salaire compris entre 1200 et 1400
SELECT * 
FROM  EMPlOYE 
WHERE EMPSAL > 1200 AND EMPSAL < 1400;

-- 5.	Liste des employ�s des d�partements 10 et 30 class�s dans l'ordre alphab�tique
SELECT * 
FROM EMPlOYE 
WHERE EMPLOYE.DPTNO  = 10 OR EMPLOYE.DPTNO  =  30 
ORDER BY EMPNOM;
--ORDER BY : permet de d�finir une colonne dont on veut l'ordre alphab�tique.

-- Alternative
SELECT * 
FROM EMPlOYE 
WHERE EMPLOYE.DPTNO  IN (10,30)  -- IN : permet de lister toutes les valeurs attendues
ORDER BY EMPNOM;




-- 6.	Liste des employ�s du d�partement 30 class�s dans l'ordre des salaires croissants

SELECT *
FROM EMPlOYE
WHERE EMPLOYE.DPTNO IN (30) 
ORDER BY EMPSAL ASC;
-- Ordre des salaires dans l'ordre croissant ASC = ordre croissant DESC = ordre d�croissant

-- 7.	Liste de tous les employ�s class�s par emploi et salaires d�croissants

SELECT *
FROM EMPlOYE
ORDER BY EMPMETIER DESC,EMPSAL DESC;

-- 8.	Liste des diff�rents emplois
SELECT DISTINCT EMPMETIER
FROM EMPlOYE

-- DISTINCT sert � lister une seule occurrence dans une colonne. 

-- Autre soloution accept�e :
SELECT EMPMETIER
FROM EMPlOYE
GROUP BY EMPMETIER;


-- 9.	Donner le nom du d�partement o� travaille ALLEN

SELECT DEPARTEMENT.DPTNOM 
FROM DEPARTEMENT
INNER JOIN EMPlOYE ON EMPlOYE.DPTNO = DEPARTEMENT.DPTNO
WHERE EMPlOYE.EMPNOM = 'ALLEN';
-- Je fais une jointure avec mon 'INNER JOIN' pour acc�der au nom du d�partement.

SELECT DEPARTEMENT.DPTNOM 
FROM DEPARTEMENT
WHERE DPTNO = (SELECT EMPlOYE.DPTNO 
					FROM EMPlOYE
					WHERE EMPNOM = 'ALLEN')

-- Deuxi�me version avec une sous-requ�te � la place d'une jointure.



-- 10.	Liste des employ�s avec nom du d�partement, nom, EMPMETIER, salaire class�s par noms de d�partements et par salaires d�croissants.
SELECT EMPNOM, DPTNOM, EMPMETIER, EMPSAL 
FROM EMPlOYE 
INNER JOIN DEPARTEMENT ON EMPlOYE.DPTNO = DEPARTEMENT.DPTNO 
ORDER BY DPTNOM DESC, EMPSAL DESC


-- 11.	Liste des employ�s vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions

Select EMPNOM, EMPSAL, EMPCOMM, (EMPSAL + EMPCOMM) AS CALCUL 
From EMPlOYE
WHERE EMPMETIER = 'SALESMAN';

-- On peut faire n'importe quels calculs sur n'importe quelle colonne qui utilise des valeurs de type num�rique.


-- 12.	Liste des employ�s du d�partement 20: nom, EMPMETIER, date d'embauche sous forme VEN 28 FEV 1997'

Select EMPNOM, EMPMETIER, FORMAT(EMPEMBDATE, 'ddd dd MMM yyyy', 'FR-fr') 
FROM EMPlOYE
WHERE DPTNO = 20;


-- 13.	Donner le salaire le plus �lev� par d�partement
SELECT MAX (EMPSAL) AS SALMAX, DPTNO 
FROM EMPlOYE 
GROUP BY DPTNO;  
-- max pour d�terminer le salaire max as=alias group by pour grouper 

-- 14.	Donner d�partement par d�partement masse salariale, nombre d'employ�s, salaire moyen par type d'emploi.
     select DPTNO, SUM(EMPSAL) AS SumSal, AVG(EMPSAL) AS AverageSal, count (EMPNOM) AS EmployeeCount,EMPMETIER
	 from EMPlOYE
	 group by DPTNO,EMPMETIER
	 order by DPTNO;



-- 15.	M�me question mais on se limite aux sous-ensembles d'au moins 2 employ�s
	SELECT DPTNOM, EMPMETIER, SUM(EMPSAL), COUNT(*) AS NBRPERSON, AVG(EMPSAL) AS AVERAGESAL 
	FROM EMPlOYE
	INNER JOIN DEPARTEMENT ON DEPARTEMENT.DPTNO = EMPlOYE.DPTNO
	GROUP BY DPTNOM, EMPMETIER 
	HAVING COUNT(*) > 1;

	-- HAVING permet d'ajouter des conditions sur des valeurs agr�g�e (avec un GROUP BY)

-- 16.	Liste des employ�s (Nom, d�partement, salaire) de m�me emploi que JONES
SELECT EMPlOYE.EMPNOM, EMPlOYE.DPTNO, EMPlOYE.EMPSAL 
FROM EMPlOYE 
WHERE EMPlOYE.EMPMETIER = (SELECT EMPlOYE.EMPMETIER FROM EMPlOYE  WHERE EMPNOM ='JONES');

-- j'ai affich� la liste des employ�s (Nom, d�partement, salaire) de m�me emploi que JONES

-- 17.	Liste des employ�s (nom, salaire) dont le salaire est sup�rieur � la moyenne globale des salaires
SELECT EMPNOM, EMPSAL 
FROM EMPlOYE
WHERE EMPSAL > (SELECT AVG(EMPSAL)FROM EMPlOYE)

-- 18.	Cr�ation d'une table PROJET avec comme colonnes num�ro de projet (3 chiffres), nom de projet(5 caract�res), budget. Entrez les valeurs suivantes:
-- 101, ALPHA,	96000
-- 102, BETA,	82000
-- 103, GAMMA,	15000

--VOIR AUTRES FICHIERS
 
-- 19.	Ajouter l'attribut num�ro de projet � la table EMPlOYE et affecter tous les vendeurs du d�partement 30 au projet 101, et les autres au projet 102

-- VOIR AUTRES FICHIERS

-- 20.	 Cr�er une vue comportant tous les employ�s avec nom, EMPMETIER, nom de d�partement et nom de projet



CREATE VIEW EMPLOYE_INFO AS E
	SELECT E.EMPNOM, E.EMPMETIER, d.DPTNOM, p.PROJNOM FROM EMPlOYE AS e
	INNER JOIN DEPARTEMENT AS d ON d.DPTNO = E.DPTNO
	INNER JOIN PROJET AS p ON p.PROJNO = E.PROJNO;

-- 21.	A l'aide de la vue cr��e pr�c�demment, lister tous les employ�s avec nom, EMPMETIER, nom de d�partement et nom de projet tri�s sur nom de d�partement et nom de projet

SELECT * FROM employees_info
	ORDER BY DPTNOM, PROJNOM;


-- 22.	Donner le nom du projet associ� � chaque manager
SELECT PROJNOM FROM employees_info WHERE EMPMETIER = 'MANAGER';

CREATE TABLE nomenclature(
reference_mat_compose INT,
reference_mat_composant INT,
CONSTRAINT PK_id_nomEnclature PRIMARY KEY(reference_mat_compose, reference_mat_composant)
);


