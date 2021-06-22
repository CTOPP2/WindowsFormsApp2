bulk insert dbo.CSVUserTestData
from 'C:\Users\justin.abrau\OneDrive - Aquinas College\2020 Year 12\Computer Tech\Elison Table.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go