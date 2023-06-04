CREATE TABLE [dbo].[CustomerTable] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Firstname] NVARCHAR (50) NOT NULL,
    [Lastname]  NVARCHAR (50) NOT NULL,
    [Phone]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[ItemCategoryTable] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[ItemTable] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [ItemName]    NVARCHAR (50) NOT NULL,
    [CategoryId]  INT           NOT NULL,
    [SupplierId]  INT           NOT NULL,
    [Quantity]    INT           NOT NULL,
    [UnitPrice]   MONEY         NOT NULL,
    [Description] TEXT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Item_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[ItemCategoryTable] ([Id]),
    CONSTRAINT [FK_Item_Supplier] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[SupplierTable] ([Id])
);

CREATE TABLE [dbo].[SaleItemTable] (
    [SaleId]           INT   NOT NULL,
    [ItemId]           INT   NOT NULL,
    [ItemSaleQuantity] INT   NOT NULL,
    [ItemTotalPrice]   MONEY NOT NULL,
    CONSTRAINT [FK_SaleItemTable_ItemTable] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[ItemTable] ([Id]),
    CONSTRAINT [FK_SaleItemTable_SaleTable] FOREIGN KEY ([SaleId]) REFERENCES [dbo].[SaleTable] ([Id])
);

CREATE TABLE [dbo].[SaleTable] (
    [Id]          INT   IDENTITY (1, 1) NOT NULL,
    [CustomerId]  INT   NOT NULL,
    [SalePrice]   MONEY NOT NULL,
    [Date]        DATE  NOT NULL,
    [Description] TEXT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SaleTable_CustomerTable] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[CustomerTable] ([Id])
);

CREATE TABLE [dbo].[StockItemTable] (
    [StockId]           INT   NOT NULL,
    [ItemId]            INT   NOT NULL,
    [ItemStockQuantity] INT   NOT NULL,
    [ItemTotalPrice]    MONEY NOT NULL,
    CONSTRAINT [FK_StockItem_Stock] FOREIGN KEY ([StockId]) REFERENCES [dbo].[StockTable] ([Id]),
    CONSTRAINT [FK_StockItem_Item] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[ItemTable] ([Id])
);

CREATE TABLE [dbo].[StockTable] (
    [Id]          INT   IDENTITY (1, 1) NOT NULL,
    [SupplierId]  INT   NOT NULL,
    [StockPrice]  MONEY NOT NULL,
    [Date]        DATE  NOT NULL,
    [Description] TEXT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Stock_Supplier] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[SupplierTable] ([Id])
);

CREATE TABLE [dbo].[SupplierTable] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [SupplierName] NVARCHAR (50) NOT NULL,
    [Phone]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[TradeHistoryTable] (
    [Id]      INT   IDENTITY (1, 1) NOT NULL,
    [StockId] INT   NULL,
    [SaleId]  INT   NULL,
    [Total]   MONEY NOT NULL,
    [Date]    DATE  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TradeHistoryTable_StockTable] FOREIGN KEY ([StockId]) REFERENCES [dbo].[StockTable] ([Id]),
    CONSTRAINT [FK_TradeHistoryTable_SaleTable] FOREIGN KEY ([SaleId]) REFERENCES [dbo].[SaleTable] ([Id]),
    CONSTRAINT [only_one_value] CHECK (([StockId] IS NULL
                                            OR [SaleId] IS NULL)
                                           AND NOT ([StockId] IS NULL
                                                    AND [SaleId] IS NULL))
);

CREATE TABLE [dbo].[UserTable] (
    [Username]  VARCHAR (50) NOT NULL,
    [Password]  VARCHAR (50) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [Gender]    CHAR (1)     NOT NULL,
    [Age]       INT          NOT NULL,
    [Email]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

