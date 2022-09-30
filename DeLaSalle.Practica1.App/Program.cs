using DeLaSalle.Practica1.Core.Entities;
using DeLaSalle.Practica1.Core.Manager;
using DeLaSalle.Practica1.Core.Service;

//Declaraciones
//peso
float weight = 0;

//Mostramos letrero usuario.
Console.WriteLine("Captura tu peso porfavor (KG):");
//Guardamos lo que escribio el usuario.
Single.TryParse(Console.ReadLine(), out weight);


//Declaramos el objeto persona y la inicializamos con el valor que capture el usuario
var person = new Person { Weight = weight };


/***********************
*Procesamos los datos  *
************************/
//1.Creamos el servicio
var service = new WeightService();
//2.Creamos el Manager e inyectamos el service
var manager = new WeightManager(service);
//3.Obtener peso en marte
var weightinmars=manager.GetWeight(person);

//4.Imprimimos el resultado
Console.WriteLine($"Peso en marte {weightinmars} kg");