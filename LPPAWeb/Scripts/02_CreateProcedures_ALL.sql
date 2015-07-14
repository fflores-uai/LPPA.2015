CREATE PROCEDURE [sp_update_Person]
@BusinessEntityID int
,@PersonType nchar(2)
,@NameStyle bit
,@Title nvarchar(8)
,@FirstName nvarchar(50)
,@MiddleName nvarchar(50)
,@LastName nvarchar(50)
,@Suffix nvarchar(10)
,@EmailPromotion int
,@AdditionalContactInfo xml(CONTENT Person.AdditionalContactInfoSchemaCollection)
,@Demographics xml(CONTENT Person.IndividualSurveySchemaCollection)



AS
BEGIN
	SET NOCOUNT ON;
	update Person.Person set 
	
       
           [PersonType] = @PersonType
           ,[NameStyle]= @NameStyle
           ,[Title]= @Title
           ,[FirstName]= @FirstName
           ,[MiddleName]= @MiddleName
           ,[LastName]=@LastName
           ,[Suffix]=@Suffix
           ,[EmailPromotion]=@EmailPromotion
           ,[AdditionalContactInfo]=@AdditionalContactInfo
           ,[Demographics]=@Demographics
           ,[ModifiedDate]= getdate()
           where [BusinessEntityID] = @BusinessEntityID
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_remove_Person]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_remove_Person]
@BussinessEntityID int


AS
BEGIN
	SET NOCOUNT ON;
	delete from Person.person 
	where BusinessEntityID=@BussinessEntityID;
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetOne_Person]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [sp_GetOne_Person]
@BussinessEntityID int

AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Person.Person where BusinessEntityID=@BussinessEntityID;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetOne_Department]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [sp_GetOne_Department]
@DeparmentId int

AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from [HumanResources].Department where DepartmentID=@DeparmentId;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAll_Person]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_GetAll_Person]

AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Person.Person;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAll_Department]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [sp_GetAll_Department]

AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from [HumanResources].Department
END
GO
/****** Object:  StoredProcedure [dbo].[sp_add_Person]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_add_Person]
@PersonType nchar(2)
,@NameStyle bit
,@Title nvarchar(8)
,@FirstName nvarchar(50)
,@MiddleName nvarchar(50)
,@LastName nvarchar(50)
,@Suffix nvarchar(10)
,@EmailPromotion int
,@AdditionalContactInfo xml(CONTENT Person.AdditionalContactInfoSchemaCollection)
,@Demographics xml(CONTENT Person.IndividualSurveySchemaCollection)



AS
BEGIN
	SET NOCOUNT ON;
		
		insert into Person.BusinessEntity (ModifiedDate) values (GETDATE());
		
		
		INSERT INTO [AdventureWorks2008].[Person].[Person]
           ([BusinessEntityID]
           ,[PersonType]
           ,[NameStyle]
           ,[Title]
           ,[FirstName]
           ,[MiddleName]
           ,[LastName]
           ,[Suffix]
           ,[EmailPromotion]
           ,[AdditionalContactInfo]
           ,[Demographics]
           ,[ModifiedDate])
	values(@@IDENTITY
           ,@PersonType
           ,@NameStyle
           ,@Title
           ,@FirstName
           ,@MiddleName
           ,@LastName
           ,@Suffix
           ,@EmailPromotion
           ,@AdditionalContactInfo
           ,@Demographics
           ,GETDATE())
END
GO
/****** Object:  StoredProcedure [dbo].[sp_add_Employee]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_add_Employee]
			@BusinessEntityID int
           ,@NationalIDNumber nvarchar(15)
           ,@LoginID nvarchar(256)
          
           ,@JobTitle nvarchar(50)
           ,@BirthDate date
           ,@MaritalStatus nchar(1)
           ,@Gender nchar(1)
           ,@HireDate date
           ,@SalariedFlag bit
           ,@VacationHours smallint
           ,@SickLeaveHours smallint
           ,@CurrentFlag bit
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [AdventureWorks2008].[HumanResources].[Employee]
           ([BusinessEntityID]
           ,[NationalIDNumber]
           ,[LoginID]
         
           ,[JobTitle]
           ,[BirthDate]
           ,[MaritalStatus]
           ,[Gender]
           ,[HireDate]
           ,[SalariedFlag]
           ,[VacationHours]
           ,[SickLeaveHours]
           ,[CurrentFlag]
           ,[ModifiedDate])
     VALUES
           (@BusinessEntityID
           ,@NationalIDNumber
           ,@LoginID
           
           ,@JobTitle
           ,@BirthDate
           ,@MaritalStatus
           ,@Gender
           ,@HireDate
           ,@SalariedFlag
           ,@VacationHours
           ,@SickLeaveHours
           ,@CurrentFlag
           , GETDATE())
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAll_Employee]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_GetAll_Employee]

AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from [HumanResources].Employee
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetOne_Employee]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [sp_GetOne_Employee]
@BussinessEntityID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from [HumanResources].Employee where BusinessEntityID=@BussinessEntityID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_remove_Employee]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_remove_Employee]
@BusinessEntityID int


AS
BEGIN
	SET NOCOUNT ON;
	delete from [HumanResources].Employee 
	where BusinessEntityID=@BusinessEntityID;
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_update_Employee]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_update_Employee]
			@BusinessEntityID int
           ,@NationalIDNumber nvarchar(15)
           ,@LoginID nvarchar(256)
           ,@JobTitle nvarchar(50)
           ,@BirthDate date
           ,@MaritalStatus nchar(1)
           ,@Gender nchar(1)
           ,@HireDate date
           ,@SalariedFlag bit
           ,@VacationHours smallint
           ,@SickLeaveHours smallint
           ,@CurrentFlag bit

AS

BEGIN
	SET NOCOUNT ON;
	update [HumanResources].Employee 
	set BusinessEntityID = @BusinessEntityID
	   ,NationalIDNumber=@NationalIDNumber
	   ,LoginID=@LoginID
	   ,JobTitle=@JobTitle
	   ,BirthDate=@BirthDate
	   ,MaritalStatus=@MaritalStatus
	   ,Gender=@Gender
	   ,HireDate=@HireDate
	   ,SalariedFlag=@SalariedFlag
	   ,VacationHours=@VacationHours
	   ,SickLeaveHours=@SickLeaveHours
	   ,CurrentFlag=@CurrentFlag
	   ,ModifiedDate=GETDATE()
where BusinessEntityID=@BusinessEntityID;
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_update_JobCandidate]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_update_JobCandidate]
@JobCandidateID int,
@BussinessEntityID int,
@Resume xml(CONTENT HumanResources.HRResumeSchemaCollection)

AS
BEGIN
	SET NOCOUNT ON;
	update [HumanResources].[JobCandidate] set BusinessEntityID = @BussinessEntityID,Resume=@Resume
	where JobCandidateID=@JobCandidateID;
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Update_EDHistory]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_Update_EDHistory] 
@BussinessEntityID int,
@DepartmentId smallint,
@StartDate date,
@EndDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

update HumanResources.EmployeeDepartmentHistory set DepartmentID=@DepartmentId,ShiftID=1,StartDate=@StartDate,EndDate=@EndDate,ModifiedDate=GETDATE()
where BusinessEntityID=@BussinessEntityID;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_remove_JobCandidate]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_remove_JobCandidate]
@JobCandidateID int


AS
BEGIN
	SET NOCOUNT ON;
	delete from [HumanResources].[JobCandidate] 
	where JobCandidateID=@JobCandidateID;
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Remove_EDHistory]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_Remove_EDHistory] 
@BussinessEntityID int,
@DepartmentId smallint,
@StartDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

delete from HumanResources.EmployeeDepartmentHistory
where BusinessEntityID=@BussinessEntityID and DepartmentID=@DepartmentId and ShiftID=1 and StartDate=@StartDate;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetOne_JobCandidate]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_GetOne_JobCandidate]
@BussinessEntityID int


AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from [HumanResources].[JobCandidate] where JobCandidateID=@BussinessEntityID;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetOne_EDHistory]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_GetOne_EDHistory] 
@BussinessEntityID int,
@DepartmentId smallint,
@StartDate date

AS
BEGIN

	SET NOCOUNT ON;

select * from HumanResources.EmployeeDepartmentHistory
where BusinessEntityID=@BussinessEntityID and DepartmentID=@DepartmentId and ShiftID=1 and StartDate=@StartDate;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAll_JobCandidate]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_GetAll_JobCandidate]

AS
BEGIN
	SET NOCOUNT ON;
	SELECT top 15 JobCandidateID,BusinessEntityID,ModifiedDate, '' as DisplayName from [HumanResources].[JobCandidate]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAll_EDHistory]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_GetAll_EDHistory] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
select * from HumanResources.EmployeeDepartmentHistory
END
GO
/****** Object:  StoredProcedure [dbo].[sp_add_JobCandidate]    Script Date: 07/12/2015 23:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_add_JobCandidate]
@BussinessEntityID int,
@Resume xml(CONTENT HumanResources.HRResumeSchemaCollection)

AS
BEGIN
	SET NOCOUNT ON;
	insert into HumanResources.JobCandidate values (@BussinessEntityID,@Resume, GETDATE())
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [sp_Add_EDHistory] 
@BussinessEntityID int,
@DepartmentId smallint,
@StartDate date,
@EndDate date
AS
BEGIN
	SET NOCOUNT ON;
insert into HumanResources.EmployeeDepartmentHistory values(@BussinessEntityID,@DepartmentId,1,@StartDate,@EndDate,GETDATE());
END
GO
