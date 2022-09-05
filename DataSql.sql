CREATE DATABASE QuanLyQuanTraSua
go
Use QuanLyQuanTraSua
go

Create table TableOrder
(
id int identity,
names nvarchar(100) default 'N\A',
status nvarchar(100) not null default 'Empty',   -- Empty / In Use
	constraint pk_TableOrder primary key(id)
)
go

create table Account
(
UserName nvarchar(100) not null,
DisplayName nvarchar(100) not null default N'N\A',
Pass nvarchar(1000) not null default N'0',
Type int not null default 0,   --0: staff / 1: admin
	constraint pk_Account primary key(UserName)
)
go

create table Category
(
id int identity,
NameCategory nvarchar(100) default 'N\A',
	constraint pk_Category primary key(id)

)
go

create table Orders
(
id int identity,
NameOrder nvarchar(100) not null default 'N\A',
idCategory int not null,
price float not null default 0,
	constraint pk_Orders primary key(id)
)
go

create table Bill
(
id int identity,
DateCheckIn datetime not null default getdate(),
DateCheckOut datetime,
idTable int not null,
status int not  null default 0,  -- 0: chua thanh toan / 1: da thanh toan 
	constraint pk_Bill primary key(id)
)
go

create table BillInfo
(
id int identity,
idBill int not null,
idOrder int not null,
count int not null default 0,
	constraint pk_BillInfo primary key(id)
)
go
--------------------------------
alter table BillInfo add
	constraint fk_info_bill foreign key(idBill) references Bill (id),
	constraint fk_info_orders foreign key(idOrder) references Orders (id)
go
--------------------------------
alter table Bill add
	constraint fk_bill foreign key(idTable) references TableOrder(id)
go
---------------------------------
alter table Orders add
	constraint fk_order foreign key(idCategory) references Category(id)
go
--------------------------------

insert into Account(UserName, DisplayName, Pass, Type)
values
('admin','Manager','SigmaMale',1),
('staff1','Employee','123123',0)
go

create proc AccountLogin
	@userName nvarchar(100),
	@passWord nvarchar(100)
as
begin
	select * 
	from dbo.Account
	where UserName = @userName and Pass = @passWord
end
go


create proc TableList
as
	select * from TableOrder
go

--add tableorder
declare @i int = 1
while @i <=20
begin
	insert into TableOrder(names) 
	values
	(N'Bàn ' + cast(@i as nvarchar(100) ) )
	set @i = @i +1
end
go


insert into Category(NameCategory)
values
(N'Meals') ,
(N'Drinks') ,
(N'Addtional')
go

update Category set NameCategory = N'Đồ uống' where id = 1
update Category set NameCategory = N'Đồ ăn' where id = 2
update Category set NameCategory = N'Thêm' where id = 3

insert into Orders(NameOrder, idCategory , price)
values
(N'Trà sữa Thái Nguyên', 1 , 20000) ,
(N'Trà sữa nguyên tố luân' , 1 , 25000) ,
(N'Trà sữa classical' , 1 , 20000) ,
(N'Trà extra sữa' , 1 , 22000) ,
(N'Trà sữa Q3 lốc gió' , 1 ,  25000) ,
(N'Trà sữa SIGMA	' , 1 , 30000),
---------
(N'Mì trộn 2 vắt trứng' , 2 , 20000) ,
(N'Mì sting familiar', 2 , 20000) ,
(N'Nui xào trứng' , 2 , 20000) ,
---------
(N'Bánh flan' , 3 , 5000) , 
(N'Trân châu', 3 , 3000) ,
(N'Thạch cà phê' , 3 , 3000) ,
(N'Thạch trái cây' , 3 , 3000)
go

insert into Orders(NameOrder, idCategory , price)
values
(N'Sting' , 3 , 10000)
go

insert into Orders(NameOrder, idCategory , price)
values
(N'Rau câu' , 3 , 5000)
go






--SELECT f.NameOrder, bi.count, f.price, f.price*bi.count AS totalPrice 
--FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Orders AS f
--WHERE bi.idBill = b.id 
	--AND bi.idOrder = f.id 
	--AND b.status = 0 
	--AND b.idTable = 2



