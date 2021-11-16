bulk insert dbo.Rapid_digit_naming
from 'C:\Users\samuel.cuanang\OneDrive - Aquinas College\!AAAAAAAAA\GitHub\WindowsFormsApp2\RapidDigitNaming - Sheet1 (3).csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go