bulk insert dbo.Elision
from '\\ac-dc2\student$\year13\samuel.cuanang\GitHub\WindowsFormsApp2\Elison Table.xlsx - Sheet1 (1).csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go