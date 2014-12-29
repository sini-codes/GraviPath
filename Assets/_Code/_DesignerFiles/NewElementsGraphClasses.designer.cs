// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;
using UnityEngine;


public partial class UniverseObjectDescriptor : System.ComponentModel.INotifyPropertyChanged {
    
    private Vector3 _Position;
    
    private UniverseObjectType _Type;
    
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName){ PropertyChangedEventHandler handler = PropertyChanged; if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName)); }
    public virtual Vector3 Position {
        get {
            return this._Position;
        }
        set {
            _Position = value;
            OnPropertyChanged("Position");
        }
    }
    
    public virtual UniverseObjectType Type {
        get {
            return this._Type;
        }
        set {
            _Type = value;
            OnPropertyChanged("Type");
        }
    }
}

public partial class UniverseListUpdateDescriptor : System.ComponentModel.INotifyPropertyChanged {
    
    private UniverseListUpdateType _Type;
    
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName){ PropertyChangedEventHandler handler = PropertyChanged; if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName)); }
    public virtual UniverseListUpdateType Type {
        get {
            return this._Type;
        }
        set {
            _Type = value;
            OnPropertyChanged("Type");
        }
    }
}

public partial class StartLevelDescriptor : System.ComponentModel.INotifyPropertyChanged {
    
    private UniverseViewModel _Universe;
    
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName){ PropertyChangedEventHandler handler = PropertyChanged; if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName)); }
    public virtual UniverseViewModel Universe {
        get {
            return this._Universe;
        }
        set {
            _Universe = value;
            OnPropertyChanged("Universe");
        }
    }
}
