using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWCalc
{
    public class Calculate : InterfaceC
    {
        private double firstNumber = 0;
        private double memory = 0;

        public void SaveFirstNumber(double firstNumber)
        {
            this.firstNumber = firstNumber;
        }

        public void ClearFirstNumber()
        {
            firstNumber = 0;
        }

        public double Add(double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Multiply(double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public double Sqrt()
        {
            return Math.Sqrt(firstNumber);
        }

        public double MR()
        {
            return memory;
        }

        public void MC()
        {
            memory = 0;
        }

        public void MS(double ms)
        {
            memory = ms;
        }

        public void MAdd(double secondNumber)
        {
            memory = memory + secondNumber;
        }

        public void MSubtract(double secondNumber)
        {
            memory = memory - secondNumber;
        }
    }
}
