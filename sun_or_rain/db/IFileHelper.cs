﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sun_or_rain.db
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
