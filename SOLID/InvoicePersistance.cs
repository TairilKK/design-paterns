namespace SOLID;

public class InvoicePersistance
{
  private Invoice _invoice;
  private IInvoiceSaver _invoiceSaver;

  public InvoicePersistance(Invoice invoice, IInvoiceSaver invoiceSaver)
  {
    _invoice = invoice;
    _invoiceSaver = invoiceSaver;
  }
  public void Save()
  {
    _invoiceSaver.Save(_invoice);
  }
}
