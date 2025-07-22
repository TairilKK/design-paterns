using TemplateMethod;

Console.WriteLine("*** PDF ***");
var pdfGenerator = new PdfGenerator();
pdfGenerator.GenerateReport();


Console.WriteLine("*** CSV ***");
var csvGenerator = new CsvGenerator();
csvGenerator.GenerateReport();


Console.WriteLine("*** EXCEL ***");
var excelGenerator = new ExcelGenerator();
excelGenerator.GenerateReport();
