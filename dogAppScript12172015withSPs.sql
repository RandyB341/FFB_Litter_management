 --create database dbFFBDogApp manually
use [dbFFBDogKennel]
go
--IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SettingT]') AND type in (N'U'))
--DROP TABLE [dbo].[SettingT]
--GO
CREATE TABLE [dbo].[SettingT]
(
    [Id] INT NOT NULL IDENTITY(1,1), 
    [Key] VARCHAR(50) NOT NULL, 
    [Value] VARCHAR(500) NULL,
    CONSTRAINT [PK_SettingT] PRIMARY KEY ([Id])
);

--CREATE TABLE [dbo].[PetType]
--(
--     [PetTypeID] INT NOT NULL IDENTITY(1,1),
--     [PetTypeDescription] VARCHAR(50) NULL,
--    CONSTRAINT [PK_PetType] PRIMARY KEY ([PetTypeID])
--);

CREATE TABLE [dbo].[StatusT] 
(
    [StatusID] INT NOT NULL IDENTITY(1,1),
    [Description] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_StatusT] PRIMARY KEY ([StatusID])
);

create table [dbo].[DogOwner]
(
	[DogOwnerID] int not null IDENTITY(1,1),
	[OwnerName] varchar(100) not null,
	[OwnerAddress] varchar(100) null,
	[OwnerCity] varchar(50) null,
	[OwnerState] varchar(25) null,
	[OwnerZip] varchar(11) null,
	[OwnerEmail] varchar(50) null,
	[OwnerPhone] varchar(12) not null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_DogOnwer] PRIMARY KEY ([DogOwnerID])
);
create table [dbo].[Breeder]
(
	[BreederID] int not null IDENTITY(1,1),
	[BreederName] varchar(100) not null,
	[BreederAddress] varchar(100) null,
	[BreederCity] varchar(50) null,
	[BreederState] varchar(25) null,
	[BreederZip] varchar(11) null,
	[BreederEmail] varchar(50) null,
	[BreederKennel] varchar(100) null,
	[BreederWebSite] varchar(100) null,
	[BreederPhone] varchar(12) not null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_Breeder] PRIMARY KEY ([BreederID])
	);
-- *********************
-- Dog could be purchased from:
-- Breeder
-- or from our Litters
-- **********************
create table [dbo].[Dog]
(
	[DogID] int not null IDENTITY(1,1),
	[AKCDogId] varchar(15) null,
	[AKCDogName] varchar(50) null,
	[AKCRegCertficateDate] datetime null,
	[Microchip_Num] varchar(50) null,
	[CoatColor] varchar(20) null,
	[Markings] varchar(20) null,
	[Gender] VARCHAR(10) NOT NULL CHECK (Gender IN ('Male', 'Female')),
	[DogName] varchar(50) null,
	[DogOwnerID] int null,
	[BreederID] int null,
	[EarsUpStayUpDate] datetime null,
	[DeceasedDate] datetime null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_Dog] PRIMARY KEY ([DogID])
	 --CONSTRAINT [FK_Dog_DogOwner] FOREIGN KEY ([DogOwnerID]) 
  --      REFERENCES [DogOwner] ([DogOwnerID])
);
CREATE TABLE [dbo].[Message]
(
    [MessageID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    [MessageDate] DATETIME NOT NULL, 
    [From] VARCHAR(150) NOT NULL, 
    [Email] VARCHAR(150) NOT NULL, 
    [Subject] VARCHAR(150) NULL, 
    [Message] VARCHAR(1500) NOT NULL,
    [Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
    CONSTRAINT [PK_Message] PRIMARY KEY ([MessageID])
    --CONSTRAINT [FK_Message_User] FOREIGN KEY ([UserID]) 
    --    REFERENCES [UserProfile] ([UserId])
);
CREATe Table [dbo].[Litter]
(
	[LitterID] int not null IDENTITY(1,1),
	[AKCLitter] varchar(15) null,
	[Sire_dogID] int not null,
	[Dam_dogID]  int not null,
	[LitterFemales] int not null,
	[LitterMales] int not null,
	[DeliverVet] varchar(50) not null,
	[WhelpDate] datetime not null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_Litter] PRIMARY KEY ([LitterID]),
    --CONSTRAINT [FK_Litter_SireDog] FOREIGN KEY ([Sire_dogID]) 
    --    REFERENCES [Dog] ([DogID]),
    --CONSTRAINT [FK_Litter_DamDog] FOREIGN KEY ([Dam_dogID]) 
    --    REFERENCES [Dog] ([DogID])        
);

create table [dbo].[DogWeight]
(
	[DogWeightID] int not null IDENTITY(1,1),
	[DogID] int not null,
	[Weight_lbs] int not null,
	[Weitht_oz] int not null,
	[WeightDate] datetime not null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_DogWeight] PRIMARY KEY ([DogWeightID]),
	CONSTRAINT [FK_DogWeight_Dog] FOREIGN KEY ([DogID]) 
        REFERENCES [Dog] ([DogID])
);

