/*
 Navicat Premium Data Transfer

 Source Server         : sqlserver
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : DESKTOP-D8HOK3N:1433
 Source Catalog        : spgl
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 24/12/2019 18:43:01
*/


-- ----------------------------
-- Table structure for brand
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[brand]') AND type IN ('U'))
	DROP TABLE [dbo].[brand]
GO

CREATE TABLE [dbo].[brand] (
  [bname] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [bwebsite] varchar(100) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [bpicture] varchar(100) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[brand] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [brand]
-- ----------------------------
INSERT INTO [dbo].[brand]  VALUES (N'百事', N'无', N'无')
GO

INSERT INTO [dbo].[brand]  VALUES (N'罗技', N'无', N'无')
GO

INSERT INTO [dbo].[brand]  VALUES (N'旺仔', N'无', N'无')
GO

INSERT INTO [dbo].[brand]  VALUES (N'123', N'网址', N'图片')
GO


-- ----------------------------
-- Table structure for commodity
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[commodity]') AND type IN ('U'))
	DROP TABLE [dbo].[commodity]
GO

CREATE TABLE [dbo].[commodity] (
  [cno] int  NOT NULL,
  [cname] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [tname] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL,
  [bname] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL,
  [gg] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [xh] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [jldw] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [scj] numeric(16,2)  NOT NULL,
  [xsj] numeric(16,2)  NOT NULL,
  [cbj] numeric(16,2)  NOT NULL,
  [slt] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [js] varchar(100) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [kc] int  NOT NULL
)
GO

ALTER TABLE [dbo].[commodity] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [commodity]
-- ----------------------------
INSERT INTO [dbo].[commodity]  VALUES (N'1', N'罗技G304 无线游戏鼠标', N'电子产品', N'罗技', N'116mm*62mm*38.2mm', N'G304', N'g', N'199.00', N'199.00', N'99.00', N'无', N'无', N'10')
GO

INSERT INTO [dbo].[commodity]  VALUES (N'2', N'fsaf', N'电子产品', N'罗技', N'5', N'5', N'5', N'5.00', N'5.00', N'5.00', N'5', N'5', N'5')
GO

INSERT INTO [dbo].[commodity]  VALUES (N'3', N'罗技123', N'电子产品', N'罗技', N'4', N'4', N'3', N'4.00', N'3.00', N'3.00', N'4', N'3', N'3')
GO

INSERT INTO [dbo].[commodity]  VALUES (N'4', N'4', N'电子产品', N'旺仔', N'4', N'4', N'4', N'4.00', N'44.00', N'4.00', N'4', N'4', N'4')
GO

INSERT INTO [dbo].[commodity]  VALUES (N'6', N'123', N'日用品', N'罗技', N'1', N'2', N'3', N'4.00', N'5.00', N'6.00', N'图', N'介绍', N'10')
GO


-- ----------------------------
-- Table structure for discounts
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[discounts]') AND type IN ('U'))
	DROP TABLE [dbo].[discounts]
GO

CREATE TABLE [dbo].[discounts] (
  [discounttype] varchar(40) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [stor_id] char(4) COLLATE Chinese_PRC_CI_AS  NULL,
  [lowqty] smallint  NULL,
  [highqty] smallint  NULL,
  [discount] decimal(4,2)  NOT NULL
)
GO

ALTER TABLE [dbo].[discounts] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for jobs
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[jobs]') AND type IN ('U'))
	DROP TABLE [dbo].[jobs]
GO

CREATE TABLE [dbo].[jobs] (
  [job_id] smallint  NOT NULL,
  [job_desc] varchar(50) COLLATE Chinese_PRC_CI_AS DEFAULT ('New Position - title not forma') NOT NULL,
  [min_lvl] tinyint  NOT NULL,
  [max_lvl] tinyint  NOT NULL
)
GO

ALTER TABLE [dbo].[jobs] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for order
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[order]') AND type IN ('U'))
	DROP TABLE [dbo].[order]
GO

CREATE TABLE [dbo].[order] (
  [ono] int  NOT NULL,
  [cno] int  NULL,
  [khxm] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [khsj] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [khdz] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [yb] varchar(16) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [dgsj] datetime  NOT NULL,
  [dgsl] int  NOT NULL,
  [dj] numeric(16)  NOT NULL,
  [dgzje] numeric(32)  NOT NULL
)
GO

ALTER TABLE [dbo].[order] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [order]
-- ----------------------------
INSERT INTO [dbo].[order]  VALUES (N'3', N'1', N'3', N'3', N'3', N'3', N'2000-01-01 00:00:00.000', N'10', N'1', N'1')
GO

INSERT INTO [dbo].[order]  VALUES (N'2', N'1', N'2', N'2', N'2', N'2', N'2001-02-06 00:00:00.000', N'2', N'2', N'2')
GO

INSERT INTO [dbo].[order]  VALUES (N'4', N'1', N'1', N'1', N'1', N'1', N'2000-01-01 00:00:00.000', N'5', N'1', N'1')
GO

INSERT INTO [dbo].[order]  VALUES (N'5', N'1', N'1', N'1', N'1', N'1', N'2019-12-19 00:00:00.000', N'50', N'1', N'1')
GO

INSERT INTO [dbo].[order]  VALUES (N'10010', N'3', N'任腾宇1', N'185812607331', N'地址1', N'4090001', N'2019-12-10 00:00:00.000', N'21', N'1001', N'2001')
GO

INSERT INTO [dbo].[order]  VALUES (N'1', N'1', N'1', N'1', N'1', N'1', N'2000-01-01 00:00:00.000', N'2', N'2', N'2')
GO


-- ----------------------------
-- Table structure for pub_info
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[pub_info]') AND type IN ('U'))
	DROP TABLE [dbo].[pub_info]
GO

CREATE TABLE [dbo].[pub_info] (
  [pub_id] char(4) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [logo] image  NULL,
  [pr_info] text COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[pub_info] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for publishers
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[publishers]') AND type IN ('U'))
	DROP TABLE [dbo].[publishers]
GO

CREATE TABLE [dbo].[publishers] (
  [pub_id] char(4) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [pub_name] varchar(40) COLLATE Chinese_PRC_CI_AS  NULL,
  [city] varchar(20) COLLATE Chinese_PRC_CI_AS  NULL,
  [state] char(2) COLLATE Chinese_PRC_CI_AS  NULL,
  [country] varchar(30) COLLATE Chinese_PRC_CI_AS DEFAULT ('USA') NULL
)
GO

ALTER TABLE [dbo].[publishers] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Relationship_1
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Relationship_1]') AND type IN ('U'))
	DROP TABLE [dbo].[Relationship_1]
GO

CREATE TABLE [dbo].[Relationship_1] (
  [sname] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [cno] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Relationship_1] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for stores
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[stores]') AND type IN ('U'))
	DROP TABLE [dbo].[stores]
GO

CREATE TABLE [dbo].[stores] (
  [stor_id] char(4) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [stor_name] varchar(40) COLLATE Chinese_PRC_CI_AS  NULL,
  [stor_address] varchar(40) COLLATE Chinese_PRC_CI_AS  NULL,
  [city] varchar(20) COLLATE Chinese_PRC_CI_AS  NULL,
  [state] char(2) COLLATE Chinese_PRC_CI_AS  NULL,
  [zip] char(5) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[stores] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Supplier
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Supplier]') AND type IN ('U'))
	DROP TABLE [dbo].[Supplier]
GO

CREATE TABLE [dbo].[Supplier] (
  [sname] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [contacts] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [phone] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [synopsis] varchar(100) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Supplier] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [Supplier]
-- ----------------------------
INSERT INTO [dbo].[Supplier]  VALUES (N'重庆交通大学', N'任腾宇1', N'11111112', N'无1')
GO


-- ----------------------------
-- Table structure for type
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[type]') AND type IN ('U'))
	DROP TABLE [dbo].[type]
GO

CREATE TABLE [dbo].[type] (
  [tname] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [tpicture] varchar(100) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[type] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [type]
-- ----------------------------
INSERT INTO [dbo].[type]  VALUES (N'饮品', N'无')
GO

INSERT INTO [dbo].[type]  VALUES (N'日用品', N'无')
GO

INSERT INTO [dbo].[type]  VALUES (N'纸面巾', N'无')
GO

INSERT INTO [dbo].[type]  VALUES (N'电子产品', N'无')
GO


-- ----------------------------
-- Table structure for users
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[users]') AND type IN ('U'))
	DROP TABLE [dbo].[users]
GO

CREATE TABLE [dbo].[users] (
  [user_id] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [user_psw] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[users] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [users]
-- ----------------------------
INSERT INTO [dbo].[users]  VALUES (N'1', N'1')
GO


-- ----------------------------
-- Primary Key structure for table brand
-- ----------------------------
ALTER TABLE [dbo].[brand] ADD CONSTRAINT [PK_BRAND] PRIMARY KEY NONCLUSTERED ([bname])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table commodity
-- ----------------------------
CREATE NONCLUSTERED INDEX [Relationship_3_FK]
ON [dbo].[commodity] (
  [bname] ASC
)
GO

CREATE NONCLUSTERED INDEX [Relationship_4_FK]
ON [dbo].[commodity] (
  [tname] ASC
)
GO


-- ----------------------------
-- Checks structure for table commodity
-- ----------------------------
ALTER TABLE [dbo].[commodity] ADD CONSTRAINT [CKC_SCJ_COMMODIT] CHECK ([scj]>=(0))
GO

ALTER TABLE [dbo].[commodity] ADD CONSTRAINT [CKC_XSJ_COMMODIT] CHECK ([xsj]>=(0))
GO

ALTER TABLE [dbo].[commodity] ADD CONSTRAINT [CKC_CBJ_COMMODIT] CHECK ([cbj]>=(0))
GO

ALTER TABLE [dbo].[commodity] ADD CONSTRAINT [CKC_KC_COMMODIT] CHECK ([kc]>=(0))
GO


-- ----------------------------
-- Primary Key structure for table commodity
-- ----------------------------
ALTER TABLE [dbo].[commodity] ADD CONSTRAINT [PK_COMMODITY] PRIMARY KEY NONCLUSTERED ([cno])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Checks structure for table jobs
-- ----------------------------
ALTER TABLE [dbo].[jobs] ADD CONSTRAINT [ckc_min_lvl_jobs] CHECK ([min_lvl]>=(10))
GO

ALTER TABLE [dbo].[jobs] ADD CONSTRAINT [ckc_max_lvl_jobs] CHECK ([max_lvl]<=(250))
GO


-- ----------------------------
-- Primary Key structure for table jobs
-- ----------------------------
ALTER TABLE [dbo].[jobs] ADD CONSTRAINT [pk__jobs__117f9d94] PRIMARY KEY CLUSTERED ([job_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table order
-- ----------------------------
CREATE NONCLUSTERED INDEX [Relationship_5_FK]
ON [dbo].[order] (
  [cno] ASC
)
GO


-- ----------------------------
-- Triggers structure for table order
-- ----------------------------
CREATE TRIGGER [dbo].[i_order]
ON [dbo].[order]
WITH EXECUTE AS CALLER
FOR INSERT
AS
begin
   declare @dgsl int
   declare @kc int
   declare @cid int
   declare @oid int
   select @cid = cno,@dgsl = dgsl,@oid=ono from inserted
   select @kc = kc from commodity where commodity.cno = @cid
   if @dgsl <=@kc
      update commodity set  kc = @kc -@dgsl
     where cno=@cid
	else
	RAISERROR ('库存不足',16, 1)
end;
GO


-- ----------------------------
-- Checks structure for table order
-- ----------------------------
ALTER TABLE [dbo].[order] ADD CONSTRAINT [CKC_DGSL_ORDER] CHECK ([dgsl]>=(0))
GO

ALTER TABLE [dbo].[order] ADD CONSTRAINT [CKC_DJ_ORDER] CHECK ([dj]>=(0))
GO

ALTER TABLE [dbo].[order] ADD CONSTRAINT [CKC_DGZJE_ORDER] CHECK ([dgzje]>=(0))
GO


-- ----------------------------
-- Primary Key structure for table order
-- ----------------------------
ALTER TABLE [dbo].[order] ADD CONSTRAINT [PK_ORDER] PRIMARY KEY NONCLUSTERED ([ono])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table pub_info
-- ----------------------------
ALTER TABLE [dbo].[pub_info] ADD CONSTRAINT [upkcl_pubinfo] PRIMARY KEY CLUSTERED ([pub_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table publishers
-- ----------------------------
ALTER TABLE [dbo].[publishers] ADD CONSTRAINT [upkcl_pubind] PRIMARY KEY CLUSTERED ([pub_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table Relationship_1
-- ----------------------------
CREATE NONCLUSTERED INDEX [Relationship_1_FK]
ON [dbo].[Relationship_1] (
  [sname] ASC
)
GO

CREATE NONCLUSTERED INDEX [Relationship_2_FK]
ON [dbo].[Relationship_1] (
  [cno] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Relationship_1
-- ----------------------------
ALTER TABLE [dbo].[Relationship_1] ADD CONSTRAINT [PK_RELATIONSHIP_1] PRIMARY KEY CLUSTERED ([sname], [cno])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table stores
-- ----------------------------
ALTER TABLE [dbo].[stores] ADD CONSTRAINT [upk_storeid] PRIMARY KEY CLUSTERED ([stor_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Supplier
-- ----------------------------
ALTER TABLE [dbo].[Supplier] ADD CONSTRAINT [PK_SUPPLIER] PRIMARY KEY NONCLUSTERED ([sname])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table type
-- ----------------------------
ALTER TABLE [dbo].[type] ADD CONSTRAINT [PK_TYPE] PRIMARY KEY NONCLUSTERED ([tname])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table users
-- ----------------------------
ALTER TABLE [dbo].[users] ADD CONSTRAINT [PK_uesrs] PRIMARY KEY CLUSTERED ([user_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table commodity
-- ----------------------------
ALTER TABLE [dbo].[commodity] ADD CONSTRAINT [FK_COMMODIT_RELATIONS_BRAND] FOREIGN KEY ([bname]) REFERENCES [brand] ([bname]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[commodity] ADD CONSTRAINT [FK_COMMODIT_RELATIONS_TYPE] FOREIGN KEY ([tname]) REFERENCES [type] ([tname]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table discounts
-- ----------------------------
ALTER TABLE [dbo].[discounts] ADD CONSTRAINT [fk__discounts__stor___0f975522] FOREIGN KEY ([stor_id]) REFERENCES [stores] ([stor_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table order
-- ----------------------------
ALTER TABLE [dbo].[order] ADD CONSTRAINT [FK_ORDER_RELATIONS_COMMODIT] FOREIGN KEY ([cno]) REFERENCES [commodity] ([cno]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table pub_info
-- ----------------------------
ALTER TABLE [dbo].[pub_info] ADD CONSTRAINT [fk__pub_info__pub_id__173876ea] FOREIGN KEY ([pub_id]) REFERENCES [publishers] ([pub_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Relationship_1
-- ----------------------------
ALTER TABLE [dbo].[Relationship_1] ADD CONSTRAINT [FK_RELATION_RELATIONS_SUPPLIER] FOREIGN KEY ([sname]) REFERENCES [Supplier] ([sname]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Relationship_1] ADD CONSTRAINT [FK_RELATION_RELATIONS_COMMODIT] FOREIGN KEY ([cno]) REFERENCES [commodity] ([cno]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

