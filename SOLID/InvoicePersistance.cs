namespace SOLID;

public class InvoicePersistance
{
  private Invoice _invoice;

  public InvoicePersistance(Invoice invoice)
  {
    _invoice = invoice;
  }
  public void SaveToPdf()
  {
    Console.WriteLine("Saving to pdf");
  }

  public void SaveToWord()
  {
    Console.WriteLine("Saving to word");
  }
}
