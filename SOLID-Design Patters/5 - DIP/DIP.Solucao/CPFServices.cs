using SOLID_Design_Patters._5___DIP.DIP.Solucao.Interfaces;

namespace SOLID_Design_Patters._5___DIP.DIP.Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}