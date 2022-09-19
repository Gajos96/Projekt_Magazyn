

Create Table Poziom_Uprawnień(
id int identity(1,1) primary key,
name nvarchar(50) not null
);


Create Table Użytkownicy(
id int identity(1,1) primary key,
login nvarchar(50) not null UNIQUE,
password nvarchar(64) not null CHECK( LEN(password) = 64 ) ,
id_user int FOREIGN KEY REFERENCES Poziom_Uprawnień(id) not null
);





Insert Into Poziom_Uprawnień(name)
Values('admin');
Insert Into Poziom_Uprawnień(name)
Values('user');
Insert Into Poziom_Uprawnień(name)
Values('mod');
Insert Into Użytkownicy(login,password,id_user)
Values('admin','bd5ad4793022ed3e1b4d657d7d8ae2e340f4b1db0a3bbec29c641a386b886743',1);

