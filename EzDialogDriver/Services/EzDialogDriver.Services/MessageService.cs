using EzDialogDriver.Services.Interfaces;

namespace EzDialogDriver.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
