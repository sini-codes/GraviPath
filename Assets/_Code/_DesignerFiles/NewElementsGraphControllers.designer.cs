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
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
    [Inject] public UniverseController UniverseController {get;set;}
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
    
    public virtual void StartLevel(MenuRootViewModel menuRoot, StartLevelDescriptor arg) {
    }
    
    public virtual void StartEditor(MenuRootViewModel menuRoot) {
    }
    
    public virtual void UpdateUniversesList(MenuRootViewModel menuRoot, UniverseListUpdateDescriptor arg) {
    }
}

public abstract class LevelRootControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public TryEntryController TryEntryController {get;set;}
    [Inject] public UniverseController UniverseController {get;set;}
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
    
    public virtual void LoadUniverse(LevelRootViewModel levelRoot, UniverseViewModel arg) {
    }
}

public abstract class PlayerControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
    [Inject] public LevelRootController LevelRootController {get;set;}
    [Inject] public TryEntryController TryEntryController {get;set;}
    [Inject] public ZoneController ZoneController {get;set;}
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
    
    public virtual void ZoneReached(PlayerViewModel player, ZoneViewModel arg) {
    }
    
    public virtual void Dock(PlayerViewModel player, DockDescriptor arg) {
    }
}

public abstract class TryEntryControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
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
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
    [Inject] public UniverseController UniverseController {get;set;}
    [Inject] public NewUniverseSubEditorController NewUniverseSubEditorController {get;set;}
    [Inject] public AddUniverseObjectSubEditorController AddUniverseObjectSubEditorController {get;set;}
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
    
    public virtual void LoadUniverse(EditorRootViewModel editorRoot, UniverseViewModel arg) {
    }
    
    public virtual void CreateNewUniverse(EditorRootViewModel editorRoot) {
    }
    
    public virtual void ToggleNewUniverseSubEditor(EditorRootViewModel editorRoot) {
    }
    
    public virtual void SaveCurrentUniverse(EditorRootViewModel editorRoot) {
    }
    
    public virtual void AddUniverseObject(EditorRootViewModel editorRoot, UniverseObjectDescriptor arg) {
    }
    
    public virtual void SwitchUniverseObjectSubEditor(EditorRootViewModel editorRoot, Boolean arg) {
    }
}

public abstract class UniverseControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
    [Inject] public MenuRootController MenuRootController {get;set;}
    [Inject] public LevelRootController LevelRootController {get;set;}
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
    
    public virtual void Load(UniverseViewModel universe, String arg) {
    }
    
    public virtual void Save(UniverseViewModel universe) {
    }
}

