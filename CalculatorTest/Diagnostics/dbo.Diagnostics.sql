CREATE PROCEDURE InsertDiagnostics
    @Id UNIQUEIDENTIFIER,
    @Message NVARCHAR(MAX),
    @Timestamp DATETIME
As
BEGIN
    INSERT INTO Diagnostics (Id, Message, Timestamp)
    VALUES (@Id, @Message, @Timestamp)
END