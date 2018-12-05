Go
Create Table Coin (
	coinId Int Primary Key Not Null,
	coinName Varchar (20) Not Null,
	coinSymbol Varchar (5) Not Null,
	coinMaxSupply Float
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
	portfolioName Varchar (20)
)
Go
Create Table [Transaction] (
	transactionId Int Primary Key,
	transactionPorfolioId Int Foreign Key References Portfolio(portfolioId),
	transactionCoinId Int Foreign Key References Coin(coinId),
	transactionQuoteId Int Foreign Key References Quote(quoteId)
)
