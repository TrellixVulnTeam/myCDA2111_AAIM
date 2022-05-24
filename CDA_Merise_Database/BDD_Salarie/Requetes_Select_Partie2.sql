USE SALARIE

-- Choses importantes de cette partie : LIKE ; Jointure ou Sous-requ�tes (questions 7, 11) ; Sous-requ�tes ; ORDER BY ; GROUP BY ; AVG ; SUM

-- 1.	Afficher la liste des managers des d�partements 20 et 30
SELECT EMPNOM, EMPMETIER, EMP_DPTNO FROM EMPLOYE
WHERE EMPMETIER = 'MANAGER' AND EMP_DPTNO IN (20, 30);

SELECT EMPNOM, EMPMETIER, EMP_DPTNO FROM EMPLOYE
WHERE EMPMETIER = 'MANAGER' AND (EMP_DPTNO = 20 OR EMP_DPTNO = 30);

-- 2.	Afficher la liste des employ�s qui ne sont pas manager et qui ont �t� embauch�s en 81

SELECT EMPNOM, EMPEMBDATE FROM EMPLOYE
WHERE EMPMETIER <> 'MANAGER' AND YEAR(EMPEMBDATE) = '1981'

SELECT EMPNOM, EMPEMBDATE FROM EMPLOYE
WHERE EMPMETIER <> 'MANAGER' AND FORMAT(EMPEMBDATE, 'yyyy') = 1981;

-- 3.	Afficher la liste des employ�s ayant une commission

SELECT *
FROM EMPLOYE
WHERE EMPCOMM IS NOT NULL;

-- IS NOT NULL : permet de sp�cifier que l'on ne prend que des valeurs non null dans la colonne EMPCOMM

-- 4.	Afficher la liste des noms, num�ros de d�partement, EMPMETIERs et date d'embauche tri�s par Numero de D�partement et EMPMETIER  les derniers embauches d'abord.
SELECT EMPNOM, EMP_DPTNO, EMPMETIER, EMPEMBDATE 
FROM EMPLOYE
ORDER BY EMP_DPTNO ASC, EMPMETIER ASC, EMPEMBDATE DESC;


-- 5.	Afficher la liste des employ�s travaillant � DALLAS
SELECT EMPNOM 
FROM EMPLOYE
WHERE EMP_DPTNO = (SELECT EMP_DPTNO FROM DEPARTEMENT WHERE DPTLOC = 'DALLAS');
	
SELECT EMPNOM 
FROM EMPLOYE
INNER JOIN DEPARTEMENT ON EMPLOYE.EMP_DPTNO = DEPARTEMENT.DPTNO
WHERE DPTLOC = 'DALLAS';

-- 6.	Afficher les noms et dates d'embauche des employ�s embauch�s avant leur manager, avec le nom et date d'embauche du manager.
SELECT MANAGER.EMPNOM AS ManagerName, MANAGER.EMPEMBDATE AS ManagerHiredate, EMPLOYE.EMPNOM AS EmployeEMPNOM, EMPLOYE.EMPEMBDATE AS EmployeeHiredate
FROM EMPLOYE
INNER JOIN EMPLOYE AS MANAGER ON EMPLOYE.EMP_MGR = MANAGER.EMPNO
WHERE EMPLOYE.EMPEMBDATE < MANAGER.EMPEMBDATE;

-- On fait une jointure de la table des employ�s vers elle m�me en faisant correspondre le num�ro des managers des employ�s avec le num�ro d'employ� des managers
-- Dans ce cas il faut penser � utiliser un alias pour bien diff�rencier employ� et manager

-- 7.	Lister les num�ros des employ�s n'ayant pas de subordonn�.

-- soluce 1 : avec jointure
SELECT managers.EMPNO, managers.EMPNOM FROM EMPLOYE AS managers
	LEFT JOIN EMPLOYE AS subordonates
	ON managers.EMPNO = subordonates.EMP_MGR
	WHERE subordonates.EMP_MGR IS null;

-- soluce 2 : avec sous requete
SELECT EMPNO, EMPNOM FROM EMPLOYE
	WHERE EMPNO NOT IN (SELECT EMP_MGR FROM EMPLOYE WHERE EMP_MGR IS NOT NULL); 

-- 8.	Afficher les noms et dates d'embauche des employ�s embauch�s avant BLAKE.

SELECT EMPNO, EMPNOM, EMPEMBDATE FROM EMPLOYE
	WHERE EMPEMBDATE < (SELECT EMPEMBDATE FROM EMPLOYE WHERE EMPNOM = 'BLAKE')

-- 9.	Afficher les employ�s embauch�s le m�me jour que FORD.


SELECT EMPNO, EMPNOM, EMPEMBDATE FROM EMPLOYE
	WHERE EMPEMBDATE = (SELECT EMPEMBDATE FROM EMPLOYE WHERE EMPNOM = 'FORD')


-- 10.	Lister les employ�s ayant le m�me manager que CLARK.

