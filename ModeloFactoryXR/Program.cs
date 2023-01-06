
using ModeloFactoryXR;
Console.WriteLine("Ingrese el tipo de médico 1-3");
int var = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tipo de servicio 1-4");
int var1 = int.Parse(Console.ReadLine());

Medico medico = Creador.CrearMedico(var);

Console.WriteLine("El tipo de médico es: " + medico.Cargo());
Console.WriteLine("La cantidad de pacientes que tiene que atender son: "+medico.PacientesMinimosAtender());
Console.WriteLine("El tipo de servicio es: "+medico.Servicio(var1));
