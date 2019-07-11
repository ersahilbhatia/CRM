If Not exists ( Select * from information_schema.Tables where table_name='Users')
Begin
Create table Users
(
UserId int not null primary key identity,
FName varchar(32),
MName varchar(32),
LName varchar(32),
UserEmail varchar(32),
UserPassword varchar(32),
birth date,
gender bit,
CreateDateTime datetime,
IsActive bit
)
End
Go