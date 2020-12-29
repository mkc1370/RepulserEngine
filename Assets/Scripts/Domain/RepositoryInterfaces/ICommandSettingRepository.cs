﻿using System;
using System.Collections.Generic;
using ProjectBlue.RepulserEngine.Domain.Model;

namespace ProjectBlue.RepulserEngine.DataStore
{

    public interface ICommandSettingRepository
    {
        void Save(IEnumerable<CommandSetting> CommandSettingList);
        IEnumerable<CommandSetting> Load();
        IObservable<IEnumerable<CommandSetting>> OnDataChangedAsObservable { get; }
    }
    
}