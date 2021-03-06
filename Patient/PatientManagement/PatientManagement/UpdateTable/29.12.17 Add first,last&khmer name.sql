/*
   Friday, December 29, 201702:49:38 Evening
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
CREATE TABLE dbo.Tmp_Patient
	(
	Id int NOT NULL IDENTITY (1, 1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	KhmerName nvarchar(50) NULL,
	Gender nvarchar(10) NOT NULL,
	DOB date NOT NULL,
	Age smallint NOT NULL,
	Address nvarchar(MAX) NOT NULL,
	Phone1 nvarchar(50) NOT NULL,
	Phone2 nvarchar(50) NULL,
	Email nvarchar(50) NULL,
	Weight smallint NULL,
	Height smallint NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Patient SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Patient ON
GO
IF EXISTS(SELECT * FROM dbo.Patient)
	 EXEC('INSERT INTO dbo.Tmp_Patient (Id, FirstName, Gender, DOB, Age, Address, Phone1, Phone2, Email, Weight, Height)
		SELECT Id, Name, Gender, DOB, Age, Address, Phone1, Phone2, Email, Weight, Height FROM dbo.Patient WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Patient OFF
GO
ALTER TABLE dbo.PrescriptionEstimate
	DROP CONSTRAINT FK_PrescriptionEstimate_Patient
GO
ALTER TABLE dbo.Dating
	DROP CONSTRAINT FK_Dating_Patient
GO
ALTER TABLE dbo.MedicalHistory
	DROP CONSTRAINT FK_MedicalHistory_Patient
GO
ALTER TABLE dbo.MedicalImagingEstimate
	DROP CONSTRAINT FK_MedicalImagingEstimate_Patient
GO
ALTER TABLE dbo.LaboratoryEstimate
	DROP CONSTRAINT FK_LaboratoryEstimate_Patient
GO
ALTER TABLE dbo.ConsultationEstimate
	DROP CONSTRAINT FK_ConsultationEstimate_Patient
GO
ALTER TABLE dbo.Visit
	DROP CONSTRAINT FK_Visit_Patient
GO
ALTER TABLE dbo.MedicalRecord
	DROP CONSTRAINT FK_MedicalRecord_Patient
GO
ALTER TABLE dbo.WaitingList
	DROP CONSTRAINT FK_WaitingList_Patient
GO
ALTER TABLE dbo.VariousDocumentEstimate
	DROP CONSTRAINT FK_VariousDocumentEstimate_Patient
GO
DROP TABLE dbo.Patient
GO
EXECUTE sp_rename N'dbo.Tmp_Patient', N'Patient', 'OBJECT' 
GO
ALTER TABLE dbo.Patient ADD CONSTRAINT
	PK_Patient PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.VariousDocumentEstimate ADD CONSTRAINT
	FK_VariousDocumentEstimate_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.VariousDocumentEstimate SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.WaitingList ADD CONSTRAINT
	FK_WaitingList_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.WaitingList SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedicalRecord ADD CONSTRAINT
	FK_MedicalRecord_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MedicalRecord SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Visit ADD CONSTRAINT
	FK_Visit_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Visit SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ConsultationEstimate ADD CONSTRAINT
	FK_ConsultationEstimate_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ConsultationEstimate SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LaboratoryEstimate ADD CONSTRAINT
	FK_LaboratoryEstimate_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LaboratoryEstimate SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedicalImagingEstimate ADD CONSTRAINT
	FK_MedicalImagingEstimate_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MedicalImagingEstimate SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedicalHistory ADD CONSTRAINT
	FK_MedicalHistory_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MedicalHistory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Dating ADD CONSTRAINT
	FK_Dating_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Dating SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PrescriptionEstimate ADD CONSTRAINT
	FK_PrescriptionEstimate_Patient FOREIGN KEY
	(
	PatientId
	) REFERENCES dbo.Patient
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PrescriptionEstimate SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
