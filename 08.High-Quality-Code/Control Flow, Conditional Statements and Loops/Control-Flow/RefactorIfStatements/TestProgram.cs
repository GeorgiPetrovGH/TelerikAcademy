namespace RefactorIfStatements
{
    using System;
    class TestProgram
    {
        static void Main()
        {
            //Potato potato;
            //... 
            //if (potato != null)
            //    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
            //       Cook(potato);

            Potato potato = new Potato();

            bool isPeeled = potato.IsPeeled,
                 isRotten = potato.IsRotten;

            if (potato != null)
            {
                if (isPeeled && !isRotten)
                {
                    potato.IsCooked = true;
                }
            }

            //if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            //{
            //    VisitCell();
            //}

            const int MinX = 0;
            const int MaxX = 100;
            const int MinY = 0;
            const int MaxY = 100;

            int x = 10,
                y = 10;

            if (InRange(x, MinX, MaxX) && InRange(y, MinY, MaxY))
            {
                if (CheckCell())
                {
                    VisitCell();
                }
            }

        }


        public static bool InRange(int value, int min, int max)
        {
            bool isInRange = value >= min && value <= max;

            return isInRange;
        }
        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        private static bool CheckCell()
        {
            throw new NotImplementedException();
        }
    }
}
