using Class_VS_Interface;
using Class_VS_Interface.Adapter_Pattern;
using Class_VS_Interface.FacadePattern;
using Class_VS_Interface.Memento;

//namespace Class_VS_Interface
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var eich = new Brendan();
//            var sanjay = new Sanjay();

//            eich.eat();
//            eich.sleep();
//            eich.love();
//            eich.run();
//            eich.writeCode();

//            sanjay.playMusic();
//            sanjay.writeCode();

//            Console.ReadLine();

//        }
//    }
//}

//ILDASM

Brendan eich = new Brendan();
Sanjay sanjay = new Sanjay();
Order placeOrder = new Order();
var flyList = new OrignalPolymorphism[3];
//ResumeBuilder builder = new ResumeBuilder();
//builder.createPDF();
//Resume myResume = builder
//                         .addName("Rahul", "Parikh")
//                         .addContactDetails("rahulparikh18@gmail.com", "8128984995", "Vadodara")
//                         .addEduction(new String[] { "BE in I.T" })
//                         .addSkills(new String[] { "C#", "TypeScript" })
//                         .addExperience(new String[] { "SSE in PMC", "SSE in Advanced Pvt LTd" })
//                         .addIntrest(new String[] { "Cricket", "Trekking", "Music" })
//                         .Build();
//builder.closePDF();

//var logger = Logger.Instance;
//for (int i = 0; i < (" Logger.Instance").Length; i++)
//{
//    logger.Info("This is logger class instance");
//}

//logger.Close();



//MessagePassing _messagePassing = new("Anders");
//_messagePassing.Message("Eat", "Mengo");
//_messagePassing.Message("Sleep", "6 hours");

//eich.eat();
//eich.sleep();
//eich.love();
//eich.run();
//eich.writeCode();

//sanjay.playMusic();
//sanjay.writeCode();

//var device = placeOrder.PlaceOrder("PC", 2, 32, 500, 14 );
//Console.WriteLine(device?.GetInfo());


//flyList[0] = new Superman();
//flyList[1] = new Plane();
//flyList[2] = new Mosquito();

//foreach (var item in flyList)
//{
//    item.fly();
//}

//var list = new List<Subscriber>();
//var bill = new Subscriber("Bill", "Gates");
//bill.AddNotifier(new Email("billg@microsoft.com"));
//list.Add(bill);

//var elon = new Subscriber("Elon", "Musk");
//elon.AddNotifier(new SMS("1-CALL-ELONMUSK"));
//list.Add(elon);

//var jeff = new Subscriber("Jeff", "Bezos");
//jeff.AddNotifier(new WhatsAppAdapter(new WhatsApp("Jeff Bezos")));
//list.Add(jeff);

//foreach (var person in list)
//    person.NotifySubscriber("Bill due in 3 days");


//string name = "Anil Ambani";
//double loanAmount = 100_000;

//LoanFacade facade = new LoanFacade();

//bool approved = facade.IsLoanApproved(name, loanAmount);

//string appStr = approved ? " " : " not ";
//Console.WriteLine($"Loan of amount {loanAmount} for {name} has{appStr}been approved");

// name = "Mukesh Ambani";
// loanAmount = 100_000;

// approved = facade.IsLoanApproved(name, loanAmount);

// appStr = approved ? " " : " not ";
//Console.WriteLine($"Loan of amount {loanAmount} for {name} has{appStr}been approved");






var location = new Location();
var locationStack = new LocationStack();

location.MoveTo("Kolkata");
locationStack.SaveState(location.SaveState());
location.print();
location.MoveTo("Indore");
location.print();
locationStack.SaveState(location.SaveState());
location.MoveTo("Mumbai");
location.print();
locationStack.SaveState(location.SaveState());

Console.WriteLine("\nDeleteing state");
location.DeleteState(locationStack.DeleteState());
location.print();
location.DeleteState(locationStack.DeleteState());
location.print();
location.DeleteState(locationStack.DeleteState());
location.print();

//Console.WriteLine(myResume);
Console.ReadLine();

