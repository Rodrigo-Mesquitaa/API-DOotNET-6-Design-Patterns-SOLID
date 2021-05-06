namespace SOLID_Design_Patters._2___OCP.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Valida Aniversário da Conta
            // Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}