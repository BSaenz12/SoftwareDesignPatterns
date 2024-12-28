// See https://aka.ms/new-console-template for more information
using SoftwareDesignPatterns.DesignPatterns;


// Author: B. Saenz
// Date: 12/28/2024
// Information was retrieved from ChatGPT.com - chatgpt 4o mini
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the Software Design Patterns console app!");


// Singleton usage
var instance = SingletonPattern.Instance;

// Factory pattern usage
ProductFactory factory = new ProductAFactory();
IProduct product = factory.CreateProduct();
product.Use();

// Observer pattern usage
var subject = new Subject();
var observer1 = new ConcreteObserver("Observer 1");
var observer2 = new ConcreteObserver("Observer 2");

subject.AddObserver(observer1);
subject.AddObserver(observer2);

subject.NotifyObservers("Hello Observers!");


// Strategy pattern usage
var context = new Context(new ConcreteStrategyA());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();


// Decorator pattern usage
ICar sportsCar = new SportsCar(new BasicCar());
sportsCar.Assemble();

ICar sportsLuxuryCar = new LuxuryCar(new SportsCar(new BasicCar()));
sportsLuxuryCar.Assemble();

// Command pattern usage
var light = new Light();
ICommand lightOn = new LightOnCommand(light);
ICommand lightOff = new LightOffCommand(light);

var remote = new RemoteControl();
remote.SetCommand(lightOn);
remote.PressButton();

remote.SetCommand(lightOff);
remote.PressButton();


// Adapter pattern usage
Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);
target.Request();
