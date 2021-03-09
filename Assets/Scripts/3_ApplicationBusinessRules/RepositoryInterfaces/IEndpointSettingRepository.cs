﻿using System;
using System.Collections;
using System.Collections.Generic;
using ProjectBlue.RepulserEngine.Domain.DataModel;

namespace ProjectBlue.RepulserEngine.DataStore
{

    public interface IEndpointSettingRepository
    {
        void Save(IEnumerable<EndpointSetting> pulseSettingList);
        IEnumerable<EndpointSetting> Load();
    }
    
}