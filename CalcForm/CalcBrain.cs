using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    class CalcBrain
    {
        float firstNumber;
        string operationToPerform;

        public void storeFirstNumber(float numberToStore)
        {
            firstNumber = numberToStore;
        }

        public void storeOperationToDo(string operationToStore)
        {
            operationToPerform = operationToStore;
        }

        public string performCalculation(float secondNumber)
        {
            float answer = 0;
            if (operationToPerform == "+")
            {
                answer = firstNumber + secondNumber;
            }
            else if (operationToPerform == "-")
            {
                answer = firstNumber - secondNumber;
            }
            else if (operationToPerform == "*")
            {
                answer = firstNumber * secondNumber;
            }
            else  if (operationToPerform == "/")
            {
                answer = firstNumber / secondNumber;
            }
            return answer.ToString();
        }
    }
}
