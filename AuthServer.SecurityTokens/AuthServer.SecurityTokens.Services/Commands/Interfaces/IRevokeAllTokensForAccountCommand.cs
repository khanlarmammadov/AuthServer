﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.SecurityTokens.Services.Commands.Interfaces
{
    public interface IRevokeAllTokensForAccountCommand
    {
        Task Execute(string accountId);
    }
}
