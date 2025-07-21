using Builder;

var builder = new InvoiceBuilder();

Invoice invoice = builder
  .SetDate(new DateTime(2025, 1, 1))
  .SetInvoiceNumber("A1")
  .SetVendor("Google..")
  .SetVendee("Vendee")
  .SetLineItems(new List<string>() { "LI1", "LI2" })
  .Build();


Console.WriteLine(invoice.Vendor);
Console.WriteLine(invoice.Vendee);
