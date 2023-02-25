namespace CalculadorDeVendas
{
    class Program
    {
        static void Main()
        {
            #region VARIABLES
            double PrecoOriginal;
            double Frete;
            double Aquisicao;

            double TaxaDeVendas;
            double ValorGastoEmAnuncios;
            double TaxasDaYampi = 2.5;
            double TaxasDoMercadoLivre = 2.0;

            double ValorSugestivo;

            double ValorComTaxaDeVendas;
            
            double ValorDeVenda;

            double Lucro;

            double Lucrox1;
            double LucroX5;
            double LucroX10;
            double LucroX25;
            double LucroX50;
            double LucroX100;
            double LucroX250;
            double LucroX500;
            double LucroX1000;
            #endregion

            #region CALCULATOR
            Console.WriteLine("Informe o valor original de compra:");
            PrecoOriginal = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do frete:");
            Frete = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua margem de lucro em porcentagem:");
            TaxaDeVendas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor gasto em anúncios:");
            ValorGastoEmAnuncios = double.Parse(Console.ReadLine());

            ValorComTaxaDeVendas = TaxaDeVenda(PrecoOriginal, Frete, TaxaDeVendas);

            Aquisicao = TaxasGateWay(ValorComTaxaDeVendas, Frete, PrecoOriginal, TaxasDaYampi, TaxasDoMercadoLivre) + ValorGastoEmAnuncios + Frete + PrecoOriginal;

            ValorSugestivo = ValorComTaxaDeVendas + Aquisicao;

            Lucro = ValorSugestivo - Aquisicao;

            Console.WriteLine("");
            Console.WriteLine("O valor sugestivo para sua venda é R$ " + ValorSugestivo);
            Console.WriteLine("O valor de aquisição foi: R$ " + Aquisicao);
            Console.WriteLine("Seu lucro por produto é: R$ " + Lucro);
            Console.WriteLine("A qual preço você irá vender este produto?");
            ValorDeVenda = double.Parse(Console.ReadLine());

            Lucrox1 = ValorDeVenda - Aquisicao;
            LucroX5 = Lucrox1 * 5;
            LucroX10 = Lucrox1 * 10;
            LucroX25 = Lucrox1 * 25;
            LucroX50 = Lucrox1 * 50;
            LucroX100 = Lucrox1 * 100;
            LucroX250 = Lucrox1 * 250;
            LucroX500 = Lucrox1 * 500;
            LucroX1000 = Lucrox1 * 1000;

            Console.WriteLine("");
            Console.WriteLine("Seu lucro x1 é: R$ " + Lucrox1);
            Console.WriteLine("Seu lucro x5 é: R$ " + LucroX5);
            Console.WriteLine("Seu lucro x10 é: R$ " + LucroX10);
            Console.WriteLine("Seu lucro x25 é: R$ " + LucroX25);
            Console.WriteLine("Seu lucro x50 é: R$ " + LucroX50);
            Console.WriteLine("Seu lucro x100 é: R$ " + LucroX100);
            Console.WriteLine("Seu lucro x250 é: R$ " + LucroX250);
            Console.WriteLine("Seu lucro x500 é: R$ " + LucroX500);
            Console.WriteLine("Seu lucro x1000 é: R$ " + LucroX1000);
            Console.WriteLine("");

            Console.WriteLine("Deseja fazer uma nova operação? Responda com: Sim/Não");
            var r = Console.ReadLine();

            if(r == "Sim")
            {
                Main();
            }

            else
            {
                Environment.Exit(0);
            }
            #endregion
        }

        #region METHODS
        public static double TaxaDeVenda(double PrecoOriginal, double Frete, double TaxasDeVendas)
        {
            return (((TaxasDeVendas * (PrecoOriginal + Frete)) / 100));
        }

        public static double TaxasGateWay(double ValorComTaxas, double Frete, double PrecoOriginal, double Yampi, double MercadoPago)
        {
            return ((Yampi * (ValorComTaxas + Frete + PrecoOriginal)) / 100) + ((MercadoPago * (ValorComTaxas + Frete + PrecoOriginal)) / 100);
        }
        #endregion
    }
}