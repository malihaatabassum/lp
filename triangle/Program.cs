using System;

namespace lp3
{
    public class Triangle
    {
        private int x;
        private int y;
        private int z;
        


        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }


        public int Z
        {
            set { z = value; }
            get { return z; }
        }


        public void showInfo()

        {
            Console.WriteLine("Triangle length: " + X);

            Console.WriteLine("Triangle height : " + Y);
            Console.WriteLine("Triangle width: " + Z);
        }

        public void TestTriangle()
        { if (X=Y && Y=Z && Z==X )
            { Console.WriteLine"All sides are Equal"}
        else if (X = Y || Y = Z || Z == X)
            { Console.WriteLine"2 of the  sides are Equal"}

    else { Console.WriteLine"0 sides are equal"}
        }