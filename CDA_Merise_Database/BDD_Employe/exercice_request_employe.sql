


-----------------------------EXERECICES EMPLOYE 1ERE PARTIE----------------------------------------

USE Employe
--1.	Donner nom, job, num�ro et salaire de tous les employ�s,puis seulement des employ�s du d�partement 10
--Person(employe_id, name_person, job_person, manager_employe_id, hire_date_person, wage_person, bonus_person, department_department_id)
SELECT name_person, job_person, wage_person FROM Person

SELECT name_person, job_person, wage_person FROM Person 
WHERE department_department_id = 10

--2.	Donner nom, job et salaire des employ�s de type MANAGER dont le salaire est sup�rieur � 2800
SELECT name_person, job_person, wage_person FROM Person 
WHERE job_person = 'MANAGER' AND wage_person > 2800

--3.	Donner la liste des MANAGER n'appartenant pas au d�partement 30
SELECT name_person, job_person, department_department_id  FROM Person 
WHERE job_person = 'MANAGER' AND department_department_id != 30

--4.	Liste des employ�s de salaire compris entre 1200 et 1400
SELECT name_person, job_person, wage_person from Person WHERE wage_person >= 1200 AND wage_person <= 1400

--5.	Liste des employ�s des d�partements 10 et 30 class�s dans l'ordre alphab�tique
SELECT name_person,  department_department_id  FROM Person WHERE  department_department_id != 20 
ORDER BY name_person ASC

--6.	Liste des employ�s du d�partement 30 class�s dans l'ordre des salaires croissants
SELECT name_person, wage_person, department_department_id FROM Person 
WHERE department_department_id = 30 
ORDER BY wage_person ASC

--7.	Liste de tous les employ�s class�s par emploi et salaires d�croissants
SELECT name_person, job_person, wage_person FROM Person 
ORDER BY job_person ASC,  wage_person DESC

--8.	Liste des diff�rents emplois
SELECT job_person FROM Person 
GROUP BY job_person

SELECT DISTINCT job_person FROM Person

--9.	Donner le nom du d�partement o� travaille ALEN
SELECT department_name FROM Department 
LEFT JOIN Person ON department_department_id = department_id 
WHERE name_person = 'ALEN'

--10.	Liste des employ�s avec nom du d�partement, nom, job, salaire class�s par noms de d�partements et par salaires d�croissants.
SELECT name_person, job_person, wage_person, department_name FROM Person 
FULL OUTER JOIN Department ON department_department_id = department_id 
ORDER BY department_name ASC, wage_person DESC

--11.	Liste des employ�s vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions
SELECT name_person, job_person, wage_person,ISNULL(bonus_person, 0), wage_person + COALESCE(bonus_person, 0)  FROM Person  
WHERE job_person = 'SALESMAN'

--12.	Liste des employ�s du d�partement 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997' ddd DD MM AAAA
SELECT name_person, job_person, FORMAT(hire_date_person, 'ddd dd MMM yyyy', 'FR-fr')  FROM Person 
WHERE department_department_id = 20

--13.	Donner le salaire le plus �lev� par d�partement
SELECT  MAX(wage_person), department_name FROM Person 
INNER JOIN Department ON department_department_id = department_id 
GROUP BY department_name

--14.	Donner d�partement par d�partement masse salariale, nombre d'employ�s, salaire moyen par type d'emploi.
SELECT  department_name, job_person, SUM(wage_person) AS payroll, COUNT(*) AS number_employe, AVG(wage_person) AS average_wage FROM Person
INNER JOIN Department ON department_department_id = department_id 
GROUP BY department_name, job_person 

--15.	M�me question mais on se limite aux sous-ensembles d'au moins 2 employ�s
SELECT  department_name, job_person, SUM(wage_person) AS payroll, COUNT(*) AS number_employe , AVG(wage_person) AS average_wage FROM Person
INNER JOIN Department ON department_department_id = department_id GROUP BY department_name, job_person HAVING COUNT(*) > 1

--16.	Liste des employ�s (Nom, d�partement, salaire) de m�me emploi que JONES
SELECT name_person, job_person, wage_person, department_name From Person 
INNER JOIN Department ON department_department_id = department_id 
WHERE job_person = (
		SELECT job_person From Person WHERE name_person = 'JONES')

--17.	Liste des employ�s (nom, salaire) dont le salaire est sup�rieur � la moyenne globale des salaires
SELECT name_person, wage_person FROM Person WHERE wage_person > (
		SELECT AVG(wage_person) FROM Person) ORDER BY name_person ASC

--18.	Cr�ation d'une table PROJET avec comme colonnes num�ro de projet (3 chiffres), nom de projet(5 caract�res), budget. Entrez les valeurs suivantes:
		--101, ALPHA,	96000
		--102, BETA,	82000
		--103, GAMMA,	15000



--19.   Ajouter l'attribut num�ro de projet � la table EMP et affecter tous les vendeurs du d�partement 30 au projet 101, et les autres au projet 102


UPDATE Person
SET person_projet_id 
= CASE department_department_id 
WHEN 30 THEN 101 
ELSE 102
END

--20.   Cr�er une vue comportant tous les employ�s avec nom, job, nom de d�partement et nom de projet
CREATE VIEW EmployeInfo AS
SELECT name_person, job_person, department_name, nom_projet FROM Person 
INNER JOIN Department ON department_department_id = department_id
INNER JOIN PROJET ON projet_id = person_projet_id 


--21.	A l'aide de la vue cr��e pr�c�demment, lister tous les employ�s avec nom, job, nom de d�partement et nom de projet tri�s sur nom de d�partement et nom de projet
SELECT  name_person, job_person, department_name, nom_projet
FROM EmployeInfo
ORDER BY department_name ASC, nom_projet ASC

