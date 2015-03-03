﻿using System.Windows.Forms;
using MW5.Api.Interfaces;
using MW5.Api.Legend;
using MW5.Api.Legend.Abstract;

namespace MW5.Plugins.Interfaces
{
    public interface IAppContext
    {
        IMap Map { get; }
        ILegend Legend { get; }
        IWin32Window MainWindow { get; }
        IMenu Menu { get; }
        IToolbarCollection Toolbars { get; }
        bool Initialized { get; }
        void Init(IMainForm form);
    }
}
