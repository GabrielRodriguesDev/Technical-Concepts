using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExampleDI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExampleDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DIController : Controller
    {
        private readonly IOperationSingleton _operationSingleton;
        private readonly IOperationTransient _operationTransient;
        private readonly IOperationScoped _operationScoped;

        public DIController(
            /* Criando as DI para a minha controller */
            IOperationSingleton operationSingleton,
            IOperationTransient operationTransient,
            IOperationScoped operationScoped)
        {
            this._operationSingleton = operationSingleton;
            this._operationTransient = operationTransient;
            this._operationScoped = operationScoped;
        }

        /* Criando um método que retorna o atributo OperationId de cada objeto criado criado a partir da DI
            no momento que a controller foi construida, como cada DI tem uma forma de gerar o ciclo de vida do serviço
            os valores de cada atributo não devem ser os mesmo, ou pelo menos não ter o mesmo funcionamento.
        */
        [HttpGet]
        [Route("/getservices")]
        public string GetServices()
        {
            return
                $"Singleton - {_operationSingleton.OperationId} / Transient - {_operationTransient.OperationId} / Scoped - {_operationScoped.OperationId}";
        }
    }
}
