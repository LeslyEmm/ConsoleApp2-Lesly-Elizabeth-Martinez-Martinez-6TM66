Imports System

Module Program

    Class Playera

        Private SAM As Integer
        Private talla As String
        Private tCost(10) As Integer
        Private dCost(10) As Integer
        Private dtotalCostura, cantHilo As Integer
        Private costototal As Integer
        Private costominuto, costohilo As Integer
        Private Padbatchminutos, Padsteamminutos As Integer
        Private Colorante As String
        Private mat(2, 119)


        Public Sub New()
            Console.WriteLine("Proceso de teñido")
            Padbatchminutos = 3
            Padsteamminutos = 2
            Colorante = "Reactivos"
        End Sub

        Public Sub IngresarDatos()
            Console.WriteLine("¿Cuál es la talla?")
            talla = Console.ReadLine
            Console.WriteLine("¿Cuál es el Costo por minuto?")
            costominuto = Console.ReadLine
            Console.WriteLine("¿Cuál es costo del hilo por metro?")
            costohilo = Console.ReadLine

            For f = 0 To 1
                For c = 0 To 10
                    Console.WriteLine("Ingrese componente:")
                    mat(f, c) = Console.ReadLine()
                    Console.WriteLine("¿Cuál es el Tiempo de la costura " & f)
                    tCost(f) = Console.ReadLine
                Next
            Next


        End Sub
        Public Sub MostrarDatos()
            Console.WriteLine("Talla: " & talla)
            Console.WriteLine("Costo por minuto: " & costominuto)
            Console.WriteLine("Costo del hilo: " & costohilo)

            For f = 0 To 1
                For c = 0 To 10
                    Console.Write(mat(f, c))
                    Console.WriteLine("Tiempo de la costura  " & tCost(f))
                Next
            Next
            For f = 0 To 10
                Console.WriteLine("Distancia de la costura  " & dCost(f))
            Next
        End Sub


        Public Function Tiempototal()
            SAM = tCost(0) + tCost(1) + tCost(2) + tCost(3) + tCost(4) + tCost(5) + tCost(6) + tCost(7) + tCost(8) + tCost(9) + tCost(10)
            Return SAM
        End Function
        Public Function dtCostura()
            For f = 0 To 10
                dtotalCostura = dtotalCostura + dCost(f)
            Next
            Return dtotalCostura
        End Function
        Public Function cantidadHilo()
            For f = 0 To 10
                cantHilo = (dCost(f)) * 2 + (dCost(f)) * 2 * 0.05
            Next
            Return cantHilo
        End Function
        Public Function CostoTotalPlayera()
            For f = 0 To 10
                costototal = (dCost(f) * 2) + (dCost(f) * 2 * 0.05) + (tCost(f) * costominuto)
            Next

            Return costototal
        End Function

    End Class
    Sub Main(args As String())

        Dim tfabricacion As Integer
        Dim Costofabricacion As Integer
        Dim mhilonecesarios As Integer

        Dim playera1 As New Playera()

        playera1.IngresarDatos()


        mhilonecesarios = playera1.cantidadHilo()
        tfabricacion = playera1.Tiempototal()
        Costofabricacion = playera1.CostoTotalPlayera()


        Console.WriteLine(" ________Para este lote se obtienen los siguientes datos: ")
        Console.WriteLine("los metros de hilo necesarios son : " & mhilonecesarios)
        Console.WriteLine("El tiempo de fabricación es : " & tfabricacion)
        Console.WriteLine("El costo de fabricación es: " & Costofabricacion)


    End Sub
End Module