using DeLaSalle.Practica1.Core.Entities;
using DeLaSalle.Practica1.Core.Service.Interfaces;
using DeLaSalle.Practica1.Core.Manager.Interfaces;

namespace DeLaSalle.Practica1.Core.Manager;

public class WeightManager:WeightPerson
{
    // 1 Inicializamos el servicio con private readonly, ya con esto nos aseguramos no se vuela a reinicializar
    private readonly IWeightSerive _service;
    //2 Inyectamos el servicio en el constructor
    public WeightManager(IWeightSerive service)
    {
        _service = service;

    }

    //3 Metodo implementado de la interface, recibe persona
     public double GetWeight(Person person){      
        //4 enviamos el peso al servicio
        return _service.ProcessWeigth(person);

     }

}

