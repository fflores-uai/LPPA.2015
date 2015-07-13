CREATE PROCEDURE sp_GetAll_JobCandidate
--PARAMS
AS
BEGIN
select * From HumanResources.JobCandidate Order By ModifiedDate
END
GO
