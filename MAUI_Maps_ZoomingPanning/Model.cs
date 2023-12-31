﻿using Syncfusion.Maui.Maps;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUI_Maps_ZoomingPanning;

public class CustomMarker : MapMarker, INotifyPropertyChanged
{
    public new event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    private string? name;
    public string? Name
    {
        get
        {
            return name;
        }
        set
        {
            if (name != value)
            {
                name = value;
                NotifyPropertyChanged();
            }
        }
    }

    private string? state;
    public string? State
    {
        get
        {
            return state;
        }
        set
        {
            if (state != value)
            {
                state = value;
                NotifyPropertyChanged();
            }
        }
    }

    private string? country;
    public string? Country
    {
        get
        {
            return country;
        }
        set
        {
            if (country != value)
            {
                country = value;
                NotifyPropertyChanged();
            }
        }
    }

    private string? time;
    public string? Time
    {
        get
        {
            return time;
        }
        set
        {
            if (time != value)
            {
                time = value;
                NotifyPropertyChanged();
            }
        }
    }

}