create proc InsertBill
@idTable int
as
begin
	insert into Bill (DateCheckIn , DateCheckOut , idTable , status)
	values
	(GETDATE() , NULL , @idTable , 0)
end
go

create proc InsertBillInfo
@idBill int , @idOrder int , @count int
as
begin
	declare @isExistBillInfo int
	declare @orderCount int = 1
	
	select @isExistBillInfo = bi.id , @orderCount = bi.count 
	from dbo.BillInfo as bi
	where bi.idBill =  @idBill
			and bi.idOrder = @idOrder
	if(@isExistBillInfo > 0)
	begin
		declare @newCount int = @orderCount + @count
		if(@newCount >0)
			update dbo.BillInfo set count = @orderCount + @count where idOrder = @idOrder
		else
			delete dbo.BillInfo where idBill = @idBill and idOrder = @idOrder 
	end
	else
	begin
		insert into dbo.BillInfo (idBill , idOrder , count)
		values
		(@idBill , @idOrder , @count)
	end
end
go


create trigger UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.TableOrder SET status = N'In Use' WHERE id = @idTable		
		
	END		
	ELSE
	BEGIN
	PRINT @idTable
		PRINT @idBill
		PRINT @count
	UPDATE dbo.TableOrder SET status = N'Empty' WHERE id = @idTable	
	end
END
GO



create trigger UpdateBill
on dbo.Bill for update
as
begin
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableOrder SET status = N'Empty' WHERE id = @idTable

end
go

CREATE PROC SwitchTable
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		
		INSERT into dbo.Bill( DateCheckIn , DateCheckOut , idTable , status )
		VALUES  ( GETDATE() , NULL , @idTable1 , 0  )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		INSERT  into dbo.Bill ( DateCheckIn , DateCheckOut , idTable , status )
		VALUES  ( GETDATE() , NULL , @idTable2 , 0  )
			SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableOrder SET status = N'Empty' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableOrder SET status = N'Empty' WHERE id = @idTable1
END
GO

ALTER TABLE dbo.Bill ADD totalPrice FLOAT
go

create PROC GetListBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.names AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra]
	FROM dbo.Bill AS b , dbo.TableOrder AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

create PROC UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE UserName = @userName AND Pass = @password

	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, Pass = @newPassword WHERE UserName = @userName
	end
END
GO


create TRIGGER DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS 
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT

	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableOrder SET status = N'Empty' WHERE id = @idTable
END
GO


CREATE FUNCTION [dbo].[fuConvertToUnsignString] ( @strInput NVARCHAR(4000) )
RETURNS NVARCHAR(4000)
AS 
BEGIN 
	IF @strInput IS NULL
		RETURN @strInput
	IF @strInput = ''
		RETURN @strInput 
		
	DECLARE @RT NVARCHAR(4000)
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	
	DECLARE @COUNTER int
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
		BEGIN 
	 --Tim trong chuoi mau
		SET @COUNTER1 = 1 
			WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
				BEGIN 
				IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
					BEGIN
						IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)
						ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
						BREAK 
					END 
				SET @COUNTER1 = @COUNTER1 +1 
				END 
				SET @COUNTER = @COUNTER +1 
		END 
		 --Tim tiep
		SET @strInput = replace(@strInput,' ','-') 
		
	RETURN @strInput
END
go
---------------

create PROC GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS
	(
	SELECT b.ID, t.names AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra]
	FROM dbo.Bill AS b,dbo.TableOrder AS t
	WHERE b.DateCheckIn >= @checkIn AND b.DateCheckOut <= @checkOut 
			AND b.status = 1
			AND t.id = b.idTable
	)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

CREATE PROC GetNumBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableOrder AS t
	WHERE b.DateCheckIn >= @checkIn AND b.DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

CREATE PROC USP_GetListBillByDateForReport
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name, b.totalPrice, DateCheckIn, DateCheckOut, discount
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO
