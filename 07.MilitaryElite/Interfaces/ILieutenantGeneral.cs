﻿using _07.MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral
    {
        public ICollection<IPrivate> Privates { get; }
    }
}
