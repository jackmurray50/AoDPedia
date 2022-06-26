CREATE PROCEDURE [dbo].[SpPopulateBookData]
AS
	--DELETE FROMs
	DELETE FROM T_Army;
	DELETE FROM T_Army_Unit;
	DELETE FROM T_Rite_Of_War;
	DELETE FROM T_Warlord_Traits;
	DELETE FROM T_Model;
	DELETE FROM T_Model_Special_Rules;
	DELETE FROM T_Model_Types;
	DELETE FROM T_Model_Model_Types;
	DELETE FROM T_Model_Wargear;
	DELETE FROM T_Model_Weapons;
	DELETE FROM T_Unit;
	DELETE FROM T_Unit_Composition_Models;
	DELETE FROM T_Unit_Composition_Wargear;
	DELETE FROM T_Unit_Composition_Weapon;
	DELETE FROM T_Unit_Option_Model;
	DELETE FROM T_Unit_Option_Wargear;
	DELETE FROM T_Unit_Option_Weapon;
	DELETE FROM T_Wargear;
	DELETE FROM T_Weapon;
	DELETE FROM T_Rule_Category;
	DELETE FROM T_Rules;
	DELETE FROM T_Source;
	DELETE FROM T_Special_Rules;

	CREATE TABLE [dbo].[#T_Source]
	(
		[Id] NVARCHAR(MAX), 
		[Name] NVARCHAR(MAX), 
		[Abbreviation] NCHAR(10)
	)
	--Begin populating data
	BULK INSERT #T_Source
	FROM 'C:\Users\Jack\source\repos\AoDPedia\AoDPedia\Data\Source.csv'
	WITH(
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		DATAFILETYPE = 'char',
		ROWTERMINATOR = '\n',
		KEEPIDENTITY
	)	

	select * from #T_Source

	INSERT INTO T_Source
	SELECT CAST(Id AS uniqueidentifier), Name, Abbreviation FROM #T_Source
	DROP TABLE #T_Source
	

	CREATE TABLE [dbo].[#T_Unit]
	(
		[Id] NVARCHAR(MAX), 
		[Name] NVARCHAR(MAX), 
		[Cost] INT, 
		[Role] NVARCHAR(25),
		[Fluff] NVARCHAR(MAX), 
		[Source] NVARCHAR(MAX), 
		[Source_Page] INT
	)

	BULK INSERT #T_Unit
	FROM 'C:\Users\Jack\source\repos\AoDPedia\AoDPedia\Data\Units.csv'
	WITH(
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		DATAFILETYPE = 'char',
		ROWTERMINATOR = '\n',
		KEEPIDENTITY
	)

	SELECT * FROM #T_Unit

	INSERT INTO T_Unit 
	SELECT CAST(id AS uniqueidentifier), Name, Cost, Role, fluff, CAST(Source AS uniqueidentifier), Source_Page
	FROM #T_Unit

	DROP TABLE #T_Unit
RETURN 0
