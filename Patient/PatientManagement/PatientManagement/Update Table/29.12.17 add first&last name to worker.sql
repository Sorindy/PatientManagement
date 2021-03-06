/*
   Friday, December 29, 201702:54:10 Evening
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
CREATE TABLE dbo.Tmp_Referrer
	(
	Id int NOT NULL IDENTITY (1, 1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Specialty nvarchar(50) NOT NULL,
	WorkPlace nvarchar(100) NOT NULL,
	Phone1 nvarchar(50) NOT NULL,
	Phone2 nvarchar(50) NULL,
	Email nvarchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Referrer SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Referrer ON
GO
IF EXISTS(SELECT * FROM dbo.Referrer)
	 EXEC('INSERT INTO dbo.Tmp_Referrer (Id, FirstName, Specialty, WorkPlace, Phone1, Phone2, Email)
		SELECT Id, Name, Specialty, WorkPlace, Phone1, Phone2, Email FROM dbo.Referrer WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Referrer OFF
GO
ALTER TABLE dbo.PrescriptionEstimate
	DROP CONSTRAINT FK_PrescriptionEstimate_Referrer
GO
ALTER TABLE dbo.MedicalImagingEstimate
	DROP CONSTRAINT FK_MedicalImagingEstimate_Referrer
GO
ALTER TABLE dbo.LaboratoryEstimate
	DROP CONSTRAINT FK_LaboratoryEstimate_Referrer
GO
ALTER TABLE dbo.ConsultationEstimate
	DROP CONSTRAINT FK_ConsultationEstimate_Referrer
GO
ALTER TABLE dbo.VariousDocumentEstimate
	DROP CONSTRAINT FK_VariousDocumentEstimate_Referrer
GO
DROP TABLE dbo.Referrer
GO
EXECUTE sp_rename N'dbo.Tmp_Referrer', N'Referrer', 'OBJECT' 
GO
ALTER TABLE dbo.Referrer ADD CONSTRAINT
	PK_Referrer PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
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
CREATE TABLE dbo.Tmp_Worker
	(
	Id int NOT NULL IDENTITY (1, 1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Gender nvarchar(10) NOT NULL,
	DOB date NOT NULL,
	Age smallint NOT NULL,
	Address nvarchar(MAX) NULL,
	Phone1 nvarchar(50) NOT NULL,
	Phone2 nvarchar(50) NULL,
	Email nvarchar(50) NULL,
	Position nvarchar(50) NULL,
	Salary int NULL,
	StartWorkDate date NULL,
	Hire bit NOT NULL,
	PhotoPath nvarchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Worker SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Worker ON
GO
IF EXISTS(SELECT * FROM dbo.Worker)
	 EXEC('INSERT INTO dbo.Tmp_Worker (Id, FirstName, Gender, DOB, Age, Address, Phone1, Phone2, Email, Position, Salary, StartWorkDate, Hire, PhotoPath)
		SELECT Id, Name, Gender, DOB, Age, Address, Phone1, Phone2, Email, Position, Salary, StartWorkDate, Hire, PhotoPath FROM dbo.Worker WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Worker OFF
GO
ALTER TABLE dbo.PrescriptionEstimate
	DROP CONSTRAINT FK_PrescriptionEstimate_Worker
GO
ALTER TABLE dbo.Account
	DROP CONSTRAINT FK_Account_Worker
GO
ALTER TABLE dbo.PrescriptionEstimate
	DROP CONSTRAINT FK_PrescriptionEstimate_Worker1
GO
ALTER TABLE dbo.Dating
	DROP CONSTRAINT FK_Dating_Worker
GO
ALTER TABLE dbo.MedicalImagingEstimate
	DROP CONSTRAINT FK_MedicalImagingEstimate_Worker
GO
ALTER TABLE dbo.MedicalImagingEstimate
	DROP CONSTRAINT FK_MedicalImagingEstimate_Worker1
GO
ALTER TABLE dbo.LaboratoryEstimate
	DROP CONSTRAINT FK_LaboratoryEstimate_Worker
GO
ALTER TABLE dbo.LaboratoryEstimate
	DROP CONSTRAINT FK_LaboratoryEstimate_Worker1
GO
ALTER TABLE dbo.ConsultationEstimate
	DROP CONSTRAINT FK_ConsultationEstimate_Worker
GO
ALTER TABLE dbo.ConsultationEstimate
	DROP CONSTRAINT FK_ConsultationEstimate_Worker1
GO
ALTER TABLE dbo.TempWaitingList
	DROP CONSTRAINT FK_TempWaitingList_Worker
GO
ALTER TABLE dbo.ConsultationEstimateEditHistory
	DROP CONSTRAINT FK_ConsultationEstimateEditHistory_Worker
GO
ALTER TABLE dbo.VariousDocumentEstimateEditHistory
	DROP CONSTRAINT FK_VariousDocumentEstimateEditHistory_Worker
GO
ALTER TABLE dbo.PrescriptionEstimateEditHistory
	DROP CONSTRAINT FK_PrescriptionEstimateEditHistory_Worker
GO
ALTER TABLE dbo.MedicalImagingEstimateEditHistory
	DROP CONSTRAINT FK_MedicalImagingEstimateEditHistory_Worker
GO
ALTER TABLE dbo.LaboratoryEstimateEditHistory
	DROP CONSTRAINT FK_LaboratoryEstimateEditHistory_Worker
GO
ALTER TABLE dbo.VariousDocumentEstimate
	DROP CONSTRAINT FK_VariousDocumentEstimate_Worker
GO
ALTER TABLE dbo.VariousDocumentEstimate
	DROP CONSTRAINT FK_VariousDocumentEstimate_Worker1
GO
DROP TABLE dbo.Worker
GO
EXECUTE sp_rename N'dbo.Tmp_Worker', N'Worker', 'OBJECT' 
GO
ALTER TABLE dbo.Worker ADD CONSTRAINT
	PK_Worker PRIMARY KEY CLUSTERED 
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
ALTER TABLE dbo.VariousDocumentEstimate ADD CONSTRAINT
	FK_VariousDocumentEstimate_Referrer FOREIGN KEY
	(
	ReferrerId
	) REFERENCES dbo.Referrer
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.VariousDocumentEstimate ADD CONSTRAINT
	FK_VariousDocumentEstimate_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.VariousDocumentEstimate ADD CONSTRAINT
	FK_VariousDocumentEstimate_Worker1 FOREIGN KEY
	(
	NurseId
	) REFERENCES dbo.Worker
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
ALTER TABLE dbo.LaboratoryEstimateEditHistory ADD CONSTRAINT
	FK_LaboratoryEstimateEditHistory_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LaboratoryEstimateEditHistory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedicalImagingEstimateEditHistory ADD CONSTRAINT
	FK_MedicalImagingEstimateEditHistory_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MedicalImagingEstimateEditHistory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PrescriptionEstimateEditHistory ADD CONSTRAINT
	FK_PrescriptionEstimateEditHistory_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PrescriptionEstimateEditHistory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.VariousDocumentEstimateEditHistory ADD CONSTRAINT
	FK_VariousDocumentEstimateEditHistory_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.VariousDocumentEstimateEditHistory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ConsultationEstimateEditHistory ADD CONSTRAINT
	FK_ConsultationEstimateEditHistory_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ConsultationEstimateEditHistory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TempWaitingList ADD CONSTRAINT
	FK_TempWaitingList_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.TempWaitingList SET (LOCK_ESCALATION = TABLE)
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
ALTER TABLE dbo.ConsultationEstimate ADD CONSTRAINT
	FK_ConsultationEstimate_Referrer FOREIGN KEY
	(
	ReferrerId
	) REFERENCES dbo.Referrer
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ConsultationEstimate ADD CONSTRAINT
	FK_ConsultationEstimate_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ConsultationEstimate ADD CONSTRAINT
	FK_ConsultationEstimate_Worker1 FOREIGN KEY
	(
	NurseId
	) REFERENCES dbo.Worker
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
ALTER TABLE dbo.LaboratoryEstimate ADD CONSTRAINT
	FK_LaboratoryEstimate_Referrer FOREIGN KEY
	(
	ReferrerId
	) REFERENCES dbo.Referrer
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LaboratoryEstimate ADD CONSTRAINT
	FK_LaboratoryEstimate_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LaboratoryEstimate ADD CONSTRAINT
	FK_LaboratoryEstimate_Worker1 FOREIGN KEY
	(
	NurseId
	) REFERENCES dbo.Worker
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
ALTER TABLE dbo.MedicalImagingEstimate ADD CONSTRAINT
	FK_MedicalImagingEstimate_Referrer FOREIGN KEY
	(
	ReferrerId
	) REFERENCES dbo.Referrer
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MedicalImagingEstimate ADD CONSTRAINT
	FK_MedicalImagingEstimate_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MedicalImagingEstimate ADD CONSTRAINT
	FK_MedicalImagingEstimate_Worker1 FOREIGN KEY
	(
	NurseId
	) REFERENCES dbo.Worker
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
ALTER TABLE dbo.Dating ADD CONSTRAINT
	FK_Dating_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
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
ALTER TABLE dbo.Account ADD CONSTRAINT
	FK_Account_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Account SET (LOCK_ESCALATION = TABLE)
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
ALTER TABLE dbo.PrescriptionEstimate ADD CONSTRAINT
	FK_PrescriptionEstimate_Referrer FOREIGN KEY
	(
	ReferrerId
	) REFERENCES dbo.Referrer
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PrescriptionEstimate ADD CONSTRAINT
	FK_PrescriptionEstimate_Worker FOREIGN KEY
	(
	WorkerId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PrescriptionEstimate ADD CONSTRAINT
	FK_PrescriptionEstimate_Worker1 FOREIGN KEY
	(
	NurseId
	) REFERENCES dbo.Worker
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PrescriptionEstimate SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
