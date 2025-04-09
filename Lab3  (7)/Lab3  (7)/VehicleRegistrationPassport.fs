module VehicleRegistrationPassport

open System
open System.Text.RegularExpressions


type VehicleRegistrationPassport(series: string, number: string, owner: string, vehicleModel: string) =

    member this.Series = series
    member this.Number = number
    member this.Owner = owner
    member this.VehicleModel = vehicleModel
   
    //if not (VehicleRegistrationPassport.ValidateSeries(series)) then
    //    raise (ArgumentException("Invalid series format. Must be exactly 4 digits."))
    //if not (VehicleRegistrationPassport.ValidateNumber(number)) then
    //    raise (ArgumentException("Invalid number format. Must be exactly 6 digits."))

    member this.PrintDocument() =
        printfn "Паспорт транспортного средства:"
        printfn "Серия: %s" this.Series
        printfn "Номер: %s" this.Number
        printfn "Владелец: %s" this.Owner
        printfn "Модель автомобиля: %s" this.VehicleModel

    member this.Equals(other: VehicleRegistrationPassport) =
        this.Series = other.Series && this.Number = other.Number

    static member ValidateSeries(series: string) =
        let seriesPattern = @"^\d{4}$"  
        Regex.IsMatch(series, seriesPattern)

    static member ValidateNumber(number: string) =
        let numberPattern = @"^\d{6}$"  
        Regex.IsMatch(number, numberPattern)





