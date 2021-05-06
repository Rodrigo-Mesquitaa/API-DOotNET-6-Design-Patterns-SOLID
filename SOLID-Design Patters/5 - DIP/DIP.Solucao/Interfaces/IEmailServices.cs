namespace SOLID_Design_Patters._5___DIP.DIP.Solucao.Interfaces
{
    public interface IEmailServices
    {
        bool IsValid(string email);
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}