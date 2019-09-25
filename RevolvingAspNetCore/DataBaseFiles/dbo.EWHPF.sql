CREATE TABLE [dbo].[EWHPF]
(
	[ANR]  CHAR(20)        references  dbo.EW0PF(ANR), /* номер договора страхования */
	[PNUM] INT NOT NULL, /* номер периода */
	[DSP] DATE NOT NULL, /* дата начала периода */
	[DEP] DATE NOT NULL, /* дата окончания периода */
	[VAMA] NUMERIC(30,2), /* рассчитанная сумма премии за период */
	[AM1] NUMERIC(30,2), /* неоплаченная сумма премии за период */
	[LAST] CHAR(1) NOT NULL /* Текущий период? */
)
