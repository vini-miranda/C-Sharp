using ByteBank.Funcionario;
using ByteBank.Sistema;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            acessarSistema();
        }

        public static void acessarSistema()
        {
            SistemaInterno system = new SistemaInterno();

            Diretor roberta = new Diretor("456987321-64");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("7896532410-45");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial renato = new ParceiroComercial();
            renato.Senha = "789";

            system.Logar(renato, "789");
            system.Logar(roberta, "12");
            system.Logar(camila, "abc");



        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("123654789-99");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("456987321-64");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("6897543215-87");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("7896532410-45");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total bonificações do mes: R$" + gerenciador.getBonificacao());
        }
    }
}
