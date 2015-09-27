Imports System.Math
Module Module1
    ' To get this to work.. 91, 159 111111
    ' Check last most digits. Then add/minus 1 till at middle
    Sub Main()
        Dim Int As Integer = 10519
        Dim IntLength, Ilength As Integer
        Dim I, J As Integer
        Dim First, Last As Integer
        Dim F1, F2 As Integer


        Console.Write("Enter the amount of iterations: ")
        I = Console.ReadLine()
        Do
            If I >= Math.Pow(2, 3) Then

                Console.Write("Valid Number: ")
                I = Console.ReadLine()

            ElseIf I <= 1 Then
                Console.Write("Valid Number: ")
                I = Console.ReadLine()

            End If
        Loop Until (I <= Math.Pow(2, 31)) And (I >= 1)
        Do
            First = CInt(CStr(Int.ToString.First))
            Last = CInt(CStr(Int.ToString.Last))
            IntLength = Int.ToString.Length
            IntLength = Math.Truncate(IntLength / 2)
            J = 0
            If IntLength = 1 Then
                IntLength = IntLength + 1
            End If
            If Int > 10000 Then
                IntLength = IntLength + 1
            End If
            Do
                F1 = CInt(CStr(Int.ToString.ElementAt(J)))
                '  Console.WriteLine("F1 = " & F1)
                Ilength = Int.ToString.Length
                Ilength = Ilength - 1
                F2 = CInt(CStr(Int.ToString.ElementAt(Ilength - J)))
                '   Console.WriteLine("F2 = " & F2)
                If IntLength = 0 Then
                Else
                    IntLength = IntLength - 1
                End If

                J = J + 1
            Loop Until IntLength = 0
            If I = 1 Then
                Console.Clear()
                Console.WriteLine(Int)
            End If
            If First + Last = 10 And F1 + F2 = 10 Then
                '    Console.WriteLine(Int)
                I = I - 1
            End If
            Int = Int + 1
        Loop Until I = 0
        Console.ReadLine()
    End Sub

End Module
