namespace SOLID_Design_Patters._2___OCP.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita Conta Investimento
            // Isentar Taxas
            return FormatarTransacao();
        }
    }
}