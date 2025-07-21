using Builder;

var builder = new InvoiceBuilder();

builder.SetDate(new DateTime(2025, 1, 1));
builder.SetInvoiceNumber("A1");
builder.SetVendor("Google..");
builder.SetVendee("Vendee");
builder.SetLineItems(new List<string>() { "LI1", "LI2" });

Invoice invoice = builder.Build();

Console.WriteLine(invoice.Vendor);
Console.WriteLine(invoice.Vendee);
