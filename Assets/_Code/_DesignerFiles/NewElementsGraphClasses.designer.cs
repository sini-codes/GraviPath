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
    
    private String _Name;
    
    private Vector3 _Position;
    
    private Vector3 _Rotation;
    
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName){ PropertyChangedEventHandler handler = PropertyChanged; if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName)); }
    public virtual String Name {
        get {
            return this._Name;
        }
        set {
            _Name = value;
            OnPropertyChanged("Name");
        }
    }
    
    public virtual Vector3 Position {
        get {
            return this._Position;
        }
        set {
            _Position = value;
            OnPropertyChanged("Position");
        }
    }
    
    public virtual Vector3 Rotation {
        get {
            return this._Rotation;
        }
        set {
            _Rotation = value;
            OnPropertyChanged("Rotation");
        }
    }
}
