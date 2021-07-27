bulk insert dbo.blending_nonwords
from '\\ac-dc2\student$\year13\samuel.cuanang\GitHub\WindowsFormsApp2\Blending_Nonwords - Sheet1.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go