﻿namespace Umc.VigiFlow.Core.SharedKernel.Command
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}
