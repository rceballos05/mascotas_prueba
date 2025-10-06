using System.Text.RegularExpressions;

namespace SistemaVeterinario.Web.Statics
{
    public class Rut
    {
        public Rut()
        {
            
        }
        
        public bool ValidaRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            //if(expresion.IsMatch(rut))
            //{
            //    return false;
            //}
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if(dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }
        public string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 2;

            while (rut > 0)
            {
                int digito = rut % 10;
                suma += digito * multiplicador;
                rut /= 10;

                multiplicador++;
                if (multiplicador > 7)
                    multiplicador = 2;
            }

            int resto = suma % 11;
            int resultado = 11 - resto;

            if (resultado == 11)
                return "0";
            if (resultado == 10)
                return "K";
            return resultado.ToString();
        }

        

        public string FormatoRut(string rut)
        {
            string rutFinal = string.Empty;
            string rutFormateado = string.Empty;
            if(rut.Length == 0)
            {
                rutFormateado = "";
            }
            else
            {
                string rutTemporal;
                string dv = "";
                Int64 rutNumerico;

                rut = rut.Replace("-", "").Replace(".", "");
                if(rut.Length == 1)
                {
                    rutFormateado = rut;
                }
                else
                {
                    rutTemporal = rut;
                    if(rut.Length >=3)
                    {
                        dv = rut.Substring(rut.Length - 1, 1);
                    }
                    
                    if(!Int64.TryParse(rutTemporal, out rutNumerico))
                    {
                        rutNumerico = 0;
                    }
                    //rutFormateado = rutNumerico.ToString("NO");
                    rutFormateado = rutNumerico.ToString();
                    
                    if(rutFormateado.Equals("0"))
                    {
                        rutFormateado = string.Empty;
                    }
                    else
                    {
                        var temRut = "";
                       if(rutFormateado.Length > 2)
                        {
                            switch (rutFormateado.Length)
                            {
                                case 3:
                                    temRut = $"{rutFormateado[0]}.{rutFormateado[1]}";
                                    break;
                                case 4:
                                    temRut = $"{rutFormateado[0]}{rutFormateado[1]}.{rutFormateado[2]}";
                                    break;
                                case 5:
                                    temRut = $"{rutFormateado[0]}{rutFormateado[1]}.{rutFormateado[2]}{rutFormateado[3]}";
                                    break;
                                case 6:
                                    temRut = $"{rutFormateado[0]}{rutFormateado[1]}.{rutFormateado[2]}{rutFormateado[3]}{rutFormateado[4]}";
                                    break;
                                case 7:
                                    temRut = $"{rutFormateado[0]}.{rutFormateado[1]}{rutFormateado[2]}{rutFormateado[3]}.{rutFormateado[4]}{rutFormateado[5]}";

                                    break;
                                case 8:
                                    temRut = $"{rutFormateado[0]}.{rutFormateado[1]}{rutFormateado[2]}{rutFormateado[3]}.{rutFormateado[4]}{rutFormateado[5]}{rutFormateado[6]}";

                                    break;
                                case 9:
                                    temRut = $"{rutFormateado[0]}{rutFormateado[1]}.{rutFormateado[2]}{rutFormateado[3]}{rutFormateado[4]}.{rutFormateado[5]}{rutFormateado[6]}{rutFormateado[7]}";

                                    break;

                            }
                            rutFormateado = temRut;
                            rutFormateado += "-" + dv;
                        }
                        
                        
                        //rutFormateado = rutFormateado.Replace("", ".");
                    }
                }
                
            }
            return rutFormateado;
        }
    }
}
