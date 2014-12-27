using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UniRx;


public partial class PlayerSpaceShipView
{ 

    /// Subscribes to the state machine property and executes a method for each state.
    public override void ShipStateChanged(Invert.StateMachine.State value) {
        base.ShipStateChanged(value);
    }
    
    public override void OnAlive() {
        base.OnAlive();

        NormalArt.SetActive(true);
        CrashedArt.SetActive(false);
        rigidbody2D.isKinematic = false;
          
    
    }
    
    public override void OnCrashed() {
        base.OnCrashed();

        NormalArt.SetActive(false);
        CrashedArt.SetActive(true);
        
        //�������������� �����
        rigidbody2D.isKinematic = true;
        transform.position = LastCollisionPoint;

        Fire.SetActive(false);
        Swearing.SetActive(false);
        Boom.SetActive(true);

        Observable.Timer(TimeSpan.FromMilliseconds(300))
            .Subscribe(_ =>
            {

                Crashed.transform.up = -(transform.position - LastCollidedGravityObject.transform.position);
                Fire.SetActive(true);
                Swearing.SetActive(true);
                Boom.SetActive(false);
            });



    }

    protected override IObservable<Vector3> GetPositionObservable()
    {
        return PositionAsObservable;
    }


    public GameObject NormalArt;
    public GameObject CrashedArt;
    public GameObject Fire;
    public GameObject Swearing;
    public GameObject Boom;
    public GameObject Crashed;

    [HideInInspector]
    public GravityObject LastCollidedGravityObject { get; set; }
    [HideInInspector]
    public Vector3 LastCollisionPoint { get; set; }

    /// Invokes ResetExecuted when the Reset command is executed.
    public override void ResetExecuted() {
        base.ResetExecuted();
        this.rigidbody2D.velocity = Vector2.zero;
        this.rigidbody2D.Sleep();
        transform.up = Vector3.up;
    }
 

    /// Invokes AccelerateExecuted when the Accelerate command is executed.
    public override void AccelerateExecuted() {
        base.AccelerateExecuted();
        var force = Player.Direction;
        this.rigidbody2D.AddForce(new Vector2(force.x,force.y),ForceMode2D.Impulse);
    }
 

    /// Subscribes to the property and is notified anytime the value changes.
    public override void DirectionChanged(Vector3 value) {
        base.DirectionChanged(value);

        //transform.LookAt(transform.position + value.normalized);
        if(!(Player.ShipState is Crashed)) 
            transform.up = value;
    }

    public override void Bind()
    {
        base.Bind();
        ShipController.Commited += ExecuteAccelerate;

        Observable.EveryUpdate().Subscribe(_ =>
        {
            if (!Player.IsControllable)
            {
                //TODO: Fix the lagging on low velocity
                transform.up = rigidbody2D.velocity;
            }
        });

    }

    /// Subscribes to the property and is notified anytime the value changes.
    public override void IsControllableChanged(Boolean value) {
        base.IsControllableChanged(value);
        if (value)
        {
            this.ShipController
                .Direction
                .Subscribe(InputDirectionChanged)
                .DisposeWhenChanged(Player.IsControllableProperty);
            
            this.ShipController
                .Acceleration
                .Subscribe(InputAccelrationChanged)
                .DisposeWhenChanged(Player.IsControllableProperty);

            this.BindComponentCollision2DWith<GravityObject>(CollisionEventType.Enter, (obj,col) =>
            {
                LastCollidedGravityObject = obj;
                LastCollisionPoint = col.contacts.First().point;
                ExecuteCrash();
            });

        }
    }



    public void InputDirectionChanged(Vector3 dir)
    {
        this.ExecuteSetDirection(dir);
    }

    public void InputAccelrationChanged(float acc)
    {
        this.ExecuteSetAcceleration(acc);
    }
}
