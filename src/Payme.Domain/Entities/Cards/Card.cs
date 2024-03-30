﻿using Payme.Domain.Commons;
using Payme.Domain.Entities.Users;
using Payme.Domain.Enums;

namespace Payme.Domain.Entities.Cards;

public class Card : Auditable
{
    public long CustomerId { get; set; }
    public User Customer { get; set; }
    public CardType Type { get; set; }
    public long Number { get; set; }
    public string ExpiryData { get; set; }
    public string Password { get; set; }
    public decimal Balance { get; set; }
}
