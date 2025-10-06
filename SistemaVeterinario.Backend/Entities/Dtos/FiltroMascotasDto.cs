namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class FiltroMascotasDto
    {
        public FiltroMascotasDto(string id,string nombre, string tipo, string raza, string rutPropietario, string nombrePropietario, string microchip,string sexo, string ciudad, string color,string codEspecie, string especie)
        {
            IdMascota = id;
            Nombre = nombre;
            Tipo = tipo;
            Raza = raza;
            RutPropietario = rutPropietario;
            NombrePropietario = nombrePropietario;
            Microchip = microchip;
            Sexo = sexo;
            Ciudad = ciudad;
            Color = color;
            CodEspecie = codEspecie;
            Especie = especie;

        }
        public string IdMascota { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public string? CodRaza { get; set; }
        public string? Raza { get; set; }
        public string? RutPropietario { get; set; }
        public string? NombrePropietario { get; set; }
        public string? Microchip { get; set; }
        public string? Sexo { get; set; }
        public string? Ciudad { get; set; }
        public string? Color { get; set; }
        public string? CodEspecie { get; set; }
        public string? Especie { get; set; }
        
    }
}
