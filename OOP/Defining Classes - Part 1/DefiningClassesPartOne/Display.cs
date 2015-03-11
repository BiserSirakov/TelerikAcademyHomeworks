using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class Display
    {
        // Fields
        private double size;
        private int numberOfColors;

        // Properties
        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }

        // Constructors
        public Display()
        {

        }

        public Display(double size)
        {
            this.size = size;
        }

        public Display(double size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        // Methods
        public override string ToString()
        {
            return String.Format("Size: {0}, Number of colors: {1}",
                this.Size, this.NumberOfColors);
        }
    }
}
