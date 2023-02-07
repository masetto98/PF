using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using FluentValidation;
using FluentValidation.Results;
using Business.Entities;

namespace Business.Logic
{
    public class Validaciones
    {
        static public void ValidarNumeroEnteroDecimal(string cantidad) 
        {
            

            try
            {
                if (!Regex.IsMatch(cantidad, @"\d{1,7}(,\d{1,2})?"))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("La cantidad ingresada no es un número", e);
                throw ExceptionManejada;
            }
        }
        static public void ValidarEmail(string email)
        {
            try
            {
                if (!(email.Contains("@") & email.Contains(".")))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Formato de email erroneo", e);
                throw ExceptionManejada;
            }
        }
        static public void ValidarNulo(string campo, string tipo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(campo))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception($"El campo {tipo} debe completarse", e);
                throw ExceptionManejada;
            }
        }
        static public void ValidarClave(string clave)
        {
            try
            {
                if (clave.Length < 8)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception($"La clave debe tener mas de 8 caracteres", e);
                throw ExceptionManejada;
            }
        }
        static public void ValidarConfirmacionClave(string clave, string clave2)
        {
            try
            {
                if (clave != clave2)
                {
                    throw new Exception();
                }

            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception($"La claves ingresadas no coinciden ", e);
                throw ExceptionManejada;
            }
        }
        static public void ValidarNumero(string campo, string tipo)
        {
            Regex regex = new Regex("^[0-9]+$");
            try
            {
                if (!(regex.IsMatch(campo)))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception($"El campo {tipo} debe ser numerico", e);
                throw ExceptionManejada;
            }
        }
        static public void ValidarLetras(string campo, string tipo)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            try
            {

                if (!(regex.IsMatch(campo)))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception($"El campo {tipo} contener solo letras", e);
                throw ExceptionManejada;
            }
        }
        static public void ValidarLetrasNumeros(string campo, string tipo)
        {
            Regex regex = new Regex("^[a-zA-Z 1-9]+$");
            try
            {
                if (!(regex.IsMatch(campo)))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception($"El campo {tipo} debe contener solo caracteres alfanuméricos", e);
                throw ExceptionManejada;
            }
        }
    }
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.Cuit).NotEmpty().Matches("^[0-9]+$").WithMessage("'Cuit' debe contener solo números");
            RuleFor(x => x.Nombre).NotEmpty();
            RuleFor(x => x.Apellido).NotEmpty();
            RuleFor(x => x.Telefono).NotEmpty().Matches("^[0-9]+$").WithMessage("'Teléfono' debe contener solo números");
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Direccion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Dirección' debe contener solo letras y/o números");
        }
    }

    public class EmpleadoValidator : AbstractValidator<Empleado>
    {
        public EmpleadoValidator()
        {
            RuleFor(x => x.Cuit).NotEmpty().Matches("^[0-9]+$").WithMessage("'Cuit' debe contener solo números");
            RuleFor(x => x.Nombre).NotEmpty();
            RuleFor(x => x.Apellido).NotEmpty();
            RuleFor(x => x.Telefono).NotEmpty().Matches("^[0-9]+$").WithMessage("'Teléfono' debe contener solo números");
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Direccion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Dirección' debe contener solo letras y/o números");
        }
    }

    public class InsumoValidator : AbstractValidator<Insumo>
    {
        public InsumoValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Descripción' debe contener solo letras y/o números");
        }
    }


    public class MantenimientoValidator : AbstractValidator<Mantenimiento>
    {
        public MantenimientoValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Descripción' debe contener solo letras y/o números");
        }
    }

    public class MaquinaValidator : AbstractValidator<Maquina>
    {
        public MaquinaValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Descripción' debe contener solo letras y/o números");
            RuleFor(x => x.TipoMaquina).NotNull();
        }
    }
    public class TipoMaquinaValidator : AbstractValidator<TiposMaquina>
    {
        public TipoMaquinaValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Descripción' debe contener solo letras y/o números");
        }
    }

    public class OrdenValidator : AbstractValidator<Orden>
    {
        public OrdenValidator()
        {
            RuleFor(x => x.IdCliente).NotNull();
            RuleFor(x => x.Observaciones).MaximumLength(500);

        }
    }

    public class ProveedorValidator : AbstractValidator<Proveedor>
    {
        public ProveedorValidator()
        {
            RuleFor(x => x.Cuit).NotEmpty().Matches("^[0-9]+$").WithMessage("'Cuit' debe contener solo números");
            RuleFor(x => x.RazonSocial).NotEmpty();
            RuleFor(x => x.Telefono).NotEmpty().Matches("^[0-9]+$").WithMessage("'Teléfono' debe contener solo números");
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Direccion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Dirección' debe contener solo letras y/o números");

        }
    }

    public class ServicioValidator : AbstractValidator<Servicio>
    {
        public ServicioValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Descripción' debe contener solo letras y/o números");
        }
    }

    public class TipoPrendaValidator : AbstractValidator<TipoPrenda>
    {
        public TipoPrendaValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Descripción' debe contener solo letras y/o números");
        }
    }

    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.NombreUsuario).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9ñÑ]+$").WithMessage("'Nombre' debe contener solo letras y/o números"); // ValidarLetrasNumeros
            RuleFor(x => x.Clave).NotNull().MinimumLength(8);
            RuleFor(x => x.Pregunta).NotNull();
            RuleFor(x => x.Respuesta).NotNull();

        }
    }

    public class GastoValidator : AbstractValidator<Gasto>
    {
        public GastoValidator()
        {
            RuleFor(x => x.TipoGasto).NotEmpty();
            RuleFor(x => x.Importe.ToString()).NotEmpty().Matches(@"\d{1,7}(,\d{1,2})?").WithMessage("'Importe' debe ser numérico");
            RuleFor(x => x.Descripcion).NotNull().MaximumLength(200);
        }
    }
    public class AtributosNegocioValidator : AbstractValidator<AtributosNegocio>
    {
        public AtributosNegocioValidator()
        {
            RuleFor(x => x.CuitEmpresa).NotEmpty().Matches("^[0-9]+$").WithMessage("'Cuit' debe contener solo números");
            RuleFor(x => x.NombreEmpresa).NotEmpty().Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Nombre de Empresa' debe contener solo letras y/o números");
            RuleFor(x => x.DireccionEmpresa).NotEmpty().MaximumLength(50).Matches("^[a-zA-Z0-9üéáíóúñÑ ]+$").WithMessage("'Dirección' debe contener solo letras y/o números");
            RuleFor(x => x.TelEmpresa).NotEmpty().Matches("^[0-9]+$").WithMessage("'Teléfono' debe contener solo números");
            
        }
    }

}