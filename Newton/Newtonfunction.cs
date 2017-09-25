using System;

namespace Newton
{
    /// <summary>
    /// Calculation of roots using the newtonmethod
    /// </summary>
    class Newtonfunction
    {
        /// <summary>
        /// root object
        /// </summary>
        private Root root;

        /// <summary>
        /// value of the precision of the root calculation
        /// </summary>
        private int precisionOfCalculation;

        /// <summary>
        /// Accessor to the value of the precision of the calculation
        /// </summary>
        public int PrecisionOfCalculation
        {
            get
            {
                return precisionOfCalculation;
            }
            set
            {
                precisionOfCalculation = value;
            }
        }

        /// <summary>
        /// value of the possible solution of the calculation
        /// </summary>
        private float possibleSolution;

        /// <summary>
        /// Accessor of value of the possible solution of the calculation
        /// </summary>
        public float PossibleSolution
        {
            get
            {
                return possibleSolution;
            }
            set
            {
                possibleSolution = value;
            }
        }

        /// <summary>
        /// value of the limit value of the root
        /// </summary>
        private float limitValue;

        /// <summary>
        /// Accessor of the value if the value of the limit value
        /// </summary>
        public float LimitValue
        {
            get
            {
                return limitValue;
            }
            set
            {
                limitValue = value;
            }
        }

        /// <summary>
        /// value of epsilon to decide if possible solution of calculation is precise enough
        /// </summary>
        private double epsilon;

        /// <summary>
        /// Representation of the root in the newtonfunction and decimalprecision of the calculation
        /// </summary>
        /// <param name="orderOfRoot">Order of the root</param>
        /// <param name="radicand">Radicand of root</param>
        /// <param name="precisionOfCalculation">Precision of calculation</param>
        public Newtonfunction(Root root, int precisionOfCalculation)
        {
            this.root = root;
            this.epsilon = Math.Pow(10, -precisionOfCalculation);
        }

        /// <summary>
        /// Constructor with default value 2 for precision of calculation
        /// </summary>
        /// <param name="orderOfRoot"></param>
        /// <param name="radicand"></param>
        public Newtonfunction(Root root) : this(root, 2)
        {
        }

        /// <summary>
        /// Shows the current data of the root
        /// </summary>
        /// <returns>Stringrepresentation of the root</returns>
        public override string ToString()
        {
            return $"{root.OrderOfRoot} root of {root.Radicand} with decimalprecision of {precisionOfCalculation} and epsilon of {epsilon}";
        }

        /// <summary>
        /// method to decide if possible solution of the root calculation is precise enough, based on epsilon
        /// </summary>
        /// <param name="PossibleSolution">possible solution of the root calculation</param>
        /// <param name="Epsilon">value to decide if the possible solution is precise enough</param>
        /// <returns>true, if possible solution is precise enough, else false</returns>
        private bool IsPreciseEnough(float PossibleSolution)
        {
            if (Math.Abs(root.Radicand - (PossibleSolution * PossibleSolution)) < epsilon)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// calculates the limit value of the root
        /// </summary>
        /// <returns>limit value of the root</returns>
        private float CalculateLimitValue()
        {

            return (1 + root.Radicand) / 2;
        }

        /// <summary>
        /// Iterative Implemention des Newtonverfahrens zur Wurzelberechnung
        /// </summary>
        /// <returns>Nach Newtonverfahren berechnete Wurzel</returns>
        public  float CalculateRootSolutionIterative()
        {
            LimitValue = CalculateLimitValue();

            PossibleSolution = LimitValue;

            while (!IsPreciseEnough(PossibleSolution))
            {
                PossibleSolution = (PossibleSolution / 2) * (3 - ((PossibleSolution * PossibleSolution) / root.Radicand));
            }
            return PossibleSolution;
        }

        /// <summary>
        /// Rekursive Implementation des Newtonverfahrens zur Wurzelberechnung
        /// </summary>
        /// <param name="PossibleSolution">Mögliche Lösung </param>
        /// <returns>Nach Newtonverfahren berechnete Wurzel</returns>
        public float CalculateSolutionRecursive(float PossibleSolution)
        {
            if(IsPreciseEnough(PossibleSolution))
            {
                return PossibleSolution;
            }

            return CalculateSolutionRecursive((PossibleSolution / 2) * ((PossibleSolution * PossibleSolution) / root.Radicand));
        }
    }
}
