using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dormir : Humano
{
    private void Awake()
    {
        typestate = TypeState.Dormir;
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
        base.Execute();

        _DataAgent.DecreaseSleep(); // Reduce el sueño

        // Si el sueño baja al 25%, vuelve a jugar
        if (_DataAgent.Sleep.value <= 0.25f)
        {
            _StateMachine.ChangeState(TypeState.Jugar);
        }
    }
    public override void Exit()
    {

    }
}
