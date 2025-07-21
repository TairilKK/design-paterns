using ObjectOrientedProgramming;

IPrinter printer = GetPrinter();
printer.Print("some content");

static IPrinter GetPrinter()
{
  return new Cannon();
}
