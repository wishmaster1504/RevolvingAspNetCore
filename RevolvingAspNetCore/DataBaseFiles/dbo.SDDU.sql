CREATE TABLE [dbo].[SDDU]
(
	[NCD] CHAR(20) NOT NULL PRIMARY KEY,/* номер кредитного догвоора */
	[TYPE] CHAR(20) NOT NULL, /* тип кредита */
	[DNK] DATE NOT NULL, /*дата начала кредита */
	[DEK] DATE NOT NULL, /* дата окончания кредита */
	[TS] TIMESTAMP /*дата и время добавления записи */
)
