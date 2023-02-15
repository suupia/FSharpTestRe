namespace FSharpTestRe

open UnityEngine

type PlayerController() =
    inherit MonoBehaviour()

    [<SerializeField>]
    let mutable speed = 6.0f

    member this.Start() = Debug.Log "Hello from F#!!!!"

module Test =
    let rec factorial n =
        match n with
        | 0 | 1 -> 1
        | _ -> n * factorial (n - 1)

module Calculation = 
    let add x y = 
        x + y