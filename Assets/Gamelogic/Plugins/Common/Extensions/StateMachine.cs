using System;
using System.Collections.Generic;

namespace Gamelogic
{
	/**
		A lightweight state machine.

		To use it:
			-#	Define your own label. Enums are probably the best choice.
			-#	Construct a new state machine, typically in a MonoBehaviour's Start method.
			-#	Add the various states with the appropriate delegates. 
			-#	Call the state machine's Update method from the MonoBehaviour's Update method.
			-#	Call the ChangeState method on the state machine to transition. (You can eitther call this method 
				from one of the state delegates, or from anywhere else. 
			-#	When a state is changed, the OnStop on exisiting state is called, then the OnStart of the new state, 
				nd from there on OnUpdate of the new state each time the update is called.

		@version1_0
	*/
	public sealed class StateMachine<TLabel>
	{
		private class State
		{
			public readonly Action OnStart;
			public readonly Action OnUpdate;
			public readonly Action OnStop;

			public State(Action OnStart, Action OnUpdate, Action OnStop)
			{
				this.OnStart = OnStart;
				this.OnUpdate = OnUpdate;
				this.OnStop = OnStop;
			}
		}

		private readonly Dictionary<TLabel, State> stateDictionary;
		private State currentState;

		/**
			Returns the label of the current state.
		*/
		public TLabel CurrentState { get; private set; }

		/**
			Constructs a new StateMachine.
		*/
		public StateMachine()
		{
			stateDictionary = new Dictionary<TLabel, State>();
		}

		/**
			Adds a state, and the delegates that should run 
			when the state starts, stops, 
			and when the state machine is updated.

			Any delegate can be null, and wont be executed.
		*/
		public void AddState(TLabel label, Action OnStart, Action OnUpdate, Action OnStop)
		{
			stateDictionary[label] = new State(OnStart, OnUpdate, OnStop);
		}

		/**
			Changes the state from the existing one to the state with the given label.
		*/
		public void ChangeState(TLabel newState)
		{
			if (currentState != null && currentState.OnStop != null)
			{
				currentState.OnStop();
			}

			currentState = stateDictionary[newState];
			CurrentState = newState;

			if (currentState.OnStart != null)
			{
				currentState.OnStart();
			}
		}

		/**
			This method should be called every frame. 
		*/
		public void Update()
		{
			if (currentState != null && currentState.OnUpdate != null)
			{
				currentState.OnUpdate();
			}
		}
	}
}