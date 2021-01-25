using CSharpV1Classes.Classes;

namespace CSharpV1Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classe instânciada à referência.
            TiposReferencia.TipoRef rtA = new TiposReferencia.TipoRef();

            // Classe instância atribuindo a um objeto nova referência.
            TiposReferencia.TipoRef rtB = rtA;
            
            // Imprimindo mensagem da referência.
            System.Console.WriteLine("Recebendo o tipo referência : " + rtB);
            System.Console.WriteLine("------------------------------------");

            //Declarando uma classe
            DeclaracaoDeClasse declaracao = new DeclaracaoDeClasse();

            // Imprimindo mensagem de classe.
            System.Console.WriteLine("Classe declarada: " + declaracao);
            System.Console.WriteLine("------------------------------------");

            // Primeiro objeto
            CriandoObjetos coA = new CriandoObjetos();
            // Segundo objeto
            CriandoObjetos coB = coA;

            // Imprimindo objetos.
            System.Console.WriteLine("Objeto criado: " + coB);
            System.Console.WriteLine("------------------------------------");

            
            // Chamando classe da herança
            HerancaDeClasse herancaDeClasse = new HerancaDeClasse();
            HerancaDeClasseA herancaDeClasseA = new HerancaDeClasseA();

            // Imprimindo heranças.
            System.Console.WriteLine(
                "Herança Principal: " + herancaDeClasse + 
                " Classe herdada: " + herancaDeClasseA
            );

        }
    }
}
