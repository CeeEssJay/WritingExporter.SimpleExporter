﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingExporter.Common.StorySyncWorker
{
    public class StorySyncWorkerStoryStatusEventArgs : EventArgs
    {
        public StorySyncWorkerStoryStatus NewStatus { get; set; }
    }
}
