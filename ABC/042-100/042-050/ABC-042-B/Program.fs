open System

#nowarn "0025"
let [|n;k|] = stdin.ReadLine().Split() |> Array.map int
let e = [| for i=0 to n-1 do stdin.ReadLine() |> string |] |> Array.sort

let result = e |> String.concat "" |> stdout.WriteLine