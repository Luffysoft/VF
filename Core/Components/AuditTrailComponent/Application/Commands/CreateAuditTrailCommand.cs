﻿using System;
using Umc.VigiFlow.Core.SharedKernel.Commands;
using Umc.VigiFlow.Core.SharedKernel.Models;

namespace Umc.VigiFlow.Core.Components.AuditTrailComponent.Application.Commands
{
    public class CreateAuditTrailCommand : Command
    {
        #region Setup

        public readonly Entity Entity;

        public CreateAuditTrailCommand(Guid commandId, Entity entity, Guid? originFromCommandId = null) : base(commandId, originFromCommandId)
        {
            Entity = entity;
        }

        #endregion Setup
    }
}