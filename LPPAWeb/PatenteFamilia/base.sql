USE [PatenteFamilia]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/10/2013 22:09:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [varchar](36) NOT NULL,
	[Nombre] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[RethrowError]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RethrowError] AS
    /* Return if there is no error information to retrieve. */
    IF ERROR_NUMBER() IS NULL
        RETURN;

    DECLARE
        @ErrorMessage    NVARCHAR(4000),
        @ErrorNumber     INT,
        @ErrorSeverity   INT,
        @ErrorState      INT,
        @ErrorLine       INT,
        @ErrorProcedure  NVARCHAR(200); 

    /* Assign variables to error-handling functions that
       capture information for RAISERROR. */

    SELECT
        @ErrorNumber = ERROR_NUMBER(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE(),
        @ErrorLine = ERROR_LINE(),
        @ErrorProcedure = ISNULL(ERROR_PROCEDURE(), '-'); 

    /* Building the message string that will contain original
       error information. */

    SELECT @ErrorMessage = 
        N'Error %d, Level %d, State %d, Procedure %s, Line %d, ' + 
         'Message: '+ ERROR_MESSAGE(); 

    /* Raise an error: msg_str parameter of RAISERROR will contain
	   the original error information. */

    RAISERROR(@ErrorMessage, @ErrorSeverity, 1,
        @ErrorNumber,    /* parameter: original error number. */
        @ErrorSeverity,  /* parameter: original error severity. */
        @ErrorState,     /* parameter: original error state. */
        @ErrorProcedure, /* parameter: original error procedure name. */
        @ErrorLine       /* parameter: original error line number. */
        );
GO
/****** Object:  Table [dbo].[Patente]    Script Date: 06/10/2013 22:09:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patente](
	[IdPatente] [varchar](36) NOT NULL,
	[Nombre] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPatente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 06/10/2013 22:09:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia](
	[IdFamilia] [varchar](36) NOT NULL,
	[Nombre] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Familia_Familia]    Script Date: 06/10/2013 22:09:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia_Familia](
	[IdFamilia] [varchar](36) NOT NULL,
	[IdFamiliaHijo] [varchar](36) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdFamiliaHijo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Familia_Delete]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Delete]
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Familia
	WHERE 
		IdFamilia=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  Table [dbo].[Familia_Patente]    Script Date: 06/10/2013 22:09:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia_Patente](
	[IdFamilia] [varchar](36) NOT NULL,
	[IdPatente] [varchar](36) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__FamiliaE__166FEEA61367E606] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Familia_Insert]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Insert]
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Familia (
		[IdFamilia], 
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
/****** Object:  StoredProcedure [dbo].[Familia_Update]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Update]
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE Familia SET 
		[Nombre]=@Nombre
	WHERE
		IdFamilia=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_SelectAll]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_SelectAll]
AS
	SELECT 
		[IdFamilia], 
		[Nombre]
	FROM Familia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Select]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Select]
	@IdFamilia varchar (36) 
AS
	SELECT 
		[IdFamilia], 
		[Nombre]
	FROM Familia
	WHERE 
		IdFamilia=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Patente_Update]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_Update]
	@IdPatente varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE Patente SET 
		[Nombre]=@Nombre
	WHERE
		IdPatente=@IdPatente
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Patente_SelectAll]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_SelectAll]
AS
	SELECT 
		[IdPatente], 
		[Nombre]
	FROM Patente
GO
/****** Object:  StoredProcedure [dbo].[Patente_Select]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_Select]
	@IdPatente varchar (36) 
AS
	SELECT 
		[IdPatente], 
		[Nombre]
	FROM Patente
	WHERE 
		IdPatente=@IdPatente
GO
/****** Object:  StoredProcedure [dbo].[Patente_Insert]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_Insert]
	@IdPatente varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Patente (
		[IdPatente], 
		[Nombre]
	) VALUES (
		@IdPatente, 
		@Nombre
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Patente_Delete]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_Delete]
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Patente
	WHERE 
		IdPatente=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  Table [dbo].[Usuario_Familia]    Script Date: 06/10/2013 22:09:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario_Familia](
	[IdUsuario] [varchar](36) NOT NULL,
	[IdFamilia] [varchar](36) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdFamilia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Delete]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Delete]
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
/****** Object:  Table [dbo].[Usuario_Patente]    Script Date: 06/10/2013 22:09:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario_Patente](
	[IdUsuario] [varchar](36) NOT NULL,
	[IdPatente] [varchar](36) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_Usuario_Patente] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Insert]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Insert]
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
/****** Object:  StoredProcedure [dbo].[Usuario_Update]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Update]
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
/****** Object:  StoredProcedure [dbo].[Usuario_SelectAll]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_SelectAll]
AS
	SELECT 
		[IdUsuario], 
		[Nombre]
	FROM Usuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Select]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Select]
	@IdUsuario varchar (36) 
AS
	SELECT 
		[IdUsuario], 
		[Nombre]
	FROM Usuario
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Patente_SelectParticular]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Patente_SelectParticular]
	@IdUsuario varchar (36)
AS
	SELECT 
		IdUsuario, 
		IdPatente
	FROM Usuario_Patente
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Patente_Insert]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Patente_Insert]
	@IdUsuario varchar(36), 
	@IdPatente varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Usuario_Patente (
		IdUsuario, 
		IdPatente
	) VALUES (
		@IdUsuario, 
		@IdPatente
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Patente_DeleteParticular]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Patente_DeleteParticular]
	@IdUsuario varchar (36)
AS
	DELETE FROM Usuario_Familia
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_SelectParticular]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_SelectParticular]
	@IdUsuario varchar (36)
AS
	SELECT 
		IdUsuario, 
		IdFamilia
	FROM Usuario_familia
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_SelectAll]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_SelectAll]
AS
	SELECT 
		[IdUsuario], 
		[IdFamilia]
	FROM Usuario_Familia
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_Select]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_Select]
	@IdUsuario varchar (36) , 
	@IdFamilia varchar (36) 
AS
	SELECT 
		IdUsuario, 
		IdFamilia
	FROM Usuario_Familia
	WHERE 
		IdUsuario=@IdUsuario AND 
		IdFamilia=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_Insert]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_Insert]
	@IdUsuario varchar(36), 
	@IdFamilia varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Usuario_Familia (
		IdUsuario, 
		IdFamilia
	) VALUES (
		@IdUsuario, 
		@IdFamilia
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_DeleteParticular]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_DeleteParticular]
	@IdUsuario varchar (36)
AS
	DELETE FROM Usuario_Familia
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_Delete]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_Delete]
	@IdUsuario varchar (36) , 
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Usuario_Familia
	WHERE 
		IdUsuario=@IdUsuario AND 
		IdFamilia=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Patente_SelectAll]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Patente_SelectAll]
AS
	SELECT 
		[IdFamilia], 
		[IdPatente]
	FROM Familia_Patente
GO
/****** Object:  StoredProcedure [dbo].[Familia_Patente_Select]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Patente_Select]
	@IdFamilia varchar (36) 
AS
	SELECT 
		[IdFamilia], 
		[IdPatente]
	FROM Familia_Patente
	WHERE 
		[IdFamilia]=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Patente_Insert]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Patente_Insert]
	@IdFamilia varchar(36), 
	@IdPatente varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Familia_Patente (
		[IdFamilia], 
		[IdPatente]
	) VALUES (
		@IdFamilia, 
		@IdPatente
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Patente_Delete]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Patente_Delete]
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Familia_Patente
	WHERE 
		IdFamilia=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_SelectParticular]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_SelectParticular]
	@IdFamilia varchar(36)
AS
	SELECT 
		[IdFamilia], 
		[IdFamiliaHijo]
	FROM Familia_Familia
	WHERE 
		[IdFamilia]=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_SelectAll]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_SelectAll]
AS
	SELECT 
		[IdFamilia], 
		[IdFamiliaHijo]
	FROM Familia_Familia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_Select]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_Select]
	@IdFamilia varchar (36) , 
	@IdFamiliaHijo varchar (36) 
AS
	SELECT 
		[IdFamilia], 
		[IdFamiliaHijo]
	FROM Familia_Familia
	WHERE 
		[IdFamilia]=@IdFamilia AND 
		[IdFamiliaHijo]=@IdFamiliaHijo
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_Insert]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_Insert]	
	@IdFamilia varchar (36) , 
	@IdFamiliaHijo varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Familia_Familia (
		[IdFamilia], 
		[IdFamiliaHijo]
	) VALUES (
		@IdFamilia, 
		@IdFamiliaHijo
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_DeleteParticular]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_DeleteParticular]
	@IdFamilia varchar (36)
AS
	DELETE FROM Familia_Familia
	WHERE 
		IdFamilia=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_Delete]    Script Date: 06/10/2013 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_Delete]
	@IdFamilia varchar (36) , 
	@IdFamiliaHijo varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Familia_Familia
	WHERE 
		IdFamilia=@IdFamilia AND 
		IdFamiliaHijo=@IdFamiliaHijo
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  ForeignKey [FK__Familia_A__Famil__37A5467C]    Script Date: 06/10/2013 22:09:56 ******/
ALTER TABLE [dbo].[Familia_Familia]  WITH CHECK ADD  CONSTRAINT [FK__Familia_A__Famil__37A5467C] FOREIGN KEY([IdFamiliaHijo])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Familia_Familia] CHECK CONSTRAINT [FK__Familia_A__Famil__37A5467C]
GO
/****** Object:  ForeignKey [FK__Familia_A__Famil__38996AB5]    Script Date: 06/10/2013 22:09:56 ******/
ALTER TABLE [dbo].[Familia_Familia]  WITH CHECK ADD FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
/****** Object:  ForeignKey [FK_Familia_Patente_Familia]    Script Date: 06/10/2013 22:09:56 ******/
ALTER TABLE [dbo].[Familia_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Patente_Familia] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Familia_Patente] CHECK CONSTRAINT [FK_Familia_Patente_Familia]
GO
/****** Object:  ForeignKey [FK_FamiliaElement_Patente]    Script Date: 06/10/2013 22:09:56 ******/
ALTER TABLE [dbo].[Familia_Patente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaElement_Patente] FOREIGN KEY([IdPatente])
REFERENCES [dbo].[Patente] ([IdPatente])
GO
ALTER TABLE [dbo].[Familia_Patente] CHECK CONSTRAINT [FK_FamiliaElement_Patente]
GO
/****** Object:  ForeignKey [FK__Usuario_P__Famil__35BCFE0A]    Script Date: 06/10/2013 22:09:56 ******/
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK__Usuario_P__Famil__35BCFE0A] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK__Usuario_P__Famil__35BCFE0A]
GO
/****** Object:  ForeignKey [FK__Usuario_P__Usuar__36B12243]    Script Date: 06/10/2013 22:09:56 ******/
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
/****** Object:  ForeignKey [FK_Usuario_Patente_Patente]    Script Date: 06/10/2013 22:09:56 ******/
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Patente] FOREIGN KEY([IdPatente])
REFERENCES [dbo].[Patente] ([IdPatente])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Patente]
GO
/****** Object:  ForeignKey [FK_Usuario_Patente_Usuario]    Script Date: 06/10/2013 22:09:56 ******/
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Usuario]
GO
