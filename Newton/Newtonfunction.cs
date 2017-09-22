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
        private int orderOfRoot;

        public int OrderOfRoot
        {
            get
            {
                return orderOfRoot;
            }
            set
            {
                orderOfRoot = value;
            }
        }

        private float radicand;

        public float Radicand
        {
            get
            {
                return radicand;
            }
            set
            {
                radicand = value;
            }
        }

        private int precisionOfCalculation;

        /// <summary>
        /// 
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
        /// Representation of the root in the newtonfunction and decimalprecision of the calculation
        /// </summary>
        /// <param name="orderOfRoot"> Order of the root</param>
        /// <param name="radicand">Radicand of the root</param>
        /// <param name="precisionOfCalculation">Precision of the calculation</param>
        public Newtonfunction(int orderOfRoot, float radicand, int precisionOfCalculation)
        {
            this.orderOfRoot = orderOfRoot;
            this.radicand = radicand;
            this.precisionOfCalculation = precisionOfCalculation;
        }

        /// <summary>
        /// Representation of the root in the newtonfunction and the decimalprecision of the calculation set to 2
        /// </summary>
        /// <param name="OrderOfRoot">Order of the root</param>
        /// <param name="Radicand">Radicand of the root</param>
        public Newtonfunction(int orderOfRoot, float radicand) : this(orderOfRoot, radicand, 2)
        {
        }

        /// <summary>
        /// Shows the current data of the root
        /// </summary>
        /// <returns>Stringrepresentation of the root</returns>
        public override string ToString()
        {
            return $"{orderOfRoot} root of {radicand} with decimalprecision of {precisionOfCalculation}";
        }
    }
}
