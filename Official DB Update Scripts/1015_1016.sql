GO
DROP PROCEDURE [dbo].[GetTopOrderItemsForOrder];

GO
CREATE PROCEDURE [dbo].[GetAllOrderItems]
	/*
	Author	Servet Vural
	Date	1 January 2004
	Comment  Gets the OrderItem By its IID
		
	@param		
	@return		
	*/
(
	@ParentOrderIID varchar(50)
)
AS
	SELECT * FROM OrderItem WHERE ParentOrderIID = @ParentOrderIID  Order by DisplayOrder desc, ItemType asc
GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;

GO

CREATE PROCEDURE [dbo].[GetAllXOrderItems]
	
(
	@ParentXOrderIID varchar(50)
)
AS
	SELECT * FROM XOrderItem WHERE ParentOrderIID = @ParentXOrderIID  Order by DisplayOrder desc, ItemType asc
GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;

GO

CREATE PROCEDURE [dbo].[SaveXOrder]
	/*
	Author	Servet Vural
	Date	1 January 2004
	Comment  Saves the given Order
		
	@param		
	@return		
	*/
(
	@IID varchar(50),
	@TableIID varchar(50),
	@OrderDate datetime,
	@Covers int,
	@OrderType int,
	@Payment money,
	@CustomerIID varchar(50),
	@SessionIID varchar(50),
	@Status int,
	@LockedClientIP varchar(20),
	@Instruction varchar(50),
	@MoneyPaid smallmoney,
	@PaymentFlag varchar(50),	
	@TableName varchar(50),
	@CName varchar(255),
	@Postcode varchar(10),
	@Address varchar(255),
	@Buzzer varchar(255),
	@Town varchar(255),
	@Tel varchar(50),
	@Mobile varchar(50),
	@Email varchar(255),
	@UserName varchar(50),
	@Reference	varchar(50)
)
AS
	IF (SELECT COUNT(IID) FROM XOrders Where IID = @IID) = 0
	BEGIN
		insert Into XOrders (IID,TableIID, OrderDate, Covers, OrderType, Payment, CustomerIID, SessionIID, Status, 
			LockedClientIP,Instruction, MoneyPaid, PaymentFlag, 
			TableName, CName, Postcode, Address, Buzzer, Town, Tel, Mobile, Email,UserName,Reference)
		values (@IID,@TableIID, @OrderDate, @Covers, @OrderType, @Payment, @CustomerIID, @SessionIID, @Status, 
			@LockedClientIP,@Instruction,@MoneyPaid, @PaymentFlag,
			@TableName, @CName, @Postcode, @Address, @Buzzer, @Town, @Tel, @Mobile, @Email, @UserName,@Reference)
	END

	ELSE
	BEGIN
		Update XOrders SET
		TableIID = @TableIID,
		OrderDate = @OrderDate,
		Covers = @Covers,
		OrderType = @OrderType,
		Payment = @Payment,
		CustomerIID = @CustomerIID,
		SessionIID = @SessionIID,
		Status = @Status, 
		LockedClientIP = @LockedClientIP,
		Instruction = @Instruction,
		MoneyPaid = @MoneyPaid,
		PaymentFlag = @PaymentFlag,
		TableName = @TableName,
		CName = @CName,
		Postcode = @Postcode,
		Address = @Address,
		Buzzer = @Buzzer,
		Town = @Town,
		Tel = @Tel,
		Mobile = @Mobile,
		Email = @Email,
		UserName = @UserName,
		Reference = @Reference
		Where IID = @IID
	END

GO

CREATE PROCEDURE [dbo].[SaveXOrderItem]
	/*
	Author	Servet Vural
	Date	1 January 2004
	Comment  Saves the given OrderItem
		
	@param		
	@return		
	*/
(
	@IID varchar(50),
	@EntityIID varchar(50),
	@OrderItemText varchar(50),
	@Quantity float,	
	@Price money,
	@OrderGroupIID varchar(50),
	@EntityButtonIID varchar(50),
	@DistributionIID varchar(50),
	@ParentOrderIID varchar(50),
	@ItemType int,
	@DisplayOrder int,
	@EntityName varchar(50),
	@EntityDisplayOrder int,
	@TaxPercent float,
	@CompletedQuantity float
)
AS
	IF (SELECT COUNT(IID) FROM XOrderItem WHERE IID = @IID) = 0
	BEGIN
		Insert Into XOrderItem (IID,EntityIID,OrderItemText, Quantity,  Price, OrderGroupIID, 
		EntityButtonIID, DistributionIID, ParentOrderIID, ItemType, DisplayOrder, 
		EntityName, EntityDisplayOrder, TaxPercent,CompletedQuantity)
		values ( @IID ,@EntityIID, @OrderItemText , @Quantity,  @Price, @OrderGroupIID,
		@EntityButtonIID, @DistributionIID, @ParentOrderIID, @ItemType, @DisplayOrder,
		@EntityName, @EntityDisplayOrder, @TaxPercent,@CompletedQuantity)
	END 
	ELSE
	BEGIN
		Update XOrderItem set 
		EntityIID = @EntityIID,
		OrderItemText = @OrderItemText, 
		Quantity = @Quantity, 
		Price = @Price, 
		OrderGroupIID= @OrderGroupIID, 
		EntityButtonIID = @EntityButtonIID, 
		DistributionIID = @DistributionIID, 
		ParentOrderIID = @ParentOrderIID, 
		ItemType = @ItemType,
		DisplayOrder = @DisplayOrder,
		EntityName = @EntityName,
		EntityDisplayOrder = @EntityDisplayOrder,
		TaxPercent = @TaxPercent,
		CompletedQuantity = @CompletedQuantity
		Where IID = @IID
	END
