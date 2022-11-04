using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia1 = new Nokia("2197600-9515", "Nokia 350", "454563.659656", 2);
nokia1.Ligar();
nokia1.InstalarAplicativo("Whatsapp");

Console.WriteLine("/n");

Iphone iphone1 = new Iphone("2197600-9515", "Iphone 18", "54545.6445", 8);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Twitter");
