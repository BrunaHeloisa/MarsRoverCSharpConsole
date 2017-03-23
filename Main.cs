using System;
using System.Text.RegularExpressions;

namespace MarsRoverCSharpConsole
{
    public class MarsRovers
    {

        public static void Main(string[] args)
        {
            Rover r = new Rover();
            int dir = 0;
            int xMax;
            int yMax;
            int xAtual;
            int yAtual;
            bool coordsNotOk = true;
            bool instrNotOk = true;
            string coordMax;
            string coordAtual;
            string dirAtual = "";
            Regex rgx = new Regex(@"^[MLR]+$");
           
            string[] vetMax;
            string[] vetAtual;
            char[] vetInstruction;
            string instruction;
            char[] separator = { };

            Console.WriteLine("Entre com o valor das coordenadas máximas do plano.");            
            coordMax = Console.ReadLine();
            vetMax = coordMax.Split(separator);
            xMax = Convert.ToInt32(vetMax[0]);
            yMax = Convert.ToInt32(vetMax[1]);

            if (xMax < 0)
            {
                xMax = Math.Abs(xMax);
            }
            if (yMax < 0)
            {
                yMax = Math.Abs(yMax);
            }

            while (true)
            {
                //Repete a instrução até que todos os parâmetros estejam corretos, ambos os números e a letra certa na direção (N|S|W|E) 
                do
                {
                    Console.WriteLine("Entre com o valor da coordenada atual do rover no plano, assim como a letra correpondente à direção atual (N, S, E, W).");
                    Console.WriteLine("Ex.: 4 5 N:  ");
                    coordAtual = Console.ReadLine();
                    vetAtual = coordAtual.Split(separator);
                    xAtual = int.Parse(vetAtual[0]);
                    yAtual = int.Parse(vetAtual[1]);
                    //Inputs negativos transformadas em inputs positivos
                    if (xAtual < 0)
                    {
                        xAtual = Math.Abs(yAtual);
                    }
                    if (yAtual < 0)
                    {
                        yAtual = Math.Abs(yAtual);
                    }

                    //Se as coordenadas do Rover são maiores que as coordenadas máximas do plano
                    if (xAtual > xMax || yAtual > yMax)
                    {
                        Console.WriteLine("Valor do x ou do y atual superior ao valor informado na coordenada máxima do plano.");
                        Console.WriteLine("Valores apenas positivos e, no máximo, correspondentes ao valor da coordenada máxima do plano. ");
                        Console.WriteLine("");
                        coordsNotOk = true;
                    }
                    else
                    {
                        //Se tudo estiver correto
                        if (vetAtual[2].Equals("N") || vetAtual[2].Equals("S") || vetAtual[2].Equals("E") || vetAtual[2].Equals("W"))
                        {
                            dirAtual = vetAtual[2];
                            Console.WriteLine("");
                            coordsNotOk = false;
                        }
                        //Se as direções estão erradas
                        else
                        {
                            coordsNotOk = true;
                        }
                    }
                } while (coordsNotOk);

                r.setCoordx(yAtual);
                r.setCoordy(yAtual);
                r.setDir(dirAtual);

                do
                {
                    Console.WriteLine("Escreva o conjunto de instruções que o rover deve seguir para se movimentar. ");
                    Console.WriteLine("Instruções aceitas: L (esquerda), R (direita) e M (mover): ");
                    instruction = Console.ReadLine();
                    vetInstruction = instruction.ToCharArray();

                    if (rgx.IsMatch(instruction))
                    {
                        instrNotOk = false;
                        foreach (char inst in vetInstruction)
                        {
                            if ('M'.Equals(inst))
                            {
                                    switch (r.getDir())
                                    {
                                        case "N":
                                            if (xMax > r.getCoordx())
                                            {
                                                r.mover();
                                            }
                                            break;
                                        case "S":
                                            if (0 < r.getCoordx())
                                            {
                                                r.mover();
                                            }
                                            break;
                                        case "W":
                                            if (0 < r.getCoordy())
                                            {
                                                r.mover();
                                            }
                                            break;
                                        case "E":
                                            if (yMax > r.getCoordy())
                                            {
                                                r.mover();
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            else
                            {
                                if ('L'.Equals(inst))
                                {
                                    r.mudaDir("L");
                                }
                                else
                                {
                                    if ('R'.Equals(inst))
                                    {
                                        r.mudaDir("R");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.Write("Comando inválido inserido.");
                        Console.WriteLine("Instruções aceitas: L (esquerda), R (direita) e M (mover): ");
                        instrNotOk = true;
                    }
                } while (instrNotOk);

                Console.WriteLine("A coordenada atual é: " + r.getCoordx() + " " + r.getCoordy() + " " + "e a direção: " + r.getDir());
                Console.WriteLine("");
            }
        }
    }
}

