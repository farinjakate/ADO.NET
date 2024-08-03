create database MYADONETDB

go
create table Trainer
(
Id int primary key identity,
Name varchar(50),
City varchar(50),
Experience int
)

insert into  Trainer values('farin','pune',15) ,('sabiha','pisoli',3)
go
select * from Trainer
go

use MYADONETDB

select * from Trainer

insert into Trainer values( 'Nazmin','pune',2)

delete from trainer where id=3

go


create proc uspInsertTrainer
@Name varchar(50),@City varchar(50),@Experience int
as
begin
    insert into Trainer values(@Name,@City,@Experience)
    return scope_identity()
end


execute uspInsertTrainer @Name ='nazmin',@City='pune',@Experience=3

select count(Id) from Trainer


go

create proc uspDeleteTrainer
@Id int, @Status bit output
as
Begin 
      Begin try
	          begin Transaction
			        if exists(Select Id from Trainer Where Id = @Id)
						begin
						delete from trainer where Id = @Id
						set @Status = 1
						end
		            else

						begin
						set @Status = 0
						end
             commit
	  end try
	  begin Catch
				Rollback
	            Set @Status = 0
	  end Catch
end
go

use MYADONETDB
select * from Trainer

go

use MYADONETArchiveDB

go
create table Trainer (Id int,Name varchar(50),City varchar(50),Experience int)

drop table Trainer

go
use MYADONETArchiveDB
--Delete from Trainer
select *from Trainer





