bulk insert dbo.phoneme_iso
from '\\ac-dc2\student$\year13\samuel.cuanang\GitHub\WindowsFormsApp2\Phoneme Isolation Table - Sheet1.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go