SELECT EMPNO, EMPNOM, EMP_MGR FROM EMPLOYE
	WHERE EMP_MGR = (SELECT EMP_MGR FROM EMPLOYE WHERE EMPNOM = 'CLARK')

-- 11.	Lister les employ�s ayant m�me EMPMETIER et m�me manager que TURNER.
SELECT EMPLOYE.EMPNOM, EMPLOYE.EMPEMBDATE, EMPLOYE.EMPMETIER, EMPLOYE.EMP_MGR
FROM EMPLOYE LEFT JOIN EMPLOYE AS EMPBIS ON EMPLOYE.EMP_MGR = EMPBIS.EMP_MGR
WHERE EMPBIS.EMPNOM = 'TURNER' AND EMPLOYE.EMPMETIER = EMPBIS.EMPMETIER;

SELECT EMPLOYE.EMPNOM, EMPLOYE.EMPEMBDATE, EMPLOYE.EMPMETIER, EMPLOYE.EMP_MGR
FROM EMPLOYE
WHERE EMPMETIER = (SELECT EMPMETIER FROM EMPLOYE WHERE EMPNOM = 'TURNER') 
	AND EMP_MGR = (SELECT EMP_MGR FROM EMPLOYE WHERE EMPNOM = 'TURNER');

-- 12.	Lister les employ�s du d�partement RESEARCH embauch�s le m�me jour que quelqu'un du d�partement SALES.




-- 13.	Lister le nom des employ�s et �galement le nom du jour de la semaine correspondant � leur date d'embauche.



-- 14.	Donner, pour chaque employ�, le nombre de mois qui s'est �coul� entre leur date d'embauche et la date actuelle.

SELECT EMPNOM, DATEDIFF(month,EMPEMBDATE,GETDATE()) AS MOIS_DEPUIS_EMBAUCHE
FROM EMPLOYE;

-- J'utilise la fonction int�gr�e 'DATEDIFF()' qui prend en param�tre un interval, une date de d�part et une date de fin. J'utilise 'GETDATE()' pour connaitre la date d'aujourd'hui.

-- 15.	Afficher la liste des employ�s ayant un M et un A dans leur nom.

SELECT EMPNOM
FROM EMPLOYE
WHERE CHARINDEX('A', EMPLOYE.EMPNOM) > 0 AND CHARINDEX('M', EMPLOYE.EMPNOM) > 0 ;

SELECT EMPNOM
FROM EMPLOYE
WHERE EMPNOM LIKE '%M%' AND EMPNOM LIKE '%A%';
-- A% Tous les mots commen�ant par A
-- %A Tous les mots finissant par A
-- %A% Tous les mots ayant au moins 1 A

-- 16.	Afficher la liste des employ�s ayant deux 'A' dans leur nom.
SELECT * 
FROM EMPLOYE
WHERE (LEN(EMPNOM) - LEN(REPLACE(EMPNOM,'A',''))) = 2


-- 17.	Afficher les employ�s embauch�s avant tous les employ�s du d�partement 10.
SELECT EMPNOM
FROM EMPLOYE
WHERE EMPEMBDATE < ALL(SELECT EMPEMBDATE FROM EMPLOYE WHERE EMP_DPTNO = 10);
-- < ALL(SELECT...) permet de sp�cifier que la valeur est inf�rieur � toutes les valeurs retourn�es par la sous-requ�te


-- 18.	S�lectionner le m�tier o� le salaire moyen est le plus faible.
SELECT EMPMETIER, AVG(EMPSAL) FROM EMPLOYE
GROUP BY EMPMETIER
HAVING AVG(EMPSAL) <= ALL(SELECT AVG(EMPSAL) FROM EMPLOYE GROUP BY EMPMETIER);



-- 19.	S�lectionner le d�partement ayant le plus d'employ�s.
SELECT EMP_DPTNO, COUNT(EMPNO)
FROM EMPLOYE
GROUP BY EMP_DPTNO
HAVING COUNT(EMPNO) >= ALL (SELECT COUNT(EMPNO) FROM EMPLOYE GROUP BY EMP_DPTNO);
-- COUNT(EMPNO) : pour compter le nombre d'emply� par departement
-- HAVING COUNT(EMPNO) >= ALL (SELECT ...) : On veut le groupe qui a le plus d'employes 

-- 20.	Donner la r�partition en pourcentage du nombre d'employ�s par d�partement selon le mod�le ci-dessous

SELECT EMP_DPTNO, CAST(CAST(COUNT(EMPNO) AS REAL)*100 / (SELECT COUNT(EMPNO) FROM EMPLOYE) AS DECIMAL(5,2)) AS Pourcentage
FROM EMPLOYE
GROUP BY EMP_DPTNO;

-- CAST(valeur AS type_d�sir�) ; 
-- DECIMAL (5,2)  => nombre d�cimal compos� de 5 caract�res avec 2 nombres apr�s la virgule
-- RAPPEL : on peut faire n'importe quel calcul dans nos requ�tes. Ici on fait un pourcentage.