using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comer : Humano
{
    private void Awake()
    {
        typestate = TypeState.Comer;
        LocadComponent();
    }
    public override void LocadComponent()
    {
        base.LocadComponent();

    }
    public override void Enter()
    {
        _DataAgent.LoadEnergy();
    }
    public override void Execute()
    {
        base.Execute();

        _DataAgent.IncreaseSleep(); // Aumenta el sueño

        // Si el sueño llega al 75%, ve a dormir
        if (_DataAgent.Sleep.value >= 0.75f)
        {
            _StateMachine.ChangeState(TypeState.Dormir);
        }
    }
    public override void Exit()
    {
        _DataAgent.StopLoadingEnergy();
    }
}
