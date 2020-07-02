using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabit.Transfer.Applicaton.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransfarLogs();
    }
}
