// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pago por hora por horas trabajadas");

Console.WriteLine();

{
    Console.WriteLine("Ingrese el pago por hora:");
    double pagoPorHora = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese las horas trabajadas:");
    double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

    double sueldoBruto = pagoPorHora * horasTrabajadas;

    // Calcular los descuentos
    double descuentoAFP = sueldoBruto * 0.0287; // 2.87%
    double descuentoSFS = sueldoBruto * 0.0304; // 3.04%
    double totalDescuentos = descuentoAFP + descuentoSFS;

    double sueldoNeto = sueldoBruto - totalDescuentos;

    Console.WriteLine("Sueldo bruto: " + sueldoBruto);
    Console.WriteLine("Descuento de AFP: " + descuentoAFP);
    Console.WriteLine("Descuento de SFS: " + descuentoSFS);
    Console.WriteLine("Total descuentos: " + totalDescuentos);
    Console.WriteLine("Sueldo neto: " + sueldoNeto);
}



