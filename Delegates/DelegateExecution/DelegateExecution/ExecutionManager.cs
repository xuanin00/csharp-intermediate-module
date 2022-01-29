using System;
using System.Collections.Generic;

namespace DelegateExecution
{
    public class ExecutionManager
    {
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; }
        private Func<int> _sum;
        private Func<int> _subtract;
        private Func<int> _multiply;

        public ExecutionManager()
        {
            FuncExecute = new Dictionary<Operation, Func<int>>(3);
        }

        public void PopulateFunctions(Func<int> Sum, Func<int> Subtract, Func<int> Multiply)
        {
            _sum = Sum;
            _subtract = Subtract;
            _multiply = Multiply;
        }

        public void PrepareExecution()
        {
            FuncExecute.Add(Operation.Sum, _sum);
            FuncExecute.Add(Operation.Subtract, _subtract);
            FuncExecute.Add(Operation.Multiply, _multiply);
        }
    }
}
