namespace HappyTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lets find happy tickets

            string[] ticketsFirstHalfArray = new string[1000];
            string[] ticketsSecHalfArray = new string[1000];

            int happyTicketsAmount = 0;

            //000 000
            //000 001
            //000 002
            //..
            //000 010
            //000 011
            //..
            //999 999
            //add numbers
            for (int i = 0; i < ticketsFirstHalfArray.Length; i++)
            {
                ticketsFirstHalfArray[i] = i.ToString();
            }
            //copy to second
            ticketsSecHalfArray = ticketsFirstHalfArray;



            

            for (int i = 0; i < ticketsFirstHalfArray.Length; i++)
            {
                int curNumb = 0;
                for (int j = 0; j < ticketsFirstHalfArray[i].Length; j++)
                {
                    
                    curNumb += int.Parse(ticketsFirstHalfArray[i][j].ToString());

                }



                for (int j = 0; j < ticketsSecHalfArray.Length; j++)
                {
                    int secSum = 0;
                    for (int k = 0; k < ticketsSecHalfArray[j].Length; k++)
                    {

                        secSum += int.Parse(ticketsSecHalfArray[j][k].ToString());

                    }
                    //display on console all possible HappyTickets
                    if (curNumb == secSum) { Console.WriteLine($"{ticketsFirstHalfArray[i]}{ticketsSecHalfArray[j]} is Happy Ticket!"); }


                }

            }



        }
    }
}