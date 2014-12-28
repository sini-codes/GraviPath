using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UniRx;
using UnityEngine.UI;


public partial class MenuRootView
{

    public Button PlayButton;
    public Button EditorButton;


    public override void Bind()
    {
        base.Bind();
        PlayButton.AsClickObservable().Subscribe(_ =>
        {
            ExecuteStartLevel("Level1");
        }).DisposeWith(this);


        EditorButton.AsClickObservable()
        .Subscribe(_ =>
        {
            ExecuteStartEditor();
        })
        .DisposeWith(this);

    }
}
