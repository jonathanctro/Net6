using DeLaSalle.Practica1.Core.Service.Interfaces;
using DeLaSalle.Practica1.Core.Entities;
namespace DeLaSalle.Practica1.Core.Service;


public class WeightService : IWeightSerive
{
    //Propiedades

    //Metodos
    public double ProcessWeigth(Person person)
    {
        double WeightMars = (person.Weight / 9.81) * 3.711;

        return WeightMars;

    }


}
