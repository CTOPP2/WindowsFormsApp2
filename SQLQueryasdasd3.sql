bulk insert dbo.segmenting_nonwords
from '\\ac-dc2\student$\year13\samuel.cuanang\GitHub\WindowsFormsApp2\SegmentingNonwords - Sheet1.csv'
with (FIRSTROW = 2, fieldterminator = ',', rowterminator = '\n')
go