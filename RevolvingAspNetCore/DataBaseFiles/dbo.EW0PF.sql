DROP TABLE [dbo].[EW0PF]

CREATE TABLE [dbo].[EW0PF]
(
	[ANR] CHAR(20) NOT NULL PRIMARY KEY, /* Номер договора страхования */
	[NCD] CHAR(20) NOT NULL, /* номер кредитного договора */
	[STS] CHAR(1) NOT NULL, /* статус догвоора страхования */
	[PNUM] INT NOT NULL, /* номер текущего периода */
	[DOD] DATE  NOT NULL, /* дата ввода договора */
	[DSD] DATE, /* дата начала действия */
	[DSP] DATE, /* дата начала периода */
	[DEP] DATE, /* дата окончания периода */
	[DPR] DATE, /* дата последнего перерасчета */
	[TS] TIMESTAMP
)
