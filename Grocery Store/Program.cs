using System;

namespace Grocery_Store
{
    class Program
    {
        class StarCard
        {
            public enum Level { Bronze, Silver, Gold };
            static int _starCardNext = 1000;

            private int NewIdNumber()
            {
                int rv = _starCardNext;
                _starCardNext++;
                return rv;
            }

            /* Commented out so the stub will compile.  Remove the comment at the beginning and end of UserInfo()
             * as you will need it for testing.  You are not allowed to modify it.
             */
            /*
            public void UserInfo()
            {
                string LevelAttained = "Bronze";
                if (_level == Level.Gold)
                {
                    LevelAttained = "Gold";
                }
                else if (_level == Level.Silver)
                {
                    LevelAttained = "Silver";
                }
                Console.WriteLine("{0} ({1}): {2} - {3}", _name, _starCardID, _pointsEarned, LevelAttained);
            }
            */

        }

        static void Main(string[] args)
        {
            StarCard user1 = new StarCard();
            StarCard user2 = new StarCard();
            StarCard user3 = new StarCard();

            /*  Test Code.  Commented out so the stub will compile.
             *  Remove Comments to test your code 

                        user1.UserInfo();
                        user1.NewCustomer("Bugs Bunny");
                        user1.UserInfo();
                        user1.AddPoints(55);
                        user1.UserInfo();
                        user1.AddPoints(155);
                        user1.UserInfo();
                        user1.AddPoints(500);
                        user1.UserInfo();
                        user1.AddPoints(400);
                        user1.UserInfo();
                        user1.SubtractPoints(900);
                        user1.UserInfo();
                        user1.SubtractPoints(900);
                        user1.UserInfo();
                        Console.WriteLine();

                        user2.NewCustomer("Donald Duck");
                        user2.UserInfo();
                        user2.AddPoints(-55);
                        user2.UserInfo();
                        user2.AddPoints(120);
                        user2.UserInfo();
                        user2.AddPoints(25,2);
                        user2.UserInfo();
                        user2.AddPoints(400);
                        user2.UserInfo();
                        user2.SubtractPoints(100);
                        user2.UserInfo();
                        user2.SubtractPoints(-50);
                        user2.UserInfo();
                        Console.WriteLine();

                        user3.NewCustomer("Mickey Mouse");
                        user3.UserInfo();
                        user3.SubtractPoints(25);
                        user3.UserInfo();
                        user3.AddPoints(-25,3);
                        user3.UserInfo();
                        user3.AddPoints(25,-3);
                        user3.UserInfo();
                        user3.AddPoints(125,5);
                        user3.UserInfo();

            *  End of Commented out code */
            Console.ReadKey();
        }
    }
}

