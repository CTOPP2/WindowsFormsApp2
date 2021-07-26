bulk insert dbo.blendedwords
from 'H:\GitHub\WindowsFormsApp2\blendedWords - Sheet1.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go