--22.	Donner le nom du projet associ� � chaque manager
SELECT name_person, job_person, nom_projet FROM Person 
INNER JOIN PROJET ON projet_id = person_projet_id
WHERE job_person = 'MANAGER'
ORDER BY name_person ASC


--SELECT * FROM Person

-----------------------------EXERECICES EMPLOYE 2EME PARTIE----------------------------------------

--1.	Afficher la liste des managers des d�partements 20 et 30
SELECT name_person, job_person, department_id FROM Person 
INNER JOIN Department ON department_department_id = department_id
WHERE (department_id = 20 OR department_id = 30) AND job_person = 'MANAGER'

--2.	Afficher la liste des employ�s qui ne sont pas manager et qui ont �t� embauch�s en 81
SELECT name_person, job_person, hire_date_person FROM Person
WHERE job_person != 'MANAGER' AND YEAR(hire_date_person) = 1981

--3.	Afficher la liste des employ�s ayant une commission
SELECT name_person, bonus_person FROM PERSON
WHERE bonus_person != NULL OR bonus_person != 0

--4.	Afficher la liste des noms, num�ros de d�partement, jobs et date d'embauche tri�s par Numero de D�partement et JOB  les derniers embauches d'abord.
SELECT name_person, department_department_id, job_person, hire_date_person FROM Person
ORDER BY department_department_id ASC, job_person ASC,  hire_date_person DESC

--5.	Afficher la liste des employ�s travaillant � DALLAS
SELECT name_person, department_location FROM Person
INNER JOIN Department ON department_department_id = department_id
WHERE department_location = 'DALLAS'
	
--6.	Afficher les noms et dates d'embauche des employ�s embauch�s avant leur manager, avec le nom et date d'embauche du manager.
SELECT e.name_person AS employe, FORMAT(e.hire_date_person, 'ddd dd MMM yyyy', 'FR-fr'), m.name_person AS manager, FORMAT(m.hire_date_person, 'ddd dd MMM yyyy', 'FR-fr') from Person AS e 
INNER JOIN Person AS m ON e.manager_employe_id = m.employe_id
WHERE e.hire_date_person < m.hire_date_person


--7.	Lister les num�ros des employ�s n'ayant pas de subordonn�.
SELECT e.name_person from Person AS e 
INNER JOIN Person AS m ON e.manager_employe_id = m.employe_id
WHERE e.employe_id NOT IN(m.manager_employe_id)
	
--8.	Afficher les noms et dates d'embauche des employ�s embauch�s avant BLAKE.
SELECT name_person, hire_date_person FROM Person 
WHERE hire_date_person < (SELECT hire_date_person FROM Person WHERE name_person  = 'BLAKE')

--9.	Afficher les employ�s embauch�s le m�me jour que FORD.
SELECT name_person, hire_date_person FROM Person 
WHERE hire_date_person = (SELECT hire_date_person FROM Person WHERE name_person  = 'FORD') AND name_person != 'FORD'

--10.	Lister les employ�s ayant le m�me manager que CLARK.
SELECT name_person, hire_date_person FROM Person 
WHERE hire_date_person = (SELECT hire_date_person FROM Person WHERE name_person  = 'FORD') AND name_person != 'FORD'

--11.	Lister les employ�s ayant m�me job et m�me manager que TURNER.
SELECT name_person, job_person, manager_employe_id FROM Person 
WHERE job_person = (
	SELECT job_person FROM Person
	WHERE name_person = 'TURNER') 
	--AND name_person != 'TURNER' 
	AND manager_employe_id = (
		SELECT manager_employe_id FROM Person
		WHERE name_person = 'TURNER')

--12.	Lister les employ�s du d�partement RESEARCH embauch�s le m�me jour que quelqu'un du d�partement SALES.
SELECT EMP.name_person FROM Person AS EMP
INNER JOIN Department AS DPT ON EMP.department_department_id = DPT.department_id
WHERE DPT.department_name = 'RESEARCH' 
AND hire_date_person IN(
	SELECT hire_date_person FROM Person 
	INNER JOIN Department ON department_department_id = department_id
	WHERE department_name = 'SALES')

--13.	Lister le nom des employ�s et �galement le nom du jour de la semaine correspondant � leur date d'embauche.
SET LANGUAGE french
SELECT name_person, DATENAME(weekday,hire_date_person) AS HIREDAY FROM Person

--14.	Donner, pour chaque employ�, le nombre de mois qui s'est �coul� entre leur date d'embauche et la date actuelle.
SELECT name_person, DATEDIFF(month,hire_date_person, GETDATE()) FROM Person

--15.	Afficher la liste des employ�s ayant un M et un A dans leur nom.
SELECT name_person FROM Person WHERE name_person LIKE '%A%M%' 

--16.	Afficher la liste des employ�s ayant deux 'A' dans leur nom.
SELECT name_person FROM Person WHERE name_person LIKE '%A%A%' 

--17.	Afficher les employ�s embauch�s avant tous les employ�s du d�partement 10.
SELECT name_person FROM Person WHERE hire_date_person < (
	SELECT MIN(hire_date_person) FROM Person WHERE department_department_id = 10)

--18.	S�lectionner le m�tier o� le salaire moyen est le plus faible.
SELECT job_person, AVG(wage_person) AS AVERAGE FROM Person GROUP BY job_person H
AVING wage_person
--19.	S�lectionner le d�partement ayant le plus d'employ�s.


--20.	Donner la r�partition en pourcentage du nombre d'employ�s par d�partement selon le mod�le ci-dessous

--D�partement R�partition en % 
-----------       ---------------- 
--10                  21.43            
--20                 35.71            
--30	 42.86 


--DECLARE @TEST VARCHAR
--SET @TEST = (SELECT name_person FROM Person WHERE employe_id = 7839)