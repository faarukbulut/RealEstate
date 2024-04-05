﻿namespace RealEstate_Api.Dtos.MessageDtos
{
    public class ResultInboxMessageDto
    {
        public int MessageId { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}