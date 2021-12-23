using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleDI.Services.Interfaces;

namespace ExampleDI.Model
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public Operation()
        {   /* Criando um Guid quando o objeto por gerado para que assim possamos validar o funcionamento
                de cada ciclo de vida - Transient - Scoped - Singleton */
            this.OperationId = Guid.NewGuid().ToString();
        }


        public string OperationId { get; }
    }
}
