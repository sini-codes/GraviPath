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
using UniRx;
using UnityEngine;


public abstract class MenuRootControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    public abstract void InitializeMenuRoot(MenuRootViewModel menuRoot);
    
    public override ViewModel CreateEmpty() {
        return new MenuRootViewModel(this);
    }
    
    public virtual MenuRootViewModel CreateMenuRoot() {
        return ((MenuRootViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeMenuRoot(((MenuRootViewModel)(viewModel)));
    }
    
    public virtual void StartLevel(MenuRootViewModel menuRoot, String arg) {
    }
    
    public virtual void StartEditor(MenuRootViewModel menuRoot) {
    }
}

public abstract class LevelRootControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public TryEntryController TryEntryController {get;set;}
    public abstract void InitializeLevelRoot(LevelRootViewModel levelRoot);
    
    public override ViewModel CreateEmpty() {
        return new LevelRootViewModel(this);
    }
    
    public virtual LevelRootViewModel CreateLevelRoot() {
        return ((LevelRootViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeLevelRoot(((LevelRootViewModel)(viewModel)));
    }
    
    public virtual void ToMenu(LevelRootViewModel levelRoot) {
    }
    
    public virtual void Restart(LevelRootViewModel levelRoot, Boolean arg) {
    }
}

public abstract class PlayerControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject] public LevelRootController LevelRootController {get;set;}
    [Inject] public TryEntryController TryEntryController {get;set;}
    public abstract void InitializePlayer(PlayerViewModel player);
    
    public override ViewModel CreateEmpty() {
        return new PlayerViewModel(this);
    }
    
    public virtual PlayerViewModel CreatePlayer() {
        return ((PlayerViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializePlayer(((PlayerViewModel)(viewModel)));
    }
    
    public virtual void Accelerate(PlayerViewModel player) {
    }
    
    public virtual void SetAcceleration(PlayerViewModel player, Single arg) {
    }
    
    public virtual void SetDirection(PlayerViewModel player, Vector3 arg) {
    }
    
    public virtual void Reset(PlayerViewModel player) {
    }
    
    public virtual void Crash(PlayerViewModel player) {
    }
}

public abstract class TryEntryControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject] public LevelRootController LevelRootController {get;set;}
    [Inject] public PlayerController PlayerController {get;set;}
    public abstract void InitializeTryEntry(TryEntryViewModel tryEntry);
    
    public override ViewModel CreateEmpty() {
        return new TryEntryViewModel(this);
    }
    
    public virtual TryEntryViewModel CreateTryEntry() {
        return ((TryEntryViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeTryEntry(((TryEntryViewModel)(viewModel)));
    }
}

public abstract class EditorRootControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject] public UniverseController UniverseController {get;set;}
    public abstract void InitializeEditorRoot(EditorRootViewModel editorRoot);
    
    public override ViewModel CreateEmpty() {
        return new EditorRootViewModel(this);
    }
    
    public virtual EditorRootViewModel CreateEditorRoot() {
        return ((EditorRootViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeEditorRoot(((EditorRootViewModel)(viewModel)));
    }
    
    public virtual void ToMenu(EditorRootViewModel editorRoot) {
    }
    
    public virtual void Serialize(EditorRootViewModel editorRoot) {
    }
    
    public virtual void LoadUniverse(EditorRootViewModel editorRoot) {
    }
}

public abstract class UniverseControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject] public EditorRootController EditorRootController {get;set;}
    [Inject] public UniverseObjectController UniverseObjectController {get;set;}
    public abstract void InitializeUniverse(UniverseViewModel universe);
    
    public override ViewModel CreateEmpty() {
        return new UniverseViewModel(this);
    }
    
    public virtual UniverseViewModel CreateUniverse() {
        return ((UniverseViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeUniverse(((UniverseViewModel)(viewModel)));
    }
}

public abstract class UniverseObjectControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject] public UniverseController UniverseController {get;set;}
    public abstract void InitializeUniverseObject(UniverseObjectViewModel universeObject);
    
    public override ViewModel CreateEmpty() {
        return new UniverseObjectViewModel(this);
    }
    
    public virtual UniverseObjectViewModel CreateUniverseObject() {
        return ((UniverseObjectViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeUniverseObject(((UniverseObjectViewModel)(viewModel)));
    }
    
    public virtual void Reset(UniverseObjectViewModel universeObject) {
    }
}

public abstract class ZoneControllerBase : UniverseObjectController {
    
    public abstract void InitializeZone(ZoneViewModel zone);
    
    public override ViewModel CreateEmpty() {
        return new ZoneViewModel(this);
    }
    
    public virtual ZoneViewModel CreateZone() {
        return ((ZoneViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeZone(((ZoneViewModel)(viewModel)));
    }
}

public abstract class GravityObjectControllerBase : UniverseObjectController {
    
    public abstract void InitializeGravityObject(GravityObjectViewModel gravityObject);
    
    public override ViewModel CreateEmpty() {
        return new GravityObjectViewModel(this);
    }
    
    public virtual GravityObjectViewModel CreateGravityObject() {
        return ((GravityObjectViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeGravityObject(((GravityObjectViewModel)(viewModel)));
    }
}

public abstract class PlanetControllerBase : GravityObjectController {
    
    public abstract void InitializePlanet(PlanetViewModel planet);
    
    public override ViewModel CreateEmpty() {
        return new PlanetViewModel(this);
    }
    
    public virtual PlanetViewModel CreatePlanet() {
        return ((PlanetViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializePlanet(((PlanetViewModel)(viewModel)));
    }
}

public abstract class AsteroidControllerBase : GravityObjectController {
    
    public abstract void InitializeAsteroid(AsteroidViewModel asteroid);
    
    public override ViewModel CreateEmpty() {
        return new AsteroidViewModel(this);
    }
    
    public virtual AsteroidViewModel CreateAsteroid() {
        return ((AsteroidViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeAsteroid(((AsteroidViewModel)(viewModel)));
    }
}

public abstract class BlackholeControllerBase : GravityObjectController {
    
    public abstract void InitializeBlackhole(BlackholeViewModel blackhole);
    
    public override ViewModel CreateEmpty() {
        return new BlackholeViewModel(this);
    }
    
    public virtual BlackholeViewModel CreateBlackhole() {
        return ((BlackholeViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeBlackhole(((BlackholeViewModel)(viewModel)));
    }
}

public abstract class MiniAsteroidControllerBase : UniverseObjectController {
    
    public abstract void InitializeMiniAsteroid(MiniAsteroidViewModel miniAsteroid);
    
    public override ViewModel CreateEmpty() {
        return new MiniAsteroidViewModel(this);
    }
    
    public virtual MiniAsteroidViewModel CreateMiniAsteroid() {
        return ((MiniAsteroidViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeMiniAsteroid(((MiniAsteroidViewModel)(viewModel)));
    }
}
