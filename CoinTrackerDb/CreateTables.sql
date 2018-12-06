Go
Create Table Coin (
	coinId Int Primary Key Not Null,
	coinName Varchar (100) Not Null,
	coinSymbol Varchar (10) Not Null,
	coinMaxSupply BigInt
)
GO
CREATE TABLE Quote (
	quoteId Int Primary Key Not Null,
	quoteDateTime DateTime Not Null,
	quoteVolume Float,
	quotePrice Float Not Null,
	quote24Hr Float,
	quoteCoinId Int Foreign Key References Coin(coinId)
)
Go
Create Table Portfolio (
	portfolioId Int Primary Key Not Null,
	portfolioName Varchar (20) Not Null
)
Go
Create Table [Transaction] (
	transactionId Int Primary Key Not Null,
	transactionPorfolioId Int Foreign Key References Portfolio(portfolioId) Not Null,
	transactionCoinId Int Foreign Key References Coin(coinId) Not Null,
	transactionQuoteId Int Foreign Key References Quote(quoteId),
	transactionAmount Float Not Null,
	transactionPricePerCoin Float Not Null
)
