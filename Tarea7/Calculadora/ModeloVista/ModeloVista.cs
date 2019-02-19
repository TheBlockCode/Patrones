using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class ModeloVista : ModeloVistaBase
    {

        #region Private members

        private Modelos.CalculationModel calculation;

        private DelegateCommand<string> digitButtonPressCommand;
        private DelegateCommand<string> operationButtonPressCommand;
        private DelegateCommand<string> singularOperationButtonPressCommand;


        private string lastOperation;
        private bool newDisplayRequired = false;
        private string fullExpression;
        private string display;

        #endregion

        #region Constructor

        public CalculatorViewModel()
        {
            this.calculation = new CalculationModel();
            this.display = "0";
            this.FirstOperand = string.Empty;
            this.SecondOperand = string.Empty;
            this.Operation = string.Empty;
            this.lastOperation = string.Empty;
            this.fullExpression = string.Empty;
        }

        #endregion

        #region Public Properties

        public string FirstOperand
        {
            get { return calculation.FirstOperand; }
            set { calculation.FirstOperand = value; }
        }

        public string SecondOperand
        {
            get { return calculation.SecondOperand; }
            set { calculation.SecondOperand = value; }
        }

        public string Operation
        {
            get { return calculation.Operation; }
            set { calculation.Operation = value; }
        }

        public string LastOperation
        {
            get { return lastOperation; }
            set { lastOperation = value; }
        }

        public string Result
        {
            get { return calculation.Result; }
        }

        public string Display
        {
            get { return display; }
            set
            {
                display = value;
                OnPropertyChanged("Display");
            }
        }

        public string FullExpression
        {
            get { return fullExpression; }
            set
            {
                fullExpression = value;
                OnPropertyChanged("FullExpression");
            }
        }

        #endregion

        #region Commands

        public ICommand OperationButtonPressCommand
        {
            get
            {
                if (operationButtonPressCommand == null)
                {
                    operationButtonPressCommand = new DelegateCommand<string>(
                        OperationButtonPress, CanOperationButtonPress);
                }
                return operationButtonPressCommand;
            }
        }

        private static bool CanOperationButtonPress(string number)
        {
            return true;
        }


        public ICommand SingularOperationButtonPressCommand
        {
            get
            {
                if (singularOperationButtonPressCommand == null)
                {
                    singularOperationButtonPressCommand = new DelegateCommand<string>(
                         SingularOperationButtonPress, CanSingularOperationButtonPress);
                }
                return singularOperationButtonPressCommand;
            }
        }

        private static bool CanSingularOperationButtonPress(string number)
        {
            return true;
        }


        public ICommand DigitButtonPressCommand
        {
            get
            {
                if (digitButtonPressCommand == null)
                {
                    digitButtonPressCommand = new DelegateCommand<string>(
                        DigitButtonPress, CanDigitButtonPress);
                }
                return digitButtonPressCommand;
            }
        }

        private static bool CanDigitButtonPress(string button)
        {
            return true;
        }

        //for operations with 2 operands
        public void OperationButtonPress(string operation)
        {
            try
            {
                if (FirstOperand == string.Empty || LastOperation == "=")
                {
                    FirstOperand = display;
                    LastOperation = operation;
                }
                else
                {
                    SecondOperand = display;
                    Operation = lastOperation;
                    calculation.CalculateResult();

                    FullExpression = Math.Round(Convert.ToDouble(FirstOperand), 10) + " " + Operation + " "
                                    + Math.Round(Convert.ToDouble(SecondOperand), 10) + " = "
                                    + Math.Round(Convert.ToDouble(Result), 10);

                    LastOperation = operation;
                    Display = Result;
                    FirstOperand = display;
                }
                newDisplayRequired = true;
            }
            catch (Exception ex)
            {
                Display = Result == string.Empty ? "Error" : Result;
                LogExceptionInformation(ex);
            }
        }

        //for sin,cos,tan
        public void SingularOperationButtonPress(string operation)
        {
            try
            {
                FirstOperand = Display;
                Operation = operation;
                calculation.CalculateResult();

                FullExpression = Operation + "(" + Math.Round(Convert.ToDouble(FirstOperand), 10) + ") = "
                    + Math.Round(Convert.ToDouble(Result), 10);

                LastOperation = "=";
                Display = Result;
                FirstOperand = display;
                newDisplayRequired = true;
            }
            catch (Exception ex)
            {
                Display = Result == string.Empty ? "Error - see event log" : Result;
                LogExceptionInformation(ex);
            }
        }

        //Write the full exception to the eventlog
        private static void LogExceptionInformation(Exception ex)
        {

        }

        #endregion
    }
}
