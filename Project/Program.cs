using Project;
using Bytescout.Spreadsheet;

Function1.main();




















/*
Spreadsheet doc = new Spreadsheet();
doc.LoadFromFile("C:\\Users\\efani\\Source\\Repos\\Efanin\\Project\\Project\\excel-spreadsheet-examples-for-students.xlsx");
Worksheet sheet = doc.Workbook.Worksheets[0];
string[,] data = new string[sheet.NotEmptyRowMax + 1, sheet.NotEmptyColumnMax + 1];
for (int i = 0; i < sheet.NotEmptyRowMax+1; i++)
    for (int j = 0; j < sheet.NotEmptyColumnMax+1; j++)
        data[i,j] =  sheet.Cell(i, j).ToString();

for (int i = 0; i < data.GetLength(0); i++)
{
    for (int j = 0; j < data.GetLength(1); j++)
    {
        Console.Write(data[i,j]+" ");
    }
    Console.WriteLine();
}

*/
