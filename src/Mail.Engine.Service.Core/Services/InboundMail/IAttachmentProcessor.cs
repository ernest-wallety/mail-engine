using Mail.Engine.Service.Core.Entities;
using MimeKit;

namespace Mail.Engine.Service.Core.Services.InboundMail
{
    public interface IAttachmentProcessor
    {
        Task ProcessAttachmentsAsync(MimeMessage message, string mailMessageId, MailboxEntity mailbox);
    }
}