using System.Runtime.CompilerServices;
using Controle;
using UnityEngine;
using System;

[RequireComponent(typeof(Controle2D))]
public class PlayerMovement : MonoBehaviour
{
    private Controle2D _controle;
    private float _movimentoHorizontal;
    private void Awake()
    {
        _controle = GetComponent<Controle2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _movimentoHorizontal = Input.GetAxisRaw("Horizontal") * 30;
    }

    void FixedUpdate()
    {
        _controle.Movimento(_movimentoHorizontal * Time.fixedDeltaTime, false);
    }
}
