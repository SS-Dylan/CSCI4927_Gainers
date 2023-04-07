CREATE TABLE Users (
	Id INT,
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    Email VARCHAR(255),
    Password VARCHAR(255),
    ProfilePictureUrl VARCHAR(512),
    Squats INT,
    Bench INT,
    Deadlift INT,
    Bio VARCHAR(2048)
)

CREATE TABLE Matches (
	Id INT,
	MatchChoice TINYINT,
	UserId INT,
	MatchId INT
)

CREATE TABLE Messages (
    Id INT,
    Message VARCHAR(2048),
    Datetime VARCHAR(255),
    FromUserId INT,
    ToUserId INT
)