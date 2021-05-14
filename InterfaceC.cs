using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWCalc
{
    interface InterfaceC
    {
        void SaveFirstNumber(double firstNumber); 

        void ClearFirstNumber();

        double Multiply(double secondNumber);

        double Divide(double secondNumberb);

        double Add(double secondNumber);

        double Subtract(double secondNumber); 

        double Sqrt();

        double MR(); 

        void MC();

        void MS(double ms);

        void MAdd(double secondNumber);

        void MSubtract(double secondNumber); 
    }
}
