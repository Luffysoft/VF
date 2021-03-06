﻿using System;
using Umc.VigiFlow.Core.SharedKernel.Models;

namespace Umc.VigiFlow.Core.Components.CaseComponent.Domain.Models
{
    public class HistoricCase : Entity
    {
        #region Properties

        public Case Case { get; private set; }

        #endregion Properties

        #region Setup

        public HistoricCase(Guid id, Case @case) : base(id)
        {
            Case = @case;
        }

        #endregion Setup
    }
}
