﻿--tạo bảng Categories
CREATE TABLE [Categories](
	[CategoryId] [uniqueidentifier]PRIMARY KEY,
	[CategoryName] [nvarchar](100) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL
)
GO

--tạo bảng Products
CREATE TABLE [Products](
	[ProductId] [uniqueidentifier] primary key,
	[ProductName] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[ManufactoringDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Status] [tinyint] NOT NULL,
	[CategoryId] [uniqueidentifier] NULL,
	[UserId] [uniqueidentifier] NULL,
	[Quantity] [int] NOT NULL
)

--tạo bảng Users
CREATE TABLE [Users](
	[UserId] [uniqueidentifier] PRIMARY KEY,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL
)


--insert dữ liệu vào bảng Categories

INSERT [Categories]
([CategoryId], [CategoryName], [Status], [CreatedDate]) 
VALUES (N'3a14e4e5-f684-4601-83f0-08982fed470f', 
N'Điện thoại', 1, CAST(N'2020-06-29 19:49:27.090' 
AS DateTime))

INSERT [Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'b8aa2e2c-cdaf-4c83-b563-186951ae8d72', N'Ti vi', 1, CAST(N'2020-07-02 15:32:29.513' AS DateTime))
INSERT [Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'cab4b833-fd38-4f35-b827-26535f2c8e70', N'Tủ lạnh', 1, CAST(N'2020-07-02 15:32:52.950' AS DateTime))
INSERT [Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'1ad749ae-fdeb-4145-b7cf-26d5e4e28dda', N'Điều hòa', 1, CAST(N'2020-07-02 15:32:13.377' AS DateTime))
INSERT [Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'78757a1a-ba39-4b93-8d5e-71a9db80a418', N'Laptop', 1, CAST(N'2020-07-02 15:35:59.923' AS DateTime))
INSERT [Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'd4b6a885-9c76-4afe-860f-b8cd0e9f9df2', N'Ô tô', 1, CAST(N'2020-07-02 15:33:26.620' AS DateTime))
INSERT [Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'72d99613-df6b-4116-bc38-e2eefe91c774', N'Xe máy', 1, CAST(N'2020-07-02 15:33:33.190' AS DateTime))
INSERT [Categories] 
(CategoryId, 
CategoryName,
Status, 
CreatedDate) 

VALUES 
(

NEWID(),
N'Điện thoại',
1, 
GETDATE())



--insert dữ liệu vào bảng Users

INSERT [Users] ([UserId], [UserName], [Password], [Email], [Mobile], [Status], [CreatedDate]) VALUES (N'043362d3-2aa1-401a-be54-3ecea1dd3834', N'Trần Văn Tuấn', N'123456', N'tuantv@gmail.com', N'0961399999', 1, CAST(N'2020-07-02 16:11:39.410' AS DateTime))
INSERT [Users] 
([UserId], [UserName], [Password], [Email], [Mobile], [Status], [CreatedDate]) 
VALUES (NEWID(), 
N'Nguyễn Thu Huyền', N'654321', N'huyennt@gmail.com',
N'0961388888', 1, GETDATE())




--insert dữ liệu vào bảng Products

