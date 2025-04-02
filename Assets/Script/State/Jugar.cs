using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugar : Humano
{
    private void Awake()
    {
        typestate = TypeState.Jugar;
        LocadComponent();
    }
    public override void LocadComponent()
    {
        base.LocadComponent();
        
    }
     
    public override void Enter()
    {

    }
    public override void Execute()
    {
        if (_DataAgent.Energy.value < 0.25f)
        {
            _StateMachine.ChangeState(TypeState.Comer);
        }
        else
        {
            _DataAgent.DiscountEnergy();
        }

        base.Execute();
    }

    public override void Exit()
    {
        _DataAgent.StopLoadingEnergy(); // Detiene la recarga de energía
    }
}
