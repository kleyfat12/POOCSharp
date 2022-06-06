using StaticMethods;

// SayHello is static so I can access through the class 
Printer.SayHello();

//I can not access to SayGoodbye through the class
//Printer.SayGoodbye();

// I need to create an object
Printer printer = new Printer();
printer.SayGoodbye();

// I can not access to SayHello through an object
// printer.SayHello();