public abstract class UniverseObjectControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
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
    
    [Inject] public PlayerController PlayerController {get;set;}
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
    
    public virtual BlackholeViewModel CreateBlackhole() {
        return ((BlackholeViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeBlackhole(((BlackholeViewModel)(viewModel)));
    }
}

public abstract class MiniObjectControllerBase : UniverseObjectController {
    
    public abstract void InitializeMiniObject(MiniObjectViewModel miniObject);
    
    public override ViewModel CreateEmpty() {
        return new MiniObjectViewModel(this);
    }
    
    public virtual MiniObjectViewModel CreateMiniObject() {
        return ((MiniObjectViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeMiniObject(((MiniObjectViewModel)(viewModel)));
    }
}

public abstract class SimplePlanet1ControllerBase : PlanetController {
    
    public abstract void InitializeSimplePlanet1(SimplePlanet1ViewModel simplePlanet1);
    
    public override ViewModel CreateEmpty() {
        return new SimplePlanet1ViewModel(this);
    }
    
    public virtual SimplePlanet1ViewModel CreateSimplePlanet1() {
        return ((SimplePlanet1ViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSimplePlanet1(((SimplePlanet1ViewModel)(viewModel)));
    }
}

public abstract class SimplePlanet2ControllerBase : PlanetController {
    
    public abstract void InitializeSimplePlanet2(SimplePlanet2ViewModel simplePlanet2);
    
    public override ViewModel CreateEmpty() {
        return new SimplePlanet2ViewModel(this);
    }
    
    public virtual SimplePlanet2ViewModel CreateSimplePlanet2() {
        return ((SimplePlanet2ViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSimplePlanet2(((SimplePlanet2ViewModel)(viewModel)));
    }
}

public abstract class SimpleAsteroid1ControllerBase : AsteroidController {
    
    public abstract void InitializeSimpleAsteroid1(SimpleAsteroid1ViewModel simpleAsteroid1);
    
    public override ViewModel CreateEmpty() {
        return new SimpleAsteroid1ViewModel(this);
    }
    
    public virtual SimpleAsteroid1ViewModel CreateSimpleAsteroid1() {
        return ((SimpleAsteroid1ViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSimpleAsteroid1(((SimpleAsteroid1ViewModel)(viewModel)));
    }
}

public abstract class SimpleAsteroid2ControllerBase : AsteroidController {
    
    public abstract void InitializeSimpleAsteroid2(SimpleAsteroid2ViewModel simpleAsteroid2);
    
    public override ViewModel CreateEmpty() {
        return new SimpleAsteroid2ViewModel(this);
    }
    
    public virtual SimpleAsteroid2ViewModel CreateSimpleAsteroid2() {
        return ((SimpleAsteroid2ViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSimpleAsteroid2(((SimpleAsteroid2ViewModel)(viewModel)));
    }
}

public abstract class SimpleAsteroid3ControllerBase : AsteroidController {
    
    public abstract void InitializeSimpleAsteroid3(SimpleAsteroid3ViewModel simpleAsteroid3);
    
    public override ViewModel CreateEmpty() {
        return new SimpleAsteroid3ViewModel(this);
    }
    
    public virtual SimpleAsteroid3ViewModel CreateSimpleAsteroid3() {
        return ((SimpleAsteroid3ViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSimpleAsteroid3(((SimpleAsteroid3ViewModel)(viewModel)));
    }
}

public abstract class SimpleAsteroid4ControllerBase : AsteroidController {
    
    public abstract void InitializeSimpleAsteroid4(SimpleAsteroid4ViewModel simpleAsteroid4);
    
    public override ViewModel CreateEmpty() {
        return new SimpleAsteroid4ViewModel(this);
    }
    
    public virtual SimpleAsteroid4ViewModel CreateSimpleAsteroid4() {
        return ((SimpleAsteroid4ViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSimpleAsteroid4(((SimpleAsteroid4ViewModel)(viewModel)));
    }
}

public abstract class SimpleBlackhole1ControllerBase : BlackholeController {
    
    public abstract void InitializeSimpleBlackhole1(SimpleBlackhole1ViewModel simpleBlackhole1);
    
    public override ViewModel CreateEmpty() {
        return new SimpleBlackhole1ViewModel(this);
    }
    
    public virtual SimpleBlackhole1ViewModel CreateSimpleBlackhole1() {
        return ((SimpleBlackhole1ViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSimpleBlackhole1(((SimpleBlackhole1ViewModel)(viewModel)));
    }
}

public abstract class SpaceGarbageAreaControllerBase : UniverseObjectController {
    
    public abstract void InitializeSpaceGarbageArea(SpaceGarbageAreaViewModel spaceGarbageArea);
    
    public override ViewModel CreateEmpty() {
        return new SpaceGarbageAreaViewModel(this);
    }
    
    public virtual SpaceGarbageAreaViewModel CreateSpaceGarbageArea() {
        return ((SpaceGarbageAreaViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSpaceGarbageArea(((SpaceGarbageAreaViewModel)(viewModel)));
    }
}

public abstract class UniverseRepositoryControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
    public abstract void InitializeUniverseRepository(UniverseRepositoryViewModel universeRepository);
    
    public override ViewModel CreateEmpty() {
        return new UniverseRepositoryViewModel(this);
    }
    
    public virtual UniverseRepositoryViewModel CreateUniverseRepository() {
        return ((UniverseRepositoryViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeUniverseRepository(((UniverseRepositoryViewModel)(viewModel)));
    }
}

public abstract class NewUniverseSubEditorControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
    [Inject] public EditorRootController EditorRootController {get;set;}
    public abstract void InitializeNewUniverseSubEditor(NewUniverseSubEditorViewModel newUniverseSubEditor);
    
    public override ViewModel CreateEmpty() {
        return new NewUniverseSubEditorViewModel(this);
    }
    
    public virtual NewUniverseSubEditorViewModel CreateNewUniverseSubEditor() {
        return ((NewUniverseSubEditorViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeNewUniverseSubEditor(((NewUniverseSubEditorViewModel)(viewModel)));
    }
    
    public virtual void CreateUniverse(NewUniverseSubEditorViewModel newUniverseSubEditor) {
    }
}

public abstract class AddUniverseObjectSubEditorControllerBase : Controller {
    
    [Inject("MenuRoot")] public MenuRootViewModel MenuRoot { get; set; }
    [Inject("LevelRoot")] public LevelRootViewModel LevelRoot { get; set; }
    [Inject("EditorRoot")] public EditorRootViewModel EditorRoot { get; set; }
    [Inject("UniverseRepository")] public UniverseRepositoryViewModel UniverseRepository { get; set; }
    [Inject] public EditorRootController EditorRootController {get;set;}
    public abstract void InitializeAddUniverseObjectSubEditor(AddUniverseObjectSubEditorViewModel addUniverseObjectSubEditor);
    
    public override ViewModel CreateEmpty() {
        return new AddUniverseObjectSubEditorViewModel(this);
    }
    
    public virtual AddUniverseObjectSubEditorViewModel CreateAddUniverseObjectSubEditor() {
        return ((AddUniverseObjectSubEditorViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeAddUniverseObjectSubEditor(((AddUniverseObjectSubEditorViewModel)(viewModel)));
    }
    
    public virtual void Add(AddUniverseObjectSubEditorViewModel addUniverseObjectSubEditor, UniverseObjectDescriptor arg) {
    }
}

public abstract class StartZoneControllerBase : ZoneController {
    
    public abstract void InitializeStartZone(StartZoneViewModel startZone);
    
    public override ViewModel CreateEmpty() {
        return new StartZoneViewModel(this);
    }
    
    public virtual StartZoneViewModel CreateStartZone() {
        return ((StartZoneViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeStartZone(((StartZoneViewModel)(viewModel)));
    }
}

public abstract class WinZoneControllerBase : ZoneController {
    
    public abstract void InitializeWinZone(WinZoneViewModel winZone);
    
    public override ViewModel CreateEmpty() {
        return new WinZoneViewModel(this);
    }
    
    public virtual WinZoneViewModel CreateWinZone() {
        return ((WinZoneViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeWinZone(((WinZoneViewModel)(viewModel)));
    }
}