create table [dbo].[DogSales]
(
	[DogSalesID] int not null IDENTITY(1,1),
	[DogID] int not null,
	[SalesPrice] decimal not null,
	[DateContractMailed] datetime not null,
	[DogSaleDate] datetime null,
	[DogSaleNotes] varchar(1000) null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_DogSales] PRIMARY KEY ([DogSalesID]),
	CONSTRAINT [FK_DogSales_Dog] FOREIGN KEY ([DogID]) 
        REFERENCES [Dog] ([DogID])
);

create table [dbo].[DogSalePayment]
(
	[DogSalePayID] int not null IDENTITY(1,1),
	[DogSalesID]	int not null,
	[Amount]  decimal not null,
	[DateReceived] datetime not null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
CONSTRAINT [PK_DogSalePayment] PRIMARY KEY ([DogSalePayID]),
	CONSTRAINT [FK_DogSalePayment_DogSalesID] FOREIGN KEY ([DogSalesID]) 
        REFERENCES [DogSales] ([DogSalesID])
);

create table [dbo].[DogSalePaymentDocument]
(
	[DogSalePaymentDocumentID] INT NOT NULL IDENTITY(1,1), 
	[DogSalePayID] int not null,
	[FileName] varchar(50) null,
	[FileNameDescription] varchar(50) null,[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_DogSalePaymentDocument] PRIMARY KEY ([DogSalePaymentDocumentID]),
	CONSTRAINT [FK_DogSalePaymentDocument_DogSalePayment] FOREIGN KEY ([DogSalePayID]) 
        REFERENCES [DogSalePayment] ([DogSalePayID])
);


CREATE TABLE [dbo].[DogPhoto]
(
    [DogPhotoID] INT NOT NULL IDENTITY(1,1), 
    [DogID] INT NOT NULL, 
    [Photo] VARCHAR(500) NOT NULL 
        CONSTRAINT [DF_PhotoFile] DEFAULT '/content/dogs/no-image.png',
    [Notes] VARCHAR(500) NULL,
    [Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
    CONSTRAINT [PK_DogPhoto] PRIMARY KEY ([DogPhotoID]),
    CONSTRAINT [FK_DogPhoto_Dog] FOREIGN KEY ([DogID]) 
        REFERENCES [Dog] ([DogID])
);

create table [dbo].[LitterDocument]
(
	[LitterDocumentID] INT NOT NULL IDENTITY(1,1), 
	[LitterID] int not null,
	[FileName] varchar(50) null,
	[FileNameDescription] varchar(50) null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_LitterDocument] PRIMARY KEY ([LitterDocumentID]),
	CONSTRAINT [FK_LitterDocument_Litter] FOREIGN KEY ([LitterID]) 
        REFERENCES [Litter] ([LitterID])
);

create table [dbo].[DogSalesDocument]
(
	[DogSalesDocumentID] INT NOT NULL IDENTITY(1,1), 
	[DogSalesID] int not null,
	[FileName] varchar(50) null,
	[FileNameDescription] varchar(50) null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_DogSalesDocument] PRIMARY KEY ([DogSalesDocumentID]),
	CONSTRAINT [FK_DogSalesDocument_DogSales] FOREIGN KEY ([DogSalesID]) 
        REFERENCES [DogSales] ([DogSalesID])
);

