using System;

namespace SimpleSingletonAdapterInCSharp
{
    /*
     O Padrão de projeto Adapter faz por meio de um intemediador com que possamos realizar conexões em entidades não conectáveis.
    Como se fosse um adaptador de tomada elétrica.

    No exemplo abaixo, simulamos comunicação com base de dados relacionais, ORACLE e MYSQL, onde por meio da interface comum de Comunicação com o Banco (IDataBaseComands) e a 
    utilização de adaptadores onde traduzem a chamada de INSERT, DELETE ou UPDATE de acordo com a chamada real da classe MySqlComands ou OracleComands. 
    As classes adapters implementam a interface e internamente ela direciona o Comando para a classe de comunicação com a base.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo básico de Adapter de Banco de Dados!");

            IDataBaseComands dbComands = new MySqlComandsAdapter();

            Console.WriteLine(dbComands.Insert());
            Console.WriteLine(dbComands.Delete());
            Console.WriteLine(dbComands.Update());

            Console.WriteLine();
            dbComands = new OracleComandsAdapter();

            Console.WriteLine(dbComands.Insert());
            Console.WriteLine(dbComands.Delete());
            Console.WriteLine(dbComands.Update());

            Console.ReadLine();

        }
    }
}
