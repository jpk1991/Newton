
namespace Newton
{
    public class Root
    {
        /// <summary>
        /// Value of the order of the root
        /// </summary>
        private int orderOfRoot;

        /// <summary>
        /// Accessor to value of the order of the root
        /// </summary>
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

        /// <summary>
        /// Value of the radicand
        /// </summary>
        private float radicand;

        /// <summary>
        /// Accessor to the value of the radicand
        /// </summary>
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

        /// <summary>
        /// Constructs a root object with variable order and radicand
        /// </summary>
        /// <param name="orderOfRoot">Integer value of the order of the root</param>
        /// <param name="radicand">Float value of the radicand</param>
        public Root(int orderOfRoot, float radicand)
        {
            this.orderOfRoot = orderOfRoot;
            this.radicand = radicand;
        }

        /// <summary>
        /// Constructs a root object with variable radicand and a default order of 2 (Squareroot)
        /// </summary>
        /// <param name="radicand">Float value iof the radicand</param>
        public Root(float radicand) : this(2, radicand)
        {
        }

        /// <summary>
        /// Give the description of the root object
        /// </summary>
        /// <returns>String representation of the root object</returns>
        public override string ToString()
        {
            return $"Rang der Wurzel: {OrderOfRoot} \nRadikand: {Radicand}";
        }
    }
}