create table [dbo].[DogDocument]
(
	[DogDocumentID] INT NOT NULL IDENTITY(1,1), 
	[DogID] int not null,
	[FileName] varchar(50) null,
	[FileNameDescription] varchar(50) null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_DogDocument] PRIMARY KEY ([DogDocumentID]),
	CONSTRAINT [FK_DogDocument_Dog] FOREIGN KEY ([DogID]) 
        REFERENCES [Dog] ([DogID])
);



create table [dbo].[OwnerDocument]
(
	[OwnerDocumentID] INT NOT NULL IDENTITY(1,1), 
	[DogOwnerID] int not null,
	[FileName] varchar(50) null,
	[FileNameDescription] varchar(50) null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_OwnerDocument] PRIMARY KEY ([OwnerDocumentID]),
	CONSTRAINT [FK_OwnerDocument_DogOwner] FOREIGN KEY ([DogOwnerID]) 
        REFERENCES [DogOwner] ([DogOwnerID])
);

create table [dbo].[DogWeightDocument]
(
	[DogWeightDocumentID] INT NOT NULL IDENTITY(1,1), 
	[DogWeightID] int not null,
	[FileName] varchar(50) null,
	[FileNameDescription] varchar(50) null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_DogWeightDocument] PRIMARY KEY ([DogWeightDocumentID]),
	CONSTRAINT [FK_DogWeightDocument_DogWeight] FOREIGN KEY ([DogWeightID]) 
        REFERENCES [DogWeight] ([DogWeightID])
);

CREATE TABLE [dbo].[DogPhotoDocument]
(
    [DogPhotoDocumentID] INT NOT NULL IDENTITY(1,1), 
    [DogPhotoID] INT NOT NULL, 
    [FileName] varchar(50) null,
	[FileNameDescription] varchar(50) null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_DogPhotoDocument] PRIMARY KEY ([DogPhotoDocumentID]),
	CONSTRAINT [FK_DogPhotoDocument_DogPhoto] FOREIGN KEY ([DogPhotoID]) 
        REFERENCES [DogPhoto] ([DogPhotoID])
);

CREATe Table [dbo].[Females_Heat]
(
	[HeatID] int not null IDENTITY(1,1),
	[FemaleDogID] int not null,
	[HeatDateStart] datetime not null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_Females_Heat] PRIMARY KEY ([HeatID]),
	CONSTRAINT [FK_Females_Heat] FOREIGN KEY ([FemaleDogID]) 
        REFERENCES [Dog] ([DogID])
);



CREATe Table [dbo].[Breeding]
(
	[BreedingID] int not null IDENTITY(1,1),
	--[AKCLitter] varchar(15) null,
	[BreedingSire_dogID] int not null,
	[BreedingDam_dogID]  int not null,
	--[LitterSize] int not null,
	--[Survive_2wks] int null,
	[BreedingVet] varchar(50) null,
	[HeatID] int null,
	[InseminationDate] datetime null,
	[Active] bit null,
	[LastUpdateID] varchar(100) not null,
	[LastUpdateTimeStamp] datetime not null,
	CONSTRAINT [PK_Breeding] PRIMARY KEY ([BreedingID]),
	CONSTRAINT [FK_HeatID] FOREIGN KEY ([HeatID]) 
        REFERENCES [Females_Heat] ([HeatID])
    --CONSTRAINT [FK_Breeding_Sire] FOREIGN KEY ([Sire_dogID]) 
    --    REFERENCES [Dog] ([DogID]),
    --CONSTRAINT [FK_Breeding_Dam] FOREIGN KEY ([Dam_dogID]) 
    --    REFERENCES [Dog] ([DogID])        
);


