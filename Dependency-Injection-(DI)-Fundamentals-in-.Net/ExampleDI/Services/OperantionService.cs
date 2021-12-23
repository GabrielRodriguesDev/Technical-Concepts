using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleDI.Services.Interfaces;

namespace ExampleDI.Services
{
    public class OperantionService
    {
        public OperantionService(
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation)
        {
            this.TransientOperation = transientOperation;
            this.ScopedOperation = scopedOperation;
            this.SingletonOperation = singletonOperation;
        }


        public IOperationTransient TransientOperation { get; }

        public IOperationScoped ScopedOperation { get; }

        public IOperationSingleton SingletonOperation { get; }

    }
}
