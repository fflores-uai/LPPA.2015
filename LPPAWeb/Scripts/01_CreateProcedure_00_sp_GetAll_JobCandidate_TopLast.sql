CREATE PROCEDURE sp_GetAll_JobCandidate_TopLast
--PARAMS
AS
BEGIN
--select * From HumanResources.JobCandidate Order By ModifiedDate
	SELECT TOP(15)JobCandidateID,BusinessEntityID,ModifiedDate FROM HumanResources.JobCandidate Order By ModifiedDate
END
GO
