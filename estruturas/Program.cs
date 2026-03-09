/*
 * PROBLEMA: 1069 - Diamantes e Areia (Beecrowd)
 * * DESCRIÇÃO:
 * João está trabalhando em uma mina, tentando retirar o máximo que consegue de diamantes "<>". 
 * Ele deve excluir todas as partículas de areia "." do processo e a cada retirada de diamante, 
 * novos diamantes poderão se formar. 
 * * Exemplo: 
 * Entrada: .<...<<..>>....>....>>>.
 * Resultado: 3 diamantes formados.
 * * ENTRADA:
 * Um valor inteiro N (casos de teste). Cada linha seguinte contém até 1000 caracteres (<, >, .).
 * * SAÍDA:
 * A quantidade de diamantes possíveis de serem extraídos em cada caso.
 */
using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine()); 

        for (int i = 0 ; i < n ; i++)
        {
            string mina = Console.ReadLine();

            int aberto = 0;
            int diamante = 0;

        foreach (Char c in mina)
            {
                if (c == '<' )
                {
                    aberto++; 
                }
                else if (c == '>'){
                    if ( aberto > 0)
                    {
                        diamante++;
                        aberto--;
                    }
                }

            }

            Console.WriteLine(diamante);

        }






    }

}