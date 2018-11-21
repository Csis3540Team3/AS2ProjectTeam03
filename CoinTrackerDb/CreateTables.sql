Go
Create Table Coin (
	coinId Int Primary Key Not Null,
	coinName Varchar (20) Not Null,
	coinSymbol Varchar (5) Not Null,
	coinCurrency Varchar(3) Not Null,
	coinCurrencyValue Float Not Null,
	coin24HourChange Float Not Null,
	coinMaxSupply Float
)
Go
Create Table Portfolio (
	portfolioId Int Primary Key Not Null,
	portfolioName Varchar (20),
)
Go
Create Table [Transaction] (
	transactionId Int Primary Key,
	transactionPorfolio Int Foreign Key References Portfolio(portfolioId),
	transactionCoin Int Foreign Key References Coin(coinId)
)