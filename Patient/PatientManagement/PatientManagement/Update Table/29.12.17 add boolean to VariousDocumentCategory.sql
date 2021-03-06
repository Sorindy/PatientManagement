/*
   Friday, December 29, 201703:00:47 Evening
   User: sa
   Server: ADMINRG-6O4VBOP\BONG_DY
   Database: Hospital
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.VariousDocumentCategory ADD
	Available bit NOT NULL
GO
ALTER TABLE dbo.VariousDocumentCategory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
