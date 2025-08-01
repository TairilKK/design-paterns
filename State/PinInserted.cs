namespace State;

public class PinInserted : State
{
  public PinInserted(Context context) : base(context)
  {
  }

  public override void EjectCard()
  {
    Console.WriteLine("Card ejected");
    _context.ChangeState(new NoCard(_context));
  }

  public override void InserCard()
  {
    Console.WriteLine("You have already inserted a card");
  }

  public override void InsertPin(int pin)
  {
    Console.WriteLine("You have already inserted correct PIN");
  }

  public override void WithdrawCash(int amount)
  {
    if (amount > _context.AvailableCash)
    {
      Console.WriteLine("That amoun of cash is not available");
    }
    else
    {
      Console.WriteLine($"You have withdraw {amount} from the machine");
      _context.AvailableCash -= amount;

      if (_context.AvailableCash == 0)
      {
        _context.ChangeState(new NoCash(_context));
      }
      else
      {
        Console.WriteLine("Card ejected");
        _context.ChangeState(new NoCard(_context));
      }
    }
  }
}
