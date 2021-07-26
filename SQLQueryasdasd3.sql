bulk insert dbo.rapid_digit_naming
from '\\ac-dc2\student$\year13\samuel.cuanang\GitHub\WindowsFormsApp2\RapidDigitNaming - Sheet1.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go