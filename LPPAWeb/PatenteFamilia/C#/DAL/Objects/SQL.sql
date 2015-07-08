/****** Object:  Table [Usuario]    Script Date: 04/06/2013 01:53:03 a.m. ******/
SET ANSI_NULLS ON
GO

CREATE TABLE Usuario (
	[IdUsuario] varchar(36),
	[Nombre] varchar(1000),
	[timestamp] [timestamp] NOT NULL,
	PRIMARY KEY(IdUsuario)
)
GO

CREATE PROCEDURE Usuario_SelectAll
AS
	SELECT 
		[IdUsuario], 
		[Nombre]
	FROM Usuario
GO

CREATE PROCEDURE Usuario_Select
	@IdUsuario varchar (36) 
AS
	SELECT 
		[IdUsuario], 
		[Nombre]
	FROM Usuario
	WHERE 
		IdUsuario=@IdUsuario
GO

CREATE PROCEDURE Usuario_Insert
	@IdUsuario varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Usuario (
		[IdUsuario], 
		[Nombre]
	) VALUES (
		@IdUsuario, 
		@Nombre
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Usuario_Update
	@IdUsuario varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE Usuario SET 
		[Nombre]=@Nombre
	WHERE
		IdUsuario=@IdUsuario
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Usuario_Delete
	@IdUsuario varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Usuario
	WHERE 
		IdUsuario=@IdUsuario
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Usuario_Permisos_SelectParticular
	@IdUsuario varchar
AS
	SELECT 
		Usuario_idUsuario, 
		FamiliaElement_idFamiliaElement
	FROM Usuario_Permisos
	WHERE 
		Usuario_IdUsuario=@Usuario_IdUsuario
GO

CREATE PROCEDURE Usuario_Permisos_DeleteParticular
	@Usuario_IdUsuario varchar
AS
	DELETE FROM Usuario_Permisos
	WHERE 
		Usuario_IdUsuario=@Usuario_IdUsuario
GO

/****** Object:  Table [Usuario_Permisos]    Script Date: 04/06/2013 01:53:03 a.m. ******/
SET ANSI_NULLS ON
GO

CREATE TABLE Usuario_Permisos (
	[Usuario_idUsuario] varchar(36),
	[FamiliaElement_idFamiliaElement] varchar(36),
	[timestamp] [timestamp] NOT NULL,
	PRIMARY KEY(Usuario_idUsuario, FamiliaElement_idFamiliaElement)
)
GO

CREATE PROCEDURE Usuario_Permisos_SelectAll
AS
	SELECT 
		[Usuario_idUsuario], 
		[FamiliaElement_idFamiliaElement]
	FROM Usuario_Permisos
GO

CREATE PROCEDURE Usuario_Permisos_Select
	@Usuario_idUsuario varchar (36) , 
	@FamiliaElement_idFamiliaElement varchar (36) 
AS
	SELECT 
		[Usuario_idUsuario], 
		[FamiliaElement_idFamiliaElement]
	FROM Usuario_Permisos
	WHERE 
		Usuario_idUsuario=@Usuario_idUsuario AND 
		FamiliaElement_idFamiliaElement=@FamiliaElement_idFamiliaElement
GO

CREATE PROCEDURE Usuario_Permisos_Insert
	@Usuario_idUsuario varchar(36), 
	@FamiliaElement_idFamiliaElement varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Usuario_Permisos (
		[Usuario_idUsuario], 
		[FamiliaElement_idFamiliaElement]
	) VALUES (
		@Usuario_idUsuario, 
		@FamiliaElement_idFamiliaElement
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Usuario_Permisos_Update
	@Usuario_idUsuario varchar(36), 
	@FamiliaElement_idFamiliaElement varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
		RETURN
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Usuario_Permisos_Delete
	@Usuario_idUsuario varchar (36) , 
	@FamiliaElement_idFamiliaElement varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Usuario_Permisos
	WHERE 
		Usuario_idUsuario=@Usuario_idUsuario AND 
		FamiliaElement_idFamiliaElement=@FamiliaElement_idFamiliaElement
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

/****** Object:  Table [FamiliaElement]    Script Date: 04/06/2013 01:53:03 a.m. ******/
SET ANSI_NULLS ON
GO

CREATE TABLE FamiliaElement (
	[IdFamiliaElement] varchar(36),
	[Nombre] varchar(1000),
	[timestamp] [timestamp] NOT NULL,
	PRIMARY KEY(IdFamiliaElement)
)
GO

CREATE PROCEDURE FamiliaElement_SelectAll
AS
	SELECT 
		[IdFamiliaElement], 
		[Nombre]
	FROM FamiliaElement
GO

CREATE PROCEDURE FamiliaElement_Select
	@IdFamilia varchar (36) 
AS
	SELECT 
		[IdFamiliaElement], 
		[Nombre]
	FROM FamiliaElement
	WHERE 
		IdFamiliaElement=@IdFamilia
GO

CREATE PROCEDURE FamiliaElement_Insert
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO FamiliaElement (
		[IdFamiliaElement], 
		[Nombre]
	) VALUES (
		@IdFamilia, 
		@Nombre
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE FamiliaElement_Update
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE FamiliaElement SET 
		[Nombre]=@Nombre
	WHERE
		IdFamiliaElement=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE FamiliaElement_Delete
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM FamiliaElement
	WHERE 
		IdFamiliaElement=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

/****** Object:  Table [Patente]    Script Date: 04/06/2013 01:53:03 a.m. ******/
SET ANSI_NULLS ON
GO

CREATE TABLE Patente (
	[IdFamiliaElement] varchar(36),
	[Nombre] varchar(1000),
	[timestamp] [timestamp] NOT NULL,
	PRIMARY KEY(IdFamiliaElement)
)
GO

CREATE PROCEDURE Patente_SelectAll
AS
	SELECT 
		[IdFamiliaElement], 
		[Nombre]
	FROM Patente
GO

CREATE PROCEDURE Patente_Select
	@IdFamilia varchar (36) 
AS
	SELECT 
		[IdFamiliaElement], 
		[Nombre]
	FROM Patente
	WHERE 
		IdFamiliaElement=@IdFamilia
GO

CREATE PROCEDURE Patente_Insert
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Patente (
		[IdFamiliaElement], 
		[Nombre]
	) VALUES (
		@IdFamilia, 
		@Nombre
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Patente_Update
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE Patente SET 
		[Nombre]=@Nombre
	WHERE
		IdFamiliaElement=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Patente_Delete
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Patente
	WHERE 
		IdFamiliaElement=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

/****** Object:  Table [Familia]    Script Date: 04/06/2013 01:53:03 a.m. ******/
SET ANSI_NULLS ON
GO

CREATE TABLE Familia (
	[IdFamiliaElement] varchar(36),
	[Nombre] varchar(1000),
	[timestamp] [timestamp] NOT NULL,
	PRIMARY KEY(IdFamiliaElement)
)
GO

CREATE PROCEDURE Familia_SelectAll
AS
	SELECT 
		[IdFamiliaElement], 
		[Nombre]
	FROM Familia
GO

CREATE PROCEDURE Familia_Select
	@IdFamilia varchar (36) 
AS
	SELECT 
		[IdFamiliaElement], 
		[Nombre]
	FROM Familia
	WHERE 
		IdFamiliaElement=@IdFamilia
GO

CREATE PROCEDURE Familia_Insert
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Familia (
		[IdFamiliaElement], 
		[Nombre]
	) VALUES (
		@IdFamilia, 
		@Nombre
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Familia_Update
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE Familia SET 
		[Nombre]=@Nombre
	WHERE
		IdFamiliaElement=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Familia_Delete
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Familia
	WHERE 
		IdFamiliaElement=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Familia_Accesos_SelectParticular
	@IdFamilia varchar
AS
	SELECT 
		Familia_idFamiliaElement, 
		FamiliaElement_idFamiliaElement
	FROM Familia_Accesos
	WHERE 
		Familia_IdFamiliaElement=@Familia_IdFamiliaElement
GO

CREATE PROCEDURE Familia_Accesos_DeleteParticular
	@Familia_IdFamiliaElement varchar
AS
	DELETE FROM Familia_Accesos
	WHERE 
		Familia_IdFamiliaElement=@Familia_IdFamiliaElement
GO

/****** Object:  Table [Familia_Accesos]    Script Date: 04/06/2013 01:53:03 a.m. ******/
SET ANSI_NULLS ON
GO

CREATE TABLE Familia_Accesos (
	[Familia_idFamiliaElement] varchar(36),
	[FamiliaElement_idFamiliaElement] varchar(36),
	[timestamp] [timestamp] NOT NULL,
	PRIMARY KEY(Familia_idFamiliaElement, FamiliaElement_idFamiliaElement)
)
GO

CREATE PROCEDURE Familia_Accesos_SelectAll
AS
	SELECT 
		[Familia_idFamiliaElement], 
		[FamiliaElement_idFamiliaElement]
	FROM Familia_Accesos
GO

CREATE PROCEDURE Familia_Accesos_Select
	@Familia_idFamiliaElement varchar (36) , 
	@FamiliaElement_idFamiliaElement varchar (36) 
AS
	SELECT 
		[Familia_idFamiliaElement], 
		[FamiliaElement_idFamiliaElement]
	FROM Familia_Accesos
	WHERE 
		Familia_idFamiliaElement=@Familia_idFamiliaElement AND 
		FamiliaElement_idFamiliaElement=@FamiliaElement_idFamiliaElement
GO

CREATE PROCEDURE Familia_Accesos_Insert
	@Familia_idFamiliaElement varchar(36), 
	@FamiliaElement_idFamiliaElement varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Familia_Accesos (
		[Familia_idFamiliaElement], 
		[FamiliaElement_idFamiliaElement]
	) VALUES (
		@Familia_idFamiliaElement, 
		@FamiliaElement_idFamiliaElement
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Familia_Accesos_Update
	@Familia_idFamiliaElement varchar(36), 
	@FamiliaElement_idFamiliaElement varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
		RETURN
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE Familia_Accesos_Delete
	@Familia_idFamiliaElement varchar (36) , 
	@FamiliaElement_idFamiliaElement varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Familia_Accesos
	WHERE 
		Familia_idFamiliaElement=@Familia_idFamiliaElement AND 
		FamiliaElement_idFamiliaElement=@FamiliaElement_idFamiliaElement
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO


ALTER TABLE Usuario_Permisos
  ADD FOREIGN KEY (FamiliaElement_IdFamiliaElement)
  REFERENCES FamiliaElement (IdFamiliaElement)
GO


ALTER TABLE Usuario_Permisos
  ADD FOREIGN KEY (Usuario_IdUsuario)
  REFERENCES Usuario (IdUsuario)
GO


ALTER TABLE Familia_Accesos
  ADD FOREIGN KEY (FamiliaElement_IdFamiliaElement)
  REFERENCES FamiliaElement (IdFamiliaElement)
GO


ALTER TABLE Familia_Accesos
  ADD FOREIGN KEY (Familia_IdFamiliaElement)
  REFERENCES Familia (IdFamiliaElement)
GO

