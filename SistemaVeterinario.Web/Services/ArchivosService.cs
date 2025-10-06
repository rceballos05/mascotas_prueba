namespace SistemaVeterinario.Web.Services
{
    public class ArchivosService
    {
        private readonly string _basePath = @"C:\Uploads";

        public void CrearCarpetaCliente(string clienteId)
        {
            var rutaCliente = Path.Combine(_basePath, $"cliente_{clienteId}");

            if (!Directory.Exists(rutaCliente))
                Directory.CreateDirectory(rutaCliente);
        }

        public void CrearCarpetaMascota(string clienteId, string mascotaId)
        {
            var rutaMascota = Path.Combine(_basePath, $"cliente_{clienteId}", $"mascota_{mascotaId}");

            if (!Directory.Exists(rutaMascota))
                Directory.CreateDirectory(rutaMascota);
        }
        public async Task<bool> ClienteExistePeroSinCarpetaAsync(int clienteId)
        {
           
            // 2. Verificar si su carpeta física existe
            var rutaCarpeta = Path.Combine("C:\\ArchivosVeterinaria", $"cliente_{clienteId}");

            var carpetaExiste = Directory.Exists(rutaCarpeta);

            // 3. Retornar true solo si el cliente existe pero no tiene carpeta
            return !carpetaExiste;
        }
        public async Task VerificarYCrearCarpetaClienteAsync(int clienteId)
        {
            if (await ClienteExistePeroSinCarpetaAsync(clienteId))
            {
                var rutaCarpeta = Path.Combine("C:\\ArchivosVeterinaria", $"cliente_{clienteId}");
                Directory.CreateDirectory(rutaCarpeta);
            }
        }
    }


}
