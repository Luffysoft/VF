﻿namespace Umc.VigiFlow.Core.SharedKernel.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
