using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console . Clear ();
            Console . WriteLine ( " --- Última Parcela " );
            DateTime  DataAtual  =  DateTime . Now ;
            Console . Write ( " Qual o valor total do financiamento ................: " );
            double  valorFinanciamento  =  Convert . ToDouble ( Console . ReadLine ());
            Console . Write ( " Quantidade de parcelas (sem juros) .................: " );
            int  quantidadeParcela  =  Convert . ToInt32 ( Console . ReadLine ());
            double  valorParcela  =  valorFinanciamento  /  quantidadeParcela ;
            DateTime  ultimaParcela  =  DataAtual . AddMonths ( quantidadeParcela );
            Console . Write (" Última parcela será em { ultimaParcela . ToShortDateString ()}, no valor de { valorParcela }. " );
        }
    }
}
