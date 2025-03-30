CREATE TABLE [dbo].[Dataset] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [CourseID]         VARCHAR (50) NOT NULL,
    [StudentID]        VARCHAR (50) NOT NULL,
    [Report]           TIME (7)     NOT NULL,
    [DateOfAttendance] DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);