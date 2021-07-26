bulk insert dbo.nonword_repitition
from '\\ac-dc2\student$\year13\samuel.cuanang\GitHub\WindowsFormsApp2\Nonword Repitition - Sheet1.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go