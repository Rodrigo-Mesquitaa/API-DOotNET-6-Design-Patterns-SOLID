namespace SOLID_Design_Patters._5___DIP.DIP.Violacao
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}