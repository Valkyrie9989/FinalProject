using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] pokemonArray = new string[17];
            int[] selectedPokemon = new int[3];
            int player1Poke = 0;
            int player2Poke = 0;
            int player = 0;
            pokemonArray[0] = "Arceus - Normal";
            pokemonArray[1] = "Cobalion - Steel";
            pokemonArray[2] = "Darkrai - Dark";
            pokemonArray[3] = "Entei - Fire";
            pokemonArray[4] = "Genesect - Bug";
            pokemonArray[5] = "Giratina - Ghost";
            pokemonArray[6] = "Groudon - Ground";
            pokemonArray[7] = "Kyogre - Water";
            pokemonArray[8] = "Lugia - Flying";
            pokemonArray[9] = "Mewtwo - Psychic";
            pokemonArray[10] = "Rayquaza - Dragon";
            pokemonArray[11] = "Regice - Ice";
            pokemonArray[12] = "Regirock - Rock";
            pokemonArray[13] = "Terrakion - Fighting";
            pokemonArray[14] = "Virizion - Grass";
            pokemonArray[15] = "Weezing - Poison";
            pokemonArray[16] = "Zekrom - Electric";
            try
            {
                for (int i = 1; i < 3; i++)
                {
                    player = i;
                    Console.WriteLine("Please select a pokemon for player " + i + ": ");
                    Console.WriteLine();
                    Console.WriteLine("1) Arceus - Normal" + "       " + "2) Cobalion - Steel" + "\r\n" +
                                      "3) Darkrai - Dark" + "        " + "4) Entei - Fire" + "\r\n" +
                                      "5) Genesect - Bug" + "        " + "6) Giratina - Ghost" + "\r\n" +
                                      "7) Groudon - Ground" + "      " + "8) Kyogre - Water" + "\r\n" +
                                      "9) Lugia - Flying" + "       " + "10) Mewtwo - Psychic" + "\r\n" +
                                      "11) Rayquaza - Dragon" + "   " + "12) Regice - Ice" + "\r\n" +
                                      "13) Regirock - Rock" + "     " + "14) Terrakion - Fighting" + "\r\n" +
                                      "15) Virizion - Grass" + "    " + "16) Weezing - Poison" + "\r\n" +
                                      "17) Zekrom - Electric");
                        
                        try
                        {
                            selectedPokemon[i] = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            try
                            {
                                Console.WriteLine("You've entered an invalid pokemon number. Please enter a correct number 1-17. If you fail to do so the program will end.");
                                selectedPokemon[i] = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Environment.Exit(0);
                            }
                        }
                    
                    Console.WriteLine("Player " + i + " has selected " + pokemonArray[selectedPokemon[i] - 1]);
                    Console.WriteLine();
                    if (i == 1)
                    {
                        player1Poke = selectedPokemon[i];
                    }
                    else if (i == 2)
                    {
                        player2Poke = selectedPokemon[i];
                    }
                    else
                    {
                        Console.WriteLine("You goofed");
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Pokemon Number. Please press ENTER to close the program.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("PRESS ENTER TO CONTINUE TO THE BATTLE PHASE");
            Console.ReadLine();
            Application.Run(new Battle(selectedPokemon));
            Environment.Exit(0);
           
        }
    }
}
