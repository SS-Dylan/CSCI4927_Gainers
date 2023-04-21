using System;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Services
{
    public interface IMessageRepository
    {
        Message Create(Message newMessage);
        Message? Read(int id);
        ICollection<Message> ReadAll();
    }
}
