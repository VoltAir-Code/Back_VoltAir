using VoltAir.Utils.Mail;

namespace VoltAir.Utils.Mail
{
    public class EmailSendingService
    {
        private readonly IEmailService emailService;
        public EmailSendingService(IEmailService service)
        {
            emailService = service;
        }


        public async Task SendWelcomeEmail(string email, string username)
        {
            try
            {
                MailRequest requst = new MailRequest
                {
                    ToEmail = email,
                    Subject = "Bem vindo ao Voltaire",
                    Body = GetHtmlContent(username)
                };

                await emailService.SendEmailAsync(requst);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task SendRecoveryPassword(string email, int codigo)
        {
            try
            {
                MailRequest requst = new MailRequest
                {
                    ToEmail = email,
                    Subject = "Código de Recuperação",
                    Body = GetHtmlContentRecovery(codigo)
                };

                await emailService.SendEmailAsync(requst);
            }
            catch (Exception)
            {

                throw;
            }
        }



        private string GetHtmlContent(string userName)
        {
            string Response = @"
<div style=""width:100%; background-color:rgba(49, 49, 49, 1); padding: 20px;"">
    <div style=""max-width: 600px; margin: 0 auto; background-color:#FFFFFF; border-radius: 10px; padding: 20px;"">
        <img src=""https://voltairestorage.blob.core.windows.net/blobvoltaire/logoVoltaire.png"" alt="" Logotipo da Aplicação"" style="" display: block; margin: 0 auto; max-width: 200px;"" />
        <h1 style=""color: #333333; text-align: center;"">Bem-vindo ao Voltaire!</h1>
        <p style=""color:#F2732E; text-align: center;"">Olá <strong>" + userName + @"</strong>,</p>
        <p style=""color:#F2732E;text-align: center"">Estamos muito felizes por você ter se inscrito na plataforma Voltaire.</p>
        <p style=""color:#F2732E;text-align: center"">Explore todas as funcionalidades que oferecemos e encontre os melhores caminhos para sua viagem.</p>
        <p style=""color:#F2732E;text-align: center"">Se tiver alguma dúvida ou precisar de assistência, nossa equipe de suporte está sempre pronta para ajudar.</p>
        <p style=""color:#F2732E;text-align: center"">Aproveite sua experiência conosco!</p>
        <p style=""color:#F2732E;text-align: center"">Atenciosamente,<br>Equipe Voltaire</p>
    </div>
</div>";

            // Retorna o conteúdo HTML do e-mail
            return Response;
        }
        private string GetHtmlContentRecovery(int codigo)
        {
            string Response = @"
<div style=""width:100%; background-color:rgba(49, 49, 49 1); padding: 20px;"">
    <div style=""max-width: 600px; margin: 0 auto; background-color:#FFFFFF; border-radius: 10px; padding: 20px;"">
        <img src=""https://voltairestorage.blob.core.windows.net/blobvoltaire/logoVoltaire.png"" alt="" Logotipo da Aplicação"" style="" display: block; margin: 0 auto; max-width: 200px;"" />
        <h1 style=""color: #333333;text-align: center;"">Recuperação de senha</h1>
        <p style=""color: #F2732E;font-size: 24px; text-align: center;"">Código de confirmação <strong>" + codigo + @"</strong></p>
    </div>
</div>";

            return Response;
        }
    }
}
