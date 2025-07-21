using AbstractFactory;

Application winApp = new Application(new WindowsFactory());
winApp.RenderUI();

Application macApp = new Application(new MacFactory());
macApp.RenderUI();
