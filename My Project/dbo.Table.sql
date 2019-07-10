CREATE TABLE [dbo].[inventory]
(
	[id] INT NOT NULL , 
    [description] VARCHAR(100) NULL, 
    [category] VARCHAR(50) NULL, 
    [inventory_beginning] INT NULL, 
    [quantity] INT NULL, 
    [price] INT NULL, 
    [transfer_in] INT NULL, 
    [transfer_out] INT NULL, 
    [wastage] INT NULL, 
    [inventory_ending] INT NULL, 
    [usage] INT NULL, 
    [remarks] VARCHAR(200) NULL, 
    [branch_id] INT NOT NULL, 
    PRIMARY KEY ([id])
)
