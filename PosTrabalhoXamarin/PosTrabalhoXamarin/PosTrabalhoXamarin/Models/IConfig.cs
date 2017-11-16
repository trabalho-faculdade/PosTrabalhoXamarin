﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace PosTrabalhoXamarin.Models
{
    public interface IConfig
    {
        string DiretorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
