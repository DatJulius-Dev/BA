create database QuanLyPhongKham
go
    use QuanLyPhongKham
go
    create table Position(
        ID int identity,
        positionName nchar(50) not null,
        primary key (ID)
    )
go
    create table Specialty (
        ID int identity,
        specialtyName nchar(50) not null,
        primary key (ID)
    )
go
    create table Branch(
        ID int identity,
        branchName nchar(50) not null,
        branchAddress nchar(256) not null,
        phoneNumber char(10) not null,
        primary key (ID)
    )
go
    create table Employee(
        ID int identity,
        positionID int not null,
        branchID int not null,
        employeeName nchar(50) not null,
        birthday date not null,
        sex int check(
            sex = 0
            or sex = 1
        ) not null,
        phoneNumber char(10) not null,
        employeeAddress nchar(256) not null,
        accountPassword char(20) default '1',
        email char(100) not null,
        primary key (ID),
        foreign key (positionID) references Position(ID),
        foreign key (branchID) references Branch(ID)
    )
go
    create table Detist(
        ID int,
        specialtyID int not null,
        foreign key (specialtyID) references Specialty(ID),
        foreign key (ID) references Employee(ID),
        primary key (ID)
    )
go
    create table Patient(
        ID int identity,
        branchID int not null,
        patientName nchar(50) not null,
        birthday date not null,
        sex int check(
            sex = 0
            or sex = 1
        ) not null,
        phoneNumber char(10) not null,
        patientAddress nchar(256) not null,
        primary key (ID),
        foreign key (branchID) references Branch(ID)
    )
go
    create table Schedule(
        ID int identity,
        patentID int not null,
        detistID int not null,
        meetTime datetime not null,
        status nchar(50) not null,
        exportDate date not null,
        primary key (ID),
        foreign key (patentID) references Patient(ID),
        foreign key (detistID) references Detist(ID)
    )
go
    create table ServiceLevel1(
        ID int identity,
        level1Name nchar(50) not null,
        primary key (ID)
    )
go
    create table ServiceLevel2(
        ID int identity,
        level2Name nchar(50) not null,
        level1ID int not null,
        primary key (ID),
        foreign key (level1ID) references ServiceLevel1(ID)
    )
go
    create table Service(
        ID int identity,
        serviceName nchar(50) not null,
        price float not null,
        primary key(ID)
    )
go
    create table ServiceLevel3(
        ID int,
        level2ID int not null,
        foreign key (level2ID) references ServiceLevel2(ID),
        foreign key (ID) references Service(ID),
        primary key(ID),
    )
go
    create table Medicine(
        ID int,
        available int not null,
        foreign key (ID) references Service(ID),
        primary key(ID),
    )
go
    create table BillInfor(
        serviceID int,
        scheduleID int,
        quantity int not null,
        foreign key (serviceID) references Service(ID),
        foreign key (scheduleID) references Schedule(ID),
        primary key(serviceID, scheduleID)
    )
go
create proc sp_insertPosition @name nchar(50) 
as insert into Position(positionName) values(@name)
go
create proc sp_insertBranch @name nchar(50), @address nchar(256), @phoneNumber char(10)
as
insert into Branch(branchName,branchAddress,phoneNumber) values (@name,@address,@phoneNumber)
go
create proc sp_insertEmployee @positionID int, @branchID int, @name nchar(50), @birthday date, @sex int ,
	@phoneNumber char(10), @address nchar(256), @password char(20), @email char(100)
	as 
		insert into Employee(positionID,branchID,employeeName, birthday, sex, phoneNumber, employeeAddress, accountPassword, email)
			values(@positionID, @branchID,@name, @birthday, @sex,@phoneNumber, @address, @password, @email)
go
create proc sp_insertSpecialty @name nchar(50)
	as insert into Specialty(specialtyName) values (@name)
go
create proc sp_insertDentist @branchID int, @name nchar(50), @birthday date, @sex int ,
	@phoneNumber char(10), @address nchar(256), @password char(20), @email char(100), @specialtyID int
		as
		declare @positionID int = (select ID from Position where positionName = N'Bác sĩ');
		exec sp_insertEmployee @positionID,@branchID, @name, @birthday, @sex, @phoneNumber, @address, @password, @email;
		declare @ID int = (select top(1) ID from Employee order by ID desc);
		insert into Detist(ID, specialtyID) values (@ID, @specialtyID);
go
create proc sp_insertPatient @branchID int, @name nchar(50), @birth date, @sex int, @phoneNumber char(10), @address nchar(256)
	as
	insert into Patient(branchID,patientName,birthday,sex, phoneNumber, patientAddress) values(@branchID,@name,@birth,@sex, @phoneNumber, @address)
go
create proc sp_insertSchedule @patientID int, @detistID int, @time datetime, @status nchar(50), @exportDate date
	as 
	insert into Schedule(patentID,detistID, meetTime, status, exportDate) 
		values (@patientID, @detistID, @time, @status, @exportDate)
go
create proc sp_insertServiceLevel1 @name nchar(50)
	as
	insert into ServiceLevel1(level1Name) values(@name)
go
create proc sp_insertServiceLevel2 @name nchar(50), @level1ID int
	as
	insert into ServiceLevel2(level2Name,level1ID) values(@name, @level1ID)
go
create proc sp_insertServiceLevel3 @name nchar(50), @price float, @level2ID int
	as 
		insert into Service(serviceName, price) values(@name, @price);
		declare @ID int = (select top(1) ID from Service order by ID desc);
		insert into ServiceLevel3(ID,level2ID) values(@ID,@level2ID)
go
create proc sp_insertMedicine @name nchar(50), @price float, @available int
	as 
		insert into Service(serviceName, price) values(@name, @price);
		declare @ID int = (select top(1) ID from Service order by ID desc);
		insert into Medicine(ID,available) values(@ID,@available)
go
create proc sp_insertBillInfor @serviceID int, @scheduleID int, @quantity int
	as
		insert into BillInfor(serviceID, scheduleID, quantity) values (@serviceID, @scheduleID, @quantity)
go