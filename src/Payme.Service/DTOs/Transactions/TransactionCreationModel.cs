﻿namespace Payme.Service.DTOs.Transactions;

public class TransactionCreationModel
{
    public long SenderCardId { get; set; }
    public long ReceiverCardId { get; set; }
    public decimal Amount { get; set; }
    public string Password { get; set; }
}
