bulk insert dbo.memorydigits
from '\\ac-dc2\student$\year13\samuel.cuanang\GitHub\WindowsFormsApp2\MemoryDigits - Sheet1.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go