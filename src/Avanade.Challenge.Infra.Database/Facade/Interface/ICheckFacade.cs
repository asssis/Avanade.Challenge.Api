﻿using Avanade.Challenge.Api.Infra.Database.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.Challenge.Infra.Database.Facade.Interface
{
    public interface ICheckFacade
    {
        bool Check(Phrase phrase, string answer);
    }
}
