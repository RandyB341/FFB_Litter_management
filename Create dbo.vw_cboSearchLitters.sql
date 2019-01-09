USE [C:\USERS\USERRANDY\APPDATA\LOCAL\MICROSOFT\VISUALSTUDIO\SSDT\DBFFB.MDF]
GO

/****** Object: View [dbo].[vw_cboSearchLitters] Script Date: 12/29/2018 6:02:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_cboSearchLitters]
	AS SELECT l.LitterID, datepart(year, l.WhelpDate) + ' - ' + am.DogName + ' - ' + af.DogName as WY_sireDam
	from dbo.Litter l
	inner join dbo.vw_activeFemales af on (l.Dam_dogID = af.DogID) 
	inner join dbo.vw_activeMales am on (l.Sire_dogID = am.DogID)
	where l.WhelpDate > '1/1/1900' and l.Active = 1;