INSERT [Products] 
([ProductId], [ProductName], [Price],
[ManufactoringDate], [CreatedDate], [Description],
[Status], [CategoryId], [UserId], [Quantity]) 
VALUES (NEWID(), 
N'Tủ lạnh Misubishi', 
CAST(300000 AS Decimal(18, 0)), 
CAST(N'2020-02-02 00:00:00.000' AS DateTime), 
GETDATE(),
N'', 1, N'cab4b833-fd38-4f35-b827-26535f2c8e70',
N'043362d3-2aa1-401a-be54-3ecea1dd3834', 300)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'6eccd342-78b7-4374-863c-1d89418a2773', N'Tủ lạnh Aqua', CAST(100000 AS Decimal(18, 0)), CAST(N'2018-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 16:11:11.837' AS DateTime), N'', 1, N'cab4b833-fd38-4f35-b827-26535f2c8e70', N'0c779398-f39d-4a20-8a0f-48bbea7341c3', 100)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'c5ac662d-3ac2-45cf-83dc-20a3cf8a1fcb', N'Ti vi Sony', CAST(300000 AS Decimal(18, 0)), CAST(N'2020-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 16:10:02.803' AS DateTime), N'', 1, N'b8aa2e2c-cdaf-4c83-b563-186951ae8d72', N'0c779398-f39d-4a20-8a0f-48bbea7341c3', 300)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'ff534bb5-fa79-404a-8b17-240a91d2b1cf', N'Iphone 8', CAST(100000 AS Decimal(18, 0)), CAST(N'2018-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 15:54:15.887' AS DateTime), N'', 1, N'3a14e4e5-f684-4601-83f0-08982fed470f', N'043362d3-2aa1-401a-be54-3ecea1dd3834', 200)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'15140fc5-8017-40e4-af01-280cde097260', N'Honda Accord', CAST(300000 AS Decimal(18, 0)), CAST(N'2020-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 16:22:14.313' AS DateTime), N'', 1, N'd4b6a885-9c76-4afe-860f-b8cd0e9f9df2', N'0c779398-f39d-4a20-8a0f-48bbea7341c3', 300)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'bf068f7b-a02c-4b0a-abc9-2da4d9dbd0c2', N'Suzuki Hayate', CAST(200000 AS Decimal(18, 0)), CAST(N'2019-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 16:25:48.583' AS DateTime), N'', 1, N'72d99613-df6b-4116-bc38-e2eefe91c774', N'043362d3-2aa1-401a-be54-3ecea1dd3834', 200)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'508bc176-400a-4de9-8172-2dec0af91e42', N'Điều hòa Daikin', CAST(300000 AS Decimal(18, 0)), CAST(N'2020-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 16:14:39.277' AS DateTime), N'', 1, N'1ad749ae-fdeb-4145-b7cf-26d5e4e28dda', N'0c779398-f39d-4a20-8a0f-48bbea7341c3', 300)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'9596cb95-222f-4955-8fd7-314bfcf301be', N'Yamaha Grande', CAST(200000 AS Decimal(18, 0)), CAST(N'2019-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 16:25:23.373' AS DateTime), N'', 1, N'72d99613-df6b-4116-bc38-e2eefe91c774', N'0c779398-f39d-4a20-8a0f-48bbea7341c3', 200)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'24303990-a70d-4a89-a010-321b8ae8df45', N'Laptop LG', CAST(100000 AS Decimal(18, 0)), CAST(N'2018-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 16:18:37.443' AS DateTime), N'', 1, N'78757a1a-ba39-4b93-8d5e-71a9db80a418', N'0c779398-f39d-4a20-8a0f-48bbea7341c3', 100)

INSERT [Products] ([ProductId], [ProductName], [Price], [ManufactoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'e0e79f5d-bee7-4353-b04e-33413b19b5dd', N'Laptop Acer', CAST(200000 AS Decimal(18, 0)), CAST(N'2019-02-02 00:00:00.000' AS DateTime), CAST(N'2020-07-02 16:18:56.330' AS DateTime), N'', 1, N'78757a1a-ba39-4b93-8d5e-71a9db80a418', N'0c779398-f39d-4a20-8a0f-48bbea7341c3', 200)


go
select CategoryName, CategoryId from Categories
go
select UserId, UserName from Users


SELECT c.CategoryName, p.* 
FROM Products AS p
INNER JOIN Categories AS c 
ON p.CategoryId = c.CategoryId

inner join Users as u
on p.UserId=u.UserId

-- lấy ra categoryId của bảng p đem ra so sánh với CategoryId của bảng c
-- sau đó cái nào bằng nhau 