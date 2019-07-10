CREATE TABLE [dbo].[inventory]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [branch_id] INT NOT NULL, 
    [description] NVARCHAR(150) NULL, 
    [unit] NVARCHAR(50) NULL, 
    [inventory_beginning] INT NULL, 
    [quantity] INT NULL, 
    [price] FLOAT NULL,
	[transfer_in] INT NULL, 
    [transfer_out] INT NULL, 
    [wastage] INT NULL, 
    [inventory_ending] INT NULL, 
    [usage] INT NULL, 
    [remarks] NVARCHAR(200) NULL, 
    CONSTRAINT [FK_inventory_Tobranch] FOREIGN KEY ([branch_id]) REFERENCES [branch]([id]) 

)
