﻿using System;
using System.Collections.Generic;
using ProjectBlue.RepulserEngine.Domain.Model;

namespace ProjectBlue.RepulserEngine.UseCaseInterfaces
{

    public interface ITimecodeSettingUseCase
    {
        void Save(IEnumerable<TimecodeSetting> timecodeSettings);
        IEnumerable<TimecodeSetting> Load();
    }

}