/****** Object:  StoredProcedure [dbo].[usp_BreederSelect]    Script Date: 12/14/2015 14:10:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_BreederSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_BreederSelect]
GO

/****** Object:  StoredProcedure [dbo].[usp_BreederSelect]    Script Date: 12/14/2015 14:10:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[usp_BreederSelect]
	-- Add the parameters for the stored procedure here
	@breederid1 int = null,
	@name1 varchar(100) = null,
	@address1 varchar(100) = null,
	@city1 varchar(50) = null,
	@state1 varchar(25) = null,
	@zip1 varchar(11) = null,
	@email1 varchar(50) = null,
	@kennel1 varchar(100) = null,
	@website1 varchar(100) = null,
	@phone1 varchar(12) = null,
	@active1 bit = null,
	@lastupdateid1 varchar(100) = null,
	@sortColumn			varchar(30) = 'BreederName',
	@sortDirection		varchar(5) = 'ASC'
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	declare @orderBy   nvarchar(50),
			@parmDef   nvarchar(300),
			@strSQL	   nvarchar(max);
			
	set @orderBy =  ' ORDER BY ' + @sortColumn + ' ' + @sortDirection;
	
    -- Insert statements for procedure here
    
    -- set default -- Bug 3422 new field that can be passed in by Internal User
	-- IF (LEN(@subaccount)=0)  BEGIN SET @subaccount=NULL END
	-- end set default -------------------------------------------------------
	set @strSQL ='
	SELECT		[BreederID]
				, [BreederName]
				, [BreederAddress]
				, [BreederCity]
				, [BreederState]
				, [BreederZip]
				, [BreederEmail]
				, [BreederKennel]
				, [BreederWebsite]
				, [BreederPhone]
				, [Active]
				, [LastUpdateId]
				, [LastUpdateTimeStamp]
	FROM	dbo.[Breeder]
	WHERE		([BreederID] = @breederid or @breederid is null) and
				([BreederName] = @name or @name is null) and
				([BreederAddress] = @address or @address is null) and
				([BreederCity] = @city or @city is null) and
				([BreederState] = @state or @state is null) and
			    ([BreederZip] = @zip or @zip is null) and
				([BreederEmail] = @email or @email is null) and
				([BreederKennel] = @kennel or @kennel is null) and
				([BreederWebSite] = @website or @website is null) and
				([BreederPhone] = @phone or @phone is null) and
				([Active] = @active or @active is null) and
				([LastUpdateId] = @lastupdateid  or @lastupdateid is null)
	' + @orderBy;
	
	set @parmDef=N'@name varchar(100), @breederid int, @address varchar(100), @city varchar(50), @state varchar(25), @zip varchar(11), @email varchar(50), @kennel varchar(100), @website varchar(100), @phone varchar(12), @active bit, @lastupdateid varchar(100)'
print @strSQL

EXEC sp_executesql @strSQL, @parmDef,
				   @breederid = @breederid1,
				   @name = @name1,
				   @address = @address1,
				   @city = @city1,
				   @state = @state1,
				   @zip = @zip1,
				   @email = @email1,
				   @kennel = @kennel1,
				   @website = @website1,
				   @phone = @phone1,
				   @active = @active1,
				   @lastupdateid = @lastupdateid1

END

GO


/****** Object:  StoredProcedure [dbo].[usp_BreederInsert]    Script Date: 12/14/2015 14:09:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_BreederInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_BreederInsert]
GO


/****** Object:  StoredProcedure [dbo].[usp_BreederInsert]    Script Date: 12/14/2015 14:09:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[usp_BreederInsert]
	-- Add the parameters for the stored procedure here
	@name varchar(100) = null,
	@address varchar(100) = null,
	@city varchar(50) = null,
	@state varchar(25) = null,
	@zip varchar(11) = null,
	@email varchar(50) = null,
	@kennel varchar(100) = null,
	@website varchar(100) = null,
	@phone varchar(12) = null,
	@active bit = null,
	@lastupdateid varchar(100) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    
    -- set default -- Bug 3422 new field that can be passed in by Internal User
	-- IF (LEN(@subaccount)=0)  BEGIN SET @subaccount=NULL END
	-- end set default -------------------------------------------------------
	
	INSERT INTO	dbo.[Breeder]
				([BreederName]
				, [BreederAddress]
				, [BreederCity]
				, [BreederState]
				, [BreederZip]
				, [BreederEmail]
				, [BreederKennel]
				, [BreederWebSite]
				, [BreederPhone]
				, [Active]
				, [LastUpdateId]
				, [LastUpdateTimeStamp]
				)
		VALUES
				(@name
				, @address
				, @city
				, @state
				, @zip
				, @email
				, @kennel
				, @website
				, @phone
				, @active
				, @lastupdateid
				, getdate()
				)
END




GO

/****** Object:  StoredProcedure [dbo].[usp_BreederUpdate]    Script Date: 12/14/2015 14:08:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_BreederUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_BreederUpdate]
GO

/****** Object:  StoredProcedure [dbo].[usp_BreederUpdate]    Script Date: 12/14/2015 14:08:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



create PROCEDURE [dbo].[usp_BreederUpdate]
	-- Add the parameters for the stored procedure here
	@breederid   int = null,
	@name varchar(100) = null,
	@address varchar(100) = null,
	@city varchar(50) = null,
	@state varchar(25) = null,
	@zip varchar(11) = null,
	@email varchar(50) = null,
	@kennel varchar(100) = null,
	@website varchar(100) = null,
	@phone varchar(12) = null,
	@active bit = null,
	@lastupdateid varchar(100) = null,
	@lastupdatetimestamp datetime = null
	--@returnRows		int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
    
    -- set default -- Bug 3422 new field that can be passed in by Internal User
	-- IF (LEN(@subaccount)=0)  BEGIN SET @subaccount=NULL END
	-- end set default -------------------------------------------------------
	UPDATE		dbo.[Breeder]
	SET			[BreederName]				= @name
				, [BreederAddress]		= @address
				, [BreederCity]			= @city
				, [BreederState]			= @state
				, [BreederZip]			= @zip
				, [BreederEmail]			= @email
				, [BreederPhone]			= @phone
				, [BreederKennel]			= @kennel
				, [BreederWebSite]			= @website
				, [Active]				= @active
				, [LastUpdateId]		= @lastupdateid
				, [LastUpdateTimeStamp] = GETDATE()
	WHERE		[BreederID]			= @breederid AND [LastUpdateTimeStamp] = @lastupdatetimestamp
	
	--SELECT @returnRows = @@ROWCOUNT
END



GO


/****** Object:  StoredProcedure [dbo].[usp_DogOwnerUpdate]    Script Date: 12/11/2015 16:39:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_DogOwnerUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_DogOwnerUpdate]
GO


/****** Object:  StoredProcedure [dbo].[usp_DogOwnerUpdate]    Script Date: 12/11/2015 16:39:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_DogOwnerUpdate]
	-- Add the parameters for the stored procedure here
	@ownerid   int = null,
	@name varchar(100) = null,
	@address varchar(100) = null,
	@city varchar(50) = null,
	@state varchar(25) = null,
	@zip varchar(11) = null,
	@email varchar(50) = null,
	@phone varchar(12) = null,
	@active bit = null,
	@lastupdateid varchar(100) = null,
	@lastupdatetimestamp datetime = null
	--@returnRows		int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
    
    -- set default -- Bug 3422 new field that can be passed in by Internal User
	-- IF (LEN(@subaccount)=0)  BEGIN SET @subaccount=NULL END
	-- end set default -------------------------------------------------------
	UPDATE		dbo.[DogOwner]
	SET			[OwnerName]				= @name
				, [OwnerAddress]		= @address
				, [OwnerCity]			= @city
				, [OwnerState]			= @state
				, [OwnerZip]			= @zip
				, [OwnerEmail]			= @email
				, [OwnerPhone]			= @phone
				, [Active]				= @active
				, [LastUpdateId]		= @lastupdateid
				, [LastUpdateTimeStamp] = GETDATE()
	WHERE		[DogOwnerID]			= @ownerid AND [LastUpdateTimeStamp] = @lastupdatetimestamp
	
	--SELECT @returnRows = @@ROWCOUNT
END



GO


/****** Object:  StoredProcedure [dbo].[usp_DogOwnerNameSelect]    Script Date: 12/11/2015 15:02:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_DogOwnerNameSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_DogOwnerNameSelect]
GO

/****** Object:  StoredProcedure [dbo].[usp_DogOwnerNameSelect]    Script Date: 12/11/2015 15:02:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[usp_DogOwnerNameSelect]
	-- Add the parameters for the stored procedure here
	@ownerid1 int = null,
	@name1 varchar(100) = null,
	@address1 varchar(100) = null,
	@city1 varchar(50) = null,
	@state1 varchar(25) = null,
	@zip1 varchar(11) = null,
	@email1 varchar(50) = null,
	@phone1 varchar(12) = null,
	@active1 bit = null,
	@lastupdateid1 varchar(100) = null,
	@sortColumn			varchar(30) = 'OwnerName',
	@sortDirection		varchar(5) = 'ASC'
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	declare @orderBy   nvarchar(50),
			@parmDef   nvarchar(300),
			@strSQL	   nvarchar(max);
			
	set @orderBy =  ' ORDER BY ' + @sortColumn + ' ' + @sortDirection;
	
    -- Insert statements for procedure here
    
    -- set default -- Bug 3422 new field that can be passed in by Internal User
	-- IF (LEN(@subaccount)=0)  BEGIN SET @subaccount=NULL END
	-- end set default -------------------------------------------------------
	set @strSQL ='
	SELECT		[DogOwnerID]
				, [OwnerName]
				, [OwnerAddress]
				, [OwnerCity]
				, [OwnerState]
				, [OwnerZip]
				, [OwnerEmail]
				, [OwnerPhone]
				, [Active]
				, [LastUpdateId]
				, [LastUpdateTimeStamp]
	FROM	dbo.[DogOwner]
	WHERE		([DogOwnerID] = @ownerid or @ownerid is null) and
				([OwnerName] = @name or @name is null) and
				([OwnerAddress] = @address or @address is null) and
				([OwnerCity] = @city or @city is null) and
				([OwnerState] = @state or @state is null) and
			    ([OwnerZip] = @zip or @zip is null) and
				([OwnerEmail] = @email or @email is null) and
				([OwnerPhone] = @phone or @phone is null) and
				([Active] = @active or @active is null) and
				([LastUpdateId] = @lastupdateid  or @lastupdateid is null)
	' + @orderBy;
	
	set @parmDef=N'@name varchar(100), @ownerid int, @address varchar(100), @city varchar(50), @state varchar(25), @zip varchar(11), @email varchar(50), @phone varchar(12), @active bit, @lastupdateid varchar(100)'
print @strSQL

EXEC sp_executesql @strSQL, @parmDef,
				   @ownerid = @ownerid1,
				   @name = @name1,
				   @address = @address1,
				   @city = @city1,
				   @state = @state1,
				   @zip = @zip1,
				   @email = @email1,
				   @phone = @phone1,
				   @active = @active1,
				   @lastupdateid = @lastupdateid1

END

GO

/****** Object:  StoredProcedure [dbo].[usp_DogOwnerInsert]    Script Date: 12/10/2015 16:16:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_DogOwnerInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_DogOwnerInsert]
GO

/****** Object:  StoredProcedure [dbo].[usp_DogOwnerInsert]    Script Date: 12/10/2015 16:16:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[usp_DogOwnerInsert]
	-- Add the parameters for the stored procedure here
	@name varchar(100) = null,
	@address varchar(100) = null,
	@city varchar(50) = null,
	@state varchar(25) = null,
	@zip varchar(11) = null,
	@email varchar(50) = null,
	@phone varchar(12) = null,
	@active bit = null,
	@lastupdateid varchar(100) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    
    -- set default -- Bug 3422 new field that can be passed in by Internal User
	-- IF (LEN(@subaccount)=0)  BEGIN SET @subaccount=NULL END
	-- end set default -------------------------------------------------------
	
	INSERT INTO	dbo.[DogOwner]
				([OwnerName]
				, [OwnerAddress]
				, [OwnerCity]
				, [OwnerState]
				, [OwnerZip]
				, [OwnerEmail]
				, [OwnerPhone]
				, [Active]
				, [LastUpdateId]
				, [LastUpdateTimeStamp]
				)
		VALUES
				(@name
				, @address
				, @city
				, @state
				, @zip
				, @email
				, @phone
				, @active
				, @lastupdateid
				, getdate()
				)
END



GO


