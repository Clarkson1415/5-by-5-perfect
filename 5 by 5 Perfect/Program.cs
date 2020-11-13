using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_by_5_perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            //game board is (0,0) bottom left start, ends at (4,4)
            int x = 0;
            int y = 0;
            int r = 0;


            Random diceRoll = new Random(); //random method calle diceRoll
            int i = 0;
            for (; ; )
            {
                if (i < 10000) //run the game until I've won 5 times.
                {

                    if (x == 4 && y == 4) //won
                    {
                        Console.WriteLine("{0}", r);
                        x = 0;
                        y = 0;
                        r = 0;
                        i++; //incrase counter by 1

                    }
                    //ladders
                    else if (x == 1 && y == 1)
                    {
                        x = 0;
                        y = 3;
                    }
                    else if (x == 2 && y == 2)
                    {
                        x = 3;
                        y = 4;

                    }
                    //snake
                    else if (x == 1 && y == 3)
                    {

                        x = 3;
                        y = 0;
                    }


                    //for the last 3 spaces that need to be perfect or you bounce back the extra spaces after last square instead of winning.
                    else if (x >= 2 && y == 4)
                    {
                        int Roll = diceRoll.Next(1, 4); //roll 1,2 or 3.

                        r++;

                        if (x + Roll == 3) ;
                        {
                            x = 3;
                        }

                        if (x + Roll == 4) //won with perfect roll of a 2 from space 0 or a roll of 1 from space 1.
                        {
                            x = 4;
                        }
                        else if (x + Roll == 5)//if on 0 and roll 3 or on 1 and roll 2.
                        {
                            x = 3;
                            
                        }
                        else if (x + Roll == 6)//rolled extra 2.
                        {
                            x = 2;
                           
                        }

                    }

                    else
                    {
                        int Roll = diceRoll.Next(1, 4); //roll 1,2 or 3.

                        r++;
                       

                        if (y % 2 == 0) //if line is even
                        {
                            if (x + Roll < 5)
                            {
                                x += Roll;
                            }
                            else if (x + Roll == 5)
                            {
                                x = 4;
                                if (y < 4)
                                {
                                    y++;
                                }
                            }
                            else if (x + Roll == 6)
                            {
                                x = 3;
                                if (y < 4) //if not the last row
                                {
                                    y++;
                                }
                            }
                            else if (x + Roll == 7)
                            {
                                x = 2;
                                if (y < 4) //only adds y if less than last row
                                {
                                    y++;
                                }
                            }

                        }


                        else if (y % 2 != 0)
                        {
                        
                            if (x - Roll >= 0)
                            {
                                x -= Roll;
                            }
                            else if (x - Roll == -1)
                            {
                                x = 0;
                                if (y < 4)
                                {
                                    y++;
                                }
                            }
                            else if (x - Roll == -2)
                            {
                                x = 1;
                                if (y < 4)
                                {
                                    y++;
                                }
                            }
                            else if (x - Roll == -3)
                            {
                                x = 2;
                                if (y < 4)
                                {
                                    y++;
                                }
                            }




                        }


                    }
                }
            }
        }
    }
}
