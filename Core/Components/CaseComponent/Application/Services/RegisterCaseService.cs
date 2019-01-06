﻿using System;
using Umc.VigiFlow.Core.Components.CaseComponent.Application.Repositories;
using Umc.VigiFlow.Core.Ports;
using Umc.VigiFlow.Core.SharedKernel.Events;

namespace Umc.VigiFlow.Core.Components.CaseComponent.Application.Services
{
    public class RegisterCaseService : IRegisterCaseService
    {
        #region Setup

        private readonly ICaseRepository caseRepository;
        private readonly IEventBus eventBus;

        public RegisterCaseService(ICaseRepository caseRepository, IEventBus eventBus)
        {
            this.caseRepository = caseRepository;
            this.eventBus = eventBus;
        }

        #endregion Setup

        #region IRegisterCaseService

        public void RegisterCase(Guid commandId, Domain.Models.Case newCase)
        {
            caseRepository.Store(newCase);

            eventBus.Publish(new CaseRegisteredEvent(Guid.NewGuid(), commandId, newCase.Id));
        }

        #endregion IRegisterCaseService
    }
}