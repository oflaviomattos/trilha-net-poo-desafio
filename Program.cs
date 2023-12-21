using DesafioPOO.Models;

// IMPLEMENTADO os testes com as classes Nokia e Iphone

Console.WriteLine("Informações do Smarthphone Nokia... ");
Smartphone nokia =  new Nokia  (numero: "+55 (21) 923665-99322",
                                modelo: "Nokia 110",
                                emei: "3538746354261789",
                                memoria: "8G");
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n");

Console.WriteLine("Informações do Smarthphone Iphone... ");
Smartphone iphone =  new Iphone (numero: "+55 (21) 99876-54321",
                                modelo: "Iphone14",
                                emei: "3538134542617878",
                                memoria: "256G");
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

