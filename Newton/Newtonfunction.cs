using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton
{
    /// <summary>
    /// Calculation of roots using the newtonmethod
    /// </summary>
    class Newtonfunction
    {

        private Root root;
        private int precisionOfCalculation;

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

        private decimal possibleSolution;

        public decimal PossibleSolution
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

        private decimal limitValue;

        public decimal LimitValue
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
       

        private bool IsPreciseEnough(float PossibleSolution, float Epsilon)
        {
            if (root.Radicand - (PossibleSolution * PossibleSolution) < Epsilon) {
                return true;
            }
            return false;
        }

        private float CalculatePossibleSolution()
        {

            float possibleSolution = (1 + root.Radicand) / 2;

            return possibleSolution;
        }

    }
}
