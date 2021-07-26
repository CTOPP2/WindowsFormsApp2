bulk insert dbo.rapid_letter_naming
from '\\ac-dc2\student$\year13\samuel.cuanang\GitHub\WindowsFormsApp2\Rapid Letter Naming - Sheet1.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go