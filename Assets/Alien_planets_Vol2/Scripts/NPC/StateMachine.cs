using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{   public delegate void StartFn();
    public delegate void UpdateFn();
    public delegate void ExitFn();

    protected class State
    {
        public readonly string _name;
        public readonly string _fnStart;
        public readonly string _fnUpdate;
        public readonly string _fnExit;

        public State (string stateName,UpdateFn fnUpdate=null,StartFn fnStart=null,ExitFn fnExit =null)
        {
            _name = stateName;
           // _fnStart = fnStart;
          //  _fnExit = fnExit;

        }
        public void Start()
        {
            if (_fnStart!=null)
            {
            //    _fnStart();
            }
        }
        public void SetState (string newStateName)
        {
           // State state = _states [newStateName];


        }

    }
